
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
using CodeImp.DoomBuilder.Controls;
using CodeImp.DoomBuilder.Data;
using CodeImp.DoomBuilder.Config;
using CodeImp.DoomBuilder.Rendering;
using SlimDX.Direct3D9;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

#endregion

namespace CodeImp.DoomBuilder.Interface
{
	public abstract partial class ImageSelectorControl : UserControl
	{
		// Properties
		public string TextureName { get { return name.Text; } set { name.Text = value; } }
		
		// Constructor
		public ImageSelectorControl()
		{
			// Initialize
			InitializeComponent();
		}
		
		// When resized
		private void ImageSelectorControl_Resize(object sender, EventArgs e)
		{
			// Fixed size
			//this.ClientSize = new Size(preview.Left + preview.Width, name.Top + name.Height);
			preview.Width = this.ClientSize.Width;
			preview.Height = this.ClientSize.Height - name.Height - 4;
			name.Width = this.ClientSize.Width;
			name.Top = this.ClientSize.Height - name.Height;
		}

		// Layout change
		private void ImageSelectorControl_Layout(object sender, LayoutEventArgs e)
		{
			ImageSelectorControl_Resize(sender, EventArgs.Empty);
		}

		// Image clicked
		private void preview_Click(object sender, EventArgs e)
		{
			name.Text = BrowseImage(name.Text);
		}

		// Name text changed
		private void name_TextChanged(object sender, EventArgs e)
		{
			General.DisplayZoomedImage(preview, FindImage(name.Text));
		}

		// This must determine and return the image to show
		protected abstract Image FindImage(string imagename);

		// This must show the image browser and return the selected texture name
		protected abstract string BrowseImage(string imagename);

		// This determines the result value
		public string GetResult(string original)
		{
			// Anyting entered?
			if(name.Text.Trim().Length > 0)
			{
				// Return the new value
				return name.Text;
			}
			else
			{
				// Nothing given, keep original value
				return original;
			}
		}
	}
}