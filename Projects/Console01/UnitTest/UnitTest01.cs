using Xunit;


namespace Console01.UnitTest
{
    public class UnitTest01
    {
        // Method / Condition / Expectattion
        [Fact]
        public void PainJob_OrderIsAlareadyPainted_ThrowsAnException()
        {
            var orderPainted = new orderPainted();

        }

        public class FakePriceCalculator : IPriceCalculator{
            public float CalculateShipping(Order order){
                 return 1;
            }
        }
    }
}