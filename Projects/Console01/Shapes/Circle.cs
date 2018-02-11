/*
this class is just a wrapper to Run Static Methods for the Program
 */

namespace Console01.Shapes
{
    internal class Circle : Shape
    {
        public float Radius { get; set; }
        private readonly float Pi = 3.14f;

        public void Area(){
            System.Console.WriteLine($"Area of circle = {Pi * Radius}");
        }

        public override void Draw(){
            System.Console.WriteLine("drawing a circle");
        }

        public override void Math01()
        {
            System.Console.WriteLine("circle math01...");
        }
    }
}