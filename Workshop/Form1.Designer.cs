namespace Workshop
{
		partial class Form1
		{
				/// <summary>
				///  Required designer variable.
				/// </summary>
				private System.ComponentModel.IContainer components = null;

				/// <summary>
				///  Clean up any resources being used.
				/// </summary>
				/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
				protected override void Dispose(bool disposing)
				{
						if (disposing && (components != null))
						{
								components.Dispose();
						}
						base.Dispose(disposing);
				}

				#region Windows Form Designer generated code

				/// <summary>
				///  Required method for Designer support - do not modify
				///  the contents of this method with the code editor.
				/// </summary>
				private void InitializeComponent()
				{
						this.components = new System.ComponentModel.Container();
						System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
						this.textBox1 = new System.Windows.Forms.TextBox();
						this.dataGridView1 = new System.Windows.Forms.DataGridView();
						this.button1 = new System.Windows.Forms.Button();
						this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
						this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
						this.menuStrip1 = new System.Windows.Forms.MenuStrip();
						this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
						this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
						this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
						this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
						this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
						this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
						this.statusStrip1 = new System.Windows.Forms.StatusStrip();
						this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
						this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
						this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
						this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
						this.timer1 = new System.Windows.Forms.Timer(this.components);
						this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
						((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
						this.menuStrip1.SuspendLayout();
						this.statusStrip1.SuspendLayout();
						this.SuspendLayout();
						// 
						// textBox1
						// 
						this.textBox1.Location = new System.Drawing.Point(135, 30);
						this.textBox1.Multiline = true;
						this.textBox1.Name = "textBox1";
						this.textBox1.Size = new System.Drawing.Size(497, 162);
						this.textBox1.TabIndex = 1;
						// 
						// dataGridView1
						// 
						this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
						this.dataGridView1.Location = new System.Drawing.Point(52, 198);
						this.dataGridView1.Name = "dataGridView1";
						this.dataGridView1.RowTemplate.Height = 25;
						this.dataGridView1.Size = new System.Drawing.Size(715, 215);
						this.dataGridView1.TabIndex = 2;
						// 
						// button1
						// 
						this.button1.Location = new System.Drawing.Point(638, 29);
						this.button1.Name = "button1";
						this.button1.Size = new System.Drawing.Size(75, 23);
						this.button1.TabIndex = 3;
						this.button1.Text = "button1";
						this.button1.UseVisualStyleBackColor = true;
						this.button1.Click += new System.EventHandler(this.button1_Click);
						// 
						// fileSystemWatcher1
						// 
						this.fileSystemWatcher1.EnableRaisingEvents = true;
						this.fileSystemWatcher1.SynchronizingObject = this;
						this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
						// 
						// menuStrip1
						// 
						this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripTextBox1,
						this.toolStripMenuItem1});
						this.menuStrip1.Location = new System.Drawing.Point(0, 0);
						this.menuStrip1.Name = "menuStrip1";
						this.menuStrip1.Size = new System.Drawing.Size(800, 27);
						this.menuStrip1.TabIndex = 4;
						this.menuStrip1.Text = "menuStrip1";
						// 
						// toolStripTextBox1
						// 
						this.toolStripTextBox1.Name = "toolStripTextBox1";
						this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
						// 
						// toolStripMenuItem1
						// 
						this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripMenuItem2,
						this.toolStripMenuItem3,
						this.toolStripSeparator1,
						this.toolStripSeparator2,
						this.toolStripTextBox2});
						this.toolStripMenuItem1.Name = "toolStripMenuItem1";
						this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 23);
						this.toolStripMenuItem1.Text = "toolStripMenuItem1";
						// 
						// toolStripMenuItem2
						// 
						this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripMenuItem4});
						this.toolStripMenuItem2.Name = "toolStripMenuItem2";
						this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem2.Text = "toolStripMenuItem2";
						this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
						// 
						// toolStripMenuItem3
						// 
						this.toolStripMenuItem3.Name = "toolStripMenuItem3";
						this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem3.Text = "toolStripMenuItem3";
						// 
						// toolStripSeparator1
						// 
						this.toolStripSeparator1.Name = "toolStripSeparator1";
						this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
						// 
						// toolStripSeparator2
						// 
						this.toolStripSeparator2.Name = "toolStripSeparator2";
						this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
						// 
						// toolStripTextBox2
						// 
						this.toolStripTextBox2.Name = "toolStripTextBox2";
						this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
						// 
						// toolStripMenuItem4
						// 
						this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripMenuItem5,
						this.toolStripMenuItem6,
						this.toolStripMenuItem7,
						this.toolStripMenuItem8,
						this.toolStripMenuItem9});
						this.toolStripMenuItem4.Name = "toolStripMenuItem4";
						this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem4.Text = "toolStripMenuItem4";
						// 
						// toolStripMenuItem5
						// 
						this.toolStripMenuItem5.Name = "toolStripMenuItem5";
						this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem5.Text = "toolStripMenuItem5";
						// 
						// toolStripMenuItem6
						// 
						this.toolStripMenuItem6.Name = "toolStripMenuItem6";
						this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem6.Text = "toolStripMenuItem6";
						// 
						// toolStripMenuItem7
						// 
						this.toolStripMenuItem7.Name = "toolStripMenuItem7";
						this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem7.Text = "toolStripMenuItem7";
						// 
						// toolStripMenuItem8
						// 
						this.toolStripMenuItem8.Name = "toolStripMenuItem8";
						this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem8.Text = "toolStripMenuItem8";
						// 
						// toolStripMenuItem9
						// 
						this.toolStripMenuItem9.Name = "toolStripMenuItem9";
						this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
						this.toolStripMenuItem9.Text = "toolStripMenuItem9";
						// 
						// statusStrip1
						// 
						this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
						this.toolStripSplitButton1,
						this.toolStripDropDownButton1,
						this.toolStripProgressBar1,
						this.toolStripStatusLabel1});
						this.statusStrip1.Location = new System.Drawing.Point(0, 428);
						this.statusStrip1.Name = "statusStrip1";
						this.statusStrip1.Size = new System.Drawing.Size(800, 22);
						this.statusStrip1.TabIndex = 5;
						this.statusStrip1.Text = "statusStrip1";
						// 
						// toolStripSplitButton1
						// 
						this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
						this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
						this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
						this.toolStripSplitButton1.Name = "toolStripSplitButton1";
						this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
						this.toolStripSplitButton1.Text = "toolStripSplitButton1";
						// 
						// toolStripDropDownButton1
						// 
						this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
						this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
						this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
						this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
						this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
						this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
						// 
						// toolStripProgressBar1
						// 
						this.toolStripProgressBar1.Name = "toolStripProgressBar1";
						this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
						// 
						// toolStripStatusLabel1
						// 
						this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
						this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
						this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
						this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
						// 
						// Form1
						// 
						this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						this.ClientSize = new System.Drawing.Size(800, 450);
						this.Controls.Add(this.statusStrip1);
						this.Controls.Add(this.button1);
						this.Controls.Add(this.dataGridView1);
						this.Controls.Add(this.textBox1);
						this.Controls.Add(this.menuStrip1);
						this.MainMenuStrip = this.menuStrip1;
						this.Name = "Form1";
						this.Text = "Form1";
						((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
						this.menuStrip1.ResumeLayout(false);
						this.menuStrip1.PerformLayout();
						this.statusStrip1.ResumeLayout(false);
						this.statusStrip1.PerformLayout();
						this.ResumeLayout(false);
						this.PerformLayout();

				}

				#endregion

				private TextBox textBox1;
				private DataGridView dataGridView1;
				private Button button1;
				private FileSystemWatcher fileSystemWatcher1;
				private MenuStrip menuStrip1;
				private ToolStripTextBox toolStripTextBox1;
				private ToolStripMenuItem toolStripMenuItem1;
				private ToolStripMenuItem toolStripMenuItem2;
				private ToolStripMenuItem toolStripMenuItem3;
				private ToolStripSeparator toolStripSeparator1;
				private ToolStripSeparator toolStripSeparator2;
				private ToolStripTextBox toolStripTextBox2;
				private System.ComponentModel.BackgroundWorker backgroundWorker1;
				private StatusStrip statusStrip1;
				private ToolStripSplitButton toolStripSplitButton1;
				private ToolStripDropDownButton toolStripDropDownButton1;
				private ToolStripProgressBar toolStripProgressBar1;
				private ToolStripStatusLabel toolStripStatusLabel1;
				private ToolStripMenuItem toolStripMenuItem4;
				private ToolStripMenuItem toolStripMenuItem5;
				private ToolStripMenuItem toolStripMenuItem6;
				private ToolStripMenuItem toolStripMenuItem7;
				private ToolStripMenuItem toolStripMenuItem8;
				private ToolStripMenuItem toolStripMenuItem9;
				private System.Windows.Forms.Timer timer1;
				private SaveFileDialog saveFileDialog1;
		}
}