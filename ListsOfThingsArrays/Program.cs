using System;

namespace ListsOfThingsArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // So in previous modules we talked about variables. We know we can initialize and instantiate values and store
            // them in a name like string name = "John";
            // Arrays allow you to do the same thing for but for multiple items of a similar type.
            // ie: a array of strings, a array of ints, and so on.
            // Array syntax:
            // datatype[] variableName;

            int[] intArray;
            string[] stringArray;
            char[] charArray;

            // There are several different ways to instantiate an array.

            intArray = new int[]
            {
                1,
                2,
                3,
                4
            };

            stringArray = new string[5];
            
            // both are valid. One is better if you know the values you want to add to an array
            // the other is good if you don't know the values but you do know how many values you will get.
            
            
            // the way you access the values contained in an array works like this:
            
            // if you wanted the first value of the intArray you would:
            int firstValueInIntArray = intArray[0];

            Console.WriteLine(firstValueInIntArray);
            
            // Arrays are what is referred to as zero indexed in C#. (meaning they start at 0, instead of 1. Some other languages are 1 indexed.)
            
            // so to access the second value in the array you would select intArray[1].
            
            
            // you can change and assign values in an array similar to how you access the value.
            // say we wanted to change the first value of the intArray to 7.
            intArray[0] = 7;

            Console.WriteLine(firstValueInIntArray);

            // You can also have arrays of arrays.
            // There are two types multidimensional arrays.

            int[,] multiDimensionalIntArray = new int[4, 2];
            
            // this array will have 4 rows and 2 columns. 
            
            // so to set the value of the first index in the first of these arrays you would:
            multiDimensionalIntArray[0,0] = 1;
            // so now the first row of the first column is 1.
            
            int[,] multiDimensionalIntArray2 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // once again you can do this all on one line if you know the values ahead of time.

            Console.WriteLine(multiDimensionalIntArray2[0,0]); // should print 1
            
            // The second type of array is called a Jagged array.
            // The difference between this and the multi dimensional array is the Jagged array can
            // contain arrays are various lengths.
            // The multi dimensional array assumes the arrays are all the same length.
            
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            
            Console.WriteLine(jaggedArray[0][0]); // should print 1
            
            // Try to select various values using array indexing to check your understanding of how arrays work and change
            // some values.

        }
    }
}
