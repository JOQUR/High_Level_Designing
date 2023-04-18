using System.Security.Cryptography;

namespace Stan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var droplet = new DropOfWater();
            droplet.TransitionTo(new Cloud());
            droplet.Raining(70);
            droplet.Drinking(2.0);
            droplet.Excretion();
            droplet.Clearance();
            droplet.Flowing();
            droplet.Evaporation(2.0);
        }
    }
}