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
                }
            }
        }
    }
}
