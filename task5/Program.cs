using System;
using System.Collections.Generic;
using System.IO;
using task5;

public class Program
    {
        public static void Main(string[] args)
        {
            List<IPhone> phones = new List<IPhone>();
            
            Smartphone smartphone1 = new Smartphone("iPhone X", "iOS", 64);
            smartphone1.TurnOn();
            smartphone1.InstallApp("Instagram");
            smartphone1.TakePhoto();
            phones.Add(smartphone1);

            Smartphone smartphone2 = new Smartphone("Samsung Galaxy S10", "Android", 128);
            smartphone2.TurnOn();
            smartphone2.InstallApp("Facebook");
            smartphone2.TakePhoto();
            phones.Add(smartphone2);
            
            foreach (var phone in phones)
            {
                phone.Call("123456789");
                phone.SendMessage("987654321", "Hello!");
            }
        }
    }