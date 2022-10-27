namespace OOPractice
{
    using System;
    public class Car : VechileBase
    {
        public Car(string name, int speed) : base(name, speed)
        {
        }
    }

    public class Truck : VechileBase
    {
        public Truck(string name, int speed) : base(name, speed)
        {
        }
    }
}
