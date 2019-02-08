using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Model
{
	public class UProgram
	{
		public string Name { get; set; }
		public Degree Degree { get; set; }

		public UProgram(string name)
		{
			Name = name;
		}
	}
}
