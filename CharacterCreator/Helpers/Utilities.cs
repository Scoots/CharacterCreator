using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace CharacterCreator.Helpers
{
	public class Utilities
	{
		public static T GetEnumDataFromBox<T>(System.Windows.Forms.ComboBox box) where T : struct, IConvertible
		{
			T data;
			Enum.TryParse<T>(box.SelectedValue.ToString(), out data);
			return data;
		}
	}
}
