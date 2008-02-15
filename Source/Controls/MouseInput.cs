
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
using CodeImp.DoomBuilder.Properties;
using System.IO;
using CodeImp.DoomBuilder.IO;
using System.Collections;
using System.Windows.Forms;
using SlimDX;
using SlimDX.DirectInput;
using CodeImp.DoomBuilder.Geometry;

#endregion

namespace CodeImp.DoomBuilder.Controls
{
	internal class MouseInput : IDisposable
	{
		#region ================== Variables

		// Mouse input
		private Device<MouseState> mouse;
		
		// Disposing
		private bool isdisposed = false;

		#endregion

		#region ================== Properties

		public bool IsDisposed { get { return isdisposed; } }

		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public MouseInput(Control source)
		{
			// Initialize
			DirectInput.Initialize();

			// Start mouse input
			mouse = new Device<MouseState>(SystemGuid.Mouse);
			if(mouse == null) throw new Exception("No mouse device found.");
			
			// Set mouse input settings
			mouse.Properties.AxisMode = DeviceAxisMode.Relative;
			
			// Set cooperative level
			mouse.SetCooperativeLevel(source,
				CooperativeLevel.NonExclusive | CooperativeLevel.Foreground);

			// Aquire device
			try { mouse.Acquire(); }
			catch(Exception) { }
			
			// We have no destructor
			GC.SuppressFinalize(this);
		}

		// Diposer
		public void Dispose()
		{
			// Not already disposed?
			if(!isdisposed)
			{
				// Dispose
				mouse.Unacquire();
				mouse.Dispose();
				DirectInput.Terminate();
				
				// Clean up
				mouse = null;
				
				// Done
				isdisposed = true;
			}
		}

		#endregion

		#region ================== Methods

		#endregion

		#region ================== Processing

		// This processes the input
		public Vector2D Process()
		{
			MouseState ms;
			float changex, changey;
			
			try
			{
				// Poll the device
				mouse.Poll();

				// Get the changes since previous poll
				ms = mouse.GetCurrentState();
				
				// Calculate changes depending on sensitivity
				changex = (float)ms.X * General.Settings.VisualMouseSensX;
				changey = (float)ms.Y * General.Settings.VisualMouseSensY;
				
				// Return changes
				return new Vector2D(changex, changey);
			}
			// Lost device?
			catch(InputLostException)
			{
				// Reaquire device
				try { mouse.Acquire(); }
				catch(Exception) { }
				return new Vector2D();
			}
			// Lost device?
			catch(DeviceNotAcquiredException)
			{
				// Reaquire device
				try { mouse.Acquire(); }
				catch(Exception) { }
				return new Vector2D();
			}
		}

		#endregion
	}
}