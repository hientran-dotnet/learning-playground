namespace CompareAbstractVsInterfaceClass
{
    public abstract class Animal
    {
        public abstract void Speak();
        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Dolphin : Animal, ISwimmable
    {
        public override void Speak()
        {
            Console.WriteLine("Dolphin clicks: Click Click");
        }

        public void Swim()
        {
            Console.WriteLine("Dolphin swims in the ocean");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dolphin dolphin = new Dolphin();
            dolphin.Speak();
            dolphin.Eat();
            dolphin.Swim();
        }
    }
}
