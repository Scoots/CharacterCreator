namespace CharacterCreator.DataForms
{
	partial class PathfinderModifierForm
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
			this.modifierListLabel = new System.Windows.Forms.Label();
			this.modifierListBox = new System.Windows.Forms.ComboBox();
			this.modifierNameLabel = new System.Windows.Forms.Label();
			this.modifierNameBox = new System.Windows.Forms.TextBox();
			this.modifierDescriptionLabel = new System.Windows.Forms.Label();
			this.modifierDescriptionBox = new System.Windows.Forms.TextBox();
			this.modifyAbilityTypeLabel = new System.Windows.Forms.Label();
			this.modifyAbilityTypeBox = new System.Windows.Forms.ComboBox();
			this.modificationAmountBox = new System.Windows.Forms.NumericUpDown();
			this.modificationAmountLabel = new System.Windows.Forms.Label();
			this.bonusTypeLabel = new System.Windows.Forms.Label();
			this.bonusTypeBox = new System.Windows.Forms.ComboBox();
			this.addModifierButton = new System.Windows.Forms.Button();
			this.removeModifierButton = new System.Windows.Forms.Button();
			this.statisticLabel = new System.Windows.Forms.Label();
			this.statisticBox = new System.Windows.Forms.ComboBox();
			this.idLabel = new System.Windows.Forms.Label();
			this.idBox = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.modificationAmountBox)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(571, 24);
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
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// modifierListLabel
			// 
			this.modifierListLabel.AutoSize = true;
			this.modifierListLabel.Location = new System.Drawing.Point(12, 30);
			this.modifierListLabel.Name = "modifierListLabel";
			this.modifierListLabel.Size = new System.Drawing.Size(66, 13);
			this.modifierListLabel.TabIndex = 1;
			this.modifierListLabel.Text = "Modifier List:";
			// 
			// modifierListBox
			// 
			this.modifierListBox.FormattingEnabled = true;
			this.modifierListBox.Location = new System.Drawing.Point(119, 27);
			this.modifierListBox.Name = "modifierListBox";
			this.modifierListBox.Size = new System.Drawing.Size(440, 21);
			this.modifierListBox.TabIndex = 2;
			this.modifierListBox.SelectedIndexChanged += new System.EventHandler(this.modifierListBox_SelectedIndexChanged);
			// 
			// modifierNameLabel
			// 
			this.modifierNameLabel.AutoSize = true;
			this.modifierNameLabel.Location = new System.Drawing.Point(12, 83);
			this.modifierNameLabel.Name = "modifierNameLabel";
			this.modifierNameLabel.Size = new System.Drawing.Size(78, 13);
			this.modifierNameLabel.TabIndex = 3;
			this.modifierNameLabel.Text = "Modifier Name:";
			// 
			// modifierNameBox
			// 
			this.modifierNameBox.Location = new System.Drawing.Point(119, 80);
			this.modifierNameBox.Name = "modifierNameBox";
			this.modifierNameBox.Size = new System.Drawing.Size(440, 20);
			this.modifierNameBox.TabIndex = 4;
			// 
			// modifierDescriptionLabel
			// 
			this.modifierDescriptionLabel.AutoSize = true;
			this.modifierDescriptionLabel.Location = new System.Drawing.Point(12, 109);
			this.modifierDescriptionLabel.Name = "modifierDescriptionLabel";
			this.modifierDescriptionLabel.Size = new System.Drawing.Size(103, 13);
			this.modifierDescriptionLabel.TabIndex = 5;
			this.modifierDescriptionLabel.Text = "Modifier Description:";
			// 
			// modifierDescriptionBox
			// 
			this.modifierDescriptionBox.Location = new System.Drawing.Point(119, 106);
			this.modifierDescriptionBox.Name = "modifierDescriptionBox";
			this.modifierDescriptionBox.Size = new System.Drawing.Size(440, 20);
			this.modifierDescriptionBox.TabIndex = 6;
			// 
			// modifyAbilityTypeLabel
			// 
			this.modifyAbilityTypeLabel.AutoSize = true;
			this.modifyAbilityTypeLabel.Location = new System.Drawing.Point(12, 135);
			this.modifyAbilityTypeLabel.Name = "modifyAbilityTypeLabel";
			this.modifyAbilityTypeLabel.Size = new System.Drawing.Size(98, 13);
			this.modifyAbilityTypeLabel.TabIndex = 7;
			this.modifyAbilityTypeLabel.Text = "Modify Ability Type:";
			// 
			// modifyAbilityTypeBox
			// 
			this.modifyAbilityTypeBox.FormattingEnabled = true;
			this.modifyAbilityTypeBox.Location = new System.Drawing.Point(119, 132);
			this.modifyAbilityTypeBox.Name = "modifyAbilityTypeBox";
			this.modifyAbilityTypeBox.Size = new System.Drawing.Size(440, 21);
			this.modifyAbilityTypeBox.TabIndex = 8;
			this.modifyAbilityTypeBox.SelectedIndexChanged += new System.EventHandler(this.modifyAbilityTypeBox_SelectedIndexChanged);
			// 
			// modificationAmountBox
			// 
			this.modificationAmountBox.Location = new System.Drawing.Point(119, 159);
			this.modificationAmountBox.Name = "modificationAmountBox";
			this.modificationAmountBox.Size = new System.Drawing.Size(73, 20);
			this.modificationAmountBox.TabIndex = 9;
			// 
			// modificationAmountLabel
			// 
			this.modificationAmountLabel.AutoSize = true;
			this.modificationAmountLabel.Location = new System.Drawing.Point(12, 161);
			this.modificationAmountLabel.Name = "modificationAmountLabel";
			this.modificationAmountLabel.Size = new System.Drawing.Size(106, 13);
			this.modificationAmountLabel.TabIndex = 10;
			this.modificationAmountLabel.Text = "Modification Amount:";
			// 
			// bonusTypeLabel
			// 
			this.bonusTypeLabel.AutoSize = true;
			this.bonusTypeLabel.Location = new System.Drawing.Point(12, 188);
			this.bonusTypeLabel.Name = "bonusTypeLabel";
			this.bonusTypeLabel.Size = new System.Drawing.Size(67, 13);
			this.bonusTypeLabel.TabIndex = 11;
			this.bonusTypeLabel.Text = "Bonus Type:";
			// 
			// bonusTypeBox
			// 
			this.bonusTypeBox.FormattingEnabled = true;
			this.bonusTypeBox.Location = new System.Drawing.Point(119, 185);
			this.bonusTypeBox.Name = "bonusTypeBox";
			this.bonusTypeBox.Size = new System.Drawing.Size(440, 21);
			this.bonusTypeBox.TabIndex = 12;
			// 
			// addModifierButton
			// 
			this.addModifierButton.Location = new System.Drawing.Point(345, 239);
			this.addModifierButton.Name = "addModifierButton";
			this.addModifierButton.Size = new System.Drawing.Size(104, 31);
			this.addModifierButton.TabIndex = 13;
			this.addModifierButton.Text = "Add Modifier";
			this.addModifierButton.UseVisualStyleBackColor = true;
			this.addModifierButton.Click += new System.EventHandler(this.addModifierButton_Click);
			// 
			// removeModifierButton
			// 
			this.removeModifierButton.Location = new System.Drawing.Point(455, 239);
			this.removeModifierButton.Name = "removeModifierButton";
			this.removeModifierButton.Size = new System.Drawing.Size(104, 31);
			this.removeModifierButton.TabIndex = 14;
			this.removeModifierButton.Text = "Remove Modifier";
			this.removeModifierButton.UseVisualStyleBackColor = true;
			this.removeModifierButton.Click += new System.EventHandler(this.removeModifierButton_Click);
			// 
			// statisticLabel
			// 
			this.statisticLabel.AutoSize = true;
			this.statisticLabel.Location = new System.Drawing.Point(12, 215);
			this.statisticLabel.Name = "statisticLabel";
			this.statisticLabel.Size = new System.Drawing.Size(47, 13);
			this.statisticLabel.TabIndex = 15;
			this.statisticLabel.Text = "Statistic:";
			// 
			// statisticBox
			// 
			this.statisticBox.FormattingEnabled = true;
			this.statisticBox.Location = new System.Drawing.Point(119, 212);
			this.statisticBox.Name = "statisticBox";
			this.statisticBox.Size = new System.Drawing.Size(440, 21);
			this.statisticBox.TabIndex = 16;
			// 
			// idLabel
			// 
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(12, 57);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(19, 13);
			this.idLabel.TabIndex = 17;
			this.idLabel.Text = "Id:";
			// 
			// idBox
			// 
			this.idBox.Location = new System.Drawing.Point(119, 54);
			this.idBox.Name = "idBox";
			this.idBox.ReadOnly = true;
			this.idBox.Size = new System.Drawing.Size(440, 20);
			this.idBox.TabIndex = 18;
			// 
			// PathfinderModifierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 322);
			this.Controls.Add(this.idBox);
			this.Controls.Add(this.idLabel);
			this.Controls.Add(this.statisticBox);
			this.Controls.Add(this.statisticLabel);
			this.Controls.Add(this.removeModifierButton);
			this.Controls.Add(this.addModifierButton);
			this.Controls.Add(this.bonusTypeBox);
			this.Controls.Add(this.bonusTypeLabel);
			this.Controls.Add(this.modificationAmountLabel);
			this.Controls.Add(this.modificationAmountBox);
			this.Controls.Add(this.modifyAbilityTypeBox);
			this.Controls.Add(this.modifyAbilityTypeLabel);
			this.Controls.Add(this.modifierDescriptionBox);
			this.Controls.Add(this.modifierDescriptionLabel);
			this.Controls.Add(this.modifierNameBox);
			this.Controls.Add(this.modifierNameLabel);
			this.Controls.Add(this.modifierListBox);
			this.Controls.Add(this.modifierListLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderModifierForm";
			this.Text = "PathfinderModifierForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.modificationAmountBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Label modifierListLabel;
		private System.Windows.Forms.ComboBox modifierListBox;
		private System.Windows.Forms.Label modifierNameLabel;
		private System.Windows.Forms.TextBox modifierNameBox;
		private System.Windows.Forms.Label modifierDescriptionLabel;
		private System.Windows.Forms.TextBox modifierDescriptionBox;
		private System.Windows.Forms.Label modifyAbilityTypeLabel;
		private System.Windows.Forms.ComboBox modifyAbilityTypeBox;
		private System.Windows.Forms.NumericUpDown modificationAmountBox;
		private System.Windows.Forms.Label modificationAmountLabel;
		private System.Windows.Forms.Label bonusTypeLabel;
		private System.Windows.Forms.ComboBox bonusTypeBox;
		private System.Windows.Forms.Button addModifierButton;
		private System.Windows.Forms.Button removeModifierButton;
		private System.Windows.Forms.Label statisticLabel;
		private System.Windows.Forms.ComboBox statisticBox;
		private System.Windows.Forms.Label idLabel;
		private System.Windows.Forms.TextBox idBox;
	}
}