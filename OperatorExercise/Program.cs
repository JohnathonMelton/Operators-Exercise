using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }
        public static double AreaOfCircle(double radius)
        { 
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
