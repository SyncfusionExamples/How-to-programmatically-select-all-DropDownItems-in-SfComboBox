//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;

using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.ListView.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfComboBoxAdvCheckBox
{
	public partial class Form1 : MetroForm
	{
		public Form1()
		{
			InitializeComponent();
			//Bind the data source to combo box control

			sfComboBox1.DataSource = GetTable();
			//Bind the Display member and Value member to the data source
			sfComboBox1.DisplayMember = "Patient";
			sfComboBox1.ValueMember = "Drug";
			sfComboBox1.ComboBoxMode = ComboBoxMode.MultiSelection;
			this.StartPosition = FormStartPosition.CenterScreen;


		}

		private static DataTable GetTable()
		{
			// Here we create a DataTable with four columns.
			DataTable table = new DataTable();
			table.Columns.Add("Dosage", typeof(int));
			table.Columns.Add("Drug", typeof(string));
			table.Columns.Add("Patient", typeof(string));
			table.Columns.Add("Date", typeof(DateTime));

			// Here we add five DataRows.
			table.Rows.Add(25, "Indocin", "David", DateTime.Now);
			table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
			table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
			table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
			table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
			return table;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (var v in this.sfComboBox1.DropDownListView.View.Items.ToList())
			{
				//Programmatically add the checked items
				this.sfComboBox1.DropDownListView.CheckedItems.Add(v);
			}
		}


	}
}
