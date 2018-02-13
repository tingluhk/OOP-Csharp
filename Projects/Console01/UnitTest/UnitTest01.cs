using System;
using Xunit;
using Fac = Console01.Factory;

namespace Console01.UnitTest
{
    public class UnitTest01
    {
        // Method / Condition / Expectattion
        [Fact]
        public void PainJob_OrderIsAlareadyPainted_ThrowsAnException()
        {
            var paintShop = new Fac.PaintShop(new FakePriceCalculator());
            var order = new Fac.Order{
                PaintJob = new Fac.PaintJob()
            };

            // check if throws an exception
            Assert.Throws<InvalidOperationException>(() => paintShop.Painting(order));
        }

        [Fact]
        public void PaintJob_OrderIsNotPainted_ShouldSetThePaintProperty(){
            var paintShop = new Fac.PaintShop(new FakePriceCalculator());
            var order = new Fac.Order();

            paintShop.Painting(order);
            Assert.True(order.isPainted);
            Assert.Equal(1, order.PaintJob.Cost);
            Assert.Equal(DateTime.Today.AddDays(1), order.PaintJob.PaintingDate);

        }

        public class FakePriceCalculator : Fac.IPriceCalculator{
            public float CalculatePainting(Fac.Order order)
            {
                return 1;
            }
        }
    }
}