namespace OOPractice
{
    public class VechileBase
    {
        private string name;
        private int speed;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string SpeedUp()
        {
            // return name + ": speed up " + speed.ToString() + " " + "km/h";
            return $"{name}: speed up {speed} km/h";
        }
    }
}