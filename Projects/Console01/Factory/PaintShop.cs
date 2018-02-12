using System;

namespace Console01.Factory
{
    public class PaintShop
    {
        private readonly IPriceCalculator _priceCalculator;
        public PaintShop(IPriceCalculator PriceCalculator){
            _priceCalculator = PriceCalculator;
        }

        public void Painting(Order order){
            if(order.isPainted)
                throw new InvalidOperationException("it has been painted... exti");
           
                order.PaintJob = new PaintJob{
                    Cost = _priceCalculator.CalculatePainting(order),
                    PaintingDate = DateTime.Today.AddDays(1)
                };
                
                System.Console.WriteLine($"order placed paintJob Cost =  {order.PaintJob.Cost}");
           
        }
    }
}