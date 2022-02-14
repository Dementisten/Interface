using System;

class Triangle : IShape{
    public int Height{get; set;}
    public int Width{get; set;}
    public void Area(){
        Console.WriteLine("Area: " + Height * Width / 2);
    }
    public void Circumference(){
        double hypo = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));
        double omkrets = hypo + Height + Width;
        Console.WriteLine("Omkrets: " + omkrets);
    }
}