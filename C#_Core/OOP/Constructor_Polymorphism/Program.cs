using C__Core.OOP.Constructor_Polymorphism.Constructors;
using C__Core.OOP.Constructor_Polymorphism.Polymorphism;
using C__Core.OOP.Constructor_Polymorphism.Polymorphism.Outfits;

namespace C__Core.OOP.Constructor_Polymorphism
{
    internal class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1: Demo Constructor.");
            Console.WriteLine("2: Demo Polymorphism.");
            Console.WriteLine("Anykey: Exit.");
        }

        static void DemoConstructor()
        {
            Car car = new Car();
            Console.WriteLine(car.ToString());

            Car car1 = new Car("BMW i3", "Black");
            Console.WriteLine(car1.ToString());

            Car car2 = new Car("RollRoyce Phantom", "White", 2021);
            Console.WriteLine(car2.ToString());
        }

        static void DemoPolymophism()
        {
            string option;
            do
            {
                Console.WriteLine("1: Wear Binkini.");
                Console.WriteLine("2: Wear Dress.");
                Console.WriteLine("3: Wear T-Shirt.");
                Console.WriteLine("AnyKey: Exit Demo.");
                option = Console.ReadLine();
                Girl girl = new Girl();
                switch (option)
                {
                    case "1":
                        girl.Outfit = new Binkini();
                        girl.Outfit.Wear();
                        break;
                    case "2":
                        girl.Outfit = new Dress();
                        girl.Outfit.Wear();
                        break;
                    case "3":
                        girl.Outfit = new TShirt();
                        girl.Outfit.Wear();
                        break;
                    default:
                        return;
                }
            }
            while (true);
        }

        static void Main(string[] args)
        {
            string option;
            do
            {
                PrintMenu();
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        DemoConstructor();
                        break;
                    case "2":
                        DemoPolymophism();
                        break;
                    default:
                        return;
                }
            }
            while (true);
        }
    }
}
