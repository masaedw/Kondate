using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kondate.Models
{
	public enum MealTime
	{
		Breakfirst,
		Lunch,
		Dinner,
	}

	public class Menu
	{
		public int MenuId { get; set; }

		[DisplayName("説明")]
		[StringLength(140)]
		public string Description { get; set; }

		[DisplayName("内容")]
		[StringLength(1024)]
		public string Content { get; set; }

		[DisplayName("日付")]
		public DateTime Date { get; set; }

		public MealTime MealTime { get; set; }

		[DisplayName("作成日時")]
		public DateTime CreatedAt { get; set; }
		[DisplayName("更新日時")]
		public DateTime UpdatedAt { get; set; }

		public virtual ICollection<Meal> Meals { get; set; }
	}
}