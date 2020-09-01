using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this is a commentary
            //Console.WriteLine("Hello There, Harald");
            /* 1. The Program ask the user´s name
             * 2. The User enters their name
             * 3. The program greets the user by their name*/
            Console.WriteLine("What´ś your name");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " + Name);


        } 
    }
}

