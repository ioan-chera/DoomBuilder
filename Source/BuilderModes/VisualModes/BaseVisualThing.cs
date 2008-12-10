
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
using CodeImp.DoomBuilder.Config;
using CodeImp.DoomBuilder.Data;

#endregion

namespace CodeImp.DoomBuilder.BuilderModes
{
	internal class BaseVisualThing : VisualThing
	{
		#region ================== Constants
		
		#endregion
		
		#region ================== Variables
		
		private ThingTypeInfo info;
		private bool isloaded;
		private ImageData sprite;
		
		#endregion
		
		#region ================== Properties
		
		#endregion
		
		#region ================== Constructor / Disposer
		
		// Constructor
		public BaseVisualThing(Thing t) : base(t)
		{
			// Find thing information
			info = General.Map.Config.GetThingInfo(Thing.Type);
			
			// Find sprite texture
			if(info.Sprite.Length > 0)
			{
				sprite = General.Map.Data.GetSpriteImage(info.Sprite);
				if(sprite != null) sprite.AddReference();
			}
			
			// We have no destructor
			GC.SuppressFinalize(this);
		}
		
		// This builds the thing geometry. Returns false when nothing was created.
		public virtual bool Setup()
		{
			if(sprite != null)
			{
				// Color to modulate sprite with (god knows what we could use this for)
				PixelColor pc = new PixelColor(255, 255, 255, 255);
				
				// Find the sector in which the thing resides
				Thing.DetermineSector();
				
				// Check if the texture is loaded
				isloaded = sprite.IsImageLoaded;
				if(isloaded)
				{
					base.Texture = sprite;
					
					// Determine sprite size
					float radius = sprite.ScaledWidth * 0.5f;
					float height = sprite.ScaledHeight;
					
					// Determine texture coordinates
					Vector2D t1 = new Vector2D(1.0f / sprite.ScaledWidth, 1.0f / sprite.ScaledHeight);
					Vector2D t2 = new Vector2D(1.0f - t1.x, 1.0f - t1.y);
					
					// Make vertices
					WorldVertex[] verts = new WorldVertex[6];
					verts[0] = new WorldVertex(-radius, 0.0f, 0.0f, pc.ToInt(), t1.x, t2.y);
					verts[1] = new WorldVertex(-radius, 0.0f, height, pc.ToInt(), t1.x, t1.y);
					verts[2] = new WorldVertex(+radius, 0.0f, height, pc.ToInt(), t2.x, t1.y);
					verts[3] = verts[0];
					verts[4] = verts[2];
					verts[5] = new WorldVertex(+radius, 0.0f, 0.0f, pc.ToInt(), t2.x, t2.y);
					SetVertices(verts);
				}
				else
				{
					base.Texture = General.Map.Data.Hourglass3D;
					
					// Determine sprite size
					float radius = info.Width * 0.5f;
					float height = info.Height;
					
					// Determine texture coordinates
					Vector2D t1 = new Vector2D(1.0f / base.Texture.ScaledWidth, 1.0f / base.Texture.ScaledHeight);
					Vector2D t2 = new Vector2D(1.0f - t1.x, 1.0f - t1.y);
					
					// Make vertices
					WorldVertex[] verts = new WorldVertex[6];
					verts[0] = new WorldVertex(-radius, 0.0f, 0.0f, pc.ToInt(), t1.x, t2.y);
					verts[1] = new WorldVertex(-radius, 0.0f, height, pc.ToInt(), t1.x, t1.y);
					verts[2] = new WorldVertex(+radius, 0.0f, height, pc.ToInt(), t2.x, t1.y);
					verts[3] = verts[0];
					verts[4] = verts[2];
					verts[5] = new WorldVertex(+radius, 0.0f, 0.0f, pc.ToInt(), t2.x, t2.y);
					SetVertices(verts);
				}
			}
			
			// Setup position
			Vector3D pos = Thing.Position;
			if(Thing.Sector != null) pos.z += Thing.Sector.FloorHeight;
			SetPosition(pos);
			
			// Done
			return true;
		}
		
		// Disposing
		public override void Dispose()
		{
			if(!IsDisposed)
			{
				if(sprite != null) sprite.RemoveReference();
			}
			
			base.Dispose();
		}
		
		#endregion
		
		#region ================== Methods
		
		// This updates the thing when needed
		public override void Update()
		{
			if(!isloaded)
			{
				// Rebuild sprite geometry when sprite is loaded
				if(sprite.IsImageLoaded)
				{
					Setup();
				}
			}
			
			// Let the base update
			base.Update();
		}
		
		#endregion
	}
}
