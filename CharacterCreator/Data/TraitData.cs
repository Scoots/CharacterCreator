using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;

namespace CharacterCreator.Data
{
	public class TraitData : BaseData
	{
		public TraitData() : base()
		{
			this.traitName = "New Trait";
			this.ModifierIdList = new List<string>();
		}

		private string traitName;
		public string TraitName
		{
			get { return this.traitName; }
			set
			{
				this.traitName = value;
				this.NotifyPropertyChanged("TraitName");
			}
		}

		private string traitDescription;
		public string TraitDescription
		{
			get { return this.traitDescription; }
			set
			{
				this.traitDescription = value;
				this.NotifyPropertyChanged("TraitDescription");
			}
		}

		private TraitType traitType;
		public TraitType TraitType
		{
			get { return this.traitType; }
			set
			{
				this.traitType = value;
				this.NotifyPropertyChanged("TraitType");
			}
		}

		private ConditionalStates conditionalState;
		public ConditionalStates ConditionalState
		{
			get { return this.conditionalState; }
			set
			{
				this.conditionalState = value;
				this.NotifyPropertyChanged("ConditionalState");
			}
		}

		private CampaignNames campaignName;
		public CampaignNames CampaignName
		{
			get { return this.campaignName; }
			set
			{
				this.campaignName = value;
				this.NotifyPropertyChanged("CampaignName");
			}
		}

		private RaceNames raceName;
		public RaceNames RaceName
		{
			get { return this.raceName; }
			set
			{
				this.raceName = value;
				this.NotifyPropertyChanged("RaceName");
			}
		}

		private RegionNames regionName;
		public RegionNames RegionName
		{
			get { return this.regionName; }
			set
			{
				this.regionName = value;
				this.NotifyPropertyChanged("RegionName");
			}
		}

		private ReligionNames religionName;
		public ReligionNames ReligionName
		{
			get { return this.religionName; }
			set
			{
				this.religionName = value;
				this.NotifyPropertyChanged("ReligionName");
			}
		}

		public List<string> ModifierIdList { get; set; }
	}
}
