using System;

namespace Factory
{
    public class Circle : IShape
    {
        public void draw()
        {
           Console.WriteLine("Draw circle");
        }
    }
}
