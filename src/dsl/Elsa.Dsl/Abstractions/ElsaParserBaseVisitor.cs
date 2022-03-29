//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Projects/Elsa/v3/src/dsl/Elsa.Dsl/Dsl\ElsaParser.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IElsaParserVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class ElsaParserBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IElsaParserVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.program"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProgram([NotNull] ElsaParser.ProgramContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.object"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObject([NotNull] ElsaParser.ObjectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.newObject"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNewObject([NotNull] ElsaParser.NewObjectContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.varDecl"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVarDecl([NotNull] ElsaParser.VarDeclContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.localVarDecl"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLocalVarDecl([NotNull] ElsaParser.LocalVarDeclContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.type"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitType([NotNull] ElsaParser.TypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.expressionMarker"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpressionMarker([NotNull] ElsaParser.ExpressionMarkerContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.expressionContent"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpressionContent([NotNull] ElsaParser.ExpressionContentContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.methodCall"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodCall([NotNull] ElsaParser.MethodCallContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.funcCall"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFuncCall([NotNull] ElsaParser.FuncCallContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.args"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArgs([NotNull] ElsaParser.ArgsContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.arg"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArg([NotNull] ElsaParser.ArgContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.block"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlock([NotNull] ElsaParser.BlockContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.objectInitializer"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectInitializer([NotNull] ElsaParser.ObjectInitializerContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.propertyList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPropertyList([NotNull] ElsaParser.PropertyListContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.property"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProperty([NotNull] ElsaParser.PropertyContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>objectStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectStat([NotNull] ElsaParser.ObjectStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>ifStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIfStat([NotNull] ElsaParser.IfStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>forStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitForStat([NotNull] ElsaParser.ForStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>returnStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReturnStat([NotNull] ElsaParser.ReturnStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>blockStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBlockStat([NotNull] ElsaParser.BlockStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>variableDeclarationStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariableDeclarationStat([NotNull] ElsaParser.VariableDeclarationStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>localVariableDeclarationStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLocalVariableDeclarationStat([NotNull] ElsaParser.LocalVariableDeclarationStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>assignmentStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignmentStat([NotNull] ElsaParser.AssignmentStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expressionStat</c>
	/// labeled alternative in <see cref="ElsaParser.stat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpressionStat([NotNull] ElsaParser.ExpressionStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.thenStat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitThenStat([NotNull] ElsaParser.ThenStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.elseStat"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitElseStat([NotNull] ElsaParser.ElseStatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>newObjectExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNewObjectExpr([NotNull] ElsaParser.NewObjectExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>subtractExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSubtractExpr([NotNull] ElsaParser.SubtractExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>incrementExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIncrementExpr([NotNull] ElsaParser.IncrementExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>objectExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitObjectExpr([NotNull] ElsaParser.ObjectExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>stringValueExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitStringValueExpr([NotNull] ElsaParser.StringValueExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>multiplyExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultiplyExpr([NotNull] ElsaParser.MultiplyExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>parenthesesExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitParenthesesExpr([NotNull] ElsaParser.ParenthesesExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>functionExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunctionExpr([NotNull] ElsaParser.FunctionExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>decrementExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDecrementExpr([NotNull] ElsaParser.DecrementExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>negateExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNegateExpr([NotNull] ElsaParser.NegateExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>methodCallExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMethodCallExpr([NotNull] ElsaParser.MethodCallExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>variableExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitVariableExpr([NotNull] ElsaParser.VariableExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>notExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitNotExpr([NotNull] ElsaParser.NotExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>integerValueExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitIntegerValueExpr([NotNull] ElsaParser.IntegerValueExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>addExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddExpr([NotNull] ElsaParser.AddExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>expressionMarkerExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpressionMarkerExpr([NotNull] ElsaParser.ExpressionMarkerExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>backTickStringValueExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBackTickStringValueExpr([NotNull] ElsaParser.BackTickStringValueExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>bracketsExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBracketsExpr([NotNull] ElsaParser.BracketsExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by the <c>compareExpr</c>
	/// labeled alternative in <see cref="ElsaParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompareExpr([NotNull] ElsaParser.CompareExprContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="ElsaParser.exprList"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExprList([NotNull] ElsaParser.ExprListContext context) { return VisitChildren(context); }
}
