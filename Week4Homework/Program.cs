using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide the length of the room in meters: ");
            double length = Convert.ToInt16(Console.ReadLine());
            Console.Write("Please provide the width of the room in meters: ");
            double width = Convert.ToInt16(Console.ReadLine());


            
            double result1 = Area(length, width);
            double result2 = Perimeter(length, width);
            Console.WriteLine($"The area of the room is {result1} square meters and the perimeter of the room is {result2} meters.");





            Console.ReadLine();


        }



        public static double Area(double length, double width)
        {
            double result = length * width;
            return result;
        }

        public static double Perimeter(double length, double width)
        {
            double result = length * 2 + width * 2;
            return result;
        }






    }
}

