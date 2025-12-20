namespace AbstractionOopPractice
{
    public abstract class Animal
    {
        public abstract void Speak();
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"Dog barks: Woof woof");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
