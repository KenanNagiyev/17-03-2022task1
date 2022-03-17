using System;
using ClassLibrary1;
using ConsoleApp6.Models;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Teacher t = new Teacher();
            Student stud = new Student();
            Console.WriteLine(stud.Age);
            Console.ReadLine();
        }
    }
}
