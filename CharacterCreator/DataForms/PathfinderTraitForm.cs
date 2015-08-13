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
using CharacterCreator.Data;

namespace CharacterCreator.DataForms
{
	public partial class PathfinderTraitForm : Form
	{
		private string savePath = @"C:\Projects\Pathfinder\CharacterCreator\CharacterCreator\Data\XmlData\Traits.xml";

		private BindingList<TraitData> traitList = new BindingList<TraitData>();
		private TraitData traitData = null;
		public PathfinderTraitForm()
		{
			InitializeComponent();
			this.traitList = CharacterCreator.Helpers.FileIO.Load<BindingList<TraitData>>(this.savePath);
			this.traitBox.DataSource = this.traitList;
			this.traitBox.DisplayMember = "TraitName";
			this.traitBox.ValueMember = "TraitName";
		}

		private void SetUpBindings()
		{

		}

		private void SaveTraitData()
		{

		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveTraitData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<TraitData>>(this.traitList, this.savePath);
		}

		private void traitListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.traitData = (TraitData)this.traitBox.SelectedItem;
			this.SetUpBindings();
		}

		private void addTraitButton_Click(object sender, EventArgs e)
		{
			this.SaveTraitData();
			this.traitList.Add(this.traitData);
			this.traitBox.SelectedIndex = this.traitList.Count - 1;
		}

		private void removeTraitButton_Click(object sender, EventArgs e)
		{
			this.traitList.Remove(this.traitData);
			this.traitData = null;
			this.traitBox.SelectedIndex = this.traitBox.SelectedIndex == 0 ? 0 : this.traitBox.SelectedIndex - 1;
		}
	}
}
