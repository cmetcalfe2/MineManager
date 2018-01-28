using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MineManager {
	class Monitor {

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT {
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;
		}

		public static void Create() {
			instance = new Monitor();
			instance.Init();
		}

		void Init() {
			desktopHandle = GetDesktopWindow();
			shellHandle = GetShellWindow();
			ThreadStart threadDelegate = new ThreadStart(this.Mon);
			monThread = new Thread(threadDelegate);
			monThread.Start();
		}

		public void StartMiner() {
			Console.Beep(1000, 200);
			var handle = Process.GetCurrentProcess().MainWindowHandle;
			ProcessStartInfo pInfo = new ProcessStartInfo(Config.GetValue("batFile").ToString());
			try {
				Process.Start(pInfo);
				minerStarted = true;
			} catch (Exception e) {
				MessageBox.Show("Miner starting failed: " + e.Message, "MineManager");
				minerStarted = false;
			}
			Thread.Sleep(1000);
			MinimiseWindow();
			SetForegroundWindow(handle.ToInt32());
		}

		public void KillMiner() {
			Console.Beep(500, 200);
			foreach (var process in Process.GetProcessesByName(Config.GetValue("minerProcess").ToString())) {
				process.Kill();
			}
			minerStarted = false;
		}

		void Mon() {
			while (true) {
				if (!IsFullScreen() && !minerStarted) {
					StartMiner();
				} else if (IsFullScreen() &&  minerStarted) {
					KillMiner();
				}
				Thread.Sleep(5000);
			}
		}

		bool IsFullScreen() {
			//Detect if the current app is running in full screen
			bool runningFullScreen = false;
			RECT appBounds;
			Rectangle screenBounds;
			IntPtr hWnd;

			//get the dimensions of the active window
			hWnd = GetForegroundWindow();
			if (hWnd != null && !hWnd.Equals(IntPtr.Zero)) {
				//Check we haven't picked up the desktop or the shell
				if (!(hWnd.Equals(desktopHandle) || hWnd.Equals(shellHandle))) {
					GetWindowRect(hWnd, out appBounds);
					//determine if window is fullscreen
					screenBounds = Screen.FromHandle(hWnd).Bounds;
					if ((appBounds.Bottom - appBounds.Top) == screenBounds.Height && (appBounds.Right - appBounds.Left) == screenBounds.Width) {
						runningFullScreen = true;
					}
				}
			}

			return runningFullScreen;
		}

		void MinimiseWindow() {
			Process[] processes = Process.GetProcessesByName(Config.GetValue("minerProcess").ToString());

			foreach (Process p in processes) {
				IntPtr windowHandle = p.MainWindowHandle;
				if (windowHandle != IntPtr.Zero) {
					ShowWindow(windowHandle, ShowWindowCommands.Minimize);
				}
			}
		}

		public static Monitor instance;

		private IntPtr desktopHandle; //Window handle for the desktop
		private IntPtr shellHandle; //Window handle for the shell
		private bool minerStarted = false;
		private Thread monThread;

		[DllImport("User32.dll")]
		public static extern Int32 SetForegroundWindow(int hWnd);
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll")]
		private static extern IntPtr GetDesktopWindow();
		[DllImport("user32.dll")]
		private static extern IntPtr GetShellWindow();
		[DllImport("user32.dll", SetLastError = true)]
		private static extern int GetWindowRect(IntPtr hwnd, out RECT rc);
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

	}
}
