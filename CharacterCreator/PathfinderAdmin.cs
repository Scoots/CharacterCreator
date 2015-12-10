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
using CharacterCreator.DataForms.TraitForms;
using CharacterCreator.DataForms.FeatForms;

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

		private void modifiersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form form = new PathfinderModifierForm();
			form.Show();
		}
	}
}
