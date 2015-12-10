namespace CharacterCreator.DataForms.TraitForms
{
	partial class PathfinderTraitForm
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
			this.traitListLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.traitBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.traitNameBox = new System.Windows.Forms.TextBox();
			this.traitTypeLabel = new System.Windows.Forms.Label();
			this.traitTypeBox = new System.Windows.Forms.ComboBox();
			this.traitDescriptionLabel = new System.Windows.Forms.Label();
			this.traitDescriptionBox = new System.Windows.Forms.TextBox();
			this.addTraitButton = new System.Windows.Forms.Button();
			this.removeTraitButton = new System.Windows.Forms.Button();
			this.traitRegionLabel = new System.Windows.Forms.Label();
			this.traitRegionBox = new System.Windows.Forms.ComboBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.idBox = new System.Windows.Forms.TextBox();
			this.traitModifierLabel = new System.Windows.Forms.Label();
			this.traitConditionLabel = new System.Windows.Forms.Label();
			this.traitConditionBox = new System.Windows.Forms.ComboBox();
			this.modifierListBox = new System.Windows.Forms.ListBox();
			this.addModifierButton = new System.Windows.Forms.Button();
			this.removeModifierButton = new System.Windows.Forms.Button();
			this.traitCampaignLabel = new System.Windows.Forms.Label();
			this.traitCampaignBox = new System.Windows.Forms.ComboBox();
			this.traitRaceBox = new System.Windows.Forms.ComboBox();
			this.traitRaceLabel = new System.Windows.Forms.Label();
			this.traitReligionBox = new System.Windows.Forms.ComboBox();
			this.traitReligionLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// traitListLabel
			// 
			this.traitListLabel.AutoSize = true;
			this.traitListLabel.Location = new System.Drawing.Point(12, 31);
			this.traitListLabel.Name = "traitListLabel";
			this.traitListLabel.Size = new System.Drawing.Size(50, 13);
			this.traitListLabel.TabIndex = 0;
			this.traitListLabel.Text = "Trait List:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(447, 24);
			this.menuStrip1.TabIndex = 1;
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
			// traitBox
			// 
			this.traitBox.FormattingEnabled = true;
			this.traitBox.Location = new System.Drawing.Point(122, 28);
			this.traitBox.Name = "traitBox";
			this.traitBox.Size = new System.Drawing.Size(313, 21);
			this.traitBox.TabIndex = 2;
			this.traitBox.SelectedIndexChanged += new System.EventHandler(this.traitListBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Trait Name:";
			// 
			// traitNameBox
			// 
			this.traitNameBox.Location = new System.Drawing.Point(122, 81);
			this.traitNameBox.Name = "traitNameBox";
			this.traitNameBox.Size = new System.Drawing.Size(313, 20);
			this.traitNameBox.TabIndex = 4;
			// 
			// traitTypeLabel
			// 
			this.traitTypeLabel.AutoSize = true;
			this.traitTypeLabel.Location = new System.Drawing.Point(12, 110);
			this.traitTypeLabel.Name = "traitTypeLabel";
			this.traitTypeLabel.Size = new System.Drawing.Size(58, 13);
			this.traitTypeLabel.TabIndex = 5;
			this.traitTypeLabel.Text = "Trait Type:";
			// 
			// traitTypeBox
			// 
			this.traitTypeBox.FormattingEnabled = true;
			this.traitTypeBox.Location = new System.Drawing.Point(122, 107);
			this.traitTypeBox.Name = "traitTypeBox";
			this.traitTypeBox.Size = new System.Drawing.Size(313, 21);
			this.traitTypeBox.TabIndex = 6;
			this.traitTypeBox.SelectedIndexChanged += new System.EventHandler(this.traitTypeBox_SelectedIndexChanged);
			// 
			// traitDescriptionLabel
			// 
			this.traitDescriptionLabel.AutoSize = true;
			this.traitDescriptionLabel.Location = new System.Drawing.Point(12, 137);
			this.traitDescriptionLabel.Name = "traitDescriptionLabel";
			this.traitDescriptionLabel.Size = new System.Drawing.Size(87, 13);
			this.traitDescriptionLabel.TabIndex = 7;
			this.traitDescriptionLabel.Text = "Trait Description:";
			// 
			// traitDescriptionBox
			// 
			this.traitDescriptionBox.Location = new System.Drawing.Point(122, 134);
			this.traitDescriptionBox.Name = "traitDescriptionBox";
			this.traitDescriptionBox.Size = new System.Drawing.Size(313, 20);
			this.traitDescriptionBox.TabIndex = 8;
			// 
			// addTraitButton
			// 
			this.addTraitButton.Location = new System.Drawing.Point(259, 407);
			this.addTraitButton.Name = "addTraitButton";
			this.addTraitButton.Size = new System.Drawing.Size(85, 27);
			this.addTraitButton.TabIndex = 9;
			this.addTraitButton.Text = "Add Trait";
			this.addTraitButton.UseVisualStyleBackColor = true;
			this.addTraitButton.Click += new System.EventHandler(this.addTraitButton_Click);
			// 
			// removeTraitButton
			// 
			this.removeTraitButton.Location = new System.Drawing.Point(350, 407);
			this.removeTraitButton.Name = "removeTraitButton";
			this.removeTraitButton.Size = new System.Drawing.Size(85, 27);
			this.removeTraitButton.TabIndex = 10;
			this.removeTraitButton.Text = "Remove Trait";
			this.removeTraitButton.UseVisualStyleBackColor = true;
			this.removeTraitButton.Click += new System.EventHandler(this.removeTraitButton_Click);
			// 
			// traitRegionLabel
			// 
			this.traitRegionLabel.AutoSize = true;
			this.traitRegionLabel.Location = new System.Drawing.Point(12, 163);
			this.traitRegionLabel.Name = "traitRegionLabel";
			this.traitRegionLabel.Size = new System.Drawing.Size(77, 13);
			this.traitRegionLabel.TabIndex = 11;
			this.traitRegionLabel.Text = "Select Region:";
			// 
			// traitRegionBox
			// 
			this.traitRegionBox.FormattingEnabled = true;
			this.traitRegionBox.Location = new System.Drawing.Point(122, 160);
			this.traitRegionBox.Name = "traitRegionBox";
			this.traitRegionBox.Size = new System.Drawing.Size(313, 21);
			this.traitRegionBox.TabIndex = 12;
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(12, 58);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(19, 13);
			this.idLabel.TabIndex = 13;
			this.idLabel.Text = "Id:";
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(122, 55);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(313, 20);
			this.idBox.TabIndex = 14;
			// 
			// traitModifierLabel
			// 
			this.traitModifierLabel.AutoSize = true;
			this.traitModifierLabel.Location = new System.Drawing.Point(12, 268);
			this.traitModifierLabel.Name = "traitModifierLabel";
			this.traitModifierLabel.Size = new System.Drawing.Size(47, 13);
			this.traitModifierLabel.TabIndex = 15;
			this.traitModifierLabel.Text = "Modifier:";
			// 
			// traitConditionLabel
			// 
			this.traitConditionLabel.AutoSize = true;
			this.traitConditionLabel.Location = new System.Drawing.Point(12, 372);
			this.traitConditionLabel.Name = "traitConditionLabel";
			this.traitConditionLabel.Size = new System.Drawing.Size(54, 13);
			this.traitConditionLabel.TabIndex = 17;
			this.traitConditionLabel.Text = "Condition:";
			// 
			// traitConditionBox
			// 
			this.traitConditionBox.FormattingEnabled = true;
			this.traitConditionBox.Location = new System.Drawing.Point(122, 369);
			this.traitConditionBox.Name = "traitConditionBox";
			this.traitConditionBox.Size = new System.Drawing.Size(313, 21);
			this.traitConditionBox.TabIndex = 18;
			// 
			// modifierListBox
			// 
			this.modifierListBox.FormattingEnabled = true;
			this.modifierListBox.Location = new System.Drawing.Point(122, 268);
			this.modifierListBox.Name = "modifierListBox";
			this.modifierListBox.Size = new System.Drawing.Size(313, 95);
			this.modifierListBox.TabIndex = 19;
			// 
			// addModifierButton
			// 
			this.addModifierButton.Location = new System.Drawing.Point(15, 284);
			this.addModifierButton.Name = "addModifierButton";
			this.addModifierButton.Size = new System.Drawing.Size(30, 23);
			this.addModifierButton.TabIndex = 20;
			this.addModifierButton.Text = "+";
			this.addModifierButton.UseVisualStyleBackColor = true;
			this.addModifierButton.Click += new System.EventHandler(this.addModifierButton_Click);
			// 
			// removeModifierButton
			// 
			this.removeModifierButton.Location = new System.Drawing.Point(51, 284);
			this.removeModifierButton.Name = "removeModifierButton";
			this.removeModifierButton.Size = new System.Drawing.Size(30, 23);
			this.removeModifierButton.TabIndex = 21;
			this.removeModifierButton.Text = "-";
			this.removeModifierButton.UseVisualStyleBackColor = true;
			this.removeModifierButton.Click += new System.EventHandler(this.removeModifierButton_Click);
			// 
			// traitCampaignLabel
			// 
			this.traitCampaignLabel.AutoSize = true;
			this.traitCampaignLabel.Location = new System.Drawing.Point(12, 190);
			this.traitCampaignLabel.Name = "traitCampaignLabel";
			this.traitCampaignLabel.Size = new System.Drawing.Size(90, 13);
			this.traitCampaignLabel.TabIndex = 22;
			this.traitCampaignLabel.Text = "Select Campaign:";
			// 
			// traitCampaignBox
			// 
			this.traitCampaignBox.FormattingEnabled = true;
			this.traitCampaignBox.Location = new System.Drawing.Point(122, 187);
			this.traitCampaignBox.Name = "traitCampaignBox";
			this.traitCampaignBox.Size = new System.Drawing.Size(313, 21);
			this.traitCampaignBox.TabIndex = 23;
			// 
			// traitRaceBox
			// 
			this.traitRaceBox.FormattingEnabled = true;
			this.traitRaceBox.Location = new System.Drawing.Point(122, 214);
			this.traitRaceBox.Name = "traitRaceBox";
			this.traitRaceBox.Size = new System.Drawing.Size(313, 21);
			this.traitRaceBox.TabIndex = 24;
			// 
			// traitRaceLabel
			// 
			this.traitRaceLabel.AutoSize = true;
			this.traitRaceLabel.Location = new System.Drawing.Point(12, 217);
			this.traitRaceLabel.Name = "traitRaceLabel";
			this.traitRaceLabel.Size = new System.Drawing.Size(69, 13);
			this.traitRaceLabel.TabIndex = 25;
			this.traitRaceLabel.Text = "Select Race:";
			// 
			// traitReligionBox
			// 
			this.traitReligionBox.FormattingEnabled = true;
			this.traitReligionBox.Location = new System.Drawing.Point(122, 241);
			this.traitReligionBox.Name = "traitReligionBox";
			this.traitReligionBox.Size = new System.Drawing.Size(313, 21);
			this.traitReligionBox.TabIndex = 26;
			// 
			// traitReligionLabel
			// 
			this.traitReligionLabel.AutoSize = true;
			this.traitReligionLabel.Location = new System.Drawing.Point(12, 244);
			this.traitReligionLabel.Name = "traitReligionLabel";
			this.traitReligionLabel.Size = new System.Drawing.Size(81, 13);
			this.traitReligionLabel.TabIndex = 27;
			this.traitReligionLabel.Text = "Select Religion:";
			// 
			// PathfinderTraitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 450);
			this.Controls.Add(this.traitReligionLabel);
			this.Controls.Add(this.traitReligionBox);
			this.Controls.Add(this.traitRaceLabel);
			this.Controls.Add(this.traitRaceBox);
			this.Controls.Add(this.traitCampaignBox);
			this.Controls.Add(this.traitCampaignLabel);
			this.Controls.Add(this.removeModifierButton);
			this.Controls.Add(this.addModifierButton);
			this.Controls.Add(this.modifierListBox);
			this.Controls.Add(this.traitConditionBox);
			this.Controls.Add(this.traitConditionLabel);
			this.Controls.Add(this.traitModifierLabel);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.traitRegionBox);
			this.Controls.Add(this.traitRegionLabel);
			this.Controls.Add(this.removeTraitButton);
			this.Controls.Add(this.addTraitButton);
			this.Controls.Add(this.traitDescriptionBox);
			this.Controls.Add(this.traitDescriptionLabel);
			this.Controls.Add(this.traitTypeBox);
			this.Controls.Add(this.traitTypeLabel);
			this.Controls.Add(this.traitNameBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.traitBox);
			this.Controls.Add(this.traitListLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderTraitForm";
			this.Text = "PathfinderTraitForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label traitListLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ComboBox traitBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox traitNameBox;
		private System.Windows.Forms.Label traitTypeLabel;
		private System.Windows.Forms.ComboBox traitTypeBox;
		private System.Windows.Forms.Label traitDescriptionLabel;
		private System.Windows.Forms.TextBox traitDescriptionBox;
		private System.Windows.Forms.Button addTraitButton;
		private System.Windows.Forms.Button removeTraitButton;
		private System.Windows.Forms.Label traitRegionLabel;
		private System.Windows.Forms.ComboBox traitRegionBox;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox idBox;
		private System.Windows.Forms.Label traitModifierLabel;
		private System.Windows.Forms.Label traitConditionLabel;
		private System.Windows.Forms.ComboBox traitConditionBox;
		private System.Windows.Forms.ListBox modifierListBox;
		private System.Windows.Forms.Button addModifierButton;
		private System.Windows.Forms.Button removeModifierButton;
		private System.Windows.Forms.Label traitCampaignLabel;
		private System.Windows.Forms.ComboBox traitCampaignBox;
		private System.Windows.Forms.ComboBox traitRaceBox;
		private System.Windows.Forms.Label traitRaceLabel;
		private System.Windows.Forms.ComboBox traitReligionBox;
		private System.Windows.Forms.Label traitReligionLabel;
	}
}