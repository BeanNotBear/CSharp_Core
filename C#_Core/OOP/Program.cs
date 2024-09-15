using C__Core.OOP.Abstract;
using C__Core.OOP.Constructor_Polymorphism.Constructors;
using C__Core.OOP.Constructor_Polymorphism.Polymorphism;
using C__Core.OOP.Constructor_Polymorphism.Polymorphism.Outfits;
using DemoPresent;

namespace C__Core.OOP
{
	internal class Program
	{
		static void PrintMenu()
		{
			Console.WriteLine("1: Demo Constructor.");
			Console.WriteLine("2: Demo Polymorphism.");
			Console.WriteLine("3: Demo Class and Encapsulattion.");
			Console.WriteLine("4: Demo Abstract");
			Console.WriteLine("Anykey: Exit.");
		}

		static void DemoAbsttract()
		{
			Pig myPig = new Pig(); // Create a Pig object
			myPig.animalSound();  // Call the abstract method
			myPig.sleep();  // Call the regular method
		}

		static void DemoClassEncapsulation()
		{
			Student student = new Student();

			// calls set accessor of the property Name
			student.Name = "Nguyen Van A";
			// calls set accessor of the property Name
			student.Age = 21;

			// Displaying values of the variables
			Console.WriteLine("Name : " + student.Name);
			Console.WriteLine("Age : " + student.Age);

			// calls set accessor of the property Name
			student.Name = "Tran Van B";
			// calls set accessor of the property Name
			student.Age = 19;

			// Display
			student.Infor();
		}

		static void DemoConstructor()
		{
			Vehicle car = new Vehicle();
			Console.WriteLine(car.ToString());

			Vehicle car1 = new Vehicle("BMW i3", "Black");
			Console.WriteLine(car1.ToString());

			Vehicle car2 = new Vehicle("RollRoyce Phantom", "White", 2021);
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
					case "3":
						DemoClassEncapsulation();
						break;
					case "4":
						DemoAbsttract();
						break;
					default:
						return;
				}
			}
			while (true);
		}
	}
}
