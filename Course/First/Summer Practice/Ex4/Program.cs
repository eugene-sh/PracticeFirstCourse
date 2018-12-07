using System;
using System.Collections.Generic;

namespace Ex4
{
    class Program
    {
        private const int LineCount = 10;
        
        static void Main(string[] args)
        {
            var listOfLines = new List<Line>();
            var crossCount = 0;
            var maxCrossCount = 0;
            var lineWithMaxCrossCount = new Line(); 

            foreach(var line in listOfLines)
            {
                foreach(var line1 in listOfLines)
                {
                    if (IsLinesCross(line.X11 , line.Y12, line.X21, line.Y22, line.X11, line.Y12, line.X21, line.Y22))
                        crossCount++;
                }

                if(crossCount > maxCrossCount)
                {
                    maxCrossCount = crossCount;
                    lineWithMaxCrossCount = line;
                }
            }

            Console.WriteLine($"Line with max cross count: {lineWithMaxCrossCount}");
        }
        
        private static void GenerateRandomLines(List<Line> listOfLines)
        {
            var random = new Random();

            for(var i = 0; i < LineCount; i++)
            {
                listOfLines.Add(new Line
                {
                    X11 = new Point(random.Next(0, 10), random.Next(0, 10)),
                    Y12 = new Point(random.Next(0, 10), random.Next(0, 10)),
                    X21 = new Point(random.Next(0, 10), random.Next(0, 10)),
                    Y22 = new Point(random.Next(0, 10), random.Next(0, 10))
                });
            }
        }

        private static bool IsLinesCross(
            double x11, double y11, double x12, double y12, double x21, double y21, double x22, double y22) {
            double maxx1 = Math.Max(x11, x12), maxy1 = Math.Max(y11, y12);
            double minx1 = Math.Min(x11, x12), miny1 = Math.Min(y11, y12);
            double maxx2 = Math.Max(x21, x22), maxy2 = Math.Max(y21, y22);
            double minx2 = Math.Min(x21, x22), miny2 = Math.Min(y21, y22);
 
            if (minx1 > maxx2 || maxx1 < minx2 || miny1 > maxy2 || maxy1 < miny2) {
                return false;
            }
 
            double dx1 = x12 - x11, dy1 = y12 - y11;
            double dx2 = x22 - x21, dy2 = y22 - y21;
            double dxx = x11 - x21, dyy = y11 - y21;
            double div, mul;
 
            if (Math.Abs((div = (dy2*dx1 - dx2*dy1)) - 0) < double.Epsilon) {
                return false; 
            }
            if (div > 0) {
                if ((mul = (dx1*dyy - dy1*dxx)) < 0 || mul > div) {
                    return false;
                }
                if ((mul = (dx2*dyy - dy2*dxx)) < 0 || mul > div) {
                    return false;
                }
            }
 
            if ((mul = -(dx1*dyy - dy1*dxx)) < 0 || mul > -div) {
                return false;
            }
            if ((mul = -(dx2*dyy - dy2*dxx)) < 0 || mul > -div) {
                return false;
            }
 
            return true;
        }

        private struct Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X;
            public double Y;
        }

        private class Line 
        {
            public Point X11 {get; set;}
            public Point Y12 {get; set;}
            public Point X21 {get; set;}
            public Point Y22 {get; set;}

            public override string ToString(){
                return $"X11{X11}, Y12{Y12}, X21{X21}, Y22{Y22}";
            }
        }
    }
}
