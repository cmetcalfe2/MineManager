using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Win32;

namespace MineManager {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		public void LoadConfig() {
			batFileTextBox.Text = Config.GetValue("batFile").ToString();
			processNameTextBox.Text = Config.GetValue("minerProcess").ToString();
			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (rkApp.GetValue("MineManager") != null)
				runAtBootCheckbox.Checked = true;
			else
				runAtBootCheckbox.Checked = false;
		}

		private void BatFileButton_Click(object sender, EventArgs e) {
			batFileDialog = new OpenFileDialog();
			DialogResult clickedOk = batFileDialog.ShowDialog();
			if (clickedOk == DialogResult.OK) {
				batFileTextBox.Text = batFileDialog.FileName;
			}
		}

		private void saveConfigButton_Click(object sender, EventArgs e) {
			Config.SetValue("batFile", batFileTextBox.Text);
			Config.SetValue("minerProcess", processNameTextBox.Text);
			Config.Save();
			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (runAtBootCheckbox.Checked && rkApp.GetValue("Folder Locker") == null) {
				rkApp.CreateSubKey("MineManager");
				rkApp.SetValue("MineManager", Application.ExecutablePath.ToString());
			} else if (rkApp.OpenSubKey("MineManager") != null) {
				rkApp.DeleteSubKeyTree("MineManager");
			}
		}

		private void startMinerButton_Click(object sender, EventArgs e) {
			Monitor.instance.StartMiner();
		}

		private void killMinerButton_Click(object sender, EventArgs e) {
			Monitor.instance.KillMiner();
		}

		private void Form1_Load(object sender, EventArgs e) {
			LoadConfig();
		}

		RegistryKey rkApp;
	}
}
