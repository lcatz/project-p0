using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            //arrange
            var sut = new Order(); //inference

            //act
            var actual = sut; 

            //assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
        }
    }
}