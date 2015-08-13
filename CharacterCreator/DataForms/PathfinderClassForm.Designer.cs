namespace CharacterCreator.DataForms
{
	partial class PathfinderClassForm
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
			this.nameLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classNameBox = new System.Windows.Forms.TextBox();
			this.hdBox = new System.Windows.Forms.ComboBox();
			this.hdLabel = new System.Windows.Forms.Label();
			this.classSaveProgressionLabel = new System.Windows.Forms.Label();
			this.classSaveProgressionBox = new System.Windows.Forms.ComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(12, 30);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(66, 13);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Class Name:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(540, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// classNameBox
			// 
			this.classNameBox.Location = new System.Drawing.Point(166, 27);
			this.classNameBox.Name = "classNameBox";
			this.classNameBox.Size = new System.Drawing.Size(362, 20);
			this.classNameBox.TabIndex = 2;
			// 
			// hdBox
			// 
			this.hdBox.FormattingEnabled = true;
			this.hdBox.Location = new System.Drawing.Point(166, 53);
			this.hdBox.Name = "hdBox";
			this.hdBox.Size = new System.Drawing.Size(110, 21);
			this.hdBox.TabIndex = 3;
			// 
			// hdLabel
			// 
			this.hdLabel.AutoSize = true;
			this.hdLabel.Location = new System.Drawing.Point(12, 56);
			this.hdLabel.Name = "hdLabel";
			this.hdLabel.Size = new System.Drawing.Size(106, 13);
			this.hdLabel.TabIndex = 4;
			this.hdLabel.Text = "Hit Dice Progression:";
			// 
			// classSaveProgressionLabel
			// 
			this.classSaveProgressionLabel.AutoSize = true;
			this.classSaveProgressionLabel.Location = new System.Drawing.Point(12, 83);
			this.classSaveProgressionLabel.Name = "classSaveProgressionLabel";
			this.classSaveProgressionLabel.Size = new System.Drawing.Size(93, 13);
			this.classSaveProgressionLabel.TabIndex = 5;
			this.classSaveProgressionLabel.Text = "Save Progression:";
			// 
			// classSaveProgressionBox
			// 
			this.classSaveProgressionBox.FormattingEnabled = true;
			this.classSaveProgressionBox.Location = new System.Drawing.Point(166, 80);
			this.classSaveProgressionBox.Name = "classSaveProgressionBox";
			this.classSaveProgressionBox.Size = new System.Drawing.Size(109, 21);
			this.classSaveProgressionBox.TabIndex = 6;
			// 
			// PathfinderClassForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 311);
			this.Controls.Add(this.classSaveProgressionBox);
			this.Controls.Add(this.classSaveProgressionLabel);
			this.Controls.Add(this.hdLabel);
			this.Controls.Add(this.hdBox);
			this.Controls.Add(this.classNameBox);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderClassForm";
			this.Text = "PathfinderClassForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TextBox classNameBox;
		private System.Windows.Forms.ComboBox hdBox;
		private System.Windows.Forms.Label hdLabel;
		private System.Windows.Forms.Label classSaveProgressionLabel;
		private System.Windows.Forms.ComboBox classSaveProgressionBox;
	}
}