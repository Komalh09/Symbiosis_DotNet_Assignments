using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3
{
    internal class Point3D : IFormattable
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"\n X: {X} " + $" Y: {Y} " + $" Z: {Z} ";
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format)) format = "G";
            switch (format)
            {
                case "G":
                case "C":
                    return $"({X}, {Y}, {Z})";
                case "X":
                    return X.ToString();
                case "Y":
                    return Y.ToString();
                case "Z":
                    return Z.ToString();
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        // Implement the IFormattable.ToString with default format provider
        public string ToString(string format)
        {
            return ToString(format, null);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Point3D
            Point3D point = new Point3D(3.5f, 7.2f, 1.4f);

            // Print x, y, and z individually and combined using various formats
            Console.WriteLine(point.ToString("X")); // Print x
            Console.WriteLine(point.ToString("Y")); // Print y
            Console.WriteLine(point.ToString("Z")); // Print z
            Console.WriteLine(point.ToString("C")); // Print combined (x, y, z)
            Console.WriteLine(point.ToString("G")); // Print combined (x, y, z)

            // Using Console.Write directly with formatting
            Console.WriteLine($"X: {point.ToString("X")}");
            Console.WriteLine($"Y: {point.ToString("Y")}");
            Console.WriteLine($"Z: {point.ToString("Z")}");
            Console.WriteLine($"Combined (C): {point.ToString("C")}");
            Console.WriteLine($"General (G): {point.ToString("G")}");

            Console.ReadKey();
        }
    }

}
    
  

