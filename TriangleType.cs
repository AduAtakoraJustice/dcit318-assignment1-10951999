
using System;

namespace TriangleType{

    public class TriangleType{

        static string computeResult(double x, double y, double z){

            if(x == y && y == z){
                return "The triangle is Equilateral";
            }


            //finding for the isoceless triangle
            bool flag1 = x == y;
            bool flag2 = y == z;
            bool flag3 = x == z;

            if(flag1 || flag2 || flag3){
                return "The triangle is Isoceless" 
            }

            return "The triangle is Scalene";
        }

        public static void Main(string[] args){

            Console.WriteLine("Triangle Type Finder\n\n");

            Console.WriteLine("Enter the length of the triangle sides.");

            Console.Write("Side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSide B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nSide C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            string triangleType = computeResult(sideA, sideB, sideC);


            Console.WriteLine("The type of triangle is " + triangleType);

        }
    }
}