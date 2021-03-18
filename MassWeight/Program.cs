using System;

namespace MassWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a mass");

            double mass = Convert.ToDouble(Console.ReadLine());
            double wheight = mass * 9.8;
            if (wheight > 1000)
            {
                Console.Write("To heavy");
            }
            else if(wheight < 10)
            {
                Console.Write("To light");
            }
        }
    }
}
