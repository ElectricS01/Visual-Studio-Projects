using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__Task2_
{
    public partial class calculator : Form
    {
        // Stores the current equation
        public string equation = "";

        public calculator()
        {
            InitializeComponent();
        }

        // Event handler for the "0" button click
        private void btn_0_Click(object sender, EventArgs e)
        {
            equation = equation + "0";
            txt_box.Text = equation;
        }

        // Event handler for the "1" button click
        private void btn_1_Click(object sender, EventArgs e)
        {
            equation = equation + "1";
            txt_box.Text = equation;
        }

        // Event handler for the "2" button click
        private void btn_2_Click(object sender, EventArgs e)
        {
            equation = equation + "2";
            txt_box.Text = equation;
        }

        // Event handler for the "3" button click
        private void btn_3_Click(object sender, EventArgs e)
        {
            equation = equation + "3";
            txt_box.Text = equation;
        }

        // Event handler for the "4" button click
        private void btn_4_Click(object sender, EventArgs e)
        {
            equation = equation + "4";
            txt_box.Text = equation;
        }

        // Event handler for the "5" button click
        private void btn_5_Click(object sender, EventArgs e)
        {
            equation = equation + "5";
            txt_box.Text = equation;
        }

        // Event handler for the "6" button click
        private void btn_6_Click(object sender, EventArgs e)
        {
            equation = equation + "6";
            txt_box.Text = equation;
        }

        // Event handler for the "7" button click
        private void btn_7_Click(object sender, EventArgs e)
        {
            equation = equation + "7";
            txt_box.Text = equation;
        }

        // Event handler for the "8" button click
        private void btn_8_Click(object sender, EventArgs e)
        {
            equation = equation + "8";
            txt_box.Text = equation;
        }

        // Event handler for the "9" button click
        private void btn_9_Click(object sender, EventArgs e)
        {
            equation = equation + "9";
            txt_box.Text = equation;
        }

        // Event handler for the "." button click
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + ".";
                txt_box.Text = equation;
            }
            else
            {
                equation = equation + "0.";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "/" button click
        private void btn_slash_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + "/";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "*" button click
        private void btn_star_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + "*";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "-" button click
        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + "-";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "+" button click
        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + "+";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "^" button click
        private void btn_power_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                equation = equation + "^";
                txt_box.Text = equation;
            }
        }

        // Event handler for the ")" button click
        private void btn_right_Click(object sender, EventArgs e)
        {
            equation = equation + ")";
            txt_box.Text = equation;

        }

        // Event handler for the "(" button click
        private void tbn_left_Click(object sender, EventArgs e)
        {
            equation = equation + "(";
            txt_box.Text = equation;
            
        }

        // Event handler for the "CE" button click
        private void btn_ce_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                // Remove the last character from the equation
                equation = equation.Remove(equation.Length - 1, 1);
                txt_box.Text = equation;
            }
        }

        // Event handler for the "C" button click
        private void btn_c_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                // Clear the equation
                equation = "";
                txt_box.Text = equation;
            }
        }

        // Event handler for the "=" button click
        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (equation != "")
            {
                // Calculate the result and display it
                double result = Calculator.CalculateResult(equation);
                equation = result.ToString();
                txt_box.Text = result.ToString();
            }
        }
    }

    public class Calculator
    {
        // Calculates the result of the given operator and operands
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

        // Evaluates the expression represented by the tokens
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

        // Tokenizes the expression into individual tokens
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

        // Calculates the result of the given equation
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
