using System;
using System.Drawing;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> kindergarden = new List<Shape>();
        Circle child = new Circle(2);
        kindergarden.Add(child);
        child.SetColor("Twelvish navy");
        Square kiddo = new Square(2);
        kiddo.SetColor("Four stone-grey");
        Rectangle lilGuy = new Rectangle(2,3);
        lilGuy.SetColor("Six shining-pink");
        kindergarden.Add(lilGuy);
        kindergarden.Add(kiddo);

        foreach (Shape kid in kindergarden)
        {
            string cor = kid.GetColor();
            double size = kid.GetArea();
            Console.WriteLine($"{cor}, {size}");
        }
    }
}