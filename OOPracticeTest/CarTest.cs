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
        public void Should_return_message_when_speed_given_car_name_and_speed_electric_engine()
        {
            //given
            ElectricEngine engine = new ElectricEngine();
            Car car = new Car("Cool Car", engine);
            Driver driver = new Driver(car);
            //when
            string message = driver.Drive();
            //then
            Assert.Equal("Cool Car: speed up 25 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_speed_given_Truck_car_name_and_speed()
        {
            //given
            Truck truck = new Truck("Big Truck", 60);
            //when
            string message = truck.SpeedUp();
            //then
            Assert.Equal("Big Truck: speed up 60 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_driver_drive_cool_car_use_gasoline_engine()
        {
            //given
            GasolineEngine engine = new GasolineEngine();
            VechileBase car = new Car("Cool car", engine);
            Driver driver = new Driver(car);
            //when
            string message = driver.Drive();
            //then
            Assert.Equal("Cool car: speed up 30 km/h", message);
        }
    }
}
