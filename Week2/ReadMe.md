# Week 2

## Minimise IF's
In this challenge we are going to look at how Object Oriented Programming can allow us to minimize the use of conditional statements (if, switch, etc.). We will use the 'State' Design Pattern to represent the calculator so that it's behavior can change when it's state does.

When we use variables to store the state of the application and conditional statements to choose the code to run, it becomes harder to reason about the code. Complexity tends to increase with any attempt to main the app, fix a bug or add a feature.

If we can eliminate conditionals we should end up with smaller methods and more maintainable code so that the effects of changes can be localized.

Sadly, we won't get it fully right this week, but we will get a glimpse of what a more Object Oriented Approach can do.

Ultimately, the approach we'll take this week will break down. When it does we'll examine why and try again.

### Instructions

This week we'll ignore the SecondaryDisplay and the Arithmetic Operations.

1. Examine 'StandardView.cs' and note that all the logic of the calculator has been moved to a Calculator class. The 'View' simple passes button clicks to the Calculator. The Calculator communicates back to the View via an event that the view handles to update the display.

2. Examine 'Calculator.cs' and note that it holds a reference to a 'CalculatorState'. Each time a button click is handled the CalculatorState state changes itself.

<pre>
public void Zero()
{
    calculatorState = calculatorState.Zero(this);
}
</pre>

3. In calculatorState.cs there are four commented sections with instructions for the code you need to write.

When you implement the missing sections you will have the entering of numbers including decimals working correctly.

4. Implement the Negate method in ComputerState and have it prepend a '-' to the display.

Attempt to use a state change to remove the '-' the next time negate is clicked.

Note the difficulty in toggling the 'Negation State' when it is implemented in the same Calculator State object as numbers and decimals.
