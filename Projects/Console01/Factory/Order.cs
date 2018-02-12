namespace Console01.Factory
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public bool isPainted { get; set; }
        public PaintJob PaintJob { get; set; }
    }
}