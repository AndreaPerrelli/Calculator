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
        private double result;
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
            inputNumber = ChangeInputText(inputNumber, button1);

        }

        private void Num2_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button2);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button3);
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button4);
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button12);
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button5);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button6);
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button7);
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button8);
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            inputNumber = ChangeInputText(inputNumber, button9);
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            (inputNumberList, inputNumber) = ProcessOperations(Operations.plusOperation);
        }

        private void NumMinus_Click(object sender, EventArgs e)
        {
            (inputNumberList, inputNumber) = ProcessOperations(Operations.minusOperation);
        }

        private void NumDivision_Click(object sender, EventArgs e)
        {
            (inputNumberList, inputNumber) = ProcessOperations(Operations.equalOperation);
        }

        private void NumMultiplication_Click(object sender, EventArgs e)
        {
            (inputNumberList, inputNumber) = ProcessOperations(Operations.orOperation);
        }

        private void NumResult_Click(object sender, EventArgs e)
        {
            (inputNumberList, inputNumber) = FillTotalInput(inputNumberList, inputNumber);
            ProcessResult();
        }

        private void NumReset_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            InitializeInternalComponents();
        }


        private string ChangeInputText(string number, Button button)
        {
            number += button.Text;
            label1.Text = number;
            return number;
        }

        private (List<string>, string) FillTotalInput(List<string> numberList, string number)
        {
            numberList.Add(number);
            number = "";

            return (numberList, number);
        }

        private (List<string>, string) ProcessOperations(string operation)
        {
            this.operation = operation;
            return (_, _) = FillTotalInput(inputNumberList, inputNumber);
        }

        private void ProcessResult()
        {
            calculateNumberList = ConvertToListInt(inputNumberList);
            result = MakeOperation(operation, calculateNumberList);
            label1.Text = result.ToString();
            InitializeInternalComponents();
        }

        private double MakeOperation(string operation, List<int> numberList) {
            double result;
            switch (operation)
            {
                case "+":
                    result = Operations.Sum(numberList);
                    break;
                case "-":
                    result = Operations.Subtract(numberList);
                    break;
                case "*":
                    result = Operations.Multiplication(numberList);
                    break;
                case "/":
                    result = Operations.Division(numberList);
                    break;
                default:
                    result = Operations.defaultValue;
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
                    result.Add(number);
                else
                    result.Add(defaultValue);
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
            calculateNumberList = new List<int>();
        }

    }

}
