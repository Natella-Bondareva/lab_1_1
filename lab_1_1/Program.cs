using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1
{
    internal class Program
    {
        public static void PrintVertices(Point[] vertices)
        {
            Console.WriteLine("Вершини многокутника:");
            foreach (Point vertex in vertices)
            {
                Console.WriteLine($"({vertex.x}; {vertex.y})");
            }
        }
        public static void ReadVertices(out Point[] vertices) 
        {
            Console.WriteLine("Введіть кількість вершин многокутника:");
            int n = int.Parse(Console.ReadLine());
            vertices = new Point[n];
            if ( n < 3 )
            {
                Console.WriteLine("Многокутник має містити більше ніж 3 вершини.");
            }
            else
            {
                Console.WriteLine("Вводьте по черзі (не в різнобій) координати вершин через Enter (x y)");
                for (int i = 0; i < n; i++)
                {
                    string[] str = Console.ReadLine().Trim().Split();
                    vertices[i] = new Point( Convert.ToDouble(str[0]), Convert.ToDouble(str[1]));
                }
            }

        }

        static void Main(string[] args)
        {

            Point[] vertices ;
            ReadVertices(out vertices);

            Polygon polygon = new Polygon(vertices);

            PrintVertices(vertices);

            double perimeter = polygon.CalculatePerimeter();
            double area = polygon.CalculateArea();
            Console.WriteLine($"Периметр: {perimeter}");
            Console.WriteLine($"Площа: {area}");
        }
    }
}