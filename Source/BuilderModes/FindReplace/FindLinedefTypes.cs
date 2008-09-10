
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
using System.Drawing;
using CodeImp.DoomBuilder.Editing;

#endregion

namespace CodeImp.DoomBuilder.BuilderModes
{
	[FindReplace("Linedef Types", BrowseButton = true)]
	internal class FindLinedefTypes : FindReplaceType
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		#endregion

		#region ================== Properties

		#endregion

		#region ================== Constructor / Destructor

		// Constructor
		public FindLinedefTypes()
		{
			// Initialize

		}

		// Destructor
		~FindLinedefTypes()
		{
		}

		#endregion

		#region ================== Methods

		// This is called when the browse button is pressed
		public override string Browse(string initialvalue)
		{
			int num = 0;
			int.TryParse(initialvalue, out num);
			return General.Interface.BrowseLinedefActions(BuilderPlug.Me.FindReplaceForm, num).ToString();
		}


		// This is called to perform a search (and replace)
		// Returns a list of items to show in the results list
		// replacewith is null when not replacing
		public override FindReplaceObject[] Find(string value, bool withinselection, string replacewith, bool keepselection)
		{
			List<FindReplaceObject> objs = new List<FindReplaceObject>();

			// Interpret the replacement
			int replaceaction = 0;
			if(replacewith != null)
			{
				// If it cannot be interpreted, set replacewith to null (not replacing at all)
				if(!int.TryParse(replacewith, out replaceaction)) replacewith = null;
			}

			// Interpret the number given
			int action = 0;
			if(int.TryParse(value, out action))
			{
				// Go for all linedefs
				foreach(Linedef l in General.Map.Map.Linedefs)
				{
					// Action matches?
					if(l.Action == action)
					{
						// Replace
						if(replacewith != null) l.Action = replaceaction;

						// Add to list
						objs.Add(new FindReplaceObject(l, "Linedef at " + l.GetCenterPoint().ToString()));
					}
				}
			}

			return objs.ToArray();
		}

		// This is called when a specific object is selected from the list
		public override void ObjectSelected(FindReplaceObject obj)
		{
			General.Interface.ShowLinedefInfo(obj.Linedef);
		}

		// Render selection
		public override void PlotSelection(IRenderer2D renderer, FindReplaceObject[] selection)
		{
			foreach(FindReplaceObject o in selection)
			{
				renderer.PlotLinedef(o.Linedef, General.Colors.Highlight);
			}
		}

		#endregion
	}
}