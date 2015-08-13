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
	public class FileIO
	{
		public static string GetSaveLoc(string filter, string baseSaveLoc)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = filter;
			sfd.RestoreDirectory = true;
			sfd.InitialDirectory = baseSaveLoc;
			sfd.ShowDialog();
			return sfd.FileName;
		}

		public static void Save<T>(T obj, string fileLoc)
		{
			XmlSerializer writer = new XmlSerializer(obj.GetType());
			System.IO.StreamWriter file = new System.IO.StreamWriter(fileLoc);
			writer.Serialize(file, obj);
			file.Close();
		}

		public static T Load<T>(string fileLoc)
		{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				using (FileStream fileStream = new FileStream(fileLoc, FileMode.Open))
				{
					return (T)serializer.Deserialize(fileStream);
				}
		}

		public static string GetLoadLoc()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			return ofd.FileName;
		}
	}
}
