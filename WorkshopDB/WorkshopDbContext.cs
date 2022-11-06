
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkshopModels;

namespace WorkshopDB
{
		public class WorkshopDBContext : DbContext
		{
				public DbSet<Station> Stations { get; set; }
				public DbSet<Tool> Tools { get; set; }
				public DbSet<Material> Materials { get; set; }
				public DbSet<Day> Days { get; set; }
				public DbSet<WsProject> WsProjects { get; set; }
				public DbSet<Day> WsDay { get; set; }
				//public DbSet<CourseInfoDTO> CourseInfoDTOs { get; set; }


				//add to allow migrations
				public WorkshopDBContext()
				{

				}

				//add to inject context options from app
				public WorkshopDBContext(DbContextOptions options)
						: base(options)

				{

				}

				//add to allow migrations when the context is not built
				protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
				{
						if (!optionsBuilder.IsConfigured)
						{
								var builder = new ConfigurationBuilder()
																.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

								var config = builder.Build();
								var cnstr = config["ConnectionStrings:WorkshopDB"];
								var options = new DbContextOptionsBuilder<WorkshopDBContext>().UseSqlServer(cnstr);
								optionsBuilder.UseSqlServer(cnstr);
						}
				}
				protected override void OnModelCreating(ModelBuilder modelBuilder)
				{
						modelBuilder.Entity<Station>(x =>
						{
								x.HasData(
										new Station() { Id = 1, Name = "Cleaning", Description = "A dedicated station for cleaning. It is more efficient to clean things here, than anywhere else!" }, //, for subsequent entries
										new Station() { Id = 2, Name = "Workbench", Description = "A universal Workbench. Your vice is here, stop using the floor to work on your projects..." },
										new Station() { Id = 3, Name = "ToolWall", Description = "A random location with which none of your tools are present at ...because you didn't put them ... you suck; change." },
										new Station() { Id = 4, Name = "Storage", Description = "A place for all the scrap material your not man enough to throw away" }

								);
						});

					
						modelBuilder.Entity<Tool>(x =>
						{
								x.HasData
								(
										new Tool() { Id = 1, Name = "Hammer", Type = "Regular", Price = 20.00, StationId = 3 },
										new Tool() { Id = 2, Name = "Saw", Type = "Hack", Price = 15.00, StationId = 3 },
										new Tool() { Id = 3, Name = "Drill", Type = "Cordless-Electric", Price = 80.00, StationId = 3 },
										new Tool() { Id = 4, Name = "Chisel", Type = "3 \"", Price = 5.00, StationId = 3 },
										new Tool() { Id = 5, Name = "Saw", Type = "Mitre", Price = 150.00, StationId = 3 },
										new Tool() { Id = 6, Name = "Drillbit", Type = "Forestner - 30 mm", Price = 13.00, StationId = 3 }


								);
						});
						modelBuilder.Entity<Material>(x =>
						{
								x.HasData
								(
										new Material() { Id = 1, Name = "2x4", Type = "Wood", Price = 30.00, StationId = 4 },
										new Material() { Id = 2, Name = "Steel", Type = "Metal-Rod", Price = 10.00, StationId = 4 },
										new Material() { Id = 3, Name = "steel", Type = "Sheet-metal", Price = 20.00, StationId = 4 },
										new Material() { Id = 4, Name = "Brick", Type = "Regular", Price = 3.00, StationId = 4 },
										new Material() { Id = 5, Name = "Brick", Type = "CinderBlock", Price = 8.00, StationId = 4 },
										new Material() { Id = 6, Name = "Glass", Type = "Stained-Blue", Price = 11.00, StationId = 4 }


								);
						});
						modelBuilder.Entity<WsProject>(x =>
						{
								x.HasData
								(
										new WsProject() { Id = 1, Name = "Video System", Description = "Dedicated cameras pointed at different stations to capture action and auto-sequence a video timeline." }, //, for subsequent entries
										new WsProject() { Id = 2, Name = "Waterjet", Description = "Modify a pressure washer and combine it with the cnc system of a 3d printer to cut complex sheet metal programmatically (preferably while sleeping.)" }



								);
						});
						var seedDate = new DateTime(2022, 11, 03);
						modelBuilder.Entity<Day>(x =>
						{
								x.HasData
								(
										new Day() { Id = 1, Description = "Inception of Workshop Program", Date = seedDate }, //, for subsequent entries
										new Day() { Id = 2, Description = "Weekday - typical day spent not being a millionaire", Date = seedDate }



								);
						});


						/*modelBuilder.Entity<CourseInfoDTO>(x =>
						{
								x.HasNoKey();
								x.ToView("CourseInfoDTOs");
						});*/
				}

		}
}