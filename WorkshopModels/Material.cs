using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopModels
{
		public class Material
		{
				[Key]
				public int Id { get; set; }
				[Required, StringLength(500)]
				public string Name { get; set; }
				[Required, StringLength(5000)]
				
				public string Type { get; set; }
				[Required]
				public double Price { get; set; }
				public int StationId { get; set; }
				//public virtual Teacher Teacher { get; set; }

				//public virtual List<CourseEnrollment> CourseEnrollments { get; set; } = new List<CourseEnrollment>();
		}
}
