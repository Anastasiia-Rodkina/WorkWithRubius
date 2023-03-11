using System;

namespace ConsoleLesson1
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
           Console.WriteLine ("Как тебя зовут? ");
           String name = Console.ReadLine();
           Console.WriteLine($"{name}, привет!");
        }
    }
}