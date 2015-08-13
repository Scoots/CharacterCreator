namespace CharacterCreator.DataForms
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.traitDescriptionLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.addTraitButton = new System.Windows.Forms.Button();
			this.removeTraitButton = new System.Windows.Forms.Button();
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
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Trait Name:";
			// 
			// traitNameBox
			// 
			this.traitNameBox.Location = new System.Drawing.Point(122, 54);
			this.traitNameBox.Name = "traitNameBox";
			this.traitNameBox.Size = new System.Drawing.Size(313, 20);
			this.traitNameBox.TabIndex = 4;
			// 
			// traitTypeLabel
			// 
			this.traitTypeLabel.AutoSize = true;
			this.traitTypeLabel.Location = new System.Drawing.Point(12, 82);
			this.traitTypeLabel.Name = "traitTypeLabel";
			this.traitTypeLabel.Size = new System.Drawing.Size(58, 13);
			this.traitTypeLabel.TabIndex = 5;
			this.traitTypeLabel.Text = "Trait Type:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(122, 79);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(313, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// traitDescriptionLabel
			// 
			this.traitDescriptionLabel.AutoSize = true;
			this.traitDescriptionLabel.Location = new System.Drawing.Point(12, 107);
			this.traitDescriptionLabel.Name = "traitDescriptionLabel";
			this.traitDescriptionLabel.Size = new System.Drawing.Size(87, 13);
			this.traitDescriptionLabel.TabIndex = 7;
			this.traitDescriptionLabel.Text = "Trait Description:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(122, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(313, 20);
			this.textBox1.TabIndex = 8;
			// 
			// addTraitButton
			// 
			this.addTraitButton.Location = new System.Drawing.Point(257, 166);
			this.addTraitButton.Name = "addTraitButton";
			this.addTraitButton.Size = new System.Drawing.Size(85, 27);
			this.addTraitButton.TabIndex = 9;
			this.addTraitButton.Text = "Add Trait";
			this.addTraitButton.UseVisualStyleBackColor = true;
			this.addTraitButton.Click += new System.EventHandler(this.addTraitButton_Click);
			// 
			// removeTraitButton
			// 
			this.removeTraitButton.Location = new System.Drawing.Point(350, 166);
			this.removeTraitButton.Name = "removeTraitButton";
			this.removeTraitButton.Size = new System.Drawing.Size(85, 27);
			this.removeTraitButton.TabIndex = 10;
			this.removeTraitButton.Text = "Remove Trait";
			this.removeTraitButton.UseVisualStyleBackColor = true;
			this.removeTraitButton.Click += new System.EventHandler(this.removeTraitButton_Click);
			// 
			// PathfinderTraitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 205);
			this.Controls.Add(this.removeTraitButton);
			this.Controls.Add(this.addTraitButton);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.traitDescriptionLabel);
			this.Controls.Add(this.comboBox1);
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
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label traitDescriptionLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button addTraitButton;
		private System.Windows.Forms.Button removeTraitButton;
	}
}