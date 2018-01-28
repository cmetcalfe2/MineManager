using MineManager.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineManager {
	class MMApplicationContext : ApplicationContext {
		private NotifyIcon trayIcon;

		public MMApplicationContext() {
			MenuItem configMenuItem = new MenuItem("Configuration", new EventHandler(ShowConfig));
			MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));
			// Initialize Tray Icon
			trayIcon = new NotifyIcon() {
				Icon = Resources.AppIcon,
				ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem }),
				Visible = true
			};
			Config.Load();
			Monitor.Create();
		}

		void Exit(object sender, EventArgs e) {
			// Hide tray icon, otherwise it will remain shown until user mouses over it
			trayIcon.Visible = false;

			Application.Exit();
		}

		Form1 configWindow = new Form1();
		void ShowConfig(object sender, EventArgs e) {
			// If we are already showing the window, merely focus it.
			if (configWindow.Visible) {
				configWindow.Activate();
			} else {
				configWindow.ShowDialog();
			}
		}
	}
}
