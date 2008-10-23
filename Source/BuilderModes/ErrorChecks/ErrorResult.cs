
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
using CodeImp.DoomBuilder.Actions;
using CodeImp.DoomBuilder.Types;
using CodeImp.DoomBuilder.Config;

#endregion

namespace CodeImp.DoomBuilder.BuilderModes
{
	public class ErrorResult
	{
		#region ================== Variables
		
		protected string description;
		
		#endregion
		
		#region ================== Properties
		
		public string Description { get { return description; } }
		
		// Override these properties to create buttons
		public virtual int Buttons { get { return 0; } }
		public virtual string Button1Text { get { return ""; } }
		public virtual string Button2Text { get { return ""; } }
		public virtual string Button3Text { get { return ""; } }
		
		#endregion
		
		#region ================== Constructor / Destructor
		
		// Constructor
		public ErrorResult()
		{
			// Initialize
		}
		
		#endregion
		
		#region ================== Methods
		
		// When this result is selected
		public virtual void Selected()
		{
		}
		
		// When the first button is clicked
		public virtual void Button1Click()
		{
		}
		
		// When the second button is clicked
		public virtual void Button2Click()
		{
		}
		
		// When the third button is clicked
		public virtual void Button3Click()
		{
		}
		
		// This must return the string that is displayed in the listbox
		public override string ToString()
		{
			return "Unknown result";
		}
		
		#endregion
	}
}
