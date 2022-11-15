
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkshopDB;
using System.Configuration;
using System.Drawing;
//FORM APP GO

namespace Workshop
{
		public class Program
		{
				/// <summary>
				///  The main entry point for the application.
				/// </summary>
				[STAThread]
				public static void Main()
				{
						// To customize application configuration such as set high DPI settings or default font,
						// see https://aka.ms/applicationconfiguration.
						ApplicationConfiguration.Initialize();
						Application.Run(new Form1());
				}
		}
}