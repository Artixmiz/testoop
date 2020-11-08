using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oop
{
    internal interface Action
        {
            void fly();

            void Thrust();

        }
    public abstract class Gundam : Action
    {
        private string namegundam;
        public string NameGumdam
        {
            get
            {
                return namegundam;
            }
            set { namegundam = value; }
        }

        private int energy;
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                energy = value;
            }
        }

        public abstract void fly();

        public abstract void Thrust();

        public abstract void Pilot();

        public abstract void Weapon();

        public abstract void SpecialFeatures();

    }
    public class Unicorn : Gundam
    {
        public Unicorn()
        {
            this.NameGumdam = "RX-0 Unicorn Gundam";
            this.Energy = 100;
        }
        public override void Pilot()
        {
            Console.WriteLine("Pilot Nmae : Banagher Links");
        }
        public override void Weapon()
        {
            Console.WriteLine("Has Weapon : [60mm Vulcan Gun]" +"[Beam Saber]"+ "[Shield]"+ "[I-Field Generator]");

        }
        public override void SpecialFeatures()
        {
            Console.WriteLine("Special Features :Newtype Destroyer System (NT-D)");
        }

        public override void fly()
        {
            Console.WriteLine("Gundam Can Not Fly");
        }

        public override void Thrust()
        {
            Console.WriteLine("Total Thrust : 142600 Kg");
        }
    }

    public class Exia : Gundam
    {
        public Exia()
        {
            this.NameGumdam = "GN-001 Gundam Exia";
            this.Energy = 99999;
        }
        public override void Pilot()
        {
            Console.WriteLine("Pilot Nmae : Setsuna F. Seiei");
        }
        public override void Weapon()
        {
            Console.WriteLine("Has Weapon : [GN Vulcan]" + "[GN LongBlade & GN ShortBlade]" + "[GN Beam Saber]"+ "[GN Shield]");

        }
        public override void SpecialFeatures()
        {
            Console.WriteLine("Special Features :[Over Boost Mode]"+ "[Optical Camouflage]"+ "[Trans-Am System]");
        }

        public override void fly()
        {
            Console.WriteLine("Gundam Can Not Fly");
        }

        public override void Thrust()
        {
            Console.WriteLine("Total Thrust : 102600 Kg");
        }
    }

    public class AGE : Gundam
    {
        public AGE()
        {
            this.NameGumdam = "AGE-FX Gundam AGE-FX";
            this.Energy = 100;
        }
        public override void Pilot()
        {
            Console.WriteLine("Pilot Nmae : Kio Asuno");
        }
        public override void Weapon()
        {
            Console.WriteLine("Has Weapon : [Stungle Rifle]" + "[Beam Saber]" + "[C - Funnel]");

        }
        public override void SpecialFeatures()
        {
            Console.WriteLine("Special Features :[AGE System]"+ "[Psycho-Follow System]"+ "[FX Burst Mode]"+ "[Core Block System]");
        }

        public override void fly()
        {
            Console.WriteLine("Gundam Can Fly");
        }

        public override void Thrust()
        {
            Console.WriteLine("Total Thrust : 172600 Kg");
        }
    }
}
