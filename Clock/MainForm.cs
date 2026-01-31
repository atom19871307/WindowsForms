using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			//*********************************************************
			this.DoubleBuffered = true;
			//********************************************************
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point
				(
					Screen.PrimaryScreen.Bounds.Width - this.Width - 50,
					50
				);
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = DateTime.Now.ToString
				(
				"hh:mm:ss tt",
				System.Globalization.CultureInfo.InvariantCulture
				);
			if (checkBoxShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (checkBoxShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text = labelTime.Text;
		}
		void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekday.Visible = visible;
			buttonHideControls.Visible = visible;
			this.ShowInTaskbar = visible;
			this.FormBorderStyle =visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color. Empty : this.BackColor;

		}
		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(false);
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{

			SetVisibility(true);
		}

		private void showWeekdayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//////////////////////////////////////////////////////////
			if (sender is ToolStripMenuItem item)
			{
				checkBoxShowWeekday.Checked = item.Checked;
			}
			///////////////////////////////////////////////////////////////
		}

		private void labelTime_Click(object sender, EventArgs e)
		{

		}

		private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
		{

		}

		private void tsmiTopmost_Click(object sender, EventArgs e)
		{
			if (sender is ToolStripMenuItem item)
			{
				// Мы просто применяем состояние к форме.
				this.TopMost = item.Checked;
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			SetVisibility(true );
			this.Activate();
		}

		private void tsmiShowDate_Click(object sender, EventArgs e)
		{
			//////////////////////////////////////////////////////
			if (sender is ToolStripMenuItem item)
			{
				// Поскольку CheckOnClick имеет значение True,
				// мы просто привязываем его к CheckBox.
				checkBoxShowDate.Checked = item.Checked;
			}

		}

		private void tsmiForegoundColor_Click(object sender, EventArgs e)
		{
			////////////////////////////////////////////////////
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				labelTime.ForeColor = cd.Color;
			}
			////////////////////////////////////////////////////
		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			///////////////////////////////////////////////////////
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog()==DialogResult.OK)
			{
				// Изменяет цвет всего окна  // Փոխում է ամբողջ պատուհանի գույնը
				this.BackColor = cd.Color;  
				// Это важно для корректной работы функции прозрачности.
				if (this.FormBorderStyle == FormBorderStyle.None)
					this.TransparencyKey = this.BackColor;
			}
		}
		////////////////////////////////////////////
		private void tsmiExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		/////////////////////////////////////////////
	}
}
