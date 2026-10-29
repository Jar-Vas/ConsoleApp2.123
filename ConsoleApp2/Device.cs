using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    internal class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Power { get; set; }

        public Device(string name, string description, double power)
        {
            Name = name;
            Description = description;
            Power = power;
        }

        public Device()
        {
            Name = "";
            Description = "";
            Power = 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + ", Description: " + Description + ", Power: " + Power + " watt");
        }

        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
    }

    internal class Kettle : Device
    {
        public Kettle() : base("Kettle", "A Kettle", 2000) { }
        public override void Sound() { Console.WriteLine("Shhhhhhh...");  }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Microwave : Device
    {
        public Microwave() : base("Microwave", "A Microwave", 3000) { }
        public override void Sound() { Console.WriteLine("Brrrrrr..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Car : Device
    {
        public Car() : base("Car", "A Car", 20000) { }
        public override void Sound() { Console.WriteLine("Vrrrr..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Steamship : Device
    {
        public Steamship() : base("Steamship", "A Steamship", 1e6) { }
        public override void Sound() { Console.WriteLine("Shhhhhhh..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
}
