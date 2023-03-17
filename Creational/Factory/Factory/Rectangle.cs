using System;

namespace Factory
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
}
