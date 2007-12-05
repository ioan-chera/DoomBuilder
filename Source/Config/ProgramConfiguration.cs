
#region ================== Copyright (c) 2007 Pascal vd Heiden

/*
 * Copyright (c) 2007 Pascal vd Heiden, www.codeimp.com
 * This program is released under GNU General Public License
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 */

#endregion

#region ================== Namespaces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Data;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

#endregion

namespace CodeImp.DoomBuilder.Config
{
	public class ProgramConfiguration
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		// Original configuration
		private Configuration cfg;
		
		// Cached variables
		private bool blackbrowsers;
		private float stitchdistance;
		
		#endregion

		#region ================== Properties

		public Configuration Config { get { return cfg; } }
		public bool BlackBrowsers { get { return blackbrowsers; } set { blackbrowsers = value; } }
		public float StitchDistance { get { return stitchdistance; } set { stitchdistance = value; } }

		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public ProgramConfiguration()
		{
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		#endregion

		#region ================== Loading / Saving

		// This loads the program configuration
		public bool Load(string cfgfilepathname, string defaultfilepathname)
		{
			// First parse it
			if(Read(cfgfilepathname, defaultfilepathname))
			{
				// Read the cache variables
				blackbrowsers = cfg.ReadSetting("blackbrowsers", false);
				stitchdistance = cfg.ReadSetting("stitchdistance", 2.0f);

				// Success
				return true;
			}
			else
			{
				// Failed
				return false;
			}
		}

		// This saves the program configuration
		public void Save(string filepathname)
		{
			// Write the cache variables
			cfg.WriteSetting("blackbrowsers", blackbrowsers);
			cfg.WriteSetting("stitchdistance", stitchdistance);

			// Save settings configuration
			General.WriteLogLine("Saving program configuration...");
			cfg.SaveConfiguration(filepathname);
		}
		
		// This reads the configuration
		private bool Read(string cfgfilepathname, string defaultfilepathname)
		{
			DialogResult result;

			// Check if no config for this user exists yet
			if(!File.Exists(cfgfilepathname))
			{
				// Copy new configuration
				General.WriteLogLine("Local user program configuration is missing!");
				File.Copy(defaultfilepathname, cfgfilepathname);
				General.WriteLogLine("New program configuration copied for local user");
			}

			// Load it
			cfg = new Configuration(cfgfilepathname, true);
			if(cfg.ErrorResult != 0)
			{
				// Error in configuration
				// Ask user for a new copy
				result = General.ShowErrorMessage("Error in program configuration near line " + cfg.ErrorLine + ": " + cfg.ErrorDescription, MessageBoxButtons.YesNoCancel);
				if(result == DialogResult.Yes)
				{
					// Remove old configuration and make a new copy
					General.WriteLogLine("User requested a new copy of the program configuration");
					File.Delete(cfgfilepathname);
					File.Copy(defaultfilepathname, cfgfilepathname);
					General.WriteLogLine("New program configuration copied for local user");

					// Load it
					cfg = new Configuration(cfgfilepathname, true);
					if(cfg.ErrorResult != 0)
					{
						// Error in configuration
						General.WriteLogLine("Error in program configuration near line " + cfg.ErrorLine + ": " + cfg.ErrorDescription);
						General.ShowErrorMessage("Default program configuration is corrupted. Please re-install Doom Builder.", MessageBoxButtons.OK);
						return false;
					}
				}
				else if(result == DialogResult.Cancel)
				{
					// User requested to cancel startup
					General.WriteLogLine("User cancelled startup");
					return false;
				}
			}

			// Success
			return true;
		}
		
		#endregion

		#region ================== Methods

		// ReadSetting
		public string ReadSetting(string setting, string defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public int ReadSetting(string setting, int defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public float ReadSetting(string setting, float defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public short ReadSetting(string setting, short defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public long ReadSetting(string setting, long defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public bool ReadSetting(string setting, bool defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public byte ReadSetting(string setting, byte defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }
		public IDictionary ReadSetting(string setting, IDictionary defaultsetting) { return cfg.ReadSetting(setting, defaultsetting); }

		// WriteSetting
		public bool WriteSetting(string setting, object settingvalue) { return cfg.WriteSetting(setting, settingvalue); }
		public bool WriteSetting(string setting, object settingvalue, string pathseperator) { return cfg.WriteSetting(setting, settingvalue, pathseperator); }
		
		#endregion
	}
}