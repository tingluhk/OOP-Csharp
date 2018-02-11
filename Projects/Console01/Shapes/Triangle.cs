/*
this class is just a wrapper to Run Static Methods for the Program
 */

namespace Console01.Shapes
{
    internal class Triangle : Shape
    {
        public override void Draw(){
            System.Console.WriteLine("drawing a triangle");
        }

        public override void Math01()
        {
            System.Console.WriteLine("circle math01...");
        }
    }
}