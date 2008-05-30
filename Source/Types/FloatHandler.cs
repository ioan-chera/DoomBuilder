
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
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Data;
using System.IO;
using System.Diagnostics;

#endregion

namespace CodeImp.DoomBuilder.Types
{
	[TypeHandler(1, "Float", true)]
	internal class FloatHandler : TypeHandler
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		private float value;

		#endregion

		#region ================== Properties

		#endregion

		#region ================== Methods

		public override void SetValue(object value)
		{
			float result;

			// Null?
			if(value == null)
			{
				this.value = 0.0f;
			}
			// Already an int or float?
			else if((value is int) || (value is float))
			{
				// Set directly
				this.value = (float)value;
			}
			else
			{
				// Try parsing as string
				if(float.TryParse(value.ToString(), NumberStyles.Float, CultureInfo.CurrentCulture, out result))
				{
					this.value = result;
				}
				else
				{
					this.value = 0.0f;
				}
			}
		}

		public override object GetValue()
		{
			return this.value;
		}

		public override int GetIntValue()
		{
			return (int)this.value;
		}

		public override string GetStringValue()
		{
			return this.value.ToString();
		}

		#endregion
	}
}