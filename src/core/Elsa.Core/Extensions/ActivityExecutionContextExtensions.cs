using System.Linq.Expressions;
using Elsa.Contracts;
using Elsa.Models;
using Microsoft.Extensions.Logging;

namespace Elsa;

public static class ActivityExecutionContextExtensions
{
    public static bool TryGetInput<T>(this ActivityExecutionContext context, string key, out T value) => context.Input!.TryGetValue(key, out value!);
    public static T GetInput<T>(this ActivityExecutionContext context) => context.GetInput<T>(typeof(T).Name);
    public static T GetInput<T>(this ActivityExecutionContext context, string key) => (T)context.Input[key];

    public static WorkflowExecutionLogEntry AddExecutionLogEntry(this ActivityExecutionContext context, string eventName, string? message = default, object? payload = default) =>
        context.AddExecutionLogEntry(eventName, message, default, payload);

    public static WorkflowExecutionLogEntry AddExecutionLogEntry(this ActivityExecutionContext context, string eventName, string? message = default, string? source = default, object? payload = default)
    {
        var activity = context.Activity;
        var workflowExecutionContext = context.WorkflowExecutionContext;
        var now = context.GetRequiredService<ISystemClock>().UtcNow;
        var logEntry = new WorkflowExecutionLogEntry(activity.Id, activity.TypeName, now, eventName, message, source, payload);
        workflowExecutionContext.ExecutionLog.Add(logEntry);
        return logEntry;
    }

    public static Variable SetVariable(this ActivityExecutionContext context, string name, object? value) => context.ExpressionExecutionContext.SetVariable(name, value);
    public static T? GetVariable<T>(this ActivityExecutionContext context, string name) => context.ExpressionExecutionContext.GetVariable<T?>(name);

    /// <summary>
    /// Evaluates each input property of the activity.
    /// </summary>
    public static async Task EvaluateInputPropertiesAsync(this ActivityExecutionContext context)
    {
        var activity = context.Activity;
        var inputs = activity.GetInputs();
        var assignedInputs = inputs.Where(x => x.LocationReference != null!).ToList();
        var evaluator = context.GetRequiredService<IExpressionEvaluator>();
        var expressionExecutionContext = context.ExpressionExecutionContext;

        foreach (var input in assignedInputs)
        {
            var locationReference = input.LocationReference;
            var value = await evaluator.EvaluateAsync(input, expressionExecutionContext);
            locationReference.Set(context, value);
        }
    }

    public static async Task<T?> EvaluateInputPropertyAsync<TActivity, T>(this ActivityExecutionContext context, Expression<Func<TActivity, Input<T>>> propertyExpression)
    {
        var inputName = propertyExpression.GetProperty()!.Name;
        var input = await EvaluateInputPropertyAsync(context, inputName);
        return context.Get((Input<T>)input);
    }

    /// <summary>
    /// Evaluates a specific input property of the activity.
    /// </summary>
    public static async Task<Input> EvaluateInputPropertyAsync(this ActivityExecutionContext context, string inputName)
    {
        var activity = context.Activity;
        var input = activity.GetInput(inputName);

        if (input == null)
            throw new Exception($"No input with name {inputName} could be found");

        if (input.LocationReference == null!)
            throw new Exception("Input not initialized");

        var evaluator = context.GetRequiredService<IExpressionEvaluator>();
        var expressionExecutionContext = context.ExpressionExecutionContext;

        var locationReference = input.LocationReference;
        var value = await evaluator.EvaluateAsync(input, expressionExecutionContext);
        locationReference.Set(context, value);

        return input;
    }

    public static ILogger GetLogger(this ActivityExecutionContext context) => (ILogger)context.GetRequiredService(typeof(ILogger<>).MakeGenericType(context.Activity.GetType()));
}