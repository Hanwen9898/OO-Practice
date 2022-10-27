namespace OOPractice
{
    using System;
    public class Car
    {
        private readonly string name;
        private readonly int speed;
        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string SpeedUp()
        {
           // return name + ": speed up " + speed.ToString() + " " + "km/h";
            return $"{name}: speed up {speed} km/h";
        }
    }
}
