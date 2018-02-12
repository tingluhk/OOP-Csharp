using System;

namespace Console01.Factory
{
    public class PaintShop
    {
        private readonly PriceCalculator _priceCalculator;
        public PaintShop(PriceCalculator priceCalculator){
            _priceCalculator = priceCalculator;
        }

        public void Painting(Order order){
            if(order.isPainted)
                throw new InvalidOperationException("it has been painted... exti");
           
                order.PaintJob = new PaintJob{
                    Cost = _priceCalculator.CalculatePainting(order),
                    PaintingDate = DateTime.Today.AddDays(1)
                };
           
        }
    }
}