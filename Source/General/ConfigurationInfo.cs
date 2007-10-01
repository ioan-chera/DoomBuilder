
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

#endregion

namespace CodeImp.DoomBuilder
{
	internal class ConfigurationInfo : IComparable<ConfigurationInfo>
	{
		#region ================== Variables

		private string name;
		private string filename;
		private string settingskey;
		private string nodebuilder;
		private bool buildonsave;
		private DataLocationList resources;
		private string testprogram;
		private string testparameters;

		#endregion

		#region ================== Properties

		public string Name { get { return name; } }
		public string Filename { get { return filename; } }
		public string Nodebuilder { get { return nodebuilder; } set { nodebuilder = value; } }
		public bool BuildOnSave { get { return buildonsave; } set { buildonsave = value; } }
		public DataLocationList Resources { get { return resources; } }
		public string TestProgram { get { return testprogram; } set { testprogram = value; } }
		public string TestParameters { get { return testparameters; } set { testparameters = value; } }

		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public ConfigurationInfo(string name, string filename)
		{
			// Initialize
			this.name = name;
			this.filename = filename;
			this.settingskey = Path.GetFileNameWithoutExtension(filename).ToLower();
			
			// Load settings from program configuration
			this.nodebuilder = General.Settings.ReadSetting("configurations." + settingskey + ".nodebuilder", "");
			this.buildonsave = General.Settings.ReadSetting("configurations." + settingskey + ".buildonsave", true);
			this.resources = new DataLocationList(General.Settings, "configurations." + settingskey + ".resources");
			this.testprogram = General.Settings.ReadSetting("configurations." + settingskey + ".testprogram", "");
			this.testparameters = General.Settings.ReadSetting("configurations." + settingskey + ".testparameters", "");
		}

		// Constructor
		private ConfigurationInfo()
		{
		}
		
		#endregion

		#region ================== Methods

		// This compares it to other ConfigurationInfo objects
		public int CompareTo(ConfigurationInfo other)
		{
			// Compare
			return name.CompareTo(other.name);
		}

		// This saves the settings to program configuration
		public void SaveSettings()
		{
			// Write to configuration
			General.Settings.WriteSetting("configurations." + settingskey + ".nodebuilder", nodebuilder);
			General.Settings.WriteSetting("configurations." + settingskey + ".buildonsave", buildonsave);
			resources.WriteToConfig(General.Settings, "configurations." + settingskey + ".resources");
			General.Settings.WriteSetting("configurations." + settingskey + ".testprogram", testprogram);
			General.Settings.WriteSetting("configurations." + settingskey + ".testparameters", testparameters);
		}

		// String representation
		public override string ToString()
		{
			return name;
		}

		// This clones the object
		public ConfigurationInfo Clone()
		{
			ConfigurationInfo ci = new ConfigurationInfo();
			ci.name = this.name;
			ci.filename = this.filename;
			ci.settingskey = this.settingskey;
			ci.nodebuilder = this.nodebuilder;
			ci.buildonsave = this.buildonsave;
			ci.resources = new DataLocationList();
			ci.resources.AddRange(this.resources);
			ci.testprogram = this.testprogram;
			ci.testparameters = this.testparameters;
			return ci;
		}
		
		// This applies settings from an object
		public void Apply(ConfigurationInfo ci)
		{
			this.name = ci.name;
			this.filename = ci.filename;
			this.settingskey = ci.settingskey;
			this.nodebuilder = ci.nodebuilder;
			this.buildonsave = ci.buildonsave;
			this.resources = new DataLocationList();
			this.resources.AddRange(ci.resources);
			this.testprogram = ci.testprogram;
			this.testparameters = ci.testparameters;
		}
		
		#endregion
	}
}
