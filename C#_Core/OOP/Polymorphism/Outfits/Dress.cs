using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Polymorphism.Outfits
{
	public class Dress : IOutfit
	{
		public void Wear()
		{
			Console.WriteLine("She is wearing Dress");
		}
	}
}
