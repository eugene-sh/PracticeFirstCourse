namespace Lab1
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridOfTours = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.reportButton = new System.Windows.Forms.Button();
			this.testDataCheckbox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.gridOfTours)).BeginInit();
			this.SuspendLayout();
			// 
			// gridOfTours
			// 
			this.gridOfTours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridOfTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridOfTours.Location = new System.Drawing.Point(12, 12);
			this.gridOfTours.Name = "gridOfTours";
			this.gridOfTours.Size = new System.Drawing.Size(778, 427);
			this.gridOfTours.TabIndex = 0;
			this.gridOfTours.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.InvalidQuantitySoldTours_DataError);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 473);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Наибольшее кол-во за полугодие";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 513);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Наименьшее кол-во за полугодие";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 552);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(255, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Кол-во фирм, продавших в мае от 70 до 90 туров";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(304, 466);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(20, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(304, 506);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(20, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(304, 545);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(20, 20);
			this.textBox3.TabIndex = 6;
			// 
			// reportButton
			// 
			this.reportButton.Location = new System.Drawing.Point(249, 588);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(75, 23);
			this.reportButton.TabIndex = 7;
			this.reportButton.Text = "Отчет";
			this.reportButton.UseVisualStyleBackColor = true;
			this.reportButton.Click += new System.EventHandler(this.Report_Click);
			// 
			// testDataCheckbox
			// 
			this.testDataCheckbox.AutoSize = true;
			this.testDataCheckbox.Checked = true;
			this.testDataCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.testDataCheckbox.Location = new System.Drawing.Point(599, 466);
			this.testDataCheckbox.Name = "testDataCheckbox";
			this.testDataCheckbox.Size = new System.Drawing.Size(191, 17);
			this.testDataCheckbox.TabIndex = 8;
			this.testDataCheckbox.Text = "Использовать тестовые данные";
			this.testDataCheckbox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 623);
			this.Controls.Add(this.testDataCheckbox);
			this.Controls.Add(this.reportButton);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridOfTours);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Туры туристические фирмы";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridOfTours)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridOfTours;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button reportButton;
		private System.Windows.Forms.CheckBox testDataCheckbox;
	}
}

