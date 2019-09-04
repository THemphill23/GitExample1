using System;

namespace GitExample1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Taylor";
            string lastName = "Hemphill";
            string sweetness = "Not Brett";

            int age = 28;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine("I am " + age +" years old");
        
            Console.WriteLine("I am glad i'm not " + oldAge + " year old");

            Console.WriteLine("Who is the Sweetness?" + sweetness);
        }
    }
}
