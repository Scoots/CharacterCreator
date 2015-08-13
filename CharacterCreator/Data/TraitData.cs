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
		public TraitData()
		{
			this.traitName = "New Trait";
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
		public TraitType TratiType
		{
			get { return this.traitType; }
			set
			{
				this.traitType = value;
				this.NotifyPropertyChanged("TraitType");
			}
		}
	}
}
