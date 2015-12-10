namespace CharacterCreator.DataForms.FeatForms
{
	partial class PathfinderFeatForm
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
			this.addFeatButton = new System.Windows.Forms.Button();
			this.removeFeatButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.featListLabel = new System.Windows.Forms.Label();
			this.featListBox = new System.Windows.Forms.ComboBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.idBox = new System.Windows.Forms.TextBox();
			this.featNameLabel = new System.Windows.Forms.Label();
			this.featNameBox = new System.Windows.Forms.TextBox();
			this.featTypeBox = new System.Windows.Forms.ListBox();
			this.featTypesLabel = new System.Windows.Forms.Label();
			this.addFeatTypeButton = new System.Windows.Forms.Button();
			this.removeFeatTypeButton = new System.Windows.Forms.Button();
			this.featDescriptionLabel = new System.Windows.Forms.Label();
			this.featDescriptionBox = new System.Windows.Forms.TextBox();
			this.modifierListBox = new System.Windows.Forms.ListBox();
			this.featModifierLabel = new System.Windows.Forms.Label();
			this.addModifierButton = new System.Windows.Forms.Button();
			this.removeModifierButton = new System.Windows.Forms.Button();
			this.featConditionBox = new System.Windows.Forms.ComboBox();
			this.featConditionLabel = new System.Windows.Forms.Label();
			this.featPrerequisiteLabel = new System.Windows.Forms.Label();
			this.prerequisiteListBox = new System.Windows.Forms.ListBox();
			this.addPrerequisiteButton = new System.Windows.Forms.Button();
			this.removePrerequisiteButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// addFeatButton
			// 
			this.addFeatButton.Location = new System.Drawing.Point(305, 409);
			this.addFeatButton.Name = "addFeatButton";
			this.addFeatButton.Size = new System.Drawing.Size(75, 23);
			this.addFeatButton.TabIndex = 0;
			this.addFeatButton.Text = "Add Feat";
			this.addFeatButton.UseVisualStyleBackColor = true;
			this.addFeatButton.Click += new System.EventHandler(this.addFeatButton_Click);
			// 
			// removeFeatButton
			// 
			this.removeFeatButton.Location = new System.Drawing.Point(386, 409);
			this.removeFeatButton.Name = "removeFeatButton";
			this.removeFeatButton.Size = new System.Drawing.Size(80, 23);
			this.removeFeatButton.TabIndex = 1;
			this.removeFeatButton.Text = "Remove Feat";
			this.removeFeatButton.UseVisualStyleBackColor = true;
			this.removeFeatButton.Click += new System.EventHandler(this.removeFeatButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(478, 24);
			this.menuStrip1.TabIndex = 2;
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
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// featListLabel
			// 
			this.featListLabel.AutoSize = true;
			this.featListLabel.Location = new System.Drawing.Point(12, 30);
			this.featListLabel.Name = "featListLabel";
			this.featListLabel.Size = new System.Drawing.Size(50, 13);
			this.featListLabel.TabIndex = 3;
			this.featListLabel.Text = "Feat List:";
			// 
			// featListBox
			// 
			this.featListBox.FormattingEnabled = true;
			this.featListBox.Location = new System.Drawing.Point(114, 27);
			this.featListBox.Name = "featListBox";
			this.featListBox.Size = new System.Drawing.Size(352, 21);
			this.featListBox.TabIndex = 4;
			this.featListBox.SelectedIndexChanged += new System.EventHandler(this.featListBox_SelectedIndexChanged);
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(12, 57);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(19, 13);
			this.idLabel.TabIndex = 5;
			this.idLabel.Text = "Id:";
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(114, 54);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(352, 20);
			this.idBox.TabIndex = 6;
			// 
			// featNameLabel
			// 
			this.featNameLabel.AutoSize = true;
			this.featNameLabel.Location = new System.Drawing.Point(12, 83);
			this.featNameLabel.Name = "featNameLabel";
			this.featNameLabel.Size = new System.Drawing.Size(62, 13);
			this.featNameLabel.TabIndex = 7;
			this.featNameLabel.Text = "Feat Name:";
			// 
			// featNameBox
			// 
			this.featNameBox.Location = new System.Drawing.Point(114, 80);
			this.featNameBox.Name = "featNameBox";
			this.featNameBox.Size = new System.Drawing.Size(352, 20);
			this.featNameBox.TabIndex = 8;
			// 
			// featTypeBox
			// 
			this.featTypeBox.FormattingEnabled = true;
			this.featTypeBox.Location = new System.Drawing.Point(114, 106);
			this.featTypeBox.Name = "featTypeBox";
			this.featTypeBox.Size = new System.Drawing.Size(352, 69);
			this.featTypeBox.TabIndex = 9;
			// 
			// featTypesLabel
			// 
			this.featTypesLabel.AutoSize = true;
			this.featTypesLabel.Location = new System.Drawing.Point(12, 106);
			this.featTypesLabel.Name = "featTypesLabel";
			this.featTypesLabel.Size = new System.Drawing.Size(63, 13);
			this.featTypesLabel.TabIndex = 10;
			this.featTypesLabel.Text = "Feat Types:";
			// 
			// addFeatTypeButton
			// 
			this.addFeatTypeButton.Location = new System.Drawing.Point(15, 122);
			this.addFeatTypeButton.Name = "addFeatTypeButton";
			this.addFeatTypeButton.Size = new System.Drawing.Size(25, 23);
			this.addFeatTypeButton.TabIndex = 11;
			this.addFeatTypeButton.Text = "+";
			this.addFeatTypeButton.UseVisualStyleBackColor = true;
			this.addFeatTypeButton.Click += new System.EventHandler(this.addFeatTypeButton_Click);
			// 
			// removeFeatTypeButton
			// 
			this.removeFeatTypeButton.Location = new System.Drawing.Point(50, 122);
			this.removeFeatTypeButton.Name = "removeFeatTypeButton";
			this.removeFeatTypeButton.Size = new System.Drawing.Size(25, 23);
			this.removeFeatTypeButton.TabIndex = 12;
			this.removeFeatTypeButton.Text = "-";
			this.removeFeatTypeButton.UseVisualStyleBackColor = true;
			this.removeFeatTypeButton.Click += new System.EventHandler(this.removeFeatTypeButton_Click);
			// 
			// featDescriptionLabel
			// 
			this.featDescriptionLabel.AutoSize = true;
			this.featDescriptionLabel.Location = new System.Drawing.Point(12, 184);
			this.featDescriptionLabel.Name = "featDescriptionLabel";
			this.featDescriptionLabel.Size = new System.Drawing.Size(87, 13);
			this.featDescriptionLabel.TabIndex = 13;
			this.featDescriptionLabel.Text = "Feat Description:";
			// 
			// featDescriptionBox
			// 
			this.featDescriptionBox.Location = new System.Drawing.Point(114, 181);
			this.featDescriptionBox.Name = "featDescriptionBox";
			this.featDescriptionBox.Size = new System.Drawing.Size(352, 20);
			this.featDescriptionBox.TabIndex = 14;
			// 
			// modifierListBox
			// 
			this.modifierListBox.FormattingEnabled = true;
			this.modifierListBox.Location = new System.Drawing.Point(114, 207);
			this.modifierListBox.Name = "modifierListBox";
			this.modifierListBox.Size = new System.Drawing.Size(352, 69);
			this.modifierListBox.TabIndex = 15;
			// 
			// featModifierLabel
			// 
			this.featModifierLabel.AutoSize = true;
			this.featModifierLabel.Location = new System.Drawing.Point(12, 207);
			this.featModifierLabel.Name = "featModifierLabel";
			this.featModifierLabel.Size = new System.Drawing.Size(52, 13);
			this.featModifierLabel.TabIndex = 16;
			this.featModifierLabel.Text = "Modifiers:";
			// 
			// addModifierButton
			// 
			this.addModifierButton.Location = new System.Drawing.Point(15, 223);
			this.addModifierButton.Name = "addModifierButton";
			this.addModifierButton.Size = new System.Drawing.Size(25, 23);
			this.addModifierButton.TabIndex = 17;
			this.addModifierButton.Text = "+";
			this.addModifierButton.UseVisualStyleBackColor = true;
			this.addModifierButton.Click += new System.EventHandler(this.addModifierButton_Click);
			// 
			// removeModifierButton
			// 
			this.removeModifierButton.Location = new System.Drawing.Point(50, 223);
			this.removeModifierButton.Name = "removeModifierButton";
			this.removeModifierButton.Size = new System.Drawing.Size(25, 23);
			this.removeModifierButton.TabIndex = 18;
			this.removeModifierButton.Text = "-";
			this.removeModifierButton.UseVisualStyleBackColor = true;
			this.removeModifierButton.Click += new System.EventHandler(this.removeModifierButton_Click);
			// 
			// featConditionBox
			// 
			this.featConditionBox.FormattingEnabled = true;
			this.featConditionBox.Location = new System.Drawing.Point(114, 282);
			this.featConditionBox.Name = "featConditionBox";
			this.featConditionBox.Size = new System.Drawing.Size(352, 21);
			this.featConditionBox.TabIndex = 19;
			// 
			// featConditionLabel
			// 
			this.featConditionLabel.AutoSize = true;
			this.featConditionLabel.Location = new System.Drawing.Point(12, 285);
			this.featConditionLabel.Name = "featConditionLabel";
			this.featConditionLabel.Size = new System.Drawing.Size(54, 13);
			this.featConditionLabel.TabIndex = 20;
			this.featConditionLabel.Text = "Condition:";
			// 
			// featPrerequisiteLabel
			// 
			this.featPrerequisiteLabel.AutoSize = true;
			this.featPrerequisiteLabel.Location = new System.Drawing.Point(12, 309);
			this.featPrerequisiteLabel.Name = "featPrerequisiteLabel";
			this.featPrerequisiteLabel.Size = new System.Drawing.Size(70, 13);
			this.featPrerequisiteLabel.TabIndex = 21;
			this.featPrerequisiteLabel.Text = "Prerequisites:";
			// 
			// prerequisiteListBox
			// 
			this.prerequisiteListBox.FormattingEnabled = true;
			this.prerequisiteListBox.Location = new System.Drawing.Point(114, 309);
			this.prerequisiteListBox.Name = "prerequisiteListBox";
			this.prerequisiteListBox.Size = new System.Drawing.Size(352, 95);
			this.prerequisiteListBox.TabIndex = 22;
			// 
			// addPrerequisiteButton
			// 
			this.addPrerequisiteButton.Location = new System.Drawing.Point(15, 325);
			this.addPrerequisiteButton.Name = "addPrerequisiteButton";
			this.addPrerequisiteButton.Size = new System.Drawing.Size(25, 23);
			this.addPrerequisiteButton.TabIndex = 23;
			this.addPrerequisiteButton.Text = "+";
			this.addPrerequisiteButton.UseVisualStyleBackColor = true;
			this.addPrerequisiteButton.Click += new System.EventHandler(this.addPrerequisiteButton_Click);
			// 
			// removePrerequisiteButton
			// 
			this.removePrerequisiteButton.Location = new System.Drawing.Point(49, 325);
			this.removePrerequisiteButton.Name = "removePrerequisiteButton";
			this.removePrerequisiteButton.Size = new System.Drawing.Size(25, 23);
			this.removePrerequisiteButton.TabIndex = 24;
			this.removePrerequisiteButton.Text = "-";
			this.removePrerequisiteButton.UseVisualStyleBackColor = true;
			this.removePrerequisiteButton.Click += new System.EventHandler(this.removePrerequisiteButton_Click);
			// 
			// PathfinderFeatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 438);
			this.Controls.Add(this.removePrerequisiteButton);
			this.Controls.Add(this.addPrerequisiteButton);
			this.Controls.Add(this.prerequisiteListBox);
			this.Controls.Add(this.featPrerequisiteLabel);
			this.Controls.Add(this.featConditionLabel);
			this.Controls.Add(this.featConditionBox);
			this.Controls.Add(this.removeModifierButton);
			this.Controls.Add(this.addModifierButton);
			this.Controls.Add(this.featModifierLabel);
			this.Controls.Add(this.modifierListBox);
			this.Controls.Add(this.featDescriptionBox);
			this.Controls.Add(this.featDescriptionLabel);
			this.Controls.Add(this.removeFeatTypeButton);
			this.Controls.Add(this.addFeatTypeButton);
			this.Controls.Add(this.featTypesLabel);
			this.Controls.Add(this.featTypeBox);
			this.Controls.Add(this.featNameBox);
			this.Controls.Add(this.featNameLabel);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.featListBox);
			this.Controls.Add(this.featListLabel);
			this.Controls.Add(this.removeFeatButton);
			this.Controls.Add(this.addFeatButton);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderFeatForm";
			this.Text = "PathfinderFeatForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addFeatButton;
		private System.Windows.Forms.Button removeFeatButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Label featListLabel;
		private System.Windows.Forms.ComboBox featListBox;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.Label featNameLabel;
		private System.Windows.Forms.TextBox featNameBox;
		private System.Windows.Forms.ListBox featTypeBox;
		private System.Windows.Forms.Label featTypesLabel;
		private System.Windows.Forms.Button addFeatTypeButton;
		private System.Windows.Forms.Button removeFeatTypeButton;
		private System.Windows.Forms.Label featDescriptionLabel;
		private System.Windows.Forms.TextBox featDescriptionBox;
		private System.Windows.Forms.ListBox modifierListBox;
		private System.Windows.Forms.Label featModifierLabel;
		private System.Windows.Forms.Button addModifierButton;
		private System.Windows.Forms.Button removeModifierButton;
		private System.Windows.Forms.ComboBox featConditionBox;
		private System.Windows.Forms.Label featConditionLabel;
		private System.Windows.Forms.Label featPrerequisiteLabel;
		private System.Windows.Forms.ListBox prerequisiteListBox;
		private System.Windows.Forms.Button addPrerequisiteButton;
		private System.Windows.Forms.Button removePrerequisiteButton;
	}
}