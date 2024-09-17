using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Inheritance
{
	class Animal
	{
		public int Legs { get; set; }
		public float Weigh { get; set; }

		public string Color { get; set; }

		public Animal()
		{
			Console.WriteLine("Khoi tao Animal");
		}
		public virtual void ShowLegs()
		{
			Console.WriteLine($"Legs: {Legs}");
		}
	}

	class Cat : Animal
	{
		public string Food;

		public Cat() : base()
		{
			Legs = 4;
			Food = "Mouse";
			Console.WriteLine("Khoi tao Cat");
		}

		public void Eat()
		{
			Console.WriteLine("Meal");
		}

		public override void ShowLegs()
		{
			base.ShowLegs();
			Console.WriteLine($"Co: {Legs} chan");
		}
	}

	//class Cat2 : Cat
	//{
	//    public override void ShowLegs()
	//    {
	//        Console.WriteLine($"Co: {Legs} chan");
	//    }
	//}
}
