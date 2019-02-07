using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			GenerateGridColumns();
		}

		private void GenerateGridColumns()
		{
			var columnsMetadata = DataProvider.GetColumnsMetadata().OrderBy(c => c.OrderNumber);

			foreach (var columnMetadata in columnsMetadata)
			{
				gridOfTours.Columns.Add(new DataGridViewColumn
				{
					HeaderText = columnMetadata.HeadText,
					CellTemplate = new DataGridViewTextBoxCell(),
					ReadOnly = columnMetadata.Readonly,
					ValueType = columnMetadata.ColumnType
				});
			}
		}

		private void Report_Click(object sender, EventArgs e)
		{
			if (testDataCheckbox.Checked)
				PrepeData();

			var listOfOrganization = new List<IEnumerable<int>>();


			for(var i = 0; i < 3; i++)
			{
				var list = new List<int>();
				for (var j = 1; j < 7; j++)
				{
					list.Add((int)gridOfTours.Rows[i].Cells[j].Value);
				}
				listOfOrganization.Add(list);
			}

			for(int i = 0; i < listOfOrganization.Count(); i++)
			{
				gridOfTours.Rows[i].Cells[7].Value = listOfOrganization[i].Sum();
				gridOfTours.Rows[i].Cells[8].Value = listOfOrganization[i].Average();
			}

			var maxHalfYear = 0;
			var minHalfYesr = 0;
			var may70and90 = 0;


			foreach(var item in listOfOrganization)
			{
				if (maxHalfYear < item.Max())
					maxHalfYear = item.Max();
				if (maxHalfYear > item.Min())
					minHalfYesr = item.Min();

				if((int)item.ToArray()[4] >= 70 && (int)item.ToArray()[4] <= 90)
				{
					may70and90++;
				}
			}

			textBox1.Text = maxHalfYear.ToString();
			textBox2.Text = minHalfYesr.ToString();
			textBox3.Text = may70and90.ToString();
		}

		private void PrepeData()
		{
			var efectiveRowsData = DataProvider.GetOrgaizationData();

			foreach (var row in efectiveRowsData)
			{
				gridOfTours.Rows.Add(
					row.Name,
					row.SoldToursByMounth[0],
					row.SoldToursByMounth[1],
					row.SoldToursByMounth[2],
					row.SoldToursByMounth[3],
					row.SoldToursByMounth[4],
					row.SoldToursByMounth[5]);
			}
		}

		private void InvalidQuantitySoldTours_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Exception != null &&
				e.Context == (DataGridViewDataErrorContexts.Parsing | DataGridViewDataErrorContexts.Commit))
			{
				MessageBox.Show(e.Exception.Message);
			}
		}
	}

}
