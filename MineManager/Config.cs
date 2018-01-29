using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace MineManager {
	class Config {
		public static void Load() {
			String appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MineManager");
			Directory.CreateDirectory(appDataPath);
			configFile = Path.Combine(appDataPath, "config.txt");
			if (!File.Exists(configFile)) {
				config["batFile"] = "1";
				config["minerProcess"] = "miner";
				config["windowProcess"] = "cmd";
				Save();
			}
			String[] configLines = File.ReadAllLines(configFile);
			foreach (String line in configLines) {
				int seperatorPos = line.IndexOf(':');
				config[line.Substring(0, seperatorPos)] = line.Substring(seperatorPos + 1, line.Length - (seperatorPos + 1));
			}
		}

		public static void Save() {
			String[] configLines = new string[config.Count];
			int i = 0;
			foreach (DictionaryEntry setting in config) {
				configLines[i] = setting.Key + ":" + setting.Value.ToString();
				i++;
			}
			File.WriteAllLines(configFile, configLines);
		}

		public static void SetValue(String key, Object value) {
			config[key] = value;
		}

		public static object GetValue(String key) {
			return config[key];
		}

		static String configFile = "";
		static Hashtable config = new Hashtable();
	}
}
