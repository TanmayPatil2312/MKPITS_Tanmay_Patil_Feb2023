using System;

namespace Inheritance
{

    // base class
    class Animal
    {

        public string name;

        public void display()
        {
            Console.WriteLine("I am a bird");
        }

    }

    // derived class of Animal 
    class bird : Animal
    {

        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // object of derived class
            bird parrot = new bird();

            // access field and method of base class
            parrot.name = "popu";
            parrot.display();

            // access method from own class
            parrot.getName();

            Console.ReadLine();
        }

    }
}