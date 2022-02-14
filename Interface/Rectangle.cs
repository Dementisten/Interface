using System;

class Rectangle : IShape{
    public int Height{get; set;}
    public int Width{get; set;}
    public void Area(){
        Console.WriteLine("Area: " + Height * Width);
    }
    public void Circumference(){
        int omkrets = Height * 2 + Width * 2;
        Console.WriteLine("Omkrets: " + omkrets);
    }
}