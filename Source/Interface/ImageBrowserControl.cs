
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
	internal partial class ImageBrowserControl : UserControl
	{
		#region ================== Delegates / Events

		public delegate void SelectedItemChangedDelegate();

		public event SelectedItemChangedDelegate SelectedItemChanged;
		
		#endregion

		#region ================== Variables

		// States
		private bool updating;
		
		// All items
		private List<ImageBrowserItem> items;
		
		#endregion

		#region ================== Properties

		public string LabelText { get { return label.Text; } set { label.Text = value; objectname.Left = label.Right + label.Margin.Right + objectname.Margin.Left; } }
		public ListViewItem SelectedItem { get { if(list.SelectedItems.Count > 0) return list.SelectedItems[0]; else return null; } }
		
		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public ImageBrowserControl()
		{
			// Initialize
			InitializeComponent();
			items = new List<ImageBrowserItem>();
			
			// Move textbox with label
			objectname.Left = label.Right + label.Margin.Right + objectname.Margin.Left;
		}

		// This applies the color settings
		public void ApplyColorSettings()
		{
			// Force black background?
			if(General.Settings.BlackBrowsers)
			{
				list.BackColor = Color.Black;
				list.ForeColor = Color.White;
			}
		}

		#endregion

		#region ================== Rendering

		// Draw item
		private void list_DrawItem(object sender, DrawListViewItemEventArgs e)
		{
			if(!updating) e.Graphics.DrawImageUnscaled((e.Item as ImageBrowserItem).GetImage(e.Bounds), e.Bounds);
		}

		// Resfresher
		private void refreshtimer_Tick(object sender, EventArgs e)
		{
			// Continue refreshing only when still loading data
			refreshtimer.Enabled = General.Map.Data.IsLoading;
			
			// Go for all items
			foreach(ImageBrowserItem i in list.Items)
			{
				// Bounds within view?
				if(i.Bounds.IntersectsWith(list.ClientRectangle))
				{
					// Items needs to be redrawn?
					if(i.CheckRedrawNeeded(i.Bounds))
					{
						// Redraw item
						i.GetImage(i.Bounds);

						// Refresh item in list
						list.RedrawItems(i.Index, i.Index, false);
					}
				}
			}
		}
		
		#endregion

		#region ================== Events

		// Name typed
		private void objectname_TextChanged(object sender, EventArgs e)
		{
			// Update list
			RefillList();

			// No item selected?
			if(list.SelectedItems.Count == 0)
			{
				// Select first
				SelectFirstItem();
			}
		}

		// Key pressed
		private void objectname_KeyDown(object sender, KeyEventArgs e)
		{
			// Check what key is pressed
			switch(e.KeyData)
			{
				// Cursor keys
				case Keys.Left: SelectNextItem(SearchDirectionHint.Left); e.SuppressKeyPress = true; break;
				case Keys.Right: SelectNextItem(SearchDirectionHint.Right); e.SuppressKeyPress = true; break;
				case Keys.Up: SelectNextItem(SearchDirectionHint.Up); e.SuppressKeyPress = true;  break;
				case Keys.Down: SelectNextItem(SearchDirectionHint.Down); e.SuppressKeyPress = true; break;
			}
		}

		// Selection changed
		private void list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// Raise event
			if(SelectedItemChanged != null) SelectedItemChanged();
		}
		
		#endregion

		#region ================== Methods

		// This selects an item by name
		public void SelectItem(string name)
		{
			ListViewItem lvi;
			
			// Find item with this text
			lvi = list.FindItemWithText(name);
			if(lvi != null)
			{
				// Does the text really match?
				if(lvi.Text == name)
				{
					// Select this item
					list.SelectedItems.Clear();
					lvi.Selected = true;
					lvi.EnsureVisible();
				}
			}
		}
		
		// This performs item sleection by keys
		private void SelectNextItem(SearchDirectionHint dir)
		{
			ListViewItem lvi;
			Point spos;
			
			// Nothing selected?
			if(list.SelectedItems.Count == 0)
			{
				// Select first
				SelectFirstItem();
			}
			else
			{
				// Get selected item
				lvi = list.SelectedItems[0];
				
				// Determine point to start searching from
				switch(dir)
				{
					case SearchDirectionHint.Left: spos = new Point(lvi.Bounds.Left - 1, lvi.Bounds.Top + 1); break;
					case SearchDirectionHint.Right: spos = new Point(lvi.Bounds.Left + 1, lvi.Bounds.Top + 1); break;
					case SearchDirectionHint.Up: spos = new Point(lvi.Bounds.Left + 1, lvi.Bounds.Top - 1); break;
					case SearchDirectionHint.Down: spos = new Point(lvi.Bounds.Left + 1, lvi.Bounds.Bottom + 1); break;
					default: spos = new Point(0, 0); break;
				}
				
				// Find next item
				//lvi = list.SelectedItems[0].FindNearestItem(dir);
				lvi = list.FindNearestItem(dir, spos);
				if(lvi != null)
				{
					// Select next item
					list.SelectedItems.Clear();
					lvi.Selected = true;
				}
				
				// Make selection visible
				if(list.SelectedItems.Count > 0) list.SelectedItems[0].EnsureVisible();
			}
		}

		// This selectes the first item
		private void SelectFirstItem()
		{
			ListViewItem lvi;
			
			// Select first
			if(list.Items.Count > 0)
			{
				list.SelectedItems.Clear();
				lvi = list.FindNearestItem(SearchDirectionHint.Down, new Point(1, -100000));
				if(lvi != null)
				{
					lvi.Selected = true;
					lvi.EnsureVisible();
				}
			}
		}
		
		// This adds a group
		public ListViewGroup AddGroup(string name)
		{
			ListViewGroup grp = new ListViewGroup(name);
			list.Groups.Add(grp);
			return grp;
		}
		
		// This begins adding items
		public void BeginAdding()
		{
			// Stop updating
			refreshtimer.Enabled = false;
		}

		// This ends adding items
		public void EndAdding()
		{
			// Fill list with items
			RefillList();

			// Start updating if needed
			refreshtimer.Enabled = General.Map.Data.IsLoading;
			
			// Select first item
			SelectFirstItem();
		}
		
		// This adds an item
		public void Add(string text, ImageData image, object tag, ListViewGroup group)
		{
			ImageBrowserItem i = new ImageBrowserItem(text, image, tag);
			i.ListGroup = group;
			i.Group = group;
			items.Add(i);
		}

		// This fills the list based on the objectname filter
		private void RefillList()
		{
			List<ListViewItem> showitems = new List<ListViewItem>();
			
			// Begin updating list
			updating = true;
			list.SuspendLayout();
			list.BeginUpdate();
			
			// Clear list first
			// Group property of items will be set to null, we will restore it later
			list.Items.Clear();
			
			// Go for all items NOT in the list
			foreach(ImageBrowserItem i in items)
			{
				// Add item if valid
				if(ValidateItem(i))
				{
					i.Group = i.ListGroup;
					i.Selected = false;
					showitems.Add(i);
				}
			}

			// Fill list
			list.Items.AddRange(showitems.ToArray());

			// Done updating list
			updating = false;
			list.EndUpdate();
			list.ResumeLayout();
			
			// Raise event
			if(SelectedItemChanged != null) SelectedItemChanged();
		}

		// This validates an item
		private bool ValidateItem(ImageBrowserItem i)
		{
			return i.Text.Contains(objectname.Text);
		}
		
		// This sends the focus to the textbox
		public void FocusTextbox()
		{
			objectname.Focus();
		}
		
		#endregion
	}
}