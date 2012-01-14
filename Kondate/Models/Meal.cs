using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kondate.Models
{
	public class Meal
	{
		public int MealId { get; set; }

		[Required]
		[StringLength(64)]
		[DisplayName("タイトル")]
		public string Name { get; set; }

		public DateTime CreatedAt { get; set; }
	}
}