
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
	internal abstract class BaseVisualGeometrySidedef : VisualGeometry, IVisualEventReceiver
	{
		#region ================== Constants
		
		private const float DRAG_ANGLE_TOLERANCE = 0.02f;
		
		#endregion

		#region ================== Variables

		protected BaseVisualMode mode;

		protected float top;
		protected float bottom;
		
		// UV dragging
		private float dragstartanglexy;
		private float dragstartanglez;
		private Vector3D dragorigin;
		private Vector3D deltaxy;
		private Vector3D deltaz;
		private int startoffsetx;
		private int startoffsety;
		protected bool uvdragging;
		
		#endregion
		
		#region ================== Properties
		
		public bool IsDraggingUV { get { return uvdragging; } }
		new public BaseVisualSector Sector { get { return (BaseVisualSector)base.Sector; } }
		
		#endregion
		
		#region ================== Constructor / Destructor
		
		// Constructor for sidedefs
		public BaseVisualGeometrySidedef(BaseVisualMode mode, VisualSector vs, Sidedef sd) : base(vs, sd)
		{
			this.mode = mode;
			this.deltaz = new Vector3D(0.0f, 0.0f, 1.0f);
			this.deltaxy = (sd.Line.End.Position - sd.Line.Start.Position) * sd.Line.LengthInv;
			if(!sd.IsFront) this.deltaxy = -this.deltaxy;
		}
		
		#endregion

		#region ================== Methods

		// This performs a fast test in object picking
		public override bool PickFastReject(Vector3D from, Vector3D to, Vector3D dir)
		{
			// Check if intersection point is between top and bottom
			return (pickintersect.z >= bottom) && (pickintersect.z <= top);
		}

		// This performs an accurate test for object picking
		public override bool PickAccurate(Vector3D from, Vector3D to, Vector3D dir, ref float u_ray)
		{
			// The fast reject pass is already as accurate as it gets,
			// so we just return the intersection distance here
			u_ray = pickrayu;
			return true;
		}
		
		#endregion

		#region ================== Events
		
		// Unused
		public virtual void OnEditBegin() { }
		
		// Select button pressed
		public virtual void OnSelectBegin()
		{
			dragstartanglexy = mode.CameraAngleXY;
			dragstartanglez = mode.CameraAngleZ;
			dragorigin = pickintersect;
			startoffsetx = Sidedef.OffsetX;
			startoffsety = Sidedef.OffsetY;
		}
		
		// Select button released
		public virtual void OnSelectEnd()
		{
			// Was dragging?
			if(uvdragging)
			{
				// Dragging stops now
				mode.UnlockTarget();
				uvdragging = false;
			}
			else
			{
				// Add/remove selection
			}
		}
		
		// Edit button released
		public virtual void OnEditEnd()
		{
			List<Linedef> lines = new List<Linedef>();
			lines.Add(this.Sidedef.Line);
			DialogResult result = General.Interface.ShowEditLinedefs(lines);
			if(result == DialogResult.OK) (this.Sector as BaseVisualSector).Rebuild();
		}
		
		// Mouse moves
		public virtual void OnMouseMove(MouseEventArgs e)
		{
			// Dragging UV?
			if(uvdragging)
			{
				UpdateDragUV();
			}
			else
			{
				// Select button pressed?
				if(General.Interface.CheckActionActive(General.ThisAssembly, "visualselect"))
				{
					// Check if tolerance is exceeded to start UV dragging
					float deltaxy = mode.CameraAngleXY - dragstartanglexy;
					float deltaz = mode.CameraAngleZ - dragstartanglez;
					if((Math.Abs(deltaxy) + Math.Abs(deltaz)) > DRAG_ANGLE_TOLERANCE)
					{
						// Start drag now
						uvdragging = true;
						mode.LockTarget();
						UpdateDragUV();
					}
				}
			}
		}
		
		// This is called to update UV dragging
		protected virtual void UpdateDragUV()
		{
			float u_ray;
			
			// Calculate intersection position
			Line2D ray = new Line2D(mode.CameraPosition, mode.CameraTarget);
			Sidedef.Line.Line.GetIntersection(ray, out u_ray);
			Vector3D intersect = mode.CameraPosition + (mode.CameraTarget - mode.CameraPosition) * u_ray;
			
			// Calculate offsets
			Vector3D dragdelta = intersect - dragorigin;
			Vector3D dragdeltaxy = dragdelta * deltaxy;
			Vector3D dragdeltaz = dragdelta * deltaz;
			float offsetx = dragdeltaxy.GetLength();
			float offsety = dragdeltaz.GetLength();
			if((Math.Sign(dragdeltaxy.x) < 0) || (Math.Sign(dragdeltaxy.y) < 0) || (Math.Sign(dragdeltaxy.z) < 0)) offsetx = -offsetx;
			if((Math.Sign(dragdeltaz.x) < 0) || (Math.Sign(dragdeltaz.y) < 0) || (Math.Sign(dragdeltaz.z) < 0)) offsety = -offsety;
			
			// Apply offsets
			Sidedef.OffsetX = startoffsetx - (int)Math.Round(offsetx);
			Sidedef.OffsetY = startoffsety + (int)Math.Round(offsety);
			
			// Update sidedef geometry
			VisualSidedefParts parts = Sector.GetSidedefParts(Sidedef);
			if(parts.lower != null) parts.lower.Setup();
			if(parts.middledouble != null) parts.middledouble.Setup();
			if(parts.middlesingle != null) parts.middlesingle.Setup();
			if(parts.upper != null) parts.upper.Setup();
		}
		
		#endregion
	}
}