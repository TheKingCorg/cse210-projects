using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Shape> myShapes = new List<Shape>();
        Square mySquare = new Square("Red", 4);
        myShapes.Add(mySquare);
        Rectangle myRectangle = new Rectangle("Blue", 4, 5);
        myShapes.Add(mySquare);
        Circle myCircle = new Circle("Purple", 8);
        myShapes.Add(mySquare);

        foreach (Shape shape in myShapes){
            Console.WriteLine($"\nColor: {shape.GetColor()}\nArea: {shape.GetArea()}");
        }
    }
}