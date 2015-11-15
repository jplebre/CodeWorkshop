using System;

namespace OOCalc
{
    public class Calculator
    {
        private string display;
        private CalculatorState calculatorState;

        public Calculator()
        {
            calculatorState = new CalculatorState();
        }

        public string Display
        {
            get { return display; }
            set
            {
                display = value;
                ChangeTheDisplay(display);
            }
        }

        public event EventHandler<string> DisplayChanged;

        public void Zero()
        {
            calculatorState = calculatorState.Zero(this);
        }

        public void Digit(string digit)
        {
            calculatorState = calculatorState.Digit(this, digit);
        }

        public void Decimal()
        {
            calculatorState = calculatorState.Decimal(this);
        }

        public void Clear()
        {
            calculatorState = calculatorState.Clear(this);
        }

        public void Equal()
        {
            calculatorState = calculatorState.Equal(this);
        }

        public void Negate()
        {
            calculatorState = calculatorState.Negate(this);
        }

        internal void Add()
        {
            calculatorState = calculatorState.Add(this);
        }

        internal void Subtract()
        {
            calculatorState = calculatorState.Subtract(this);
        }

        internal void Multiply()
        {
            calculatorState = calculatorState.Multiply(this);
        }

        internal void Divide()
        {
            calculatorState = calculatorState.Divide(this);
        }

        private void ChangeTheDisplay(string text)
        {
            if (DisplayChanged != null)
            {
                DisplayChanged(this, text);
            }
        }
    }
}