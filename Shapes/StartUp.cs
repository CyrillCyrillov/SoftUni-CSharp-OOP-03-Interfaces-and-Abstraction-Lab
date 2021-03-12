using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IDrawable figureOne = new Rectangle(6, 4);
            figureOne.Draw();

            IDrawable fugureTwo = new Circle(5);
            fugureTwo.Draw();

            //Console.WriteLine("Hello World!");
        }
    }
}
