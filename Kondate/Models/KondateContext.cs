using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kondate.Models
{
	public class KondateContext : DbContext
	{
		public DbSet<Menu> Menus { get; set; }
		public DbSet<Meal> Meals { get; set; }
	}
}