using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCreator.Enumerations;
using System.Windows.Forms;
using System.ComponentModel;

namespace CharacterCreator.Data
{
	public class BaseData: INotifyPropertyChanged
	{
		protected void NotifyPropertyChanged(string propertyName)
		{
			this.InvokePropertyChanged(new PropertyChangedEventArgs(propertyName));
		}

		#region Implementation of INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
		public void InvokePropertyChanged(PropertyChangedEventArgs e)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, e);
			}
		}
		#endregion
	}
}
