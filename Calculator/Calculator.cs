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
    public partial class Calculator : Form
    {

        private int inputTotalNumber;
        private List<string> inputNumberList;
        private string inputNumber;
        private int result;
        private string operation;
        private List<int> calculateNumberList;
        public Calculator()
        {
            InitializeComponent();
            InitializeInternalComponents();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Num1_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button1);

        }

        private void Num2_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button2);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button3);
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button4);
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button12);
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button5);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button6);
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button7);
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button8);
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            ChangeInputText(inputNumber, button9);
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            (inputNumberList, inputNumber) = FillTotalInput(inputNumberList, inputNumber);
        }

        private void NumMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            (inputNumberList, inputNumber) = FillTotalInput(inputNumberList, inputNumber);
        }

        private void NumDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            (inputNumberList, inputNumber) = FillTotalInput(inputNumberList, inputNumber);
        }

        private void NumMultiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            (inputNumberList, inputNumber) = FillTotalInput(inputNumberList, inputNumber);
        }

        private void NumResult_Click(object sender, EventArgs e)
        {
            calculateNumberList = ConvertToListInt(inputNumberList);
            result = MakeOperation(operation, calculateNumberList);
        }

        private void ChangeInputText(string number, Button button)
        {
            number += button.Text;
            label1.Text = inputNumber;
        }

        private (List<string>, string) FillTotalInput(List<string> numberList, string number)
        {
            numberList.Append(inputNumber);
            number = "";

            return (numberList, number);
        }

        private int MakeOperation(string operation, List<int> numberList) {
            int result;
            switch (operation)
            {
                case "+":
                    Operations.Sum(numberList);
                    break;
                case "-":
                    Operations.Subtract();
                    break;
                case "*":
                    Operations.Multiplication();
                    break;
                case "/":
                    Operations.Division();
                    break;
                default:
                    Operations.defaultValue;
                    break;
            }
            return result;
        }

        private List<int> ConvertToListInt(List<string> inputNumbers)
        {
            List<int> result = new List<int>();
            int number;
            int defaultValue = 0;
            foreach (var inputNumber in inputNumbers)
            {
                if (int.TryParse(inputNumber, out number))
                    result.Append(number);
                else
                    result.Append(defaultValue);
            }
            return result;
        }


        private void InitializeInternalComponents()
        {
            // initialize variable
            inputTotalNumber = 0;
            result = 0;
            inputNumber = "";
            operation = "";
            inputNumberList = new List<string>();
        }

    }

}
