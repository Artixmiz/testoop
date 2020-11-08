using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_oop
{
    class Controller
    {
        public void play()
        {
            Exia exia = new Exia();
            AGE age = new AGE();
            Unicorn unicorn = new Unicorn();
            Console.Write("Start Progream ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Task.Delay(500).Wait();
            }
            Console.WriteLine("");
            Console.WriteLine("select your Gundam");
            Console.WriteLine("1."+unicorn.NameGumdam+" "+"2."+exia.NameGumdam + " " + "3."+age.NameGumdam);
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(unicorn.NameGumdam);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Energy : [" + unicorn.Energy + " % ]");
                    Console.WriteLine("-------------------");
                    unicorn.Pilot();
                    Console.WriteLine("-------------------");
                    unicorn.Weapon();
                    Console.WriteLine("-------------------");
                    unicorn.SpecialFeatures();
                    Console.WriteLine("-------------------");
                    unicorn.Thrust();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("do you want to chack gundam of fly? Y / N ");
                    string Option1 = Console.ReadLine();
                    if (Option1=="Y"||Option1=="y")
                    {
                        Console.WriteLine("-------------------");
                        unicorn.fly();
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(exia.NameGumdam);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Energy : [" + exia.Energy+ " % ]");
                    Console.WriteLine("-------------------");
                    exia.Pilot();
                    Console.WriteLine("-------------------");
                    exia.Weapon();
                    Console.WriteLine("-------------------");
                    exia.SpecialFeatures();
                    Console.WriteLine("-------------------");
                    exia.Thrust();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("do you want to chack gundam of fly? Y / N ");
                    string Option2 = Console.ReadLine();
                    if (Option2 == "Y" || Option2 == "y")
                    {
                        Console.WriteLine("-------------------");
                        exia.fly();
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        break;
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine(age.NameGumdam);
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Energy : [" + age.Energy + " % ]");
                    Console.WriteLine("-------------------");
                    age.Pilot();
                    Console.WriteLine("-------------------");
                    age.Weapon();
                    Console.WriteLine("-------------------");
                    age.SpecialFeatures();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("do you want to chack gundam of fly? Y / N ");
                    string Option3 = Console.ReadLine();
                    if (Option3 == "Y" || Option3 == "y")
                    {
                        Console.WriteLine("-------------------");
                        age.fly();
                        Console.WriteLine("-------------------");
                    }
                    else
                    {
                        break;
                    }
                    break;
            }
        }
    }
}
