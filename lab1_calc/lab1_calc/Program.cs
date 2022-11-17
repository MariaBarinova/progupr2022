using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            class reverseNotarion
            {
                static void Main (string [] args)
                {
                    while (true)
                    {
                        Console.Write ();
                        var input = Console.ReadLine ();
                        var result = reverseNotarion.resultNotation (input);
                        Console.Write (result);
                    }
                }

                static string readingEquation (string input);
                {
                    string output = string.Empty;
                    Stack <char> operStack = new Stack<char>();

                    for (int = 0; i<input.Lenghth; i++) 
                    {
                        if (Char.IsDigit (input[i]))
                        {
                            while ! (IsDelimetre(input[i]) || IsOperator (input[i]))
                            {
                                output += input [i];
                                i++;
                                if (i == input.Lenght) break
                            }
                            output += " ";
                            i--
                        }
                        else if (IsOperator(input [i]))
                        {
                            switch (input [i])
                            {
                                case '(': 
                                operStack.Push (input [i]);
                                break;
                                case ')': 
                                {
                                    char symbol = operStack.Pop();
                                    while (symbol != '(')
                                    {
                                        output += symbol.ToString() + '';
                                        sumbol = oper.Stack.Pop;
                                    }
                                    break;
                                }
                                    default: 
                                        if (operStack.Count > 0;
                                                 if (CheckOperatorPrecedence (input[i]) <= CheckOpoeratorPrecedence (operStack.Peek()))
                                                    output += operStack.Pop().ToString + " ";
                                                    operStack.Push(char.Parse(input[i].ToString()));
                                                 break;
                                }

                            }
                    }
                                            while (operStack.Counr > 0)
                                            {
                                                output += operStack.Pop() + "";
                                            }
                                            return output;
                }
                                            static double resultEquation (string input);
                                            {
                                                string polishExpression = readingEquation(input);
                                                Console.WriteLine ("Польская нотация: " + polishExpression);
                                                double res = result (polishExpression);
                                                return res;
                                            }
                                            static bool IsDelimeter (char symbol);
                                            {
                                                switch (symbol)
                                                {
                                                    case ' ':
                                                    case '=':
                                                        return true;
                                                    default:
                                                        return false;
                                                }
                                            }
                                            
                                            static bool IsOperator (char symbol)
                                            {
                                                return CheckOperatorPrecedence (symbol) < MAX_PRIORITY;
                                            }
                                            
                                            static byte CheckOperatorPrecedence (char symbol) => symbol switch
                                            {
                                                '(' => 0,
                                                ')' => 1,
                                                '+' => 2,
                                                '-' => 2,
                                                '/' => 3,
                                                '*' => 3,
                                                _ => MAX_PRIORITY   ,
                                            }
                                            
                                            static private double result (string inputing)
                                            {
                                                double total = 0;
                                                Stack<double> stack = new Stack<double>;
                                                for (int symbol = 0; symbol < input.Lenght; symbol++)
                                                {
                                                    if (IsOperator (inputing [symbol]))
                                                    {
                                                        double a = stack.Pop;
                                                        double b = stack.Pop;
                                                        
                                                        switch (inputing [symbol])
                                                        {
                                                            case '+': total = b+a; break;
                                                            case '-': total = b-a; break;
                                                            case '/': total = b/a; break;
                                                            case '*': total = b*a; break;
                                                        }
                                                        stack.Push(total);
                                                    }
                                                    
                                                    else if (Char.IsDigit(inputing[symbol]))
                                                    {
                                                        strig output = string.Empty;
                                                        while (! (IsOperator (inputing[symbol]) || IsDelimeter (inputing[symbol])))
                                                        {
                                                            output += inputing[symbol];
                                                            symbol++;
                                                            if symbol == inputing.Length) break;
                                                        }
                                                        stack.Push(double.Parse(output));
                                                        symbol--;
                                                    }
                                                }
                                                return stack.Peek();
                                            }
            }
        }
    }
}
