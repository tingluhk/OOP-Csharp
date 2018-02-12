using System;

namespace Console01.Factory
{
    public class PriceCalculator
    {
        public float CalculatePainting(Order order)
        {
            if(order.TotalPrice < 100.00f)
                return order.TotalPrice * 0.15f;

            // if cost more than 100 then its free;
            return 0;
        }
    }
}