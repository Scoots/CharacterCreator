namespace CharacterCreator.DataForms
{
	partial class PathfinderSkillForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.skillDescriptionBox = new System.Windows.Forms.TextBox();
			this.skillNameBox = new System.Windows.Forms.TextBox();
			this.statBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.skillsLabel = new System.Windows.Forms.Label();
			this.skillsBox = new System.Windows.Forms.ComboBox();
			this.addSkillButton = new System.Windows.Forms.Button();
			this.removeSkillButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(422, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Skill Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Skill Description:";
			// 
			// skillDescriptionBox
			// 
			this.skillDescriptionBox.Location = new System.Drawing.Point(140, 86);
			this.skillDescriptionBox.Name = "skillDescriptionBox";
			this.skillDescriptionBox.Size = new System.Drawing.Size(270, 20);
			this.skillDescriptionBox.TabIndex = 4;
			// 
			// skillNameBox
			// 
			this.skillNameBox.Location = new System.Drawing.Point(140, 60);
			this.skillNameBox.Name = "skillNameBox";
			this.skillNameBox.Size = new System.Drawing.Size(270, 20);
			this.skillNameBox.TabIndex = 1;
			// 
			// statBox
			// 
			this.statBox.FormattingEnabled = true;
			this.statBox.Location = new System.Drawing.Point(140, 112);
			this.statBox.Name = "statBox";
			this.statBox.Size = new System.Drawing.Size(121, 21);
			this.statBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Skill Stat Modifier:";
			// 
			// skillsLabel
			// 
			this.skillsLabel.AutoSize = true;
			this.skillsLabel.Location = new System.Drawing.Point(12, 36);
			this.skillsLabel.Name = "skillsLabel";
			this.skillsLabel.Size = new System.Drawing.Size(34, 13);
			this.skillsLabel.TabIndex = 7;
			this.skillsLabel.Text = "Skills:";
			// 
			// skillsBox
			// 
			this.skillsBox.FormattingEnabled = true;
			this.skillsBox.Location = new System.Drawing.Point(140, 33);
			this.skillsBox.Name = "skillsBox";
			this.skillsBox.Size = new System.Drawing.Size(270, 21);
			this.skillsBox.TabIndex = 8;
			this.skillsBox.SelectedIndexChanged += new System.EventHandler(this.skillsBox_SelectedIndexChanged);
			// 
			// addSkillButton
			// 
			this.addSkillButton.Location = new System.Drawing.Point(232, 143);
			this.addSkillButton.Name = "addSkillButton";
			this.addSkillButton.Size = new System.Drawing.Size(76, 30);
			this.addSkillButton.TabIndex = 9;
			this.addSkillButton.Text = "Add Skill";
			this.addSkillButton.UseVisualStyleBackColor = true;
			this.addSkillButton.Click += new System.EventHandler(this.addSkillButton_Click);
			// 
			// removeSkillButton
			// 
			this.removeSkillButton.Location = new System.Drawing.Point(314, 143);
			this.removeSkillButton.Name = "removeSkillButton";
			this.removeSkillButton.Size = new System.Drawing.Size(96, 30);
			this.removeSkillButton.TabIndex = 10;
			this.removeSkillButton.Text = "Remove Skill";
			this.removeSkillButton.UseVisualStyleBackColor = true;
			this.removeSkillButton.Click += new System.EventHandler(this.removeSkillButton_Click);
			// 
			// PathfinderSkillForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 185);
			this.Controls.Add(this.removeSkillButton);
			this.Controls.Add(this.addSkillButton);
			this.Controls.Add(this.skillsBox);
			this.Controls.Add(this.skillsLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.statBox);
			this.Controls.Add(this.skillDescriptionBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.skillNameBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderSkillForm";
			this.Text = "PathfinderSkillForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox skillDescriptionBox;
		private System.Windows.Forms.TextBox skillNameBox;
		private System.Windows.Forms.ComboBox statBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Label skillsLabel;
		private System.Windows.Forms.ComboBox skillsBox;
		private System.Windows.Forms.Button addSkillButton;
		private System.Windows.Forms.Button removeSkillButton;
	}
}