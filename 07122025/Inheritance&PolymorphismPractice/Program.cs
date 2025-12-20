namespace Inheritance_PolymorphismPractice
{
    public class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Vehicle are running");
        }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car are running");
        }
    }

    public class Bike : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bike are running");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bike bike = new Bike();
            bike.Move();
        }
    }
}
