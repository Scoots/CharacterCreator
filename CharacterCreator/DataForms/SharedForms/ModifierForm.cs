using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.Data;

namespace CharacterCreator.DataForms.SharedForms
{
	public partial class ModifierForm : Form
	{
		private string loadPath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Modifiers.xml";
		private BindingList<ModifierData> modifierList = new BindingList<ModifierData>();

		public string ObjectId { get; set; }
		public string ObjectName { get; set; }

		public ModifierForm()
		{
			InitializeComponent();
			this.modifierList = CharacterCreator.Helpers.FileIO.Load<BindingList<ModifierData>>(this.loadPath);
			this.modifierListBox.DataSource = this.modifierList;
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			ModifierData md = (ModifierData)this.modifierListBox.SelectedItem;
			this.ObjectId = md.Id;
			this.ObjectName = md.ModifierName;
			this.Close();
		}
	}
}
