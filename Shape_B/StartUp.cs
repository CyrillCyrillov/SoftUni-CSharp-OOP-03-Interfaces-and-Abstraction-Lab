using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int radiusInput = int.Parse(Console.ReadLine());

            IDrawable custumCircle = new Circle(radiusInput);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            IDrawable custumRectangle = new Rectangle(width, height);

            custumCircle.Drow();

            custumRectangle.Drow();


            //Console.WriteLine("Hello World!");
        }
    }
}
