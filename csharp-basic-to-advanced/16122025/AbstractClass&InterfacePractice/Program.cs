namespace AbstractClass_InterfacePractice
{
    public abstract class Device
    {
        public string Name {  get; set; }
        public string Model { get; set; }

        public Device(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void GetDeviceInfo()
        {
            Console.WriteLine($"Device Name: {Name}, Model: {Model}");
        }
    }

    interface INetworkConnectable
    {
        void ConnectToNetWork();
    }

    class SmartPhone : Device, INetworkConnectable
    {
        public SmartPhone(string name, string model) : base(name, model) 
        {
            
        }

        public void ConnectToNetWork()
        {
            Console.WriteLine($"{Name} (SmartPhone) is connected to the network");
        }

    }

    class Laptop : Device, INetworkConnectable
    {
        public Laptop(string name, string model) : base(name, model) 
        {
            
        }

        public void ConnectToNetWork()
        {
            Console.WriteLine($"{Name} (Laptop) is connected to the network");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>()
            {
                new SmartPhone("iPhone", "16 Pro Max"),
                new Laptop("Macbook", "Pro M1 2022")
            };

            foreach(var device in devices)
            {
                device.GetDeviceInfo();
                if(device is INetworkConnectable connectable)
                {
                    connectable.ConnectToNetWork();
                }
            }
        }
    }
}
