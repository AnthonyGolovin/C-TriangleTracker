using System;
using System.Threading;
using System.Collections.Generic;

public class Triangle
    {
        public int Side1Length;
        public int Side2Length;
        public int Side3Length;


        public Triangle(int side1Length, int side2Length, int side3Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
            
        }

        public static string calc(int Side1Length, int Side2Length, int Side3Length)
        {
            int [] userSide = {Side1Length, Side2Length, Side3Length};
            string Equilateral = "This is an Equilateral Triangle";
            string Isosceles = "This is an Isosceles Triangle";
            string Scalene = "This is a Scalene Triangle";
            string NAT = "This is not a triangle";
            string Invalid = "Please enter valid integers";

        if (userSide[0] != userSide[1] && userSide[0] != userSide[2] && userSide[1] != userSide[2])
            {
                return Scalene;
            }

         else if (userSide[0] == userSide[1] && userSide[0] == userSide[2] && userSide[1] == userSide[2])
            {
                return Equilateral;
            }

         else if (userSide[0] + userSide[1] <= userSide[2] || userSide[1] + userSide[2] <= userSide[0] || userSide[2] + userSide[0] <= userSide[1])
            {
                return NAT;
            }
         else if (userSide[0] == userSide[1] && userSide[0] != userSide[2])
            { 
                return Isosceles;
            }
            else
            {
                return Invalid;
            }
            
        }
    }
class Program 
{
 static void Main()
    {
       
        Console.WriteLine("Enter a side length for a Triangle.");
        int side1Length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second side length for a Triangle.");
        int side2Length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the last side length for a Triangle.");
        int side3Length = int.Parse(Console.ReadLine());

        string answer = Triangle.calc(side1Length, side2Length, side3Length);
        Console.WriteLine(answer);

            
    }
}