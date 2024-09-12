using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Core.OOP.Polymorphism
{
	public class Girl
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public IOutfit Outfit { get; set; }

		public Girl()
		{
			Name = "Eva Anna";
			Age = 18;
		}
	}
}
