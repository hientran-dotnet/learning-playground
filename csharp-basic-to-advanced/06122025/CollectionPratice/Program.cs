namespace CollectionPratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customer = new Queue<string>();
            while (true)
            {
                Console.WriteLine("\n1. Add new customer");
                Console.WriteLine("2. Call the next customer");
                Console.WriteLine("3. Show list customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Please choose a function: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter customer name: ");
                        customer.Enqueue(Console.ReadLine());
                        break;
                    case 2:
                        if (customer.Count > 0)
                        {
                            Console.WriteLine($"Call customer: {customer.Dequeue()}");
                        }
                        else
                        {
                            Console.WriteLine("Customer queue is empty");
                        }
                        break;
                    case 3:
                        if(customer.Count > 0)
                        {
                            Console.WriteLine("List customer in the queue: ");
                            foreach (string item in customer)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Customer queue is empty!");
                        }
                            break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
