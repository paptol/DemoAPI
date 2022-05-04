using System;
using Xunit;
using DemoAPI.Controllers;

namespace DemoAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController _controller = new WeatherForecastController();

        [Fact]
        public void GetRetrunValues()
        {
            var returnValue = _controller.Get(1);
            Assert.Equal("Patyk Demo Deploy", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {
       
        }
    }
}
