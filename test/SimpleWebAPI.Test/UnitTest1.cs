using System;
using Xunit;
using SimpleWebAPI.Controllers;

namespace SimpleWebAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void CheckName()
        {
            Assert.Equal("Nutan1", controller.GetName());
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
