using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator.Containers
{
	public class IdName
	{
		public string ObjectId { get; set; }

		public string ObjectName { get; set; }

		public IdName(string id, string name)
		{
			this.ObjectId = id;
			this.ObjectName = name;
		}

		public override string ToString()
		{
			return this.ObjectName;
		}
	}
}
