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
            return new EnteringDecimalNumber();
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
            calculator.Display = "-"+calculator.Display;
            return new NegateState();
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
            calculator.Display += "0";
            return this;
        }

        public override CalculatorState Digit(Calculator calculator, string digit)
        {
            calculator.Display += digit;
            return this;
        }
    }

    internal class EnteringDecimalNumber : EnteringNumber
    {
        public override CalculatorState Decimal(Calculator calculator)
        {
            return new EnteringDecimalNumber();
        }
    }

    internal class NegateState : CalculatorState
    {
        public override CalculatorState Negate(Calculator calculator)
        {
            calculator.Display = calculator.Display.Remove(0, 1);
            return new CalculatorState();
        }
    }
}
