using System;
using System.Windows.Forms;

namespace NoIfCalc {
  public partial class StandardView : Form {

    public StandardView() {
      InitializeComponent();
    }

    private void DigitButton_Click(object sender, EventArgs e) {
      var button = sender as Button;
      var digit = Int16.Parse(button.Text);

      SecondaryDisplay.Text = "Handle Digit Not Implemented";
    }

    private void DecimalButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Decimal Not Implemented";
    }

    private void DivideButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Divide Not Implemented";
    }

    private void MultiplyButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Multiply Not Implemented";
    }

    private void SubtractButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Subtract Not Implemented";
    }

    private void AddButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Add Not Implemented";
    }

    private void EqualsButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Equals Not Implemented";
    }

    private void PlusMinusButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Plus/Minus Not Implemented";
    }

    private void CancelButton_Click(object sender, EventArgs e) {
      SecondaryDisplay.Text = "Handle Cancel Not Implemented";
    }
  }
}
