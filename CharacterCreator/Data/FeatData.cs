using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;

namespace CharacterCreator.Data
{
	public class FeatData : BaseData
	{
		public FeatData()
			: base()
		{
			this.featName = "New Feat";
			this.ModifierIdList = new List<string>();
		}

		private string featName;
		public string FeatName
		{
			get { return this.featName; }
			set
			{
				this.featName = value;
				this.NotifyPropertyChanged("FeatName");
			}
		}

		private string featDescription;
		public string FeatDescription
		{
			get { return this.featDescription; }
			set
			{
				this.featDescription = value;
				this.NotifyPropertyChanged("FeatDescription");
			}
		}

		public List<string> ModifierIdList { get; set; }

		public override string ToString()
		{
			return this.FeatName;
		}
	}
}
