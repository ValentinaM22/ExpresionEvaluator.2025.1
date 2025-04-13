namespace Evaluator.Logic;

public class FunctionEvaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = ToPostfix(infix);
        return Calculate(postfix);
    }

    private static double Calculate(string postfix)
    {
        var stack = new Stack<double>();
        var number = string.Empty;

        for (int i = 0; i < postfix.Length; i++)
        {
            var item = postfix[i];

            if (char.IsDigit(item) || item == '.')
            {
                number += item;
            }
            else if (item == ' ')
            {
                if (!string.IsNullOrEmpty(number))
                {
                    stack.Push(double.Parse(number));
                    number = string.Empty;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(number))
                {
                    stack.Push(double.Parse(number));
                    number = string.Empty;
                }

                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(Result(a, item, b));
            }
        }

        if (!string.IsNullOrEmpty(number))
        {
            stack.Push(double.Parse(number));
        }

        return stack.Pop();
    }

    private static double Result(double operator1, char item, double operator2)
    {
        return item switch
        {
            '+' => operator1 + operator2,
            '-' => operator1 - operator2,
            '*' => operator1 * operator2,
            '/' => operator1 / operator2,
            '^' => Math.Pow(operator1, operator2),
            _ => throw new Exception("Invalid expresion"),
        };
    }

    private static string ToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var postfix = string.Empty;
        var number = string.Empty;

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];

            if (char.IsDigit(item) || item == '.')
            {
                number += item;
            }
            else
            {
                if (!string.IsNullOrEmpty(number))
                {
                    postfix += number + " ";
                    number = string.Empty;
                }

                if (IsOperator(item))
                {
                    if (item == ')')
                    {
                        while (stack.Peek() != '(')
                            postfix += stack.Pop() + " ";
                        stack.Pop(); // remove '('
                    }
                    else
                    {
                        while (stack.Count > 0 &&
                              ((item != '^' && PriorityExpression(item) <= PriorityStack(stack.Peek())) ||
                               (item == '^' && PriorityExpression(item) < PriorityStack(stack.Peek()))))
                        {
                            postfix += stack.Pop() + " ";
                        }

                        stack.Push(item);
                    }
                }
                else if (item == '(')
                {
                    stack.Push(item);
                }
            }
        }

        if (!string.IsNullOrEmpty(number))
        {
            postfix += number + " ";
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop() + " ";
        }

        return postfix;
    }

    private static int PriorityStack(char item)
    {
        return item switch
        {
            '^' => 3,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 0,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static int PriorityExpression(char item)
    {
        return item switch
        {
            '^' => 4,
            '*' => 2,
            '/' => 2,
            '+' => 1,
            '-' => 1,
            '(' => 5,
            _ => throw new Exception("Invalid expression."),
        };
    }

    private static bool IsOperator(char item) => "()^*/+-".IndexOf(item) >= 0;
}
