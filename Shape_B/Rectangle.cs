using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        public int Width
        {
            get { return Width; }
            set { width = value; }
        }

        public int Height
        {
            get { return Height; }
            set { height = value; }
        }

        public void Drow()  //width -> 4 height -> 5

        {
            for (int i = 1; i <= width; i++)
            {
                Console.Write('*');
            }

            Console.WriteLine();

            for (int j = 2; j <= height - 1; j++)
            {
                for (int x = 1; x <= height; x++)
                {
                    if (x == 1 || x == width)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= width; i++)
            {
                Console.Write('*');
            }


        }
    }
}
