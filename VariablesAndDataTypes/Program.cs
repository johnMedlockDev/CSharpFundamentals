using System;

namespace Variables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region DocumentingYourCode

            // Most programming languages have multiple ways to document what your code is doing.
            // The most common is just using comments.
            // (What you're reading is referred to as a comment.)
            // The // tells the compiler to effectively ignore this line of code.

            // // = single line comment

            // this is how you can make a multiline comment
            /*
             * multiline
             * comment
             */

            // The IDE defaults to the // so I use it for most everything.

            // C# also allows for regions.
            // This is a way of adding code folding to your program.
            // I don't know why this feature isn't more popular among developers, but it allows you to further
            // encapsulate logic in your application.

            // #region Example
            //  ****Code here*****
            // #endregion Example

            // If your code gets rather large or complex.
            // Consider adding some of these to reduce the cognitive load it takes to work with it.  
            // Most devs subscribe to the idea of self documenting code to justify not commenting,
            // but I say why not do both!

            #endregion DocumentingYourCode

            #region ValueTypes

            // Value Types (Simple, Enum, Structs, and Nullable Types)
            // Value Types are stored in a memory on the stack.
            // Value types can not be null. (Null is an empty space in memory.)
            // Value Types are passed by value. (Meaning the value isn't a pointer to a reference. It is a value.) 

            #region NumericTypes

            #region Integral

            // Integral is a fancy way of saying whole number.
            // The reason we have multiple types for different numbers is allocate varying amounts of memory.
            // This allows developers to optimize the memory efficiency of a application.

            // Unsigned Integral meaning it doesn't have a minus sign and uses the same range starting at zero.

            byte b; // 0 to 255 | 8 bits of memory
            ushort ush; // 0 to 65,535 | 16 bits of memory
            uint ui; //	0 to 4,294,967,295 | 32 bits of memory
            ulong ul; // 0 to 18,446,744,073,709,551,615 | 64 bits of memory

            // Signed Integral meaning it doesn't have a minus sign and uses the same range starting at zero.

            sbyte sb; // -128 to 127 | 8 bits of memory
            short sh; // -32,768 to 32,767 | 16 bits of memory 
            int i; // -2,147,483,648 to 2,147,483,647 | 32 bits of memory
            long l; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | 64 bits of memory

            #endregion Integral

            #region FloatingPoint

            // Floating point means the number can contain a decimal point. 

            float f; // -3.402823e38 to 3.402823e38	| 32 bits of memory
            double d; // -1.79769313486232e308 to 1.79769313486232e308 | 64 bits of memory
            decimal de; // (+ or -)1.0 x 10e-28 to 7.9 x 10e28 | 128 bits of memory

            #endregion FloatingPoint

            #endregion NumericTypes

            #region Booleans

            // Boolean values are a way communicating true or false, 0 or 1, on or off. 

            bool bo; // True or False

            #endregion Booleans

            #region Characters

            // Chars are data types that can contain exactly 1 character. 

            char c; // Any valid character

            #endregion Characters

            #endregion ValueTypes

            #region ReferenceTypes

            // Reference Types
            // Reference types are stored in a memory on the heap.
            // Reference types can be null. (Null is an empty space in memory.)
            // Reference Types are passed by reference. (Meaning the value is a pointer to a reference.
            // So if you create two of the same object they point to the first instance of the object.)

            // The object type is base type by which all other types are created. 
            // You could thing of it like the atom of C# compared to the universe.
            object obj; // Base type for all types

            #region Strings

            // Strings are commonly used to encapsulate words, sentences, etc.
            // Strings are really a sequence of chars called an array of chars.
            string str; // A sequence of chars.

            #endregion Strings

            #endregion ReferenceTypes

            #region InstantiateAndInitialize

            //An object is instantiated when memory is allocated for it and it's constructor has been run.
            string n;

            //A variable is initialized with a value.
            n = "John";

            // Note that you can do both on the same line like this:
            // string name = "John";

            #endregion InstantiateAndInitialize

            #region MeaningfulNames

            // Up until this point we'll gave our variables pretty meaningless names.
            // This is a bad practice because it adds pointless complexity to the environment.
            // Variable names in C# (and most other languages) are supposed to camelCase by convention.
            // Always write code in such a way that if you were to comeback in 6 months you would still be able to read
            // your code like you would read a newspaper or a book.

            // Above we assigned the n variable to the value of "John". 
            // I think a better name for that variable might have been name, because the value "John" represents my name.

            string name = "John";

            // string firstName = "John"; This would have been another acceptable name.

            // string Fne = "John"; This would not have been an acceptable name.
            // string fN = "John"; This would not have been an acceptable name.
            // string a = "John"; This would not have been an acceptable name.
            // string n = "John"; This would not have been an acceptable name.
            // string car = "John"; This would not have been an acceptable name.
            // string optimusPrime = "John"; This would not have been an acceptable name.

            #endregion MeaningfulNames

            #region WorkingWithTheConsole

            // Until you learn about Unit Testing, the console is going to your best friend
            // when you are debugging your application.

            // To print to the console you'll use this Static Method on the Console class.

            // Console = static class
            // WriteLine = Method name 
            // using System = Namespace (This is at the top of the file.)
            // (Namespaces tell the compiler where to look to find method methods and classes.)

            // Don't worry about understanding this right now just understand this is a way we can use someone
            // else's code they have written and use it in our application. 

            Console.WriteLine();

            // This method prints a string if passed into the () with a new line character at the end of it.
            // You can think of a new line character as an equivalent of pressing enter.
            // So if you were in notepad or some other writing app and typed something out and pressed enter.
            // That is equivalent to what we are doing here.

            // To use this method we need to pass a value into the method, here are some examples of how you might do that.

            Console.WriteLine(32);
            Console.WriteLine("32");

            int johnAge = 32;
            Console.WriteLine(johnAge);

            // You can also concatenate strings together with the + operator. (Concatenate means join together.)

            string firstName = "John";
            string lastName = "Medlock";
            string fullName = firstName + " " + lastName;

            Console.WriteLine("John");
            Console.WriteLine(firstName);

            Console.WriteLine("Medlock");
            Console.WriteLine(lastName);

            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(fullName);

            // You can use what is referred to as string interpolation with the follow syntax.
            // Add the dollar sign to the front of the string literal. (String literal meaning the double quotes)
            // Then you can pass values into the {}. 
            fullName = $"{firstName} {lastName}";

            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine(fullName);

            // It's really just preference but I prefer the string interpolation method of formatting strings.

            #endregion WorkingWithTheConsole

            #region Debugging

            // Most of your debugging is going to come from breakpoints.
            // To set a break point click in the gutter and click start with debugging.
            // When the compiler hits the break point the compiler will pause execution of the application.
            // From this point you will have to step into or step over the evaluable lines of code to proceed execution.
            // You can hover the variables during execution to see how the value state changes.

            int debuggingInt;
            string debuggingString;

            debuggingInt = 10;
            debuggingString = "John";

            int debuggingIntTwo = 10;
            string debuggingStringTwo = "John";

            // Note that the compiler doesn't set the value until it has passed the line. 

            #endregion Debugging
        }
    }
}
