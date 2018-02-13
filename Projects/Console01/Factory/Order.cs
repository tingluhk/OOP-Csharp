using System;

namespace Console01.Factory
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrdered { get; set; }
        public PaintJob PaintJob { get; set; }
        public float TotalPrice { get; set; }

        public bool isPainted 
        { 
            get{return PaintJob != null;} 
        }

    }
}