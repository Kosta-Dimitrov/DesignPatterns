using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = IShape.of(ShapeType.Rectangle);
            //creates object of type rectangle

            shape1.draw();
            //invokes rectangle draw method

            IShape shape2 = IShape.of(ShapeType.Circle);

            shape2.draw();

            IShape shape3 = IShape.of(ShapeType.Square);

            shape3.draw();
        }
    }
}
