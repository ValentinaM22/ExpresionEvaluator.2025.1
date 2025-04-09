using Evaluator.Logic;

try
{
    var result1 = FunctionEvaluator.Evalute("4*5/(4+6)");
    var result2 = FunctionEvaluator.Evalute("4*(5+6-(8/2^3)-7)-1");
    var result3 = FunctionEvaluator.Evalute("9^(1/2)");
    var result4 = FunctionEvaluator.Evalute("3.5+2.2");


    Console.WriteLine(result1);
    Console.WriteLine(result2);
    Console.WriteLine(result3);
    Console.WriteLine(result4); 
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}