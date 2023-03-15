namespace Polymorphism
{
    public abstract class Human
    {
        public string? Name { get; protected set; }
        public int Salary { get; set; }
        public abstract int Cost(int months);
    }
}