using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Kondate.Models
{
	public class Menu
	{
		public int MenuId { get; set; }

		[DisplayName("説明")]
		public string Description { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }

		public virtual ICollection<Meal> Meals { get; set; }
	}
}