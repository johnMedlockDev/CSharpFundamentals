using System;

namespace LoopsAdditionalLoopingStatements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          // So in the last module we learned about about the foreach loop and this is really our first introduction to
          // an abstraction interface.
          
          // That is just a fancy way of saying the Microsoft or what ever developer made something easier or added a layer
          // to complexity to hide it from the user. 
          // They do this to make development easier and maybe more readable. 

          
          // if you recall in the foreach loop I said that the foreach statement cycles through all the indexes in
          // a collection and gives you access to the data in a temporary variable.
          
          #region ForLoops

          // for loops can allow you do basically the same thing as a foreach loop but it assumes you want access to the index
          // either through out the lifecycle of the loop or at least in parts.

          int[] intArray =
          {
              1,
              2,
              3,
              4,
              5
          };
          
          for (int i = 0; i < intArray.Length; i++)
          {
              // selected index 
              int selectedIndex = intArray[i];
              
              Console.WriteLine(selectedIndex);
          }
          
          // forKeyword ( dataType variableNameToRepresentAIndex = Value; variableNameToRepresentAIndex  < collection.Length; variableNameToRepresentAIndex += 1 )
          // if you step through the loop you'll see that it's doing this basically:
          
          /*
           * int selectedIndex = intArray[0];
           * int selectedIndex = intArray[1];
           * int selectedIndex = intArray[2];
           * etc.
           */
          
          // the foreach loop just did this without all the c++ style syntax.
          
          // for loops are flexible in the fact that you can go forward and backwards:
          // the <  intArray.Length thing gets the number of values in the array. 
          
          for (int i = intArray.Length - 1; i >= 0; i--)
          {
              // selected index 
              int selectedIndex = intArray[i];
              
              Console.WriteLine(selectedIndex);
          }
          
          // In this instance it starts at the end of the array and goes to the first value.
          
          // Just to kind of way break it done a little more this is kinda how it works:
          // for (
          //
          //   int i = 0;
          //   if(i < intArray.Length)
          //   {
          //     // selected index 
          //     int selectedIndex = intArray[i];
          //     
          //     Console.WriteLine(selectedIndex);
          //   }
          //     i++;
          // )

          #endregion ForLoops

          #region WhileLoops
          
          // while loops can do the same thing as a for loop or foreach loop but it's really best to use when you don't
          // know when the loop will stop or maybe if the loop will never stop.

          // this is how you would write a loop that would never end.
          // it will continue to run until the value in the () turns false. 
          // because nothing effects it to change the state if ran it will run for ever.
          // while (true)
          // {
          //     
          // }

          int value = 0;

          while (value != 4)
          {
              // a way to generate sudo random values 
              Random random = new();

              value = random.Next(0, intArray.Length);

              Console.WriteLine(value);
          }
          
          // in this instance the value is selected sudo randomly until the value == 4.
          // this would be a good instance for a while loop. 
          // a for loop couldn't be used because the value may never == 4.
          
          while (false)
          {
              
          }
          
          // on the contrary to the first while example this while loop will never run because it never evaluates () to true.
          
          #endregion WhileLoops
          
          #region DoWhileLoops
          
          // I'm just going to briefly go over Do While loops. They work the same way as while loops but the code in the
          // loop always runs once regardless of the condition of the while loop (). But after it runs once it takes into account
          // the loop condition.

          do
          {
              Console.WriteLine("Do While Ran.");
          }
          while (false);
          
          // So you use a do while if you want to write a loop that always executes at least once.

          #endregion DoWhileLoops

          
          // So to recap:
          // foreach loops are better if you don't need access to several specific indexes.
          // for loops are better if you need access to several specific indexes.
          // while loops are better if you don't know how long you want something to run.
          // do while loop are better if you don't know how long you want something to run and you want it to run at least once.
          
        }
    }
}
