namespace OOPractice
{
    using System;
    public class Car : VechileBase
    {
        public Car(string name, IEngine engine)
        {
            this.Name = name;
            this.Speed = engine.Speed;
        }
    }
}
