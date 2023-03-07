namespace Inheritance.Model
{
    public class AutonomousCar : Car
    {
        public int SoftwareVersion { get; private set; }
        public int AutonomousLevel { get; private set; }
        public AutonomousCar(int softwareVersion = 1,
                             int autonomousLevel = 5,
                             int hp = 100,
                             double eng = 1.8,
                             int doors = 5,
                             bool manual = false,
                             Companies company = Companies.notSpecified,
                             int wheels = 4,
                             string msg = null,
                             int cap = 0,
                             double len = 0,
                             double weight = 0) : base(hp, eng, doors, manual, company, wheels, msg, cap, len, weight)
        {
            SoftwareVersion = softwareVersion;
            AutonomousLevel = autonomousLevel;
        }
    }
}
