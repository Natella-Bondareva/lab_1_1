using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1
{
    internal class Polygon
    {
        public Point[] vertices;
        public double[] sides;

        public Polygon(Point[] vertices)
        {
            this.vertices = vertices;
            sides = new double[vertices.Length];
            for (int i = 0; i < vertices.Length - 1; i++)
            {
                sides[i] = vertices[i].DistanceTo(vertices[i + 1]);
            }
            sides[vertices.Length - 1] = vertices[vertices.Length - 1].DistanceTo(vertices[0]);
        }

        public double this[int index]
        {
            get 
            {
                if (index >= 0 || index < sides.Length)
                {
                   return sides[index];
                }
                else
                {
                    return 0;
                }
            }
        }

        public double CalculatePerimeter()
        {
            //double perimeter = 0;
            //for (int i = 0; i < vertices.Length; i++)
            //{
            //    perimeter += sides[i];
            //}
            //return perimeter;
            return sides.Sum();
        }

        public double CalculateArea()
        {
            double area = 0;
            for (int i = 0; i < vertices.Length - 1; i++)
            {
                area += (vertices[i].x * vertices[i + 1].y - vertices[i + 1].x * vertices[i].y);
            }
            area += (vertices[vertices.Length - 1].x * vertices[0].y - vertices[0].x * vertices[vertices.Length - 1].y);
            area = Math.Abs(area) / 2.0;
            return area;
        }
    }
}
