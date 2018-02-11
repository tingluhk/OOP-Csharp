namespace Console01.Shapes
{
    public class Square : Shape
    {
        
        public string Colors { get; set; }

        public override void Draw(){
            System.Console.WriteLine("drawing a Square...");
        }

        public override void Math01()
        {
            System.Console.WriteLine("Square math01...");
        }
    }
}