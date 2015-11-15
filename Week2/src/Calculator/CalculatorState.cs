namespace OOCalc
{
    internal class CalculatorState
    {
        public virtual CalculatorState Zero(Calculator calculator)
        {
            calculator.Display = "0";
            return this;
        }

        public virtual CalculatorState Digit(Calculator calculator, string digit)
        {
            calculator.Display = digit;
            return new EnteringNumber();
        }

        public virtual CalculatorState Decimal(Calculator calculator)
        {
            calculator.Display += ".";
            // TODO: Change State When Decimal is pressed.
            // Once a decimal point is used we don't want to allow any more
            // So the state of the calculator changes.
            // Implement this by returning an instance of 'EnteringDecimalNumber'
            // Also: Complete the implementation of 'EnteringDecimalNumber' below
            return new EnteringNumber();
        }

        public virtual CalculatorState Clear(Calculator calculator)
        {
            calculator.Display = "0";
            return new CalculatorState();
        }

        public virtual CalculatorState Equal(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }

        public virtual CalculatorState Negate(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }

        public virtual CalculatorState Add(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }

        public virtual CalculatorState Subtract(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }

        public virtual CalculatorState Multiply(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }

        public virtual CalculatorState Divide(Calculator calculator)
        {
            calculator.Display = "Not implemented";
            return this;
        }
    }

    internal class EnteringNumber: CalculatorState
    {
        public override CalculatorState Zero(Calculator calculator)
        {
            // TODO: Append '0' when entering a number.
            // Override the base implementation which sets the display to 0
            // Instead you should append 0 to the display
            return this;
        }

        public override CalculatorState Digit(Calculator calculator, string digit)
        {
            // TODO: Append the digit when entering a number.
            // Override the base implementation which sets the display to the digit
            // Instead you should append the digit to the display
            return this;
        }
    }

    internal class EnteringDecimalNumber : EnteringNumber
    {
        // TODO: Override the default implementation for handling Decimal Point
        // Override the Decimal method to handle situations where a decimal point
        // Has already been entered.
        // This override should not append a decimal point.
    }
}
