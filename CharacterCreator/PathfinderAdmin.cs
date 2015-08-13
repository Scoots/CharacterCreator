using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.DataForms;

namespace CharacterCreator
{
	public partial class PathfinderAdmin : Form
	{
		public PathfinderAdmin()
		{
			InitializeComponent();
		}

		private void classToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new PathfinderClassForm();
			form.Show();
		}

		private void featToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new PathfinderFeatForm();
			form.Show();
		}

		private void skillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new PathfinderSkillForm();
			form.Show();
		}

		private void traitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new PathfinderTraitForm();
			form.Show();
		}
	}
}
