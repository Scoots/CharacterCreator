namespace CharacterCreator
{
	partial class PathfinderAdmin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGeneratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.featToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.skillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.traitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataGeneratorsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(454, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// dataGeneratorsToolStripMenuItem
			// 
			this.dataGeneratorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripMenuItem,
            this.featToolStripMenuItem,
            this.skillToolStripMenuItem,
            this.traitToolStripMenuItem});
			this.dataGeneratorsToolStripMenuItem.Name = "dataGeneratorsToolStripMenuItem";
			this.dataGeneratorsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
			this.dataGeneratorsToolStripMenuItem.Text = "Data Generators";
			// 
			// classToolStripMenuItem
			// 
			this.classToolStripMenuItem.Name = "classToolStripMenuItem";
			this.classToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.classToolStripMenuItem.Text = "Class";
			this.classToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem_Click);
			// 
			// featToolStripMenuItem
			// 
			this.featToolStripMenuItem.Name = "featToolStripMenuItem";
			this.featToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.featToolStripMenuItem.Text = "Feat";
			this.featToolStripMenuItem.Click += new System.EventHandler(this.featToolStripMenuItem_Click);
			// 
			// skillToolStripMenuItem
			// 
			this.skillToolStripMenuItem.Name = "skillToolStripMenuItem";
			this.skillToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.skillToolStripMenuItem.Text = "Skill";
			this.skillToolStripMenuItem.Click += new System.EventHandler(this.skillToolStripMenuItem_Click);
			// 
			// traitToolStripMenuItem
			// 
			this.traitToolStripMenuItem.Name = "traitToolStripMenuItem";
			this.traitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.traitToolStripMenuItem.Text = "Trait";
			this.traitToolStripMenuItem.Click += new System.EventHandler(this.traitToolStripMenuItem_Click);
			// 
			// PathfinderAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 186);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderAdmin";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataGeneratorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem classToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem featToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem skillToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem traitToolStripMenuItem;
	}
}

