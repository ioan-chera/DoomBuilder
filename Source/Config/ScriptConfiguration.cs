
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
using System.Windows.Forms;
using CodeImp.DoomBuilder.Map;

#endregion

namespace CodeImp.DoomBuilder.Config
{
	internal class ScriptConfiguration
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		// Original configuration
		private Configuration cfg;
		
		// Compiler settings
		private CompilerInfo compiler;
		private string parameters;
		private string resultlump;
		
		// Editor settings
		private bool casesensitive;
		private int insertcase;
		private int lexer;
		private string keywordhelp;
		
		// Collections
		private Dictionary<string, string> keywords;
		private Dictionary<string, string> lowerkeywords;
		private List<string> constants;
		private Dictionary<string, string> lowerconstants;
		
		#endregion

		#region ================== Properties

		// Compiler settings
		public CompilerInfo Compiler { get { return compiler; } }
		public string Parameters { get { return parameters; } }
		public string ResultLump { get { return resultlump; } }
		
		// Editor settings
		public bool CaseSensitive { get { return casesensitive; } }
		public int InsertCase { get { return insertcase; } }
		public int Lexer { get { return lexer; } }
		public string KeywordHelp { get { return keywordhelp; } }
		
		// Collections
		public Dictionary<string, string>.KeyCollection Keywords { get { return keywords.Keys; } }
		public Dictionary<string, string>.ValueCollection KeywordFunctions { get { return keywords.Values; } }
		public ICollection<string> Constants { get { return constants; } }
		
		#endregion

		#region ================== Constructor / Disposer
		
		// Constructor
		internal ScriptConfiguration(Configuration cfg)
		{
			string compilername;
			IDictionary dic;
			
			// Initialize
			this.cfg = cfg;
			this.keywords = new Dictionary<string,string>();
			this.constants = new List<string>();
			this.lowerkeywords = new Dictionary<string, string>();
			this.lowerconstants = new Dictionary<string, string>();
			
			// Read settings
			compilername = cfg.ReadSetting("compiler", "");
			parameters = cfg.ReadSetting("parameters", "");
			resultlump = cfg.ReadSetting("resultlump", "");
			casesensitive = cfg.ReadSetting("casesensitive", true);
			insertcase = cfg.ReadSetting("insertcase", 0);
			lexer = cfg.ReadSetting("lexer", 0);
			keywordhelp = cfg.ReadSetting("keywordhelp", "");
			
			// Load keywords
			dic = cfg.ReadSetting("keywords", new Hashtable());
			foreach(DictionaryEntry de in dic)
			{
				keywords.Add(de.Key.ToString(), de.Value.ToString());
				lowerkeywords.Add(de.Key.ToString().ToLowerInvariant(), de.Key.ToString());
			}
			
			// Load constants
			dic = cfg.ReadSetting("constants", new Hashtable());
			foreach(DictionaryEntry de in dic)
			{
				constants.Add(de.Key.ToString());
				lowerconstants.Add(de.Key.ToString().ToLowerInvariant(), de.Key.ToString());
			}
			
			// Compiler specified?
			if(compilername.Length > 0)
			{
				// Find compiler
				foreach(CompilerInfo c in General.Compilers)
				{
					// Compiler name matches?
					if(c.Name == compilername)
					{
						// Apply compiler
						this.compiler = c;
						break;
					}
				}
				
				// No compiler found?
				if(this.compiler == null) throw new Exception("No such compiler defined: '" + compilername + "'");
			}
		}
		
		#endregion

		#region ================== Methods
		
		// This returns the correct case for a keyword
		// Returns the same keyword as the input when it cannot be found
		public string GetKeywordCase(string keyword)
		{
			if(lowerkeywords.ContainsKey(keyword.ToLowerInvariant()))
				return lowerkeywords[keyword.ToLowerInvariant()];
			else
				return keyword;
		}

		// This returns the correct case for a constant
		// Returns the same constant as the input when it cannot be found
		public string GetConstantCase(string constant)
		{
			if(lowerconstants.ContainsKey(constant.ToLowerInvariant()))
				return lowerconstants[constant.ToLowerInvariant()];
			else
				return constant;
		}
		
		// This returns true when the given word is a keyword
		public bool IsKeyword(string keyword)
		{
			return lowerkeywords.ContainsKey(keyword.ToLowerInvariant());
		}

		// This returns true when the given word is a contant
		public bool IsConstant(string constant)
		{
			return lowerconstants.ContainsKey(constant.ToLowerInvariant());
		}
		
		#endregion
	}
}
