﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} equals {sum} and {a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine("Give number for chosen Radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;

        }
    }
}
