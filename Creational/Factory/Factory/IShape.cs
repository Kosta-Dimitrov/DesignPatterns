using System;

namespace Factory
{
    public interface  IShape
    {
        void draw();
        static IShape of(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle : return new Circle();
                case ShapeType.Rectangle: return new Rectangle();
                case ShapeType.Square: return new Square();
                default: throw new ArgumentException();
            }

        }
    }
}
