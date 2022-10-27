namespace OOPractice
{
    public class VechileBase
    {
        protected string name;
        protected int speed;
        public VechileBase(string name, int speed)
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