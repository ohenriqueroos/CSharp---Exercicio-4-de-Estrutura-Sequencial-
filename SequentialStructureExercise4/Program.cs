using System;
using System.Globalization;

namespace SequentialStructureExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeNumber = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double hourPayment = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = hourPayment * hours;

            Console.WriteLine("NUMBER = " + employeeNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}