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
	public partial class PathfinderModifierForm : Form
	{
		private string savePath = @"C:\Projects\CharacterCreator\CharacterCreator\Data\XmlData\Modifiers.xml";

		private BindingList<ModifierData> modifierList = new BindingList<ModifierData>();
		private ModifierData modifierData = null;

		public PathfinderModifierForm()
		{
			InitializeComponent();
			this.modifierList = CharacterCreator.Helpers.FileIO.Load<BindingList<ModifierData>>(this.savePath);
			this.modifierListBox.DataSource = this.modifierList;
			this.modifierListBox.DisplayMember = "ModifierName";
			this.modifierListBox.ValueMember = "ModifierName";

			this.modifyAbilityTypeBox.DataSource = TypeToModify.GetValues(typeof(TypeToModify));
		}

		private void SetUpBindings()
		{
			this.modifierNameBox.DataBindings.Clear();
			this.modifierDescriptionBox.DataBindings.Clear();
			this.modifyAbilityTypeBox.DataBindings.Clear();
			this.modificationAmountBox.DataBindings.Clear();
			this.bonusTypeBox.DataBindings.Clear();
			this.statisticBox.DataBindings.Clear();

			this.modifierNameBox.DataBindings.Add("Text", this.modifierData, "ModifierName");
			this.modifierDescriptionBox.DataBindings.Add("Text", this.modifierData, "ModifierDescription");
			this.modifyAbilityTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "ModificationType");
			this.modificationAmountBox.DataBindings.Add("Value", this.modifierData, "ModificationAmount");
			this.statisticBox.DataBindings.Add("SelectedItem", this.modifierData, "StatisticType");

			switch (this.modifierData.ModificationType)
			{
				case TypeToModify.Attack:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "AttackBonusType");
					break;
				case TypeToModify.Damage:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "DamageBonusType");
					break;
				case TypeToModify.Skill:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "SkillCheckBonusType");
					break;
				case TypeToModify.Save:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "SaveBonusType");
					break;
				case TypeToModify.CasterLevel:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "DCBonusType");
					break;
				case TypeToModify.CMB:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "CMBType");
					break;
				case TypeToModify.CMD:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "CMDType");
					break;
				case TypeToModify.ArmorClass:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "ArmorBonusType");
					break;
				case TypeToModify.Bonus:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "AllBonusType");
					break;
				case TypeToModify.SaveVSpell:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "SaveVSpell");
					break;
				case TypeToModify.Immunities:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "ImmunityType");
					break;
				case TypeToModify.DamageReduction:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "DamageReductionType");
					break;
				case TypeToModify.Statistic:
					this.bonusTypeBox.DataBindings.Add("SelectedItem", this.modifierData, "AbilityScoreBonusType");
					break;
				default:
					break;
			}
			this.idBox.Text = this.modifierData.Id;
		}

		private void SaveModifierData()
		{
			TypeToModify typeToModify;
			Enum.TryParse<TypeToModify>(this.modifyAbilityTypeBox.SelectedValue.ToString(), out typeToModify);
			this.modifierData.ModifierName = this.modifierNameBox.Text;
			this.modifierData.ModifierDescription = this.modifierDescriptionBox.Text;
			this.modifierData.ModificationType = typeToModify;
			this.modifierData.ModificationAmount = (int)this.modificationAmountBox.Value;

			switch (typeToModify)
			{
				case TypeToModify.Attack:
					this.modifierData.AttackBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<AttackBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.Damage:
					this.modifierData.DamageBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<DamageBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.Skill:
					this.modifierData.SkillCheckBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<SkillCheckBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.Save:
					this.modifierData.SaveBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<SaveBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.CasterLevel:
					this.modifierData.DCBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<DCBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.CMB:
					this.modifierData.CMBType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<CombatManeuverTypes>(this.bonusTypeBox);
					break;
				case TypeToModify.CMD:
					this.modifierData.CMDType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<CombatManeuverTypes>(this.bonusTypeBox);
					break;
				case TypeToModify.ArmorClass:
					this.modifierData.ArmorBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<ArmorBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.Bonus:
					this.modifierData.AllBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<AllBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.SaveVSpell:
					this.modifierData.SaveVSpell = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<SaveBonusType>(this.bonusTypeBox);
					break;
				case TypeToModify.Immunities:
					this.modifierData.ImmunityType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<ImmunityTypes>(this.bonusTypeBox);
					break;
				case TypeToModify.DamageReduction:
					this.modifierData.DamageReductionType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<DamageReductionTypes>(this.bonusTypeBox);
					break;
				case TypeToModify.Statistic:
					this.modifierData.AbilityScoreBonusType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<AbilityScoreBonusType>(this.bonusTypeBox);
					this.modifierData.StatisticType = CharacterCreator.Helpers.Utilities.GetEnumDataFromBox<StatType>(this.statisticBox);
					break;
				default:
					break;
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveModifierData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<ModifierData>>(this.modifierList, this.savePath);
		}

		private void modifierListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.modifierData = (ModifierData)this.modifierListBox.SelectedItem;
			this.SetUpBindings();
		}

		private void addModifierButton_Click(object sender, EventArgs e)
		{
			this.SaveModifierData();

			this.modifierData = new ModifierData();
			this.modifierList.Add(this.modifierData);
			this.modifierListBox.SelectedIndex = this.modifierList.Count - 1;
		}

		private void removeModifierButton_Click(object sender, EventArgs e)
		{
			this.modifierList.Remove(this.modifierData);
			this.modifierData = null;
			this.modifierListBox.SelectedIndex = this.modifierListBox.SelectedIndex == 0 ? 0 : this.modifierListBox.SelectedIndex - 1;
		}

		private void modifyAbilityTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			TypeToModify typeToModify;
			Enum.TryParse<TypeToModify>(this.modifyAbilityTypeBox.SelectedValue.ToString(), out typeToModify);

			this.statisticBox.Visible = false;
			switch(typeToModify)
			{
				case TypeToModify.Attack:
					this.bonusTypeBox.DataSource = AttackBonusType.GetValues(typeof(AttackBonusType));
					break;
				case TypeToModify.Damage:
					this.bonusTypeBox.DataSource = DamageBonusType.GetValues(typeof(DamageBonusType));
					break;
				case TypeToModify.Skill:
					this.bonusTypeBox.DataSource = SkillCheckBonusType.GetValues(typeof(SkillCheckBonusType));
					break;
				case TypeToModify.Save:
					this.bonusTypeBox.DataSource = SaveBonusType.GetValues(typeof(SaveBonusType));
					break;
				case TypeToModify.ArmorCheckPenalty:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.CasterLevel:
					this.bonusTypeBox.DataSource = DCBonusType.GetValues(typeof(DCBonusType));
					break;
				case TypeToModify.CMB:
					this.bonusTypeBox.DataSource = CombatManeuverTypes.GetValues(typeof(CombatManeuverTypes));
					break;
				case TypeToModify.CMD:
					this.bonusTypeBox.DataSource = CombatManeuverTypes.GetValues(typeof(CombatManeuverTypes));
					break;
				case TypeToModify.ArmorClass:
					this.bonusTypeBox.DataSource = ArmorBonusType.GetValues(typeof(ArmorBonusType));
					break;
				case TypeToModify.Resist:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.Bonus:
					this.bonusTypeBox.DataSource = AllBonusType.GetValues(typeof(AllBonusType));
					break;
				case TypeToModify.SaveVSpell:
					this.bonusTypeBox.DataSource = SaveBonusType.GetValues(typeof(SaveBonusType));
					break;
				case TypeToModify.SaveVSLA:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.SaveVPoison:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.SaveVFear:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.SaveVDisease:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.Immunities:
					this.bonusTypeBox.DataSource = ImmunityTypes.GetValues(typeof(ImmunityTypes));
					break;
				case TypeToModify.DamageReduction:
					this.bonusTypeBox.DataSource = DamageReductionTypes.GetValues(typeof(DamageReductionTypes));
					break;
				case TypeToModify.SpellResistance:
					this.bonusTypeBox.Enabled = false;
					break;
				case TypeToModify.Statistic:
					this.statisticBox.Visible = true;
					this.bonusTypeBox.DataSource = AbilityScoreBonusType.GetValues(typeof(AbilityScoreBonusType));
					this.statisticBox.DataSource = StatType.GetValues(typeof(StatType));
					break;
				default:
					break;
			}
		}
	}
}
