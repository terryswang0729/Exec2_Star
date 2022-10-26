using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void leftStarsButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				return;
			}
			if (rows.Value < 0)
			{
				MessageBox.Show("列數必須大於零");
				return;
			}
			string stars = GenerateLeftStars(rows.Value);

			resultTextBox.Text = stars;
		}

		private void midStarsButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				return;
			}
			if (rows.Value < 0)
			{
				MessageBox.Show("列數必須大於零");
				return;
			}
			string stars = GenerateMidStars(rows.Value);

			resultTextBox.Text = stars;

		}

		private void RightStarsButton_Click(object sender, EventArgs e)
		{
			int? rows = GetRows();
			if (rows.HasValue == false)
			{
				MessageBox.Show("請輸入列數");
				return;
			}
			if (rows.Value < 0)
			{
				MessageBox.Show("列數必須大於零");
				return;
			}
			string stars = GenerateRightStars(rows.Value);

			resultTextBox.Text = stars;

		}
		private int? GetRows()
		{
			string input = rowsTextBox.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt)
			{
				return rows;
			}
			else
			{
				return null;
			}
		}
		private string GenerateLeftStars(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private string GenerateMidStars(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				result += new string(' ', (rows - i)*2) + new string('*', 2 * i - 1)+"\r\n";
				
			}
			return result;
		}
		private string GenerateRightStars(int rows)
		{
			string result = string.Empty;
			
			for (int i = 1; i<=rows ; i++)
			{
				result += new string(' ', (rows-i)*2) + new string('*',i) + "\r\n";

			}
			return result;
		}
	}
}
