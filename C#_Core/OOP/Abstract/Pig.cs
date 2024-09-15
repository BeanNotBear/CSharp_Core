using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Abstract
{
	// Derived class (inherit from Animal)
	public class Pig : Animal
	{
		public override void animalSound()
		{
			// The body of animalSound() is provided here
			Console.WriteLine("The pig says: wee wee");
		}
	}
}
