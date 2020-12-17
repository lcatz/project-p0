using Xunit;
using PizzaWorld.Domain.Models;

namespace PizzaWorld.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Testing_PizzaExists()
        {
            //arrange
            var sut = new Pizza(); //inference

            //act
            var actual = sut; 

            //assert
            Assert.IsType<Pizza>(actual);
            Assert.NotNull(actual);
        }
    }
}