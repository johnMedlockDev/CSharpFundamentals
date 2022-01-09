using System;

namespace IfStatementsLogicalExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region ComparisonOperators

            // Briefly we'll review the comparison operators.
            // Comparison operator syntax:

            /*
             * valueA ComparisonOperator valueB : Output is a Boolean
             */

            // == : Evaluates to True if the values being compared are the same. | 1 == 1 = True   
            // != : Evaluates to True if the values being compared are not the same. | 1 != 1 = False
            // <  : Evaluates to True if the first value is less than the second. | 1 < 1 = False
            // >  : Evaluates to True if the first value is greater than the second. | 1 > 1 = False
            // <= : Evaluates to True if the first value is less than or equal to the second. | 1 <= 1 = True
            // >= : Evaluates to True if the first value is greater than or equal to the second. | 1 >= 1 = True

            #endregion ComparisonOperators

            #region BasicConditionalStatements

            #region IfStatements

            // The reason you use conditional statements like if statements is when state is one deterministic,
            // (meaning predictable.), and two state of the application has multiple execution outcomes.
            // Conditional statements take the values passed in the () and evaluate it using boolean logic.
            // to determine if the state evaluation expression is True or False.
            // state evaluation expression = Does 1 + 1 = 2? Yes, replace that with True. 
            // state evaluation expression = Does 1 + 3 = 4? Yes, replace that with True.
            // state evaluation expression = Does 1 + 4 = 5? Yes, replace that with True.
            // state evaluation expression = Does 1 + 1 = 3? No, replace that with False.
            // state evaluation expression = Does 10 + 1 = 3? No, replace that with False.
            // (Not the string value "True", but the boolean value True.
            // In practice if statements are used to selectively execute code blocks based on state.
            // This is a great time to use break points. (If this is you first exposure to conditional statements
            // it might be a good idea to put a break point at the start of the application and set through this project
            // hovering the if statements and variables as you go.
            // Try to predict what the compiler will end up doing.
            // Basic syntax of a if statement is:

            /*
             * if (condition) 
                {
                  // block of code to be executed if the condition is True
                }
             */

            int num1 = 10;
            int num2 = 10;
            int num3 = 11;

            // since num1 and num2 are the same values you would expect that the code will execute.
            if (num1 == num2)
            {
                Console.WriteLine(num1 == num2);
                Console.WriteLine($"{num1.ToString()} == {num2.ToString()}");
            }

            // since num1 and num3 are not the same values you would expect that the code will not execute.
            if (num1 == num3)
            {
                Console.WriteLine(num1 == num3);
                Console.WriteLine($"{num1.ToString()} == {num3.ToString()}");
            }

            // Notice that the code always runs out side of the if blocks.
            // However based on the expression state the value in the if code block may or may not execute. 

            #endregion IfStatements

            #region ElseIfClause

            // The else if clause is a optional extenstion of the if statement. 
            // You'll use something like this if your function state can have more than two evaluation.
            // Else if Syntax: 
            /*
             *  if (condition) 
                {
                  // block of code to be executed if the condition is True
                } 
                else if (condition)
                {
                   // block of code to be executed else if the condition is True
                }
             */

            string nameA = "John";
            string nameB = "Sally";
            string nameC = "Sue";

            string selectedName = nameB;

            if (selectedName == nameA)
                Console.WriteLine($"Hi, {selectedName} nice code.");
            else if (selectedName == nameB)
                Console.WriteLine($"Hi, {selectedName} nice hair.");
            else if (selectedName == nameC)
                Console.WriteLine($"Hi, {selectedName} nice eyes");

            // Since our outcome is predicable and we have more than two values a else if statement makes since to use here.
            // Note only one of this if blocks will ever get executed.
            // After execution the program effectively stops checking else ifs or else clauses.
            // This is different than a series of naked if statements. In that case all of if statements will be evaluated
            // assume there is no value returned. (Don't worry about returning values right now.)

            #endregion ElseIfClause

            #region ElseClause

            // The else block is a way to handle the edge cases (things that don't happen frequently or don't know about.)
            // Else is kind of like a catch all clause. 
            // You use use else with either the if or append it to the end of a else if block.
            /*
             * if (condition) 
             * {
             *     // block of code to be executed if the condition is True
             * } else
             * {
             *     // block of code to be executed if the condition is True
             * }
             */
            // Note that the else block doesn't have a condition block, that is because it's only executing if
            // none of the other conditions are triggered.  

            char letterA = 'a';
            char letterB = 'b';
            char letterC = 'c';
            char letterD = 'd';

            char selectedLetter = 'e';

            if (selectedLetter == letterA)
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");
            else if (selectedLetter == letterB)
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");
            else if (selectedLetter == letterC)
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");
            else if (selectedLetter == letterD)
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");
            else
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

            if (selectedLetter == letterA)
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");
            else
                Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

            // I'd recommend going through the exercise a few times with break points.

            #endregion ElseClause

            #endregion BasicConditionalStatements

            #region OtherConditionalStatements

            #region TernaryOperator

            // The ternary operator is a shorthand way of creating a if statement.
            // It does the exact same thing as a traditional if statement does, but it's syntax is quite a bit different.
            /*
             *  condition ? consequent : alternative
             *  1 == 1 ? True : False
             */

            int tNum1 = 1;
            int tNum2 = 1;

            bool expressionBool = tNum1 == tNum2 ? true : false;
            Console.WriteLine(expressionBool);

            // this is highlighted because (tNum1 == tNum2) will automatically return a boolean
            // do to how comparison operators work.

            int expressionInt = tNum1 < tNum2 ? tNum1 : tNum2;
            Console.WriteLine(expressionInt);

            // there are a few instances where this significantly cleans up your code. 
            // However, I think if your if statements are rather complicated I might consider just making it longer.
            // There is no performance boost from doing it this way.

            #endregion TernaryOperator

            #region Switches

            // Switch statements are yet another way to do write conditional statements.
            // using the values above I'm going to create an equal switch. 
            /*
             switch(expression) 
            {
              case x:
                // code block
                break;
              case y:
                // code block
                break;
              default:
                // code block
                break;
            }
             */

            switch (selectedLetter)
            {
                case 'a':
                    Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

                    break;
                case 'b':
                    Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

                    break;
                case 'c':
                    Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

                    break;
                case 'd':
                    Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

                    break;
                default:
                    Console.WriteLine($"Your letter is {selectedLetter.ToString()}");

                    break;
            }

            // Case is for deterministic values that you are checking for. 
            // the break keyword tell the switch that after this is hit don't evaluate any more cases and go to the end.
            // default is effectively an else block.

            // Why use a switch over a if statement? Sometimes it's a little cleaner to use a switch like when your
            // if statements get over 3 else ifs deep.

            #endregion Switches

            #endregion OtherConditionalStatements
        }
    }
}
