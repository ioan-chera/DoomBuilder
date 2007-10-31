
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using CodeImp.DoomBuilder.Data;
using CodeImp.DoomBuilder.Map;

#endregion

namespace CodeImp.DoomBuilder.Interface
{
	public partial class SectorInfoPanel : UserControl
	{
		// Constructor
		public SectorInfoPanel()
		{
			// Initialize
			InitializeComponent();
		}

		// This shows the info
		public void ShowInfo(Sector s)
		{
			int sheight = s.CeilHeight - s.FloorHeight;

			// TODO: Lookup effect description in config

			// Sector info
			effect.Text = s.Effect.ToString();
			ceiling.Text = s.CeilHeight.ToString();
			floor.Text = s.FloorHeight.ToString();
			tag.Text = s.Tag.ToString();
			height.Text = sheight.ToString();
			brightness.Text = s.Brightness.ToString();
			floorname.Text = s.FloorTexture;
			ceilingname.Text = s.CeilTexture;
			floortex.BackgroundImage = General.Map.Data.GetFlatBitmap(s.FloorTexture);
			ceilingtex.BackgroundImage = General.Map.Data.GetFlatBitmap(s.CeilTexture);

			// Show the whole thing
			this.Show();
			this.Update();
		}

		// When visible changed
		protected override void OnVisibleChanged(EventArgs e)
		{
			// Hiding panels
			if(!this.Visible)
			{
				floortex.BackgroundImage = null;
				ceilingtex.BackgroundImage = null;
			}

			// Call base
			base.OnVisibleChanged(e);
		}
	}
}