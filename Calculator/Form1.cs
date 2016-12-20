using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        // Is the last input operator?
        private bool IsInputOperator = false;
        // For expression compute
        DataTable dt = new DataTable();
        // Binary Regex
        static readonly Regex binary = new Regex("^[01]{1,32}$", RegexOptions.Compiled);

        public Form1()
        {
            InitializeComponent();
        }

        // Numeric Button.Text set to TextBox.
        private void NumButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                textBox1.Text += b.Text;
            }

            IsInputOperator = false;
        }

        // Operator Button.Text set to TextBox.
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                if (IsInputOperator == false)
                {
                    textBox1.Text += b.Text;
                    IsInputOperator = true;
                }
            }    
        }

        // Clear
        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // Evaluate
        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = dt.Compute(textBox1.Text, "").ToString();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void DecimalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DecimalRadioButton.Checked == true)
            {
                if (binary.IsMatch(textBox1.Text))
                {
                    textBox1.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid binary: " + textBox1.Text);
                }
            }
            else // BinaryRadioButton.Checked == true
            {
                // First, do evaluate
                EvaluateButton_Click(null, null);
                // Second, convert to int
                int convertedValue = 0;
                bool result = int.TryParse(textBox1.Text, out convertedValue);
                if (result == false)
                {
                    MessageBox.Show("Invalid decimal: " + textBox1.Text);
                    return;
                }                
                // Thrid, Convert to binary
                textBox1.Text = Convert.ToString(convertedValue, 2);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Focused == true && e.KeyCode != Keys.Enter)
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    NumButton_Click(button0, null);
                    break;
                case Keys.NumPad1:
                case Keys.D1:
                    NumButton_Click(button1, null);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    NumButton_Click(button2, null);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    NumButton_Click(button3, null);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    NumButton_Click(button4, null);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    NumButton_Click(button5, null);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    NumButton_Click(button6, null);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    NumButton_Click(button7, null);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    NumButton_Click(button8, null);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    NumButton_Click(button9, null);
                    break;
                case Keys.Add:
                    OperatorButton_Click(buttonAdd, null);
                    break;
                case Keys.Subtract:
                    OperatorButton_Click(buttonSub, null);
                    break;
                case Keys.Multiply:
                    OperatorButton_Click(buttonMul, null);
                    break;
                case Keys.Divide:
                    OperatorButton_Click(buttonDiv, null);
                    break;
                case Keys.Enter:
                    EvaluateButton_Click(null, null);
                    break;
                case Keys.Escape:
                    ClearButton_Click(buttonClear, null);
                    break;
                default:
                    break;
            }
        }

        // Make numeric and operator textbox, except "Enter", "Backspace", "Dot"
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                // Enter, Backspace
                if (e.KeyChar == '\r' || e.KeyChar == '\b')
                {
                    return;
                }
                // operator include '.'
                if (e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                else
                {
                    if (IsInputOperator == true)
                    {
                        e.Handled = true;
                    }
                    IsInputOperator = true;
                }
            }
            else
            {
                IsInputOperator = false;
            }
        }
    }
}