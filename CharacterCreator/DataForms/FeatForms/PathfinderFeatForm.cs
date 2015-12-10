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
using CharacterCreator.DataForms.TraitForms;
using CharacterCreator.DataForms.SharedForms;
using CharacterCreator.Containers;

namespace CharacterCreator.DataForms.FeatForms
{
	public partial class PathfinderFeatForm : Form
	{
		private string savePath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Feats.xml";
		private string modifierLoadPath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Modifiers.xml";

		private BindingList<ModifierData> loadedModifierList = new BindingList<ModifierData>();
		private BindingList<FeatData> featList = new BindingList<FeatData>();
		private FeatData featData = null;

		private List<FeatTypes> featTypeList = new List<FeatTypes>();
		private List<IdName> modifierList = new List<IdName>();

		private string currentFeatId = null;

		public PathfinderFeatForm()
		{
			InitializeComponent();

			this.loadedModifierList = CharacterCreator.Helpers.FileIO.Load<BindingList<ModifierData>>(this.modifierLoadPath);

			this.featList = CharacterCreator.Helpers.FileIO.Load<BindingList<FeatData>>(this.savePath);
			this.featListBox.DataSource = this.featList;
			this.featListBox.DisplayMember = "FeatName";
			this.featListBox.ValueMember = "FeatName";
		}

		private void SetUpBindings()
		{
			// Set up bindings
		}

		private void SaveFeatData()
		{
			// Save all the data here
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveFeatData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<FeatData>>(this.featList, this.savePath);
		}

		private void featListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.currentFeatId == ((FeatData)this.featListBox.SelectedItem).Id)
			{
				return;
			}

			this.featData = (FeatData)this.featListBox.SelectedItem;
			this.currentFeatId = this.featData.Id;
			this.SetUpBindings();
		}

		private void addFeatButton_Click(object sender, EventArgs e)
		{
			this.SaveFeatData();

			this.featData = new FeatData();
			this.featList.Add(this.featData);
			this.featListBox.SelectedIndex = this.featList.Count - 1;
		}

		private void removeFeatButton_Click(object sender, EventArgs e)
		{
			this.featList.Remove(this.featData);
			this.featData = null;
			this.featListBox.SelectedIndex = this.featListBox.SelectedIndex == 0 ? 0 : this.featListBox.SelectedIndex - 1;
		}

		private void addFeatTypeButton_Click(object sender, EventArgs e)
		{
			FeatTypeForm ftf = new FeatTypeForm();
			ftf.StartPosition = FormStartPosition.CenterParent;
			ftf.ShowDialog(this);

			this.featTypeList.Add(ftf.FeatType);
			this.featTypeBox.DataSource = null;
			this.featTypeBox.DataSource = this.featTypeList;
		}

		private void removeFeatTypeButton_Click(object sender, EventArgs e)
		{
			this.featTypeList.Remove((FeatTypes)this.featTypeBox.SelectedValue);
			this.featTypeBox.DataSource = null;
			this.featTypeBox.DataSource = this.featTypeList;
		}

		private void addModifierButton_Click(object sender, EventArgs e)
		{
			ModifierForm tmf = new ModifierForm();
			tmf.StartPosition = FormStartPosition.CenterParent;
			tmf.ShowDialog(this);

			this.modifierList.Add(new IdName(tmf.ObjectId, tmf.ObjectName));
			this.modifierListBox.DataSource = null;
			this.modifierListBox.DataSource = this.modifierList;
		}

		private void removeModifierButton_Click(object sender, EventArgs e)
		{
			this.modifierList.Remove((IdName)this.modifierListBox.SelectedValue);
			this.modifierListBox.DataSource = null;
			this.modifierListBox.DataSource = this.modifierList;
		}

		private void addPrerequisiteButton_Click(object sender, EventArgs e)
		{
			// Prereqs can be a number of things
			// Feat, stat, race, bab, class level
			// number of feats (3 teamwork feats, 5 metamagic, etc)
			// can have OR, might need to set up multiple prereq things
			// So the sub page will have a list, each of the ones in the list MUST be met
			// But the main page will have a list of those lists, and ANY of those can be met, not necessarily all
		}

		private void removePrerequisiteButton_Click(object sender, EventArgs e)
		{
			
		}
	}
}
