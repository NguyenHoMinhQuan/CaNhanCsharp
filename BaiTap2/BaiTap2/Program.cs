using System;
namespace BaiTap2
{
    public enum PointColor
    {
        LightBlue, BloodRed, Gold
    }
    public class Point     {
        public double X { get; set; }
        public double Y { get; set; }
        public PointColor Color { get; set; }
        //constructor
        public Point(double x, double y, PointColor color)
        {
            X = x;
            Y = y;
            Color = color;
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Point Position: ({X}, {Y}), Point Color: {Color}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}