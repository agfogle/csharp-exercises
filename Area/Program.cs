using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            Console.WriteLine("Enter a radius");
            radius = double.Parse(Console.ReadLine());
            double pi = 3.14;
            

            while (radius<0)
                    {
                Console.WriteLine("Input is invalid");
                Console.WriteLine("Enter a radius");
                radius = double.Parse(Console.ReadLine());
            }

            double Area = pi * radius * radius;
            Console.WriteLine($"The area of a circle with {radius} is: {Area}");
            
            
        }
    }
}
