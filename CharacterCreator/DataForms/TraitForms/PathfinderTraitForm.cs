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

namespace CharacterCreator.DataForms.TraitForms
{
	public partial class PathfinderTraitForm : Form
	{
		private string savePath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Traits.xml";
		private string modifierLoadPath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Modifiers.xml";
		private BindingList<ModifierData> loadedModifierList = new BindingList<ModifierData>();

		private BindingList<TraitData> traitList = new BindingList<TraitData>();
		private TraitData traitData = null;
		private List<IdName> modifierList = new List<IdName>();

		private string currentTraitId = null;

		public PathfinderTraitForm()
		{
			InitializeComponent();

			this.loadedModifierList = CharacterCreator.Helpers.FileIO.Load<BindingList<ModifierData>>(this.modifierLoadPath);

			this.traitList = CharacterCreator.Helpers.FileIO.Load<BindingList<TraitData>>(this.savePath);
			this.traitBox.DataSource = this.traitList;
			this.traitBox.DisplayMember = "TraitName";
			this.traitBox.ValueMember = "TraitName";

			this.traitTypeBox.DataSource = TraitType.GetValues(typeof(TraitType));
			this.traitRegionBox.DataSource = RegionNames.GetValues(typeof(RegionNames));
			this.traitCampaignBox.DataSource = CampaignNames.GetValues(typeof(CampaignNames));
			this.traitRaceBox.DataSource = RaceNames.GetValues(typeof(RaceNames));
			this.traitReligionBox.DataSource = ReligionNames.GetValues(typeof(ReligionNames));
			this.traitConditionBox.DataSource = ConditionalStates.GetValues(typeof(ConditionalStates));
			
		}

		private void SetUpBindings()
		{
			// Immutable
			this.idBox.Text = this.traitData.Id;

			this.traitNameBox.DataBindings.Clear();
			this.traitDescriptionBox.DataBindings.Clear();
			this.traitTypeBox.DataBindings.Clear();
			this.traitRegionBox.DataBindings.Clear();
			this.traitCampaignBox.DataBindings.Clear();
			this.traitRaceBox.DataBindings.Clear();
			this.traitReligionBox.DataBindings.Clear();

			this.traitNameBox.DataBindings.Add("Text", this.traitData, "TraitName");
			this.traitDescriptionBox.DataBindings.Add("Text", this.traitData, "TraitDescription");
			this.traitTypeBox.DataBindings.Add("SelectedItem", this.traitData, "TraitType");
			this.traitRegionBox.DataBindings.Add("SelectedItem", this.traitData, "RegionName");
			this.traitCampaignBox.DataBindings.Add("SelectedItem", this.traitData, "CampaignName");
			this.traitRaceBox.DataBindings.Add("SelectedItem", this.traitData, "RaceName");
			this.traitReligionBox.DataBindings.Add("SelectedItem", this.traitData, "ReligionName");

			this.traitRegionBox.Enabled = false;
			this.traitCampaignBox.Enabled = false;
			this.traitRaceBox.Enabled = false;
			this.traitReligionBox.Enabled = false;
			switch(this.traitData.TraitType)
			{
				case TraitType.Regional:
					this.traitRegionBox.Enabled = true;
					break;
				case TraitType.Campaign:
					this.traitCampaignBox.Enabled = true;
					break;
				case TraitType.Race:
					this.traitRaceBox.Enabled = true;
					break;
				case TraitType.Religion:
					this.traitReligionBox.Enabled = true;
					break;
				default:
					break;
			}

			this.modifierList = new List<IdName>();
			foreach(string id in this.traitData.ModifierIdList)
			{
				ModifierData modifierData = this.loadedModifierList.Single(s => s.Id == id);
				this.modifierList.Add(new IdName(modifierData.Id, modifierData.ModifierName));
			}
			this.modifierListBox.DataSource = null;
			this.modifierListBox.DataSource = this.modifierList;
		}

		private void SaveTraitData()
		{
			TraitType traitType;
			Enum.TryParse<TraitType>(this.traitTypeBox.SelectedValue.ToString(), out traitType);
			this.traitData.TraitName = this.traitNameBox.Text;
			this.traitData.TraitDescription = this.traitDescriptionBox.Text;
			this.traitData.TraitType = traitType;
			this.traitData.Id = this.idBox.Text;

			this.traitData.ModifierIdList = new List<string>();
			foreach (IdName idName in this.modifierList)
			{
				this.traitData.ModifierIdList.Add(idName.ObjectId);
			}

			RegionNames region;
			Enum.TryParse<RegionNames>(this.traitRegionBox.SelectedValue.ToString(), out region);
			this.traitData.RegionName = region;

			CampaignNames campaign;
			Enum.TryParse<CampaignNames>(this.traitCampaignBox.SelectedValue.ToString(), out campaign);
			this.traitData.CampaignName = campaign;

			RaceNames race;
			Enum.TryParse<RaceNames>(this.traitRaceBox.SelectedValue.ToString(), out race);
			this.traitData.RaceName = race;

			ReligionNames religion;
			Enum.TryParse<ReligionNames>(this.traitReligionBox.SelectedValue.ToString(), out religion);
			this.traitData.ReligionName = religion;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveTraitData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<TraitData>>(this.traitList, this.savePath);
		}

		private void traitListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.currentTraitId == ((TraitData)this.traitBox.SelectedItem).Id)
			{
				return;
			}

			this.traitData = (TraitData)this.traitBox.SelectedItem;
			this.currentTraitId = this.traitData.Id;
			this.SetUpBindings();
		}

		private void addTraitButton_Click(object sender, EventArgs e)
		{
			this.SaveTraitData();

			this.traitData = new TraitData();
			this.traitList.Add(this.traitData);
			this.traitBox.SelectedIndex = this.traitList.Count - 1;
		}

		private void removeTraitButton_Click(object sender, EventArgs e)
		{
			this.traitList.Remove(this.traitData);
			this.traitData = null;
			this.traitBox.SelectedIndex = this.traitBox.SelectedIndex == 0 ? 0 : this.traitBox.SelectedIndex - 1;
		}

		private void traitTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			TraitType traitType;
			Enum.TryParse<TraitType>(this.traitTypeBox.SelectedValue.ToString(), out traitType);

			this.traitRegionBox.Enabled = false;
			this.traitCampaignBox.Enabled = false;
			this.traitRaceBox.Enabled = false;
			this.traitReligionBox.Enabled = false;
			switch (this.traitData.TraitType)
			{
				case TraitType.Regional:
					this.traitRegionBox.Enabled = true;
					break;
				case TraitType.Campaign:
					this.traitCampaignBox.Enabled = true;
					break;
				case TraitType.Race:
					this.traitRaceBox.Enabled = true;
					break;
				case TraitType.Religion:
					this.traitReligionBox.Enabled = true;
					break;
				default:
					break;
			}
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
	}
}
