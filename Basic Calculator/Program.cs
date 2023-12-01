using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Basic Calculator Project");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double addition = num1 + num2;
            double subtraction = num1 - num2;
            double multiplication = num2 * num1;
            double division = num1 / num2;
            Console.WriteLine("Waiting...");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.WriteLine("Addition: " + addition);
            Thread.Sleep(500);
            Console.WriteLine("Subtraction: " + subtraction);
            Thread.Sleep(500);
            Console.WriteLine("Multiplication: " + multiplication);
            Thread.Sleep(500);
            Console.WriteLine("Division: " + division);
            Console.ReadLine();
            
            Console.ReadLine();


        }
    }
}