namespace InterfaceClassSample
{
    interface IAnimal
    {
        void Speak();
        void Move();
    }

    class Bird : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Bird chirps: Tweet tweet");
        }
        public void Move()
        {
            Console.WriteLine("Bird flies");
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
