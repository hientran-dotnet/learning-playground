namespace Inheritance_Polymorphism
{
    class Parent
    {
        public string Name { set; get; }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    class Child : Parent
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is a child class");
        }
    }

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal make sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barking");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance
            Child child = new Child();
            child.Name = "HienTran";
            child.Display();
            child.ShowMessage();

            // Polymorphism
            // Overloading method
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(3, 6));
            Console.WriteLine(calculator.Add(3.6, 2.5));

            // Overriding method
            Animal BullDog = new Dog();
            BullDog.MakeSound();
        }
    }

}
