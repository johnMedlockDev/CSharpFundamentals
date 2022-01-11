using System;

namespace FunctionsInputAndOutput
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Function are a way to write code once and get the same output in the context of the situation.
            // Functions kind of act like a wrapper for code to execute
            
            // Take this function that I've written below:
            // public int Add(int num1, int num2)
            // {
            //     int sum = num1 + num2;
            //
            //     return sum;
            // } 
            
            // accessModifier returnType Method/FunctionName( Parameters )
            // {
            //  * code * 
            //  return returnType;
            // }
            
            // The difference between methods and functions is:
            // Method a function that is apart of a class.
            // Function a function that is not part of a class.
            // C# only has methods but in other languages that isn't the case. (Like Python for example.)

            int firstNum = 10;
            int secondNum = 10;

            int result = Add(firstNum, secondNum);

            Console.WriteLine(result);

            secondNum = 20;
            
            result = Add(firstNum, secondNum);

            Console.WriteLine(result);
            
            firstNum = 20;
            
            result = Add(firstNum, secondNum);

            Console.WriteLine(result);
            
            // just writing the method doesn't mean that it is executed. 
            // You have to call the method Add();
            // and pass in the arguments firstNum, secondNum.
            // to execute the method.
            
            // Parameters vs Arguments:
            // the values passed into the method are called arguments.
            // in the method definition the values passed in are referred to as parameters.
            
            // Functions can clean up code and increase maintainability of the application.
            // You can also right methods that don't return a value with "void" in the returnType field.
        }

        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;
        }
        
    }
}
