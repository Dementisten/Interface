using System;

class Circle : IShape{
    public int Radie{get; set;}

    public void Area(){
        Console.WriteLine("Area: " + Radie * Radie * 3.14);
    }
    public void Circumference(){
        Console.WriteLine("Omkrets: " + Radie * 2 * 3.14);
    }
}