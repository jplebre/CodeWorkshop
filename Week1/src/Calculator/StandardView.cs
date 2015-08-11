using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NoIfCalc {
  public partial class StandardView : Form {
      string currentValue;
      string secondaryDisplay;
      bool hasEqualsBeenPressed = false;
      List<int> inputNumbers = new List<int>();
      List<char> operators = new List<char>();

    public StandardView() {
      InitializeComponent();
      currentValue = Display.Text;
    }

    private void DigitButton_Click(object sender, EventArgs e) {
      var button = sender as Button;
      var digit = Int16.Parse(button.Text);

      if (currentValue == "0") currentValue = digit.ToString();
      else currentValue += digit.ToString();
      Display.Text = currentValue;
    }

    private void DecimalButton_Click(object sender, EventArgs e) 
    {
        SecondaryDisplay.Text = "Handle Equals Not Implemented";
    }

    private void DivideButton_Click(object sender, EventArgs e) 
    {
        OperationBehaviour('/');
    }

    private void MultiplyButton_Click(object sender, EventArgs e) 
    {
        OperationBehaviour('*');
    }

    private void SubtractButton_Click(object sender, EventArgs e) 
    {
        OperationBehaviour('-');
    }

    private void AddButton_Click(object sender, EventArgs e) 
    {
        OperationBehaviour('+');
    }

    private void EqualsButton_Click(object sender, EventArgs e) 
    {
        if (inputNumbers.Count == 0) return;

        if (int.Parse(currentValue) != 0) inputNumbers.Add(int.Parse(currentValue));
        else inputNumbers.Add(inputNumbers[inputNumbers.Count - 1]);

        operators.Add(operators[operators.Count - 1]);

        secondaryDisplay = MergeLists(inputNumbers, operators);
        SecondaryDisplay.Text = secondaryDisplay;

        currentValue = "0";
        var toDisplay = CalculateOperations(inputNumbers, operators).ToString();
        SecondaryDisplay.Text = "";
        Display.Text = toDisplay;
    }

    private void PlusMinusButton_Click(object sender, EventArgs e) 
    {
      SecondaryDisplay.Text = "Handle Plus/Minus Not Implemented";
    }

    private void CancelButton_Click(object sender, EventArgs e) 
    {
        inputNumbers.Clear();
        operators.Clear();
        currentValue = "0";
        SecondaryDisplay.Text = "";
        Display.Text = currentValue;
    }

    private void OperationBehaviour(char operationSymbol)
    {
        inputNumbers.Add(int.Parse(currentValue));
        operators.Add(operationSymbol);
        secondaryDisplay = MergeLists(inputNumbers,operators);
        SecondaryDisplay.Text = secondaryDisplay;

        currentValue = "0";
        var toDisplay = CalculateOperations(inputNumbers, operators).ToString();
        Display.Text = toDisplay;
    }

    private string MergeLists(IList<int> number, IList<char> operators)
    {
        string result = "";
        for (int i = 0; i<number.Count; i++)
        {
            result += number[i] + " " + operators[i] + " ";
        }
        return result;
    }

    private int CalculateOperations(IList<int> number, IList<char> operators)
    {

        int answer = number[0];

        for (int i = 1; i < number.Count; i++ )
        {
            int operandus = number[i];

            if (operators[i-1] == '+')
            {
                answer += operandus;
            }
            else if (operators[i-1] == '-')
            {
                answer -= operandus;
            }
            else if (operators[i-1] == '/')
            {
                if (answer == 0) answer = 0;
                else answer = answer / operandus;
            }
            else if (operators[i-1] == '*')
            {
                if (answer == 0) answer = 0;
                else answer = answer * operandus; 
            }
        }

        return answer;
    }
  }
}
