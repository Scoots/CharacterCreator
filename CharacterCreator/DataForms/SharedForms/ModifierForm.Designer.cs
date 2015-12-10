namespace CharacterCreator.DataForms.SharedForms
{
	partial class ModifierForm
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
			this.submitButton = new System.Windows.Forms.Button();
			this.modifierListBox = new System.Windows.Forms.ComboBox();
			this.modifierLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(232, 39);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(75, 23);
			this.submitButton.TabIndex = 0;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// modifierListBox
			// 
			this.modifierListBox.FormattingEnabled = true;
			this.modifierListBox.Location = new System.Drawing.Point(65, 12);
			this.modifierListBox.Name = "modifierListBox";
			this.modifierListBox.Size = new System.Drawing.Size(242, 21);
			this.modifierListBox.TabIndex = 1;
			// 
			// modifierLabel
			// 
			this.modifierLabel.AutoSize = true;
			this.modifierLabel.Location = new System.Drawing.Point(12, 15);
			this.modifierLabel.Name = "modifierLabel";
			this.modifierLabel.Size = new System.Drawing.Size(47, 13);
			this.modifierLabel.TabIndex = 2;
			this.modifierLabel.Text = "Modifier:";
			// 
			// ModifierForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 70);
			this.Controls.Add(this.modifierLabel);
			this.Controls.Add(this.modifierListBox);
			this.Controls.Add(this.submitButton);
			this.Name = "ModifierForm";
			this.Text = "Modifier Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.ComboBox modifierListBox;
		private System.Windows.Forms.Label modifierLabel;
	}
}