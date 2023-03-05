namespace Inheritance
{
    class Vehicle 
    {
        private int _capacity;
        private float _length;
        private float _weight;


        public int Capacity { get => _capacity; set => _capacity = value; }
        public float Length { get => _length; set => _length = value; }
        public float Weight { get => _weight; set => _weight = value; }


        Vehicle()
        {

        }
    }

}
