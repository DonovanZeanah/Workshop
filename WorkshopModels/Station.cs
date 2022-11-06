using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopModels
{
		public class Station
		{
				[Key]
				public int Id { get; set; }
				[Required, StringLength(1000)]
				public string Name { get; set; }
				[Required, StringLength(5000)]
				public string Description { get; set; }
				public virtual List<Tool> ToolSets { get; set; } = new List<Tool>();


		}
}
