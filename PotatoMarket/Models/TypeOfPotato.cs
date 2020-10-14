using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PotatoMarket.Models
{
	public class TypeOfPotato
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Potato> Potatoes { get; set; }
		public TypeOfPotato()
		{
			Potatoes = new List<Potato>();
		}
	}
}
