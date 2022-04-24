using System.Collections.Immutable;
using Elsa.Attributes;
using Elsa.Behaviors;
using Elsa.Contracts;
using Elsa.Models;

namespace Elsa.Activities;

[Activity("Elsa", "Control Flow", "Branch execution into multiple branches.")]
public class Fork : Activity
{
    public Fork()
    {
        Behaviors.Remove<AutoCompleteBehavior>();
    }

    /// <summary>
    /// Controls when this activity yields control back to its parent activity.
    /// </summary>
    [Input]
    public JoinMode JoinMode { get; set; } = JoinMode.WaitAny;

    /// <summary>
    /// The branches to schedule.
    /// </summary>
    [Outbound]
    public ICollection<IActivity> Branches { get; set; } = new List<IActivity>();

    protected override void Execute(ActivityExecutionContext context) => context.ScheduleActivities(Branches.Reverse(), CompleteChildAsync);

    private async ValueTask CompleteChildAsync(ActivityExecutionContext context, ActivityExecutionContext childContext)
    {
        var completedChildActivityId = childContext.Activity.Id;

        // Append activity to set of completed activities.
        var completedActivityIds = context.UpdateProperty<HashSet<string>>("Completed", set =>
        {
            set ??= new HashSet<string>();
            set.Add(completedChildActivityId);
            return set;
        });

        var allChildActivityIds = Branches.Select(x => x.Id).ToImmutableHashSet();
        var joinMode = JoinMode;

        switch (joinMode)
        {
            case JoinMode.WaitAny:
            {
                // Remove any and all bookmarks from other branches.
                RemoveBookmarks(context);

                // Signal activity completion.
                await CompleteAsync(context);
            }
                break;
            case JoinMode.WaitAll:
            {
                var allSet = allChildActivityIds.All(x => completedActivityIds.Contains(x));

                if (allSet)
                    // Signal activity completion.
                    await CompleteAsync(context);
            }
                break;
        }
    }


    private void RemoveBookmarks(ActivityExecutionContext context)
    {
        // Find all descendants for each branch and remove them as well as any associated bookmarks.
        var workflowExecutionContext = context.WorkflowExecutionContext;
        var forkNode = context.ActivityNode;
        var branchNodes = forkNode.Children;
        var branchDescendantActivityIds = branchNodes.SelectMany(x => x.Flatten()).Select(x => x.Activity.Id).ToHashSet();
        var bookmarksToRemove = workflowExecutionContext.Bookmarks.Where(x => branchDescendantActivityIds.Contains(x.ActivityId)).ToList();

        workflowExecutionContext.UnregisterBookmarks(bookmarksToRemove);
    }
}