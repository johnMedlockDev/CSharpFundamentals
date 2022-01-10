using System;

namespace LoopsTheForEachStatement
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Ok so up until this point we've gone over variables, data types, and conditional statements.
            // And we can do a lot of powerful stuff compared to where we first started.
            // But really our operations are really still manual.
            // By that I mean we're still putting in a action or series of actions to get the the same number of results.
            // With loops you can program a single operation and then just "Loop" or cycle through the rest of the actions.
            // Like lets say we have an array of ints and we want to add the numbers 1 - 10 to the array.
            
            // We would have to do it something like this:

            int[] intArray = new[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };
            
            // or this:

            int[] intArray2 = new int[10];

            intArray2[0] = 1;
            intArray2[1] = 2;
            intArray2[2] = 3;
            intArray2[3] = 4;
            intArray2[4] = 5;
            intArray2[5] = 6;
            intArray2[6] = 7;
            intArray2[7] = 8;
            intArray2[8] = 9;
            intArray2[9] = 10;
            
            // Now imagine if we had to do this 100,000 times. 
            // That would be a lot of typing for one two quite error prone.

            // With loops we can do something like this with just a few lines of code.

            int[] intArray3 = new int[10];
            
            int counter = 0;
            
            foreach (int space in intArray3)
            {
                int valueForSpace = counter + 1;
                intArray3[counter] = valueForSpace;
                counter++;
            }
            
            // maybe for ten values you can't appreciate the difference but for 100,000 you could
            int[] intArray4 = new int[100000];
            counter = 0;
            
            foreach (int space in intArray4)
            {
                int valueForSpace = counter + 1;
                intArray3[counter] = valueForSpace;
                counter++;
            }
            
            /*
             *  foreach ( datatype variableName inKeyword collection )  
             *  {
             *      * Code *
             *  }
             */
            
            // What the foreach statement does is cycle through all of the indexes in a collection until
            // it reaches the end.
            // This is useful when you have to do a similar operation for a series.
            // This is one of the more common loops you'll use because most of the time you don't actually need the index.
            // You just need to modify the state of what is contained in the collection.
            // You can use the foreach look any more than just ints but this was just an example.
            
            // Indexes are the marker for a specific place in an array. 
            // the variableName can be called whatever you want but just like with normal variables it is a good idea to 
            // make the value you place there make since in the context of the collection.
            // Say you had a array of names a foreach statement like this might make sense.
            // foreach(string name in names)
            // {
            //    * Code * 
            // }
            
            // for the code above you would have made argument for using what is referred to as a discard variable
            // because we didn't actually end up using the variable itself. _ <= that is regarded as a discard variable. 
            // foreach(int _ in intArray4)

            string[] names = {"John", "Justin", "Anne"};

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            
            // Set some break points and step through the loops to check your understanding.



        }
    }
}
