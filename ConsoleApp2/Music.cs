using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp2
{
    internal class MusicInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MusicInstrument(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public MusicInstrument()
        {
            Name = "";
            Description = "";
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + ", Description: " + Description);
        }

        public virtual void Sound() { }
        public virtual void Show() { }
        public virtual void Desc() { }
    }

    internal class Violin : MusicInstrument
    {
        public Violin() : base("Violin", "A Violin") { }
        public override void Sound() { Console.WriteLine("(Violin SOUND)..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Trombone : MusicInstrument
    {
        public Trombone() : base("Trombone", "A Trombone") { }
        public override void Sound() { Console.WriteLine("(Trombone SOUND)..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Ukulele : MusicInstrument
    {
        public Ukulele() : base("Ukulele", "A Ukulele") { }
        public override void Sound() { Console.WriteLine("(Ukulele SOUND)..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
    internal class Cello : MusicInstrument
    {
        public Cello() : base("Cello", "A Cello") { }
        public override void Sound() { Console.WriteLine("(Cello SOUND)..."); }
        public override void Show() { Console.WriteLine(Name); }
        public override void Desc() { Console.WriteLine(Description); }
    }
}
