using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square sqr = new Square("black",2);
        //Console.WriteLine(sqr.GetColor());
        //Console.WriteLine(sqr.GetArea());
        shapes.Add(sqr);

        Rectangle rec = new Rectangle("brown", 2, 4);
        //Console.WriteLine(rec.GetColor());
        //Console.WriteLine(rec.GetArea());
        shapes.Add(rec);

        Circle cir = new Circle("yellow", 6);
        //Console.WriteLine(cir.GetColor());
        //Console.WriteLine(cir.GetArea());
        shapes.Add(cir);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"A {color} shape has area {area}");
        }

    }
}