using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_given_car_name_and_speed()
        {
            //given
            Car car = new Car("Cool Car", 60);
            //when
            string message = car.SpeedUp();
            //then
            Assert.Equal("Cool Car: speed up 60 km/h", message);
        }
    }
}
