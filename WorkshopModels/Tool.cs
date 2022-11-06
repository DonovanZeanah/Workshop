using System.ComponentModel.DataAnnotations;

namespace WorkshopModels
{
		public class Tool
		{
				[Key]
				public int Id { get; set; }
				[Required, StringLength(5000)]
				public string Name { get; set; }
				[Required, StringLength(5000)]

				public string Type { get; set; }
				[Required]
				public double Price { get; set; }
				public int StationId { get; set; }
				public virtual List<Material> MaterialList { get; set; } = new List<Material>();

		}
}