using System;

namespace task5
{
    public abstract class MobilePhone : IPhone
    {
        public string Model { get; set; }
        private int BatteryLevel { get; set; }
        protected bool IsOn { get; set; }

        protected MobilePhone(string model)
        {
            Model = model;
            BatteryLevel = 100;
            IsOn = false;
        }

        public virtual void Call(string number)
        {
            Console.WriteLine($"Calling {number} from {Model}");
        }

        public virtual void SendMessage(string number, string message)
        {
            Console.WriteLine($"Sending message to {number} from {Model}: {message}");
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Model} is turned on");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Model} is turned off");
        }

        public void RechargeBattery()
        {
            BatteryLevel = 100;
            Console.WriteLine($"{Model} battery is fully recharged");
        }
    }
}