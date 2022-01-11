using System;

namespace ObjectsAndClasses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // objects are memory references contained on the heap.
            // A class or struct definition is like a blueprint that specifies what the type can do.
            // An object is basically a block of memory that has been allocated and configured according to the blueprint. 
            
            // Classes are a way to create groups of data and contain them in a normalized object.
            // It's useful to cluster objects in classes as oppose to other dataTypes because they keep track of state
            // and can contain methods.

            object strObject = "";
            object intObject = 23;
            object doubleObject = 23.45;
            object personObject = new Person("John");

            Person person = new("Jim");
            person.Run();
            
            // the reason you can create a instance of the Person class with the object type is because all classes are objects.
            // Everything is actually a object at the root.
        }
        
        
    }

    class Person
    {
        public string ColorHair { get; set; }
        public double Height { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is Running.");
        }
    }
}
