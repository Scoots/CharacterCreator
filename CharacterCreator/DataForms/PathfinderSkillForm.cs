﻿using System;
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
	public partial class PathfinderSkillForm : Form
	{
		private string savePath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Skills.xml";

		private BindingList<SkillData> skillList = new BindingList<SkillData>();
		private SkillData skillData = null;

		public PathfinderSkillForm()
		{
			InitializeComponent();
			this.skillList = CharacterCreator.Helpers.FileIO.Load<BindingList<SkillData>>(this.savePath);
			this.skillsBox.DataSource = this.skillList;
			this.skillsBox.DisplayMember = "SkillName";
			this.skillsBox.ValueMember = "SkillName";

			this.statBox.DataSource = StatType.GetValues(typeof(StatType));
		}

		private void SetUpBindings()
		{
			this.skillNameBox.DataBindings.Clear();
			this.skillDescriptionBox.DataBindings.Clear();
			this.statBox.DataBindings.Clear();

			this.skillNameBox.DataBindings.Add("Text", this.skillData, "SkillName");
			this.skillDescriptionBox.DataBindings.Add("Text", this.skillData, "SkillDescription");
			this.statBox.DataBindings.Add("SelectedItem", this.skillData, "SkillStat", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		// This is necessary, even with the bindings, in case a user saves while they are still modifying a field
		// The databinding doesn't trigger until after the update is "complete", so we force it
		private void SaveSkillData()
		{
			StatType statType;
			Enum.TryParse<StatType>(this.statBox.SelectedValue.ToString(), out statType);
			this.skillData.SkillName = this.skillNameBox.Text;
			this.skillData.SkillDescription = this.skillDescriptionBox.Text;
			this.skillData.SkillStat = statType;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveSkillData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<SkillData>>(this.skillList, this.savePath);
		}

		private void skillsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.skillData = (SkillData)this.skillsBox.SelectedItem;
			this.SetUpBindings();
		}

		private void addSkillButton_Click(object sender, EventArgs e)
		{
			this.SaveSkillData();

			this.skillData = new SkillData();
			this.skillList.Add(this.skillData);
			this.skillsBox.SelectedIndex = this.skillList.Count - 1;
		}

		private void removeSkillButton_Click(object sender, EventArgs e)
		{
			this.skillList.Remove(this.skillData);
			this.skillData = null;
			this.skillsBox.SelectedIndex = this.skillsBox.SelectedIndex == 0 ? 0 : this.skillsBox.SelectedIndex - 1;
		}
	}
}