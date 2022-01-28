using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStruct
{
    struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int a, int b, int c)
        {
            X = a;
            Y = b;
            Z = c;
        }
        public Point3D(int value)
        {
            X = Y = Z = value;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Point3D point1 = new Point3D(), point2 = new Point3D();

            Console.WriteLine($"Please Enter x for Point 1");
            point1.X = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter y for Point 1");
            point1.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter z for Point 1");
            point1.Z = int.Parse(Console.ReadLine());

            // Enter Value For Point 2
            Console.WriteLine($"Please Enter x for Point 2");
            point2.X = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter y for Point 2");
            point2.Y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Enter z for Point 2");
            point2.Z = int.Parse(Console.ReadLine());

            // Print Two Points 
            Console.WriteLine($"Point1 = {point1.ToString()} point2 = {point2}");

            Console.WriteLine("Please Enter Number of Points");
            int numberOfPoints = int.Parse(Console.ReadLine());
            Point3D[] points = new Point3D[numberOfPoints];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Please Enter x for Point {i + 1}");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please Enter y for Point {i + 1}");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Please Enter z for Point {i + 1}");
                int z = int.Parse(Console.ReadLine());
                points[i] = new Point3D(x, y, z);
            }

            // Print Points
            Console.WriteLine("All Points");
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Point Number {i + 1} is {points[i]}");
            }

        }
    }
}
