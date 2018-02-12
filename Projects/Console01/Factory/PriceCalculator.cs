using System;

namespace Console01.Factory
{
    public interface IPriceCalculator{
        float CalculatePainting(Order order);
    }


    public class PriceCalculator : IPriceCalculator
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