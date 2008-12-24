
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
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using CodeImp.DoomBuilder.Windows;
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Map;
using CodeImp.DoomBuilder.Rendering;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Editing;
using CodeImp.DoomBuilder.VisualModes;

#endregion

namespace CodeImp.DoomBuilder.BuilderModes
{
	internal abstract class BaseVisualGeometrySector : VisualGeometry, IVisualEventReceiver
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		protected BaseVisualMode mode;

		#endregion

		#region ================== Properties
		
		new public BaseVisualSector Sector { get { return (BaseVisualSector)base.Sector; } }
		
		#endregion

		#region ================== Constructor / Destructor

		// Constructor
		public BaseVisualGeometrySector(BaseVisualMode mode, VisualSector vs) : base(vs)
		{
			this.mode = mode;
		}

		#endregion

		#region ================== Methods

		// This changes the height
		protected abstract void ChangeHeight(int amount);

		#endregion

		#region ================== Events

		// Unused
		public virtual void OnSelectBegin() { }
		public virtual void OnSelectEnd() { }
		public virtual void OnEditBegin() { }
		public virtual void OnMouseMove(MouseEventArgs e) { }
		
		// Edit button released
		public virtual void OnEditEnd()
		{
			List<Sector> sectors = new List<Sector>();
			sectors.Add(this.Sector.Sector);
			DialogResult result = General.Interface.ShowEditSectors(sectors);
			if(result == DialogResult.OK) (this.Sector as BaseVisualSector).Rebuild();
		}

		// Sector height change
		public virtual void OnChangeTargetHeight(int amount)
		{
			ChangeHeight(amount);
			
			// Rebuild sector
			Sector.Rebuild();
			
			// Also rebuild surrounding sectors, because outside sidedefs may need to be adjusted
			foreach(Sidedef sd in Sector.Sector.Sidedefs)
			{
				if((sd.Other != null) && mode.VisualSectorExists(sd.Other.Sector))
				{
					BaseVisualSector bvs = (BaseVisualSector)mode.GetVisualSector(sd.Other.Sector);
					bvs.Rebuild();
				}
			}
		}
		
		// Sector brightness change
		public virtual void OnChangeTargetBrightness(int amount)
		{
			// Change brightness
			General.Map.UndoRedo.CreateUndo("Change sector brightness", UndoGroup.SectorBrightnessChange, Sector.Sector.Index);
			Sector.Sector.Brightness = General.Clamp(Sector.Sector.Brightness + amount, 0, 255);
			
			// Rebuild sector
			Sector.Rebuild();
		}
		
		#endregion
	}
}
