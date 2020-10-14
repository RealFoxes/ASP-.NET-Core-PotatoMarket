using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PotatoMarket.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[Required,MaxLength(32)]
		public string Login { get; set; }
		[Required, MaxLength(32)]
		public string Password { get; set; }
		[Required,MaxLength(128)]
		public string FirstName { get; set; }
		[Required, MaxLength(128)]
		public string SecondName { get; set; }
		[Required, Column(TypeName = "date")]
		public DateTime Birthday { get; set; }
		[Required]
		public int Age { get { return DateTime.Now.Year - Birthday.Year; } }
		public List<Potato> HistoryOfPurchases { get; set; }
		public List<Potato> CartOfPotato { get; set; }
		public User()
		{
			HistoryOfPurchases = new List<Potato>();
			CartOfPotato = new List<Potato>();
		}
	}
}
