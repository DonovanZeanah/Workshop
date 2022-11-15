using System.Text.Json.Serialization;
using WorkshopModels;
namespace Workshop
{
		public partial class Form1 : Form
		{
				public static Material metal = new Material();

				//dictionary of reused words
				private Dictionary<int, bool> WordUseTracker = new Dictionary<int, bool>();


				public Form1()
				{
						InitializeComponent();
				}



				
		private void button1_Click(object sender, EventArgs e)
		{



						var var8 = new Tool(1, hammer, standard, 20.00, metal);
						var result = textBox1.Text;
						MessageBox.Show(result);
						
						var var2 = new Tool();

				}

				private void toolStripMenuItem2_Click(object sender, EventArgs e)
				{

				}

				private void toolStripStatusLabel1_Click(object sender, EventArgs e)
				{

				}

				private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
				{

				}
		}
}