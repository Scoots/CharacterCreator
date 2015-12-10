using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;

namespace CharacterCreator.Data
{
	public class ModifierData : BaseData
	{
		public ModifierData() : base()
		{
			this.modifierName = "New Modifier";
		}

		private string modifierName;
		public string ModifierName
		{
			get { return this.modifierName; }
			set
			{
				this.modifierName = value;
				this.NotifyPropertyChanged("ModifierName");
			}
		}

		private string modifierDescription;
		public string ModifierDescription
		{
			get { return this.modifierDescription; }
			set
			{
				this.modifierDescription = value;
				this.NotifyPropertyChanged("ModifierDescription");
			}
		}

		private TypeToModify modificationType;
		public TypeToModify ModificationType
		{
			get { return this.modificationType; }
			set
			{
				this.modificationType = value;
				this.NotifyPropertyChanged("ModificationType");
			}
		}

		private int modificationAmount;
		public int ModificationAmount
		{
			get { return this.modificationAmount; }
			set
			{
				this.modificationAmount = value;
				this.NotifyPropertyChanged("ModificationAmount");
			}
		}

		private AttackBonusType attackBonusType;
		public AttackBonusType AttackBonusType
		{
			get { return this.attackBonusType; }
			set
			{
				this.attackBonusType = value;
				this.NotifyPropertyChanged("AttackBonusType");
			}
		}

		private DamageBonusType damageBonusType;
		public DamageBonusType DamageBonusType
		{
			get { return this.damageBonusType; }
			set
			{
				this.damageBonusType = value;
				this.NotifyPropertyChanged("DamageBonusType");
			}
		}

		private SkillCheckBonusType skillCheckBonusType;
		public SkillCheckBonusType SkillCheckBonusType
		{
			get { return this.skillCheckBonusType; }
			set
			{
				this.skillCheckBonusType = value;
				this.NotifyPropertyChanged("SkillCheckBonusType");
			}
		}

		private SaveBonusType saveBonusType;
		public SaveBonusType SaveBonusType
		{
			get { return this.saveBonusType; }
			set
			{
				this.saveBonusType = value;
				this.NotifyPropertyChanged("SaveBonusType");
			}
		}

		private DCBonusType dcBonusType;
		public DCBonusType DCBonusType
		{
			get { return this.dcBonusType; }
			set
			{
				this.dcBonusType = value;
				this.NotifyPropertyChanged("DCBonusType");
			}
		}

		private CombatManeuverTypes cmdType;
		public CombatManeuverTypes CMDType
		{
			get { return this.cmdType; }
			set
			{
				this.cmdType = value;
				this.NotifyPropertyChanged("CMDType");
			}
		}

		private CombatManeuverTypes cmbType;
		public CombatManeuverTypes CMBType
		{
			get { return this.cmbType; }
			set
			{
				this.cmbType = value;
				this.NotifyPropertyChanged("CMBType");
			}
		}

		private ArmorBonusType armorBonusType;
		public ArmorBonusType ArmorBonusType
		{
			get { return this.armorBonusType; }
			set
			{
				this.armorBonusType = value;
				this.NotifyPropertyChanged("ArmorBonusType");
			}
		}

		private AllBonusType allBonusType;
		public AllBonusType AllBonusType
		{
			get { return this.allBonusType; }
			set
			{
				this.allBonusType = value;
				this.NotifyPropertyChanged("AllBonusType");
			}
		}

		private SaveBonusType saveVSpell;
		public SaveBonusType SaveVSpell
		{
			get { return this.saveVSpell; }
			set
			{
				this.saveVSpell = value;
				this.NotifyPropertyChanged("SaveVSpell");
			}
		}

		private ImmunityTypes immunityType;
		public ImmunityTypes ImmunityType
		{
			get { return this.immunityType; }
			set
			{
				this.immunityType = value;
				this.NotifyPropertyChanged("ImmunityType");
			}
		}

		private DamageReductionTypes damageReductionType;
		public DamageReductionTypes DamageReductionType
		{
			get { return this.damageReductionType; }
			set
			{
				this.damageReductionType = value;
				this.NotifyPropertyChanged("DamageReductionType");
			}
		}

		private AbilityScoreBonusType abilityScoreBonusType;
		public AbilityScoreBonusType AbilityScoreBonusType
		{
			get { return this.abilityScoreBonusType; }
			set
			{
				this.abilityScoreBonusType = value;
				this.NotifyPropertyChanged("AbilityScoreBonusType");
			}
		}

		private StatType statisticType;
		public StatType StatisticType
		{
			get { return this.statisticType; }
			set
			{
				this.statisticType = value;
				this.NotifyPropertyChanged("StatisticType");
			}
		}

		public override string ToString()
		{
			return this.ModifierName;
		}
	}
}
