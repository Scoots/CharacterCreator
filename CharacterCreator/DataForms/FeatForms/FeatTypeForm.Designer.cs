namespace CharacterCreator.DataForms.FeatForms
{
	partial class FeatTypeForm
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
			this.featTypeBox = new System.Windows.Forms.ComboBox();
			this.featTypeLabel = new System.Windows.Forms.Label();
			this.featSubmitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// featTypeBox
			// 
			this.featTypeBox.FormattingEnabled = true;
			this.featTypeBox.Location = new System.Drawing.Point(87, 12);
			this.featTypeBox.Name = "featTypeBox";
			this.featTypeBox.Size = new System.Drawing.Size(242, 21);
			this.featTypeBox.TabIndex = 0;
			// 
			// featTypeLabel
			// 
			this.featTypeLabel.AutoSize = true;
			this.featTypeLabel.Location = new System.Drawing.Point(12, 15);
			this.featTypeLabel.Name = "featTypeLabel";
			this.featTypeLabel.Size = new System.Drawing.Size(58, 13);
			this.featTypeLabel.TabIndex = 1;
			this.featTypeLabel.Text = "Feat Type:";
			// 
			// featSubmitButton
			// 
			this.featSubmitButton.Location = new System.Drawing.Point(254, 39);
			this.featSubmitButton.Name = "featSubmitButton";
			this.featSubmitButton.Size = new System.Drawing.Size(75, 23);
			this.featSubmitButton.TabIndex = 2;
			this.featSubmitButton.Text = "Submit";
			this.featSubmitButton.UseVisualStyleBackColor = true;
			this.featSubmitButton.Click += new System.EventHandler(this.featSubmitButton_Click);
			// 
			// FeatTypeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(341, 68);
			this.Controls.Add(this.featSubmitButton);
			this.Controls.Add(this.featTypeLabel);
			this.Controls.Add(this.featTypeBox);
			this.Name = "FeatTypeForm";
			this.Text = "Feat Type Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox featTypeBox;
		private System.Windows.Forms.Label featTypeLabel;
		private System.Windows.Forms.Button featSubmitButton;
	}
}