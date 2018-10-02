using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Employees.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }

		[ForeignKey("Dep")]
		public int IdDep { get; set; }

		public virtual Department Dep { get; set; }
	}
}