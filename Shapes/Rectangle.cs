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
            get { return width; }
            set { width = value; }
        
        }
        public int Height
        {
            get { return height; }
            set { height = value; }

        }
        
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
