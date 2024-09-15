using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Abstract
{
	// Abstract class
	public abstract class Animal
	{
		// Abstract method (does not have a body)
		public abstract void animalSound();
		// Regular method
		public void sleep()
		{
			Console.WriteLine("Zzz");
		}
	}
}
