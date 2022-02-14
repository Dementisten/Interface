using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rektangel = new Rectangle();
            Circle cirkel = new Circle();
            Triangle triangel = new Triangle();

            rektangel.Width = 10;
            rektangel.Height = 10;
            rektangel.Area();
            rektangel.Circumference();

            cirkel.Radie = 10;
            cirkel.Area();
            cirkel.Circumference();

            triangel.Width = 10;
            triangel.Height = 10;
            triangel.Area();
            triangel.Circumference();
        }
    }
}
