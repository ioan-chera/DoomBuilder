
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
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using CodeImp.DoomBuilder.IO;
using System.Windows.Forms;
using SlimDX.Direct3D9;

#endregion

namespace CodeImp.DoomBuilder.Data
{
	public sealed class DataManager : IDisposable
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		// Data containers
		private List<DataReader> containers;

		// Palette
		private Playpal palette;
		
		// Textures
		private Dictionary<long, ImageData> textures;
		
		// Flats
		private Dictionary<long, ImageData> flats;

		// Sprites
		private Dictionary<long, ImageData> sprites;

		// Disposing
		private bool isdisposed = false;

		#endregion

		#region ================== Properties

		public Playpal Palette { get { return palette; } }
		public bool IsDisposed { get { return isdisposed; } }

		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public DataManager()
		{
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		// Disposer
		public void Dispose()
		{
			// Not already disposed?
			if(!isdisposed)
			{
				// Clean up
				Unload();
				
				// Done
				isdisposed = true;
			}
		}

		#endregion

		#region ================== Loading / Unloading

		// This loads all data resources
		public void Load(DataLocationList configlist, DataLocationList maplist, DataLocation maplocation)
		{
			DataLocationList all = DataLocationList.Combined(configlist, maplist);
			all.Add(maplocation);
			Load(all);
		}

		// This loads all data resources
		public void Load(DataLocationList configlist, DataLocationList maplist)
		{
			DataLocationList all = DataLocationList.Combined(configlist, maplist);
			Load(all);
		}

		// This loads all data resources
		public void Load(DataLocationList locations)
		{
			DataReader c;
			
			// Create collections
			containers = new List<DataReader>();
			textures = new Dictionary<long, ImageData>();
			flats = new Dictionary<long, ImageData>();
			sprites = new Dictionary<long, ImageData>();
			
			// Go for all locations
			foreach(DataLocation dl in locations)
			{
				// Nothing chosen yet
				c = null;

				// TODO: Make this work more elegant using reflection.
				// Make DataLocation.type of type Type and assign the
				// types of the desired reader classes.

				try
				{
					// Choose container type
					switch(dl.type)
					{
						// WAD file container
						case DataLocation.RESOURCE_WAD:
							c = new WADReader(dl);
							break;

						// Directory container
						case DataLocation.RESOURCE_DIRECTORY:
							c = new DirectoryReader(dl);
							break;
					}
				}
				catch(Exception)
				{
					// Unable to load resource
					General.ShowErrorMessage("Unable to load resources from location \"" + dl.location + "\". Please make sure the location is accessible and not in use by another program.", MessageBoxButtons.OK);
					continue;
				}	
				
				// Add container
				if(c != null) containers.Add(c);
			}

			// Load stuff
			General.WriteLogLine("Loading PLAYPAL palette...");
			LoadPalette();
			General.WriteLogLine("Loading textures...");
			LoadTextures();
			General.WriteLogLine("Loading flats...");
			LoadFlats();
		}

		// This unloads all data
		public void Unload()
		{
			// Dispose resources
			foreach(KeyValuePair<long, ImageData> i in textures) i.Value.Dispose();
			foreach(KeyValuePair<long, ImageData> i in flats) i.Value.Dispose();
			foreach(KeyValuePair<long, ImageData> i in sprites) i.Value.Dispose();
			palette = null;
			
			// Dispose containers
			foreach(DataReader c in containers) c.Dispose();
			containers.Clear();
		}

		#endregion
		
		#region ================== Suspend / Resume

		// This suspends data resources
		public void Suspend()
		{
			// Go for all containers
			foreach(DataReader d in containers)
			{
				// Suspend
				General.WriteLogLine("Suspended data resource '" + d.Location.location + "'");
				d.Suspend();
			}
		}

		// This resumes data resources
		public void Resume()
		{
			// Go for all containers
			foreach(DataReader d in containers)
			{
				try
				{
					// Resume
					General.WriteLogLine("Resumed data resource '" + d.Location.location + "'");
					d.Resume();
				}
				catch(Exception)
				{
					// Unable to load resource
					General.ShowErrorMessage("Unable to load resources from location \"" + d.Location.location + "\". Please make sure the location is accessible and not in use by another program.", MessageBoxButtons.OK);
				}
			}
		}
		
		#endregion

		#region ================== Palette

		// This loads the PLAYPAL palette
		private void LoadPalette()
		{
			// Go for all opened containers
			for(int i = containers.Count - 1; i >= 0; i--)
			{
				// Load palette
				palette = containers[i].LoadPalette();
				if(palette != null) break;
			}
		}

		#endregion

		#region ================== Textures
		
		// This loads the textures
		private void LoadTextures()
		{
			PatchNames pnames = new PatchNames();
			ICollection<ImageData> images;
			
			// Go for all opened containers
			foreach(DataReader dr in containers)
			{
				// Load PNAMES info
				// Note that pnames is NOT set to null in the loop
				// because if a container has no pnames, the pnames
				// of the previous (higher) container should be used.
				pnames = dr.LoadPatchNames();
				if(pnames != null)
				{
					// Load textures
					images = dr.LoadTextures(pnames);
					if(images != null)
					{
						// Go for all textures
						foreach(ImageData img in images)
						{
							// Add or replace in textures list
							textures.Remove(img.LongName);
							textures.Add(img.LongName, img);
						}
					}
				}
			}
		}
		
		// This returns a specific patch stream
		public Stream GetPatchData(string pname)
		{
			Stream patch;

			// Go for all opened containers
			for(int i = containers.Count - 1; i >= 0; i--)
			{
				// This contain provides this patch?
				patch = containers[i].GetPatchData(pname);
				if(patch != null) return patch;
			}

			// No such patch found
			return null;
		}
		
		// This returns an image by string
		public ImageData GetTextureImage(string name)
		{
			// Get the long name
			long longname = Lump.MakeLongName(name);
			return GetTextureImage(longname);
		}

		// This returns an image by long
		public ImageData GetTextureImage(long longname)
		{
			// Does this texture exist?
			if(textures.ContainsKey(longname))
			{
				// Return texture
				return textures[longname];
			}
			else
			{
				// Return null image
				return new NullImage();
			}
		}

		// This returns a bitmap by string
		public Bitmap GetTextureBitmap(string name)
		{
			ImageData img = GetTextureImage(name);
			img.LoadImage();
			return img.Bitmap;
		}

		// This returns a bitmap by string
		public Bitmap GetTextureBitmap(long longname)
		{
			ImageData img = GetTextureImage(longname);
			img.LoadImage();
			return img.Bitmap;
		}

		// This returns a texture by string
		public Texture GetTextureTexture(string name)
		{
			ImageData img = GetTextureImage(name);
			img.LoadImage();
			img.CreateTexture();
			return img.Texture;
		}

		// This returns a texture by string
		public Texture GetTextureTexture(long longname)
		{
			ImageData img = GetTextureImage(longname);
			img.LoadImage();
			img.CreateTexture();
			return img.Texture;
		}
		
		#endregion

		#region ================== Flats

		// This loads the flats
		private void LoadFlats()
		{
			ICollection<ImageData> images;

			// Go for all opened containers
			foreach(DataReader dr in containers)
			{
				// Load flats
				images = dr.LoadFlats();
				if(images != null)
				{
					// Go for all flats
					foreach(ImageData img in images)
					{
						// Add or replace in flats list
						flats.Remove(img.LongName);
						flats.Add(img.LongName, img);
					}
				}
			}
		}

		// This returns a specific flat stream
		public Stream GetFlatData(string pname)
		{
			Stream flat;

			// Go for all opened containers
			for(int i = containers.Count - 1; i >= 0; i--)
			{
				// This contain provides this flat?
				flat = containers[i].GetFlatData(pname);
				if(flat != null) return flat;
			}

			// No such patch found
			return null;
		}
		
		// This returns an image by string
		public ImageData GetFlatImage(string name)
		{
			// Get the long name
			long longname = Lump.MakeLongName(name);
			return GetFlatImage(longname);
		}

		// This returns an image by long
		public ImageData GetFlatImage(long longname)
		{
			// Does this flat exist?
			if(flats.ContainsKey(longname))
			{
				// Return flat
				return flats[longname];
			}
			else
			{
				// Return null image
				return new NullImage();
			}
		}

		// This returns a bitmap by string
		public Bitmap GetFlatBitmap(string name)
		{
			ImageData img = GetFlatImage(name);
			img.LoadImage();
			return img.Bitmap;
		}

		// This returns a bitmap by string
		public Bitmap GetFlatBitmap(long longname)
		{
			ImageData img = GetFlatImage(longname);
			img.LoadImage();
			return img.Bitmap;
		}

		// This returns a texture by string
		public Texture GetFlatTexture(string name)
		{
			ImageData img = GetFlatImage(name);
			img.LoadImage();
			img.CreateTexture();
			return img.Texture;
		}

		// This returns a texture by string
		public Texture GetFlatTexture(long longname)
		{
			ImageData img = GetFlatImage(longname);
			img.LoadImage();
			img.CreateTexture();
			return img.Texture;
		}
		
		#endregion

		#region ================== Sprites

		// This returns an image by long
		public ImageData GetSpriteImage(string name)
		{
			Stream spritedata = null;
			long longname = Lump.MakeLongName(name);
			SpriteImage image;

			// Sprite already loaded?
			if(sprites.ContainsKey(longname))
			{
				// Return exiting sprite
				return sprites[longname];
			}
			else
			{
				// Go for all opened containers
				for(int i = containers.Count - 1; i >= 0; i--)
				{
					// This contain provides this sprite?
					spritedata = containers[i].GetSpriteData(name);
					if(spritedata != null) break;
				}

				// Found anything?
				if(spritedata != null)
				{
					// Make new sprite image
					image = new SpriteImage(name);

					// Add to collection
					sprites.Add(longname, image);

					// Return result
					return image;
				}
				else
				{
					// Return null image
					return new NullImage();
				}
			}
		}

		// This returns a bitmap by string
		public Bitmap GetSpriteBitmap(string name)
		{
			ImageData img = GetSpriteImage(name);
			img.LoadImage();
			return img.Bitmap;
		}

		// This returns a texture by string
		public Texture GetSpriteTexture(string name)
		{
			ImageData img = GetSpriteImage(name);
			img.LoadImage();
			img.CreateTexture();
			return img.Texture;
		}
		
		#endregion
	}
}
