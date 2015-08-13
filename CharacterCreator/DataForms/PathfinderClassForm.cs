using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator.Enumerations;
using CharacterCreator.Data;

namespace CharacterCreator.DataForms
{
	public partial class PathfinderClassForm : Form
	{
		private string savePath = null;
		private ClassData classData = new ClassData();

		public PathfinderClassForm()
		{
			InitializeComponent();
			this.hdBox.DataSource = HitDiceProgression.GetValues(typeof(HitDiceProgression));
			//this.classSaveProgression.DataSource = SaveProgression.GetValues(typeof(SaveProgression));
			this.SetUpBindings();
		}

		private void SetUpBindings()
		{
			this.classNameBox.DataBindings.Clear();

			this.classNameBox.DataBindings.Add("Text", this.classData, "ClassName");
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.classData = new ClassData();
			this.savePath = null;
			this.SetUpBindings();
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.savePath = CharacterCreator.Helpers.FileIO.GetLoadLoc();
			this.classData = CharacterCreator.Helpers.FileIO.Load<ClassData>(this.savePath);
			this.SetUpBindings();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HitDiceProgression hdProgression;
			Enum.TryParse<HitDiceProgression>(this.hdBox.SelectedValue.ToString(), out hdProgression);
			this.classData.ClassName = this.classNameBox.Text;
			this.classData.HdProgression = hdProgression;
			if(string.IsNullOrEmpty(this.savePath))
			{
				this.savePath = CharacterCreator.Helpers.FileIO.GetSaveLoc("classXml|*classXml", @"C:\Projects\Pathfinder\CharacterCreator\CharacterCreator\Data\XmlData\ClassData");
			}
			CharacterCreator.Helpers.FileIO.Save<ClassData>(this.classData, this.savePath);
		}
	}
}
