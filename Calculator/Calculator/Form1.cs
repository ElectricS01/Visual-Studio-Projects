using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_eq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string equation = txt_eq.Text;
                double result = Calculator.CalculateResult(equation);
                txt_answer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txt_answer.Text = "Error: " + ex.Message;
            }
        }
    }

    public class Calculator
    {
        private static double Calculate(char @operator, double operand1, double operand2)
        {
            switch (@operator)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                case '^':
                    return Math.Pow(operand1, operand2);
                default:
                    throw new ArgumentException("Invalid operator");
            }
        }

        private static double EvaluateExpression(string[] tokens)
        {
            var precedence = new Dictionary<char, int>
            {
                { '+', 1 },
                { '-', 1 },
                { '*', 2 },
                { '/', 2 },
                { '^', 3 },
            };

            var values = new Stack<double>();
            var operators = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];

                if (double.TryParse(token, out var number))
                {
                    // If the token is a number, push it to the values stack
                    values.Push(number);
                }
                else if (precedence.ContainsKey(token[0]))
                {
                    // If the token is an operator, handle operator precedence
                    while (operators.Count > 0 && precedence.ContainsKey(operators.Peek()) && precedence[operators.Peek()] >= precedence[token[0]])
                    {
                        var @operator = operators.Pop();
                        var operand2 = values.Pop();
                        var operand1 = values.Pop();
                        var result = Calculate(@operator, operand1, operand2);
                        values.Push(result);
                    }
                    operators.Push(token[0]);
                }
                else if (token == "(")
                {
                    // If the token is an opening parenthesis, push it to the operators stack
                    operators.Push(token[0]);
                }
                else if (token == ")")
                {
                    // If the token is a closing parenthesis, evaluate the expression inside the parentheses
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        var @operator = operators.Pop();
                        var operand2 = values.Pop();
                        var operand1 = values.Pop();
                        var result = Calculate(@operator, operand1, operand2);
                        values.Push(result);
                    }
                    if (operators.Count == 0 || operators.Peek() != '(')
                    {
                        throw new ArgumentException("Mismatched parentheses");
                    }
                    operators.Pop(); // Discard the opening parenthesis
                }
                else
                {
                    throw new ArgumentException("Invalid token: " + token);
                }
            }

            // Apply any remaining operators
            while (operators.Count > 0)
            {
                var @operator = operators.Pop();
                var operand2 = values.Pop();
                var operand1 = values.Pop();
                var result = Calculate(@operator, operand1, operand2);
                values.Push(result);
            }

            if (values.Count != 1 || operators.Count != 0)
            {
                throw new ArgumentException("Invalid expression");
            }

            return values.Pop();
        }


        private static string[] TokenizeExpression(string equation)
        {
            var operators = new char[] { '+', '-', '*', '/', '^', '(', ')' };
            var tokens = new List<string>();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < equation.Length; i++)
            {
                if (operators.Contains(equation[i]))
                {
                    if (sb.Length > 0)
                    {
                        tokens.Add(sb.ToString());
                        sb.Clear();
                    }
                    tokens.Add(equation[i].ToString());
                }
                else if (!char.IsWhiteSpace(equation[i]))
                {
                    sb.Append(equation[i]);
                }
            }

            if (sb.Length > 0)
            {
                tokens.Add(sb.ToString());
            }

            return tokens.ToArray();
        }

        public static double CalculateResult(string equation)
        {
            try
            {
                string[] tokens = TokenizeExpression(equation);
                return EvaluateExpression(tokens);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid expression: " + ex.Message);
            }
        }

    }
}

