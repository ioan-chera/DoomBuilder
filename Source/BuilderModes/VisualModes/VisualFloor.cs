
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
using System.Drawing;
using System.ComponentModel;
using CodeImp.DoomBuilder.Map;
using CodeImp.DoomBuilder.Geometry;
using System.Drawing.Imaging;
using CodeImp.DoomBuilder.Data;
using CodeImp.DoomBuilder.Editing;
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Rendering;
using CodeImp.DoomBuilder.VisualModes;

#endregion

namespace CodeImp.DoomBuilder.BuilderModes
{
	internal class VisualFloor : VisualGeometry
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		#endregion

		#region ================== Properties

		#endregion

		#region ================== Constructor / Setup

		// Constructor
		public VisualFloor()
		{
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		// This builds the geometry. Returns false when no geometry created.
		public bool Setup(Sector s)
		{
			WorldVertex[] verts;
			
			// Load floor texture
			base.Texture = General.Map.Data.GetFlatImage(s.LongFloorTexture);
			if(base.Texture == null) base.Texture = General.Map.Data.MissingTexture3D;

			// Make vertices
			verts = new WorldVertex[s.Triangles.Vertices.Count];
			for(int i = 0; i < s.Triangles.Vertices.Count; i++)
			{
				// Use sector brightness for color shading
				PixelColor pc = new PixelColor(255, unchecked((byte)s.Brightness),
													unchecked((byte)s.Brightness),
													unchecked((byte)s.Brightness));
				verts[i].c = pc.ToInt();
				//verts[i].c = -1;

				// Grid aligned texture coordinates
				if(base.Texture.IsImageLoaded)
				{
					verts[i].u = s.Triangles.Vertices[i].x / base.Texture.ScaledWidth;
					verts[i].v = s.Triangles.Vertices[i].y / base.Texture.ScaledHeight;
				}
				else
				{
					verts[i].u = s.Triangles.Vertices[i].x / 64;
					verts[i].v = s.Triangles.Vertices[i].y / 64;
				}

				// Vertex coordinates
				verts[i].x = s.Triangles.Vertices[i].x;
				verts[i].y = s.Triangles.Vertices[i].y;
				verts[i].z = (float)s.FloorHeight;
			}
			
			// Apply vertices
			base.SetVertices(verts);
			return (verts.Length > 0);
		}
		
		#endregion

		#region ================== Methods

		#endregion
	}
}
