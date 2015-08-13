using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;

namespace CharacterCreator.Data
{
	public class ClassData : BaseData
	{
		public ClassData()
		{ }

		private string className;
		public string ClassName
		{
			get { return this.className; }
			set
			{
				this.className = value;
				this.NotifyPropertyChanged("ClassName");
			}
		}

		private HitDiceProgression hdProgression;
		public HitDiceProgression HdProgression
		{
			get { return this.hdProgression; }
			set
			{
				this.hdProgression = value;
				this.NotifyPropertyChanged("HdProgression");
			}
		}
	}
}
