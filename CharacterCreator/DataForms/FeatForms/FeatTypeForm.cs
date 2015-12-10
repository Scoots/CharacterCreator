using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.Enumerations;

namespace CharacterCreator.DataForms.FeatForms
{
	public partial class FeatTypeForm : Form
	{
		public FeatTypes FeatType { get; set; }

		public FeatTypeForm()
		{
			InitializeComponent();
			this.featTypeBox.DataSource = FeatTypes.GetValues(typeof(FeatTypes));
		}

		private void featSubmitButton_Click(object sender, EventArgs e)
		{
			FeatTypes ft;
			Enum.TryParse<FeatTypes>(this.featTypeBox.SelectedValue.ToString(), out ft);
			this.FeatType = ft;
			this.Close();
		}
	}
}
