using System;
using System.Threading;
using System.Collections.Generic;

// public class Triangle
//     {
//         public int Side1;
//         public int Side2;
//         public int Side3;


//         public Triangle(int side1, int side2, int side3)
//         {
//             Side1 = side1;
//             Side2 = side2;
//             Side3 = side3;
//         }

//         // public int calc()
//         // {
//         //     if (Side1 == Side3 && Side3 == Side2)
//         //     {
//         //         Console.WriteLine("This is an Isoceles Triangle");
//         //     }
//         //     // else if ()
//         //     // {

//         //     // }
//         //     else if (Side1 != Side3 && Side1 != Side2 && Side2 != Side3)
//         //     {
//         //         Console.WriteLine("This is an Isoceles Triangle");
//         //     }
            
//         // }
//     }
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

        // Triangle newTriangle = new Triangle(side1Length, side2Length, side3Length);
        // int answer = newTriangle.calc();
        // Console.WriteLine("Its is a " + answer + " triangle.");

        int [] userSide = {side1Length, side2Length, side3Length};
    

        if (userSide[0] != userSide[1] && userSide[0] != userSide[2] && userSide[1] != userSide[2])
            {
                Console.WriteLine("This is an Scalene Triangle");
            }

         else if (userSide[0] == userSide[1] && userSide[0] == userSide[2] && userSide[1] == userSide[2])
            {
                Console.WriteLine("This is an Equilateral Triangle");
            }

         else if (userSide[0] + userSide[1] <= userSide[2] || userSide[1] + userSide[2] <= userSide[0] || userSide[2] + userSide[0] <= userSide[1])
            {
                Console.WriteLine("This is not a Triangle");
            }
         else if (userSide[0] == userSide[1] && userSide[0] != userSide[2])
            {
                Console.WriteLine("This is an Isoceles Triangle");
            }

            
    }
}