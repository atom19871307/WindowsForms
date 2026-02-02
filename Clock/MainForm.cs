using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//***********************************
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using Microsoft.Win32; // Սա պետք է լինի ֆայլի ամենավերևում
					   //***********************************

namespace Clock
{
	public partial class MainForm : Form
	{
		ColorDialog backgroundDialog;
		ColorDialog foregroundDialog;
		//******************************************************
		PrivateFontCollection pfc = new PrivateFontCollection();	// Տառատեսակի հավաքածու
		Point lastPoint;              // Для перемещения окна       // Պատուհանը շարժելու համար
	    //******************************************************
		public MainForm()
		{
			InitializeComponent();
			// 1. Вызов функции загрузки шрифта
			InitCustomFont(); // ՍԱ ՊԱՐՏԱԴԻՐ Է
			this.Location = new Point
				(
					Screen.PrimaryScreen.Bounds.Width - this.Width - 50,
					50
				);
			tsimShowControls.Checked = true;
			backgroundDialog = new ColorDialog();
			foregroundDialog = new ColorDialog();
		}
		// Функция для загрузки шрифта из ресурсов
		private void InitCustomFont()
		{// Получить шрифт из ресурсов
			try
			{ 
		 // 1. Վերցնում ենք ֆայլը Resources-ից որպես byte array
			byte[] fontData = Properties.Resources.DS_DIGIT;

			// 2. Հատկացնում ենք հիշողություն տառատեսակի համար
			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

			// 3. Ավելացնում ենք մեր հավաքածուի մեջ
			pfc.AddMemoryFont(fontPtr, fontData.Length);

			// 4. Ազատում ենք հիշողությունը
			Marshal.FreeCoTaskMem(fontPtr);
				if (pfc.Families.Length > 0)
				{
					// Կիրառում ենք Label-ի վրա
					labelTime.Font = new Font(pfc.Families[0], 40f, FontStyle.Regular);
				}
			}
			catch (Exception ex)
			{
				// Եթե սխալ լինի, կտեսնես հաղորդագրություն
				MessageBox.Show("Font error: " + ex.Message);
			}
		}
		//********************************************************************
		private void tsimAutorun_CheckedChanged(object sender, EventArgs e)
		{// Բացում ենք ռեեստրի բանալին
			RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (tsmiAutorun.Checked)
			{// Ավելացնում ենք ծրագիրը ավտոմատ միացման ցուցակում
				rk.SetValue("MyCoolClack", Application.ExecutablePath);
			}
			else
			{ // Հեռացնում ենք ցուցակից
				rk.DeleteValue("MyCoolClack",false);
			}
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
			this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}

		//********************************************************************
		// События перемещения окна (когда элементы управления скрыты)
		private void labelTime_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				lastPoint = new Point(e.X, e.Y);
			}
		}
		private void labelTime_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
		//*******************************************************************
		private void buttonHideControls_Click(object sender, EventArgs e) => tsimShowControls.Checked = false;
		private void labelTime_DoubleClick(object sender, EventArgs e) => tsimShowControls.Checked = true;

		private void tsmiTopmost_CheckedChanged(object sender, EventArgs e) =>
			//this.TopMost = tsmiTopmost.Checked;
			//this.TopMost = ((ToolStripMenuItem)sender).Checked;
			this.TopMost = (sender as ToolStripMenuItem).Checked;

		private void tsimShowControls_CheckedChanged(object sender, EventArgs e) => SetVisibility(tsimShowControls.Checked);
		private void tsmiExit_Click(object sender, EventArgs e) => this.Close();

		private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
		{
			if (this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void tsmiBackgroundColor_Click(object sender, EventArgs e)
		{
			DialogResult result = backgroundDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				labelTime.BackColor = backgroundDialog.Color;
			}
		}

		private void tsmiForegroundColor_Click(object sender, EventArgs e)
		{
			if (foregroundDialog.ShowDialog() == DialogResult.OK)
				labelTime.ForeColor = foregroundDialog.Color;
		}
		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) => tsmiShowDate.Checked = (sender as CheckBox).Checked;
		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e) => tsimShowWeekday.Checked = (sender as CheckBox).Checked;
		private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => checkBoxShowDate.Checked = (sender as ToolStripMenuItem).Checked;
		private void tsimShowWeekday_CheckedChanged(object sender, EventArgs e) =>checkBoxShowWeekday.Checked = (sender as ToolStripMenuItem).Checked;
	}
}