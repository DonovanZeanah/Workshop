using System.ComponentModel.DataAnnotations;

namespace WorkshopModels
{
		public class Tool : IMaterial
		{
		

				//prop
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
				

				// CTOR
				public Tool(int id, string name, string type, double price, int stationId, List<Material> materialList)
				{
						this.Id = id;
						this.Name = name;
						this.Type = type;
						this.Price = price;
						this.StationId = stationId;
						this.MaterialList = materialList;
				}

				public Tool()
				{
				}

			

				// Method
				public double Cost()
				{
						throw new NotImplementedException();
				}

				public string GetDescription()
				{
						throw new NotImplementedException();
				}

				public double GetQuantity()
				{
						throw new NotImplementedException();
				}

				public int Hardness()
				{
						throw new NotImplementedException();
				}

				public string Source()
				{
						throw new NotImplementedException();
				}
		}
}