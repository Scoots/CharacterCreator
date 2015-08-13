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
	public class BaseForm<T> : Form where T : new()
	{
		// Added here, but it will be overridden in all children
		// Note - this MUST be the name of the dropdown that contains all data elements
		// Add the 'new' keyword to the winform generated file when the error happens
		protected System.Windows.Forms.ComboBox dataListBox;

		// This data needs to be populated in all children
		protected string savePath = null;
		protected string displayMember = null;

		protected BindingList<T> dataList = new BindingList<T>();
		protected T data = default(T);

		public BaseForm() { }

		// Needs to be filled with save logic in children
		protected virtual void SaveData() { }
		protected virtual void SetUpBindings() { }

		protected void DataSetUp()
		{
			this.dataList = CharacterCreator.Helpers.FileIO.Load<BindingList<T>>(this.savePath);
			this.dataListBox.DataSource = this.dataList;
			this.dataListBox.DisplayMember = this.displayMember;
			this.dataListBox.ValueMember = this.displayMember;
		}

		protected void SaveMenuItemClick(object sender, EventArgs e)
		{
			this.SaveData();
			CharacterCreator.Helpers.FileIO.Save<BindingList<T>>(this.dataList, this.savePath);
		}

		protected void SelectedIndexChanged(object sender, EventArgs e)
		{
			this.data = (T)this.dataListBox.SelectedItem;
			this.SetUpBindings();
		}

		protected void AddDataButtonClick(object sender, EventArgs e)
		{
			this.SaveData();
			this.data = new T();
			this.dataList.Add(this.data);
			this.dataListBox.SelectedIndex = this.dataList.Count - 1;
		}

		protected void RemoveDataButtonClick(object sender, EventArgs e)
		{
			this.dataList.Remove(this.data);
			this.data = default(T);
			this.dataListBox.SelectedIndex = this.dataListBox.SelectedIndex == 0 ? 0 : this.dataListBox.SelectedIndex - 1;
		}
	}
}
