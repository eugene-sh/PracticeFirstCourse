using System;
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
				dataGridView1.Columns.Add(new DataGridViewColumn
				{
					HeaderText = columnMetadata.HeadText,
					CellTemplate = new DataGridViewTextBoxCell(),
					ReadOnly = columnMetadata.Readonly,
					ValueType = typeof(int)
				});
			}
		}

		private void Report_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Exception != null &&
				e.Context == (DataGridViewDataErrorContexts.Parsing | DataGridViewDataErrorContexts.Commit))
			{
				MessageBox.Show(e.Exception.Message);
			}
		}
	}

}
