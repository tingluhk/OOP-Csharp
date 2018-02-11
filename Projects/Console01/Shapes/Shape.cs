namespace Console01.Shapes
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Edges { get; set; }
        public virtual void Draw(){
            System.Console.WriteLine("drawing a shape");
        }

        public abstract void Math01();
    }
}