using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;

namespace CharacterCreator.Data
{
	public class SkillData:BaseData
	{
		public SkillData() : base()
		{ 
			this.skillName = "New Skill";
		}

		private string skillName;
		public string SkillName
		{
			get { return this.skillName; }
			set
			{
				this.skillName = value;
				this.NotifyPropertyChanged("SkillName");
			}
		}

		private string skillDescription;
		public string SkillDescription
		{
			get { return this.skillDescription; }
			set
			{
				this.skillDescription = value;
				this.NotifyPropertyChanged("SkillDescription");
			}
		}

		private StatType skillStat;
		public StatType SkillStat
		{
			get { return this.skillStat; }
			set
			{
				this.skillStat = value;
				this.NotifyPropertyChanged("SkillStat");
			}
		}
	}
}
