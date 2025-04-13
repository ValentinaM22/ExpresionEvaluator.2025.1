using Evaluator.Logic;

Console.WriteLine("Expressions Evaluator");

var expression1 = "4*5/(4+6)";
var expression2 = "4*(5+6-(8/2^3)-7)-1";

Console.WriteLine($"{expression1} = {FunctionEvaluator.Evaluate(expression1)}");
Console.WriteLine($"{expression2} = {FunctionEvaluator.Evaluate(expression2)}");