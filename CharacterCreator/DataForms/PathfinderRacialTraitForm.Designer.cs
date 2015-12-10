namespace CharacterCreator.DataForms
{
	partial class PathfinderRacialTraitForm
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
			this.racialTraitLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.racialTraitListBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.racialTraitNameBox = new System.Windows.Forms.TextBox();
			this.racialTraitDescriptionLabel = new System.Windows.Forms.Label();
			this.racialTrait = new System.Windows.Forms.TextBox();
			this.rpCostLabel = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// racialTraitLabel
			// 
			this.racialTraitLabel.AutoSize = true;
			this.racialTraitLabel.Location = new System.Drawing.Point(12, 30);
			this.racialTraitLabel.Name = "racialTraitLabel";
			this.racialTraitLabel.Size = new System.Drawing.Size(83, 13);
			this.racialTraitLabel.TabIndex = 0;
			this.racialTraitLabel.Text = "Racial Trait List:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(499, 24);
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
			// 
			// racialTraitListBox
			// 
			this.racialTraitListBox.FormattingEnabled = true;
			this.racialTraitListBox.Location = new System.Drawing.Point(147, 27);
			this.racialTraitListBox.Name = "racialTraitListBox";
			this.racialTraitListBox.Size = new System.Drawing.Size(340, 21);
			this.racialTraitListBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Racial Trait Name:";
			// 
			// racialTraitNameBox
			// 
			this.racialTraitNameBox.Location = new System.Drawing.Point(147, 54);
			this.racialTraitNameBox.Name = "racialTraitNameBox";
			this.racialTraitNameBox.Size = new System.Drawing.Size(340, 20);
			this.racialTraitNameBox.TabIndex = 4;
			// 
			// racialTraitDescriptionLabel
			// 
			this.racialTraitDescriptionLabel.AutoSize = true;
			this.racialTraitDescriptionLabel.Location = new System.Drawing.Point(12, 83);
			this.racialTraitDescriptionLabel.Name = "racialTraitDescriptionLabel";
			this.racialTraitDescriptionLabel.Size = new System.Drawing.Size(120, 13);
			this.racialTraitDescriptionLabel.TabIndex = 5;
			this.racialTraitDescriptionLabel.Text = "Raical Trait Description:";
			// 
			// racialTrait
			// 
			this.racialTrait.Location = new System.Drawing.Point(147, 80);
			this.racialTrait.Name = "racialTrait";
			this.racialTrait.Size = new System.Drawing.Size(340, 20);
			this.racialTrait.TabIndex = 6;
			// 
			// rpCostLabel
			// 
			this.rpCostLabel.AutoSize = true;
			this.rpCostLabel.Location = new System.Drawing.Point(12, 108);
			this.rpCostLabel.Name = "rpCostLabel";
			this.rpCostLabel.Size = new System.Drawing.Size(49, 13);
			this.rpCostLabel.TabIndex = 7;
			this.rpCostLabel.Text = "RP Cost:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(147, 106);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 8;
			// 
			// PathfinderRacialTraitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 139);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.rpCostLabel);
			this.Controls.Add(this.racialTrait);
			this.Controls.Add(this.racialTraitDescriptionLabel);
			this.Controls.Add(this.racialTraitNameBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.racialTraitListBox);
			this.Controls.Add(this.racialTraitLabel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PathfinderRacialTraitForm";
			this.Text = "PathfinderRacialTraitForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label racialTraitLabel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ComboBox racialTraitListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox racialTraitNameBox;
		private System.Windows.Forms.Label racialTraitDescriptionLabel;
		private System.Windows.Forms.TextBox racialTrait;
		private System.Windows.Forms.Label rpCostLabel;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}