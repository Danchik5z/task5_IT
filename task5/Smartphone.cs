using System;

namespace task5
{
    public class Smartphone : MobilePhone
    {
        private string OperatingSystem { get; set; }
        private int StorageCapacity { get; set; }

        public Smartphone(string model, string operatingSystem, int storageCapacity) : base(model)
        {
            OperatingSystem = operatingSystem;
            StorageCapacity = storageCapacity;
        }

        public override void Call(string number)
        {
            if (IsOn)
            {
                Console.WriteLine($"Calling {number} from {Model} (Smartphone)");
            }
            else
            {
                Console.WriteLine($"{Model} is turned off. Cannot make a call.");
            }
        }

        public override void SendMessage(string number, string message)
        {
            if (IsOn)
            {
                Console.WriteLine($"Sending message to {number} from {Model} (Smartphone): {message}");
            }
            else
            {
                Console.WriteLine($"{Model} is turned off. Cannot send a message.");
            }
        }

        public void InstallApp(string appName)
        {
            Console.WriteLine($"Installing {appName} app on {Model}");
        }

        public void TakePhoto()
        {
            if (IsOn)
            {
                Console.WriteLine($"Taking a photo with {Model} (Smartphone)");
            }
            else
            {
                Console.WriteLine($"{Model} is turned off. Cannot take a photo.");
            }
        }
    }
}