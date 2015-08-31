using System;
using System.Windows.Forms;

namespace OOCalc {
  public partial class StandardView : Form
  {
    private Calculator calculator;

    public StandardView() {
      InitializeComponent();
      calculator = new Calculator();
      calculator.DisplayChanged += onPrimaryDisplayChanged;
      calculator.Clear();
    }

    private void ZeroButton_Click(object sender, EventArgs e)
    {
        calculator.Zero();
    }

    private void DigitButton_Click(object sender, EventArgs e) {
      var button = sender as Button;
      calculator.Digit(button.Text);
    }

    private void DecimalButton_Click(object sender, EventArgs e) {
        calculator.Decimal();
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        calculator.Clear();
    }

    private void EqualsButton_Click(object sender, EventArgs e)
    {
        calculator.Equal();
    }

    private void NegateButton_Click(object sender, EventArgs e)
    {
        calculator.Negate();
    }


    private void AddButton_Click(object sender, EventArgs e)
    {
        calculator.Add();
    }

    private void SubtractButton_Click(object sender, EventArgs e)
    {
        calculator.Subtract();
    }

    private void MultiplyButton_Click(object sender, EventArgs e)
    {
        calculator.Multiply();
    }

    private void DivideButton_Click(object sender, EventArgs e) {
        calculator.Divide();
    }

    private void onPrimaryDisplayChanged(object owner, string text)
    {
        Display.Text = text;
    }
  }
}
