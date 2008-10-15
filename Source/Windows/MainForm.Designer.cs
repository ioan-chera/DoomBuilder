namespace CodeImp.DoomBuilder.Windows
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
			System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
			System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
			System.Windows.Forms.ToolStripSeparator toolstripSeperator1;
			System.Windows.Forms.ToolStripSeparator toolstripSeperator6;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
			System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttoneditmodesseperator = new System.Windows.Forms.ToolStripSeparator();
			this.poscommalabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.menumain = new System.Windows.Forms.MenuStrip();
			this.menufile = new System.Windows.Forms.ToolStripMenuItem();
			this.itemclosemap = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsavemapas = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsavemapinto = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.itemnorecent = new System.Windows.Forms.ToolStripMenuItem();
			this.itemexit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuedit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.itemgridinc = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgriddec = new System.Windows.Forms.ToolStripMenuItem();
			this.menumode = new System.Windows.Forms.ToolStripMenuItem();
			this.menutools = new System.Windows.Forms.ToolStripMenuItem();
			this.itemreloadresources = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuhelp = new System.Windows.Forms.ToolStripMenuItem();
			this.itemhelpabout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolbar = new System.Windows.Forms.ToolStrip();
			this.thingfilters = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.statusbar = new System.Windows.Forms.StatusStrip();
			this.configlabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.gridlabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.zoomlabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.xposlabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.yposlabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelinfo = new System.Windows.Forms.Panel();
			this.modename = new System.Windows.Forms.Label();
			this.vertexinfo = new CodeImp.DoomBuilder.Controls.VertexInfoPanel();
			this.thinginfo = new CodeImp.DoomBuilder.Controls.ThingInfoPanel();
			this.sectorinfo = new CodeImp.DoomBuilder.Controls.SectorInfoPanel();
			this.linedefinfo = new CodeImp.DoomBuilder.Controls.LinedefInfoPanel();
			this.redrawtimer = new System.Windows.Forms.Timer(this.components);
			this.display = new CodeImp.DoomBuilder.Controls.RenderTargetControl();
			this.processor = new System.Windows.Forms.Timer(this.components);
			this.warningtimer = new System.Windows.Forms.Timer(this.components);
			this.warningflasher = new System.Windows.Forms.Timer(this.components);
			this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttongrid = new System.Windows.Forms.ToolStripDropDownButton();
			this.itemgrid1024 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid512 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid256 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid128 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid64 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid32 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid16 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid8 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgrid4 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgridcustom = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonzoom = new System.Windows.Forms.ToolStripDropDownButton();
			this.itemzoom200 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoom100 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoom50 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoom25 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoom10 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoom5 = new System.Windows.Forms.ToolStripMenuItem();
			this.itemzoomfittoscreen = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonnewmap = new System.Windows.Forms.ToolStripButton();
			this.buttonopenmap = new System.Windows.Forms.ToolStripButton();
			this.buttonsavemap = new System.Windows.Forms.ToolStripButton();
			this.buttonmapoptions = new System.Windows.Forms.ToolStripButton();
			this.buttonundo = new System.Windows.Forms.ToolStripButton();
			this.buttonredo = new System.Windows.Forms.ToolStripButton();
			this.buttoncut = new System.Windows.Forms.ToolStripButton();
			this.buttoncopy = new System.Windows.Forms.ToolStripButton();
			this.buttonpaste = new System.Windows.Forms.ToolStripButton();
			this.buttonthingsfilter = new System.Windows.Forms.ToolStripButton();
			this.buttonviewnormal = new System.Windows.Forms.ToolStripButton();
			this.buttonviewbrightness = new System.Windows.Forms.ToolStripButton();
			this.buttonviewfloors = new System.Windows.Forms.ToolStripButton();
			this.buttonviewceilings = new System.Windows.Forms.ToolStripButton();
			this.buttonsnaptogrid = new System.Windows.Forms.ToolStripButton();
			this.buttonautomerge = new System.Windows.Forms.ToolStripButton();
			this.buttontestmonsters = new System.Windows.Forms.ToolStripButton();
			this.buttontest = new System.Windows.Forms.ToolStripSplitButton();
			this.itemnewmap = new System.Windows.Forms.ToolStripMenuItem();
			this.itemopenmap = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsavemap = new System.Windows.Forms.ToolStripMenuItem();
			this.itemtestmap = new System.Windows.Forms.ToolStripMenuItem();
			this.itemundo = new System.Windows.Forms.ToolStripMenuItem();
			this.itemredo = new System.Windows.Forms.ToolStripMenuItem();
			this.itemcut = new System.Windows.Forms.ToolStripMenuItem();
			this.itemcopy = new System.Windows.Forms.ToolStripMenuItem();
			this.itempaste = new System.Windows.Forms.ToolStripMenuItem();
			this.itemsnaptogrid = new System.Windows.Forms.ToolStripMenuItem();
			this.itemautomerge = new System.Windows.Forms.ToolStripMenuItem();
			this.itemgridsetup = new System.Windows.Forms.ToolStripMenuItem();
			this.itemmapoptions = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			toolstripSeperator1 = new System.Windows.Forms.ToolStripSeparator();
			toolstripSeperator6 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menumain.SuspendLayout();
			this.toolbar.SuspendLayout();
			this.statusbar.SuspendLayout();
			this.panelinfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
			// 
			// toolStripMenuItem2
			// 
			toolStripMenuItem2.Name = "toolStripMenuItem2";
			toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
			// 
			// toolStripMenuItem3
			// 
			toolStripMenuItem3.Name = "toolStripMenuItem3";
			toolStripMenuItem3.Size = new System.Drawing.Size(198, 6);
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new System.Drawing.Size(194, 6);
			// 
			// toolStripSeparator9
			// 
			toolStripSeparator9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			toolStripSeparator9.Name = "toolStripSeparator9";
			toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator10
			// 
			toolStripSeparator10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator11
			// 
			toolStripSeparator11.Name = "toolStripSeparator11";
			toolStripSeparator11.Size = new System.Drawing.Size(162, 6);
			// 
			// toolstripSeperator1
			// 
			toolstripSeperator1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			toolstripSeperator1.Name = "toolstripSeperator1";
			toolstripSeperator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolstripSeperator6
			// 
			toolstripSeperator6.Name = "toolstripSeperator6";
			toolstripSeperator6.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator12
			// 
			toolStripSeparator12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			toolStripSeparator12.Name = "toolStripSeparator12";
			toolStripSeparator12.Size = new System.Drawing.Size(6, 23);
			// 
			// buttoneditmodesseperator
			// 
			this.buttoneditmodesseperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.buttoneditmodesseperator.Name = "buttoneditmodesseperator";
			this.buttoneditmodesseperator.Size = new System.Drawing.Size(6, 25);
			// 
			// poscommalabel
			// 
			this.poscommalabel.Name = "poscommalabel";
			this.poscommalabel.Size = new System.Drawing.Size(11, 18);
			this.poscommalabel.Text = ",";
			this.poscommalabel.ToolTipText = "Current X, Y coordinates on map";
			// 
			// menumain
			// 
			this.menumain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menufile,
            this.menuedit,
            this.menumode,
            this.menutools,
            this.menuhelp});
			this.menumain.Location = new System.Drawing.Point(0, 0);
			this.menumain.Name = "menumain";
			this.menumain.Size = new System.Drawing.Size(1012, 24);
			this.menumain.TabIndex = 0;
			// 
			// menufile
			// 
			this.menufile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemnewmap,
            this.itemopenmap,
            this.itemclosemap,
            toolStripMenuItem1,
            this.itemsavemap,
            this.itemsavemapas,
            this.itemsavemapinto,
            this.toolStripMenuItem5,
            this.itemtestmap,
            toolStripMenuItem2,
            this.itemnorecent,
            toolStripMenuItem3,
            this.itemexit});
			this.menufile.Name = "menufile";
			this.menufile.Size = new System.Drawing.Size(35, 20);
			this.menufile.Text = "File";
			// 
			// itemclosemap
			// 
			this.itemclosemap.Name = "itemclosemap";
			this.itemclosemap.Size = new System.Drawing.Size(201, 22);
			this.itemclosemap.Tag = "builder_closemap";
			this.itemclosemap.Text = "Close Map";
			this.itemclosemap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemsavemapas
			// 
			this.itemsavemapas.Name = "itemsavemapas";
			this.itemsavemapas.Size = new System.Drawing.Size(201, 22);
			this.itemsavemapas.Tag = "builder_savemapas";
			this.itemsavemapas.Text = "Save Map As...";
			this.itemsavemapas.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemsavemapinto
			// 
			this.itemsavemapinto.Name = "itemsavemapinto";
			this.itemsavemapinto.Size = new System.Drawing.Size(201, 22);
			this.itemsavemapinto.Tag = "builder_savemapinto";
			this.itemsavemapinto.Text = "Save Map Into...";
			this.itemsavemapinto.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(198, 6);
			// 
			// itemnorecent
			// 
			this.itemnorecent.Enabled = false;
			this.itemnorecent.Name = "itemnorecent";
			this.itemnorecent.Size = new System.Drawing.Size(201, 22);
			this.itemnorecent.Text = "No recently opened files";
			// 
			// itemexit
			// 
			this.itemexit.Name = "itemexit";
			this.itemexit.Size = new System.Drawing.Size(201, 22);
			this.itemexit.Text = "Exit";
			this.itemexit.Click += new System.EventHandler(this.itemexit_Click);
			// 
			// menuedit
			// 
			this.menuedit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemundo,
            this.itemredo,
            this.toolStripMenuItem7,
            this.itemcut,
            this.itemcopy,
            this.itempaste,
            toolstripSeperator6,
            this.itemsnaptogrid,
            this.itemautomerge,
            this.toolStripMenuItem6,
            this.itemgridinc,
            this.itemgriddec,
            this.itemgridsetup,
            toolStripSeparator11,
            this.itemmapoptions});
			this.menuedit.Name = "menuedit";
			this.menuedit.Size = new System.Drawing.Size(37, 20);
			this.menuedit.Text = "Edit";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(162, 6);
			// 
			// itemgridinc
			// 
			this.itemgridinc.Name = "itemgridinc";
			this.itemgridinc.Size = new System.Drawing.Size(165, 22);
			this.itemgridinc.Tag = "builder_gridinc";
			this.itemgridinc.Text = "Increase Grid";
			this.itemgridinc.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemgriddec
			// 
			this.itemgriddec.Name = "itemgriddec";
			this.itemgriddec.Size = new System.Drawing.Size(165, 22);
			this.itemgriddec.Tag = "builder_griddec";
			this.itemgriddec.Text = "Decrease Grid";
			this.itemgriddec.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// menumode
			// 
			this.menumode.Name = "menumode";
			this.menumode.Size = new System.Drawing.Size(45, 20);
			this.menumode.Text = "Mode";
			// 
			// menutools
			// 
			this.menutools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemreloadresources,
            toolStripSeparator4,
            this.configurationToolStripMenuItem,
            this.preferencesToolStripMenuItem});
			this.menutools.Name = "menutools";
			this.menutools.Size = new System.Drawing.Size(44, 20);
			this.menutools.Text = "Tools";
			// 
			// itemreloadresources
			// 
			this.itemreloadresources.Name = "itemreloadresources";
			this.itemreloadresources.Size = new System.Drawing.Size(197, 22);
			this.itemreloadresources.Tag = "builder_reloadresources";
			this.itemreloadresources.Text = "Reload Resources";
			this.itemreloadresources.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.configurationToolStripMenuItem.Tag = "builder_configuration";
			this.configurationToolStripMenuItem.Text = "Game Configurations...";
			this.configurationToolStripMenuItem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// preferencesToolStripMenuItem
			// 
			this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
			this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
			this.preferencesToolStripMenuItem.Tag = "builder_preferences";
			this.preferencesToolStripMenuItem.Text = "Preferences...";
			this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// menuhelp
			// 
			this.menuhelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemhelpabout});
			this.menuhelp.Name = "menuhelp";
			this.menuhelp.Size = new System.Drawing.Size(40, 20);
			this.menuhelp.Text = "Help";
			// 
			// itemhelpabout
			// 
			this.itemhelpabout.Name = "itemhelpabout";
			this.itemhelpabout.Size = new System.Drawing.Size(191, 22);
			this.itemhelpabout.Text = "About Doom Builder...";
			this.itemhelpabout.Click += new System.EventHandler(this.itemhelpabout_Click);
			// 
			// toolbar
			// 
			this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonnewmap,
            this.buttonopenmap,
            this.buttonsavemap,
            toolStripSeparator3,
            this.buttonmapoptions,
            toolStripSeparator10,
            this.buttonundo,
            this.buttonredo,
            toolStripSeparator7,
            this.buttoncut,
            this.buttoncopy,
            this.buttonpaste,
            toolstripSeperator1,
            this.buttoneditmodesseperator,
            this.buttonthingsfilter,
            this.thingfilters,
            this.buttonviewnormal,
            this.buttonviewbrightness,
            this.buttonviewfloors,
            this.buttonviewceilings,
            this.toolStripSeparator8,
            this.buttonsnaptogrid,
            this.buttonautomerge,
            this.toolStripSeparator5,
            this.buttontestmonsters,
            this.buttontest,
            this.toolStripSeparator6});
			this.toolbar.Location = new System.Drawing.Point(0, 24);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(1012, 25);
			this.toolbar.TabIndex = 1;
			// 
			// thingfilters
			// 
			this.thingfilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.thingfilters.Enabled = false;
			this.thingfilters.Items.AddRange(new object[] {
            "(none)",
            "(custom)",
            "Easy skill items only",
            "Medium skill items only",
            "Hard skill items only"});
			this.thingfilters.Margin = new System.Windows.Forms.Padding(1, 0, 6, 0);
			this.thingfilters.Name = "thingfilters";
			this.thingfilters.Size = new System.Drawing.Size(130, 25);
			this.thingfilters.ToolTipText = "Things Filter";
			this.thingfilters.SelectedIndexChanged += new System.EventHandler(this.thingfilters_SelectedIndexChanged);
			this.thingfilters.DropDownClosed += new System.EventHandler(this.LoseFocus);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// statusbar
			// 
			this.statusbar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel,
            this.configlabel,
            toolStripSeparator12,
            this.gridlabel,
            this.buttongrid,
            toolStripSeparator1,
            this.zoomlabel,
            this.buttonzoom,
            toolStripSeparator9,
            this.xposlabel,
            this.poscommalabel,
            this.yposlabel});
			this.statusbar.Location = new System.Drawing.Point(0, 670);
			this.statusbar.Name = "statusbar";
			this.statusbar.ShowItemToolTips = true;
			this.statusbar.Size = new System.Drawing.Size(1012, 23);
			this.statusbar.TabIndex = 2;
			// 
			// configlabel
			// 
			this.configlabel.AutoSize = false;
			this.configlabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.configlabel.Name = "configlabel";
			this.configlabel.Size = new System.Drawing.Size(280, 18);
			this.configlabel.Text = "ZDoom (Doom in Hexen Format)";
			this.configlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.configlabel.ToolTipText = "Current Game Configuration";
			// 
			// gridlabel
			// 
			this.gridlabel.AutoSize = false;
			this.gridlabel.AutoToolTip = true;
			this.gridlabel.Name = "gridlabel";
			this.gridlabel.Size = new System.Drawing.Size(62, 18);
			this.gridlabel.Text = "32 mp";
			this.gridlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.gridlabel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.gridlabel.ToolTipText = "Grid size";
			// 
			// zoomlabel
			// 
			this.zoomlabel.AutoSize = false;
			this.zoomlabel.AutoToolTip = true;
			this.zoomlabel.Name = "zoomlabel";
			this.zoomlabel.Size = new System.Drawing.Size(54, 18);
			this.zoomlabel.Text = "50%";
			this.zoomlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.zoomlabel.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
			this.zoomlabel.ToolTipText = "Zoom level";
			// 
			// xposlabel
			// 
			this.xposlabel.AutoSize = false;
			this.xposlabel.Name = "xposlabel";
			this.xposlabel.Size = new System.Drawing.Size(50, 18);
			this.xposlabel.Text = "0";
			this.xposlabel.ToolTipText = "Current X, Y coordinates on map";
			// 
			// yposlabel
			// 
			this.yposlabel.AutoSize = false;
			this.yposlabel.Name = "yposlabel";
			this.yposlabel.Size = new System.Drawing.Size(50, 18);
			this.yposlabel.Text = "0";
			this.yposlabel.ToolTipText = "Current X, Y coordinates on map";
			// 
			// panelinfo
			// 
			this.panelinfo.Controls.Add(this.modename);
			this.panelinfo.Controls.Add(this.vertexinfo);
			this.panelinfo.Controls.Add(this.thinginfo);
			this.panelinfo.Controls.Add(this.sectorinfo);
			this.panelinfo.Controls.Add(this.linedefinfo);
			this.panelinfo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelinfo.Location = new System.Drawing.Point(0, 564);
			this.panelinfo.Name = "panelinfo";
			this.panelinfo.Size = new System.Drawing.Size(1012, 106);
			this.panelinfo.TabIndex = 4;
			// 
			// modename
			// 
			this.modename.AutoSize = true;
			this.modename.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modename.ForeColor = System.Drawing.SystemColors.GrayText;
			this.modename.Location = new System.Drawing.Point(12, 20);
			this.modename.Name = "modename";
			this.modename.Size = new System.Drawing.Size(244, 59);
			this.modename.TabIndex = 4;
			this.modename.Text = "Vertices";
			this.modename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.modename.UseMnemonic = false;
			this.modename.Visible = false;
			// 
			// vertexinfo
			// 
			this.vertexinfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.vertexinfo.Location = new System.Drawing.Point(3, 3);
			this.vertexinfo.MaximumSize = new System.Drawing.Size(10000, 100);
			this.vertexinfo.MinimumSize = new System.Drawing.Size(100, 100);
			this.vertexinfo.Name = "vertexinfo";
			this.vertexinfo.Size = new System.Drawing.Size(180, 100);
			this.vertexinfo.TabIndex = 1;
			this.vertexinfo.Visible = false;
			// 
			// thinginfo
			// 
			this.thinginfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thinginfo.Location = new System.Drawing.Point(3, 3);
			this.thinginfo.MaximumSize = new System.Drawing.Size(10000, 100);
			this.thinginfo.MinimumSize = new System.Drawing.Size(100, 100);
			this.thinginfo.Name = "thinginfo";
			this.thinginfo.Size = new System.Drawing.Size(580, 100);
			this.thinginfo.TabIndex = 3;
			this.thinginfo.Visible = false;
			// 
			// sectorinfo
			// 
			this.sectorinfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sectorinfo.Location = new System.Drawing.Point(3, 3);
			this.sectorinfo.MaximumSize = new System.Drawing.Size(10000, 100);
			this.sectorinfo.MinimumSize = new System.Drawing.Size(100, 100);
			this.sectorinfo.Name = "sectorinfo";
			this.sectorinfo.Size = new System.Drawing.Size(447, 100);
			this.sectorinfo.TabIndex = 2;
			this.sectorinfo.Visible = false;
			// 
			// linedefinfo
			// 
			this.linedefinfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linedefinfo.Location = new System.Drawing.Point(3, 3);
			this.linedefinfo.MaximumSize = new System.Drawing.Size(10000, 100);
			this.linedefinfo.MinimumSize = new System.Drawing.Size(100, 100);
			this.linedefinfo.Name = "linedefinfo";
			this.linedefinfo.Size = new System.Drawing.Size(1000, 100);
			this.linedefinfo.TabIndex = 0;
			this.linedefinfo.Visible = false;
			// 
			// redrawtimer
			// 
			this.redrawtimer.Interval = 1;
			this.redrawtimer.Tick += new System.EventHandler(this.redrawtimer_Tick);
			// 
			// display
			// 
			this.display.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.display.CausesValidation = false;
			this.display.Dock = System.Windows.Forms.DockStyle.Fill;
			this.display.Location = new System.Drawing.Point(0, 49);
			this.display.Name = "display";
			this.display.Size = new System.Drawing.Size(1012, 515);
			this.display.TabIndex = 5;
			this.display.MouseLeave += new System.EventHandler(this.display_MouseLeave);
			this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
			this.display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
			this.display.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.display_MouseDoubleClick);
			this.display.MouseClick += new System.Windows.Forms.MouseEventHandler(this.display_MouseClick);
			this.display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.display_MouseDown);
			this.display.Resize += new System.EventHandler(this.display_Resize);
			this.display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.display_MouseUp);
			this.display.MouseEnter += new System.EventHandler(this.display_MouseEnter);
			// 
			// processor
			// 
			this.processor.Interval = 10;
			this.processor.Tick += new System.EventHandler(this.processor_Tick);
			// 
			// warningtimer
			// 
			this.warningtimer.Tick += new System.EventHandler(this.warningtimer_Tick);
			// 
			// warningflasher
			// 
			this.warningflasher.Tick += new System.EventHandler(this.warningflasher_Tick);
			// 
			// statuslabel
			// 
			this.statuslabel.Image = global::CodeImp.DoomBuilder.Properties.Resources.Status2;
			this.statuslabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.statuslabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.statuslabel.Name = "statuslabel";
			this.statuslabel.Size = new System.Drawing.Size(201, 16);
			this.statuslabel.Spring = true;
			this.statuslabel.Text = "Initializing user interface...";
			this.statuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttongrid
			// 
			this.buttongrid.AutoToolTip = false;
			this.buttongrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttongrid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemgrid1024,
            this.itemgrid512,
            this.itemgrid256,
            this.itemgrid128,
            this.itemgrid64,
            this.itemgrid32,
            this.itemgrid16,
            this.itemgrid8,
            this.itemgrid4,
            toolStripMenuItem4,
            this.itemgridcustom});
			this.buttongrid.Image = global::CodeImp.DoomBuilder.Properties.Resources.Grid2_arrowup;
			this.buttongrid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttongrid.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.buttongrid.Name = "buttongrid";
			this.buttongrid.ShowDropDownArrow = false;
			this.buttongrid.Size = new System.Drawing.Size(29, 20);
			this.buttongrid.Text = "Grid";
			// 
			// itemgrid1024
			// 
			this.itemgrid1024.Name = "itemgrid1024";
			this.itemgrid1024.Size = new System.Drawing.Size(164, 22);
			this.itemgrid1024.Tag = "1024";
			this.itemgrid1024.Text = "1024 mp";
			this.itemgrid1024.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid512
			// 
			this.itemgrid512.Name = "itemgrid512";
			this.itemgrid512.Size = new System.Drawing.Size(164, 22);
			this.itemgrid512.Tag = "512";
			this.itemgrid512.Text = "512 mp";
			this.itemgrid512.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid256
			// 
			this.itemgrid256.Name = "itemgrid256";
			this.itemgrid256.Size = new System.Drawing.Size(164, 22);
			this.itemgrid256.Tag = "256";
			this.itemgrid256.Text = "256 mp";
			this.itemgrid256.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid128
			// 
			this.itemgrid128.Name = "itemgrid128";
			this.itemgrid128.Size = new System.Drawing.Size(164, 22);
			this.itemgrid128.Tag = "128";
			this.itemgrid128.Text = "128 mp";
			this.itemgrid128.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid64
			// 
			this.itemgrid64.Name = "itemgrid64";
			this.itemgrid64.Size = new System.Drawing.Size(164, 22);
			this.itemgrid64.Tag = "64";
			this.itemgrid64.Text = "64 mp";
			this.itemgrid64.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid32
			// 
			this.itemgrid32.Name = "itemgrid32";
			this.itemgrid32.Size = new System.Drawing.Size(164, 22);
			this.itemgrid32.Tag = "32";
			this.itemgrid32.Text = "32 mp";
			this.itemgrid32.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid16
			// 
			this.itemgrid16.Name = "itemgrid16";
			this.itemgrid16.Size = new System.Drawing.Size(164, 22);
			this.itemgrid16.Tag = "16";
			this.itemgrid16.Text = "16 mp";
			this.itemgrid16.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid8
			// 
			this.itemgrid8.Name = "itemgrid8";
			this.itemgrid8.Size = new System.Drawing.Size(164, 22);
			this.itemgrid8.Tag = "8";
			this.itemgrid8.Text = "8 mp";
			this.itemgrid8.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// itemgrid4
			// 
			this.itemgrid4.Name = "itemgrid4";
			this.itemgrid4.Size = new System.Drawing.Size(164, 22);
			this.itemgrid4.Tag = "4";
			this.itemgrid4.Text = "4 mp";
			this.itemgrid4.Click += new System.EventHandler(this.itemgridsize_Click);
			// 
			// toolStripMenuItem4
			// 
			toolStripMenuItem4.Name = "toolStripMenuItem4";
			toolStripMenuItem4.Size = new System.Drawing.Size(161, 6);
			// 
			// itemgridcustom
			// 
			this.itemgridcustom.Name = "itemgridcustom";
			this.itemgridcustom.Size = new System.Drawing.Size(164, 22);
			this.itemgridcustom.Text = "Customize...";
			this.itemgridcustom.Click += new System.EventHandler(this.itemgridcustom_Click);
			// 
			// buttonzoom
			// 
			this.buttonzoom.AutoToolTip = false;
			this.buttonzoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonzoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemzoom200,
            this.itemzoom100,
            this.itemzoom50,
            this.itemzoom25,
            this.itemzoom10,
            this.itemzoom5,
            toolStripSeparator2,
            this.itemzoomfittoscreen});
			this.buttonzoom.Image = global::CodeImp.DoomBuilder.Properties.Resources.Zoom_arrowup;
			this.buttonzoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonzoom.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.buttonzoom.Name = "buttonzoom";
			this.buttonzoom.ShowDropDownArrow = false;
			this.buttonzoom.Size = new System.Drawing.Size(29, 20);
			this.buttonzoom.Text = "Zoom";
			// 
			// itemzoom200
			// 
			this.itemzoom200.Name = "itemzoom200";
			this.itemzoom200.Size = new System.Drawing.Size(167, 22);
			this.itemzoom200.Tag = "200";
			this.itemzoom200.Text = "200%";
			this.itemzoom200.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// itemzoom100
			// 
			this.itemzoom100.Name = "itemzoom100";
			this.itemzoom100.Size = new System.Drawing.Size(167, 22);
			this.itemzoom100.Tag = "100";
			this.itemzoom100.Text = "100%";
			this.itemzoom100.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// itemzoom50
			// 
			this.itemzoom50.Name = "itemzoom50";
			this.itemzoom50.Size = new System.Drawing.Size(167, 22);
			this.itemzoom50.Tag = "50";
			this.itemzoom50.Text = "50%";
			this.itemzoom50.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// itemzoom25
			// 
			this.itemzoom25.Name = "itemzoom25";
			this.itemzoom25.Size = new System.Drawing.Size(167, 22);
			this.itemzoom25.Tag = "25";
			this.itemzoom25.Text = "25%";
			this.itemzoom25.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// itemzoom10
			// 
			this.itemzoom10.Name = "itemzoom10";
			this.itemzoom10.Size = new System.Drawing.Size(167, 22);
			this.itemzoom10.Tag = "10";
			this.itemzoom10.Text = "10%";
			this.itemzoom10.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// itemzoom5
			// 
			this.itemzoom5.Name = "itemzoom5";
			this.itemzoom5.Size = new System.Drawing.Size(167, 22);
			this.itemzoom5.Tag = "5";
			this.itemzoom5.Text = "5%";
			this.itemzoom5.Click += new System.EventHandler(this.itemzoomto_Click);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
			// 
			// itemzoomfittoscreen
			// 
			this.itemzoomfittoscreen.Name = "itemzoomfittoscreen";
			this.itemzoomfittoscreen.Size = new System.Drawing.Size(167, 22);
			this.itemzoomfittoscreen.Text = "Fit to screen";
			this.itemzoomfittoscreen.Click += new System.EventHandler(this.itemzoomfittoscreen_Click);
			// 
			// buttonnewmap
			// 
			this.buttonnewmap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonnewmap.Image = global::CodeImp.DoomBuilder.Properties.Resources.NewMap;
			this.buttonnewmap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonnewmap.Name = "buttonnewmap";
			this.buttonnewmap.Size = new System.Drawing.Size(23, 22);
			this.buttonnewmap.Tag = "builder_newmap";
			this.buttonnewmap.Text = "New Map";
			this.buttonnewmap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonopenmap
			// 
			this.buttonopenmap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonopenmap.Image = global::CodeImp.DoomBuilder.Properties.Resources.OpenMap;
			this.buttonopenmap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonopenmap.Name = "buttonopenmap";
			this.buttonopenmap.Size = new System.Drawing.Size(23, 22);
			this.buttonopenmap.Tag = "builder_openmap";
			this.buttonopenmap.Text = "Open Map";
			this.buttonopenmap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonsavemap
			// 
			this.buttonsavemap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonsavemap.Image = global::CodeImp.DoomBuilder.Properties.Resources.SaveMap;
			this.buttonsavemap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonsavemap.Name = "buttonsavemap";
			this.buttonsavemap.Size = new System.Drawing.Size(23, 22);
			this.buttonsavemap.Tag = "builder_savemap";
			this.buttonsavemap.Text = "Save Map";
			this.buttonsavemap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonmapoptions
			// 
			this.buttonmapoptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonmapoptions.Image = global::CodeImp.DoomBuilder.Properties.Resources.Properties;
			this.buttonmapoptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonmapoptions.Name = "buttonmapoptions";
			this.buttonmapoptions.Size = new System.Drawing.Size(23, 22);
			this.buttonmapoptions.Tag = "builder_mapoptions";
			this.buttonmapoptions.Text = "Map Options";
			this.buttonmapoptions.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonundo
			// 
			this.buttonundo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonundo.Image = global::CodeImp.DoomBuilder.Properties.Resources.Undo;
			this.buttonundo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonundo.Name = "buttonundo";
			this.buttonundo.Size = new System.Drawing.Size(23, 22);
			this.buttonundo.Tag = "builder_undo";
			this.buttonundo.Text = "Undo";
			this.buttonundo.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonredo
			// 
			this.buttonredo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonredo.Image = global::CodeImp.DoomBuilder.Properties.Resources.Redo;
			this.buttonredo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonredo.Name = "buttonredo";
			this.buttonredo.Size = new System.Drawing.Size(23, 22);
			this.buttonredo.Tag = "builder_redo";
			this.buttonredo.Text = "Redo";
			this.buttonredo.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttoncut
			// 
			this.buttoncut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttoncut.Image = global::CodeImp.DoomBuilder.Properties.Resources.Cut;
			this.buttoncut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttoncut.Name = "buttoncut";
			this.buttoncut.Size = new System.Drawing.Size(23, 22);
			this.buttoncut.Tag = "builder_cutselection";
			this.buttoncut.Text = "Cut Selection";
			this.buttoncut.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttoncopy
			// 
			this.buttoncopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttoncopy.Image = global::CodeImp.DoomBuilder.Properties.Resources.Copy;
			this.buttoncopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttoncopy.Name = "buttoncopy";
			this.buttoncopy.Size = new System.Drawing.Size(23, 22);
			this.buttoncopy.Tag = "builder_copyselection";
			this.buttoncopy.Text = "Copy Selection";
			this.buttoncopy.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonpaste
			// 
			this.buttonpaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonpaste.Image = global::CodeImp.DoomBuilder.Properties.Resources.Paste;
			this.buttonpaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonpaste.Name = "buttonpaste";
			this.buttonpaste.Size = new System.Drawing.Size(23, 22);
			this.buttonpaste.Tag = "builder_pasteselection";
			this.buttonpaste.Text = "Paste Selection";
			this.buttonpaste.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonthingsfilter
			// 
			this.buttonthingsfilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonthingsfilter.Enabled = false;
			this.buttonthingsfilter.Image = global::CodeImp.DoomBuilder.Properties.Resources.Filter;
			this.buttonthingsfilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonthingsfilter.Name = "buttonthingsfilter";
			this.buttonthingsfilter.Size = new System.Drawing.Size(23, 22);
			this.buttonthingsfilter.Tag = "builder_thingsfilterssetup";
			this.buttonthingsfilter.Text = "Configure Things Filters";
			this.buttonthingsfilter.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonviewnormal
			// 
			this.buttonviewnormal.CheckOnClick = true;
			this.buttonviewnormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonviewnormal.Image = global::CodeImp.DoomBuilder.Properties.Resources.ViewNormal;
			this.buttonviewnormal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonviewnormal.Name = "buttonviewnormal";
			this.buttonviewnormal.Size = new System.Drawing.Size(23, 22);
			this.buttonviewnormal.Tag = "0";
			this.buttonviewnormal.Text = "toolStripButton1";
			this.buttonviewnormal.Click += new System.EventHandler(this.ViewModeButtonClick);
			// 
			// buttonviewbrightness
			// 
			this.buttonviewbrightness.CheckOnClick = true;
			this.buttonviewbrightness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonviewbrightness.Image = global::CodeImp.DoomBuilder.Properties.Resources.ViewBrightness;
			this.buttonviewbrightness.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonviewbrightness.Name = "buttonviewbrightness";
			this.buttonviewbrightness.Size = new System.Drawing.Size(23, 22);
			this.buttonviewbrightness.Tag = "1";
			this.buttonviewbrightness.Text = "toolStripButton2";
			this.buttonviewbrightness.Click += new System.EventHandler(this.ViewModeButtonClick);
			// 
			// buttonviewfloors
			// 
			this.buttonviewfloors.CheckOnClick = true;
			this.buttonviewfloors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonviewfloors.Image = global::CodeImp.DoomBuilder.Properties.Resources.ViewTextureFloor;
			this.buttonviewfloors.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonviewfloors.Name = "buttonviewfloors";
			this.buttonviewfloors.Size = new System.Drawing.Size(23, 22);
			this.buttonviewfloors.Tag = "2";
			this.buttonviewfloors.Text = "toolStripButton3";
			this.buttonviewfloors.Click += new System.EventHandler(this.ViewModeButtonClick);
			// 
			// buttonviewceilings
			// 
			this.buttonviewceilings.CheckOnClick = true;
			this.buttonviewceilings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonviewceilings.Image = global::CodeImp.DoomBuilder.Properties.Resources.ViewTextureCeiling;
			this.buttonviewceilings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonviewceilings.Name = "buttonviewceilings";
			this.buttonviewceilings.Size = new System.Drawing.Size(23, 22);
			this.buttonviewceilings.Tag = "3";
			this.buttonviewceilings.Text = "toolStripButton1";
			this.buttonviewceilings.Click += new System.EventHandler(this.ViewModeButtonClick);
			// 
			// buttonsnaptogrid
			// 
			this.buttonsnaptogrid.Checked = true;
			this.buttonsnaptogrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttonsnaptogrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonsnaptogrid.Image = global::CodeImp.DoomBuilder.Properties.Resources.Grid4;
			this.buttonsnaptogrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonsnaptogrid.Name = "buttonsnaptogrid";
			this.buttonsnaptogrid.Size = new System.Drawing.Size(23, 22);
			this.buttonsnaptogrid.Tag = "builder_togglesnap";
			this.buttonsnaptogrid.Text = "Snap to Grid";
			this.buttonsnaptogrid.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttonautomerge
			// 
			this.buttonautomerge.Checked = true;
			this.buttonautomerge.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttonautomerge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonautomerge.Image = global::CodeImp.DoomBuilder.Properties.Resources.mergegeometry2;
			this.buttonautomerge.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonautomerge.Name = "buttonautomerge";
			this.buttonautomerge.Size = new System.Drawing.Size(23, 22);
			this.buttonautomerge.Tag = "builder_toggleautomerge";
			this.buttonautomerge.Text = "Merge Geometry";
			this.buttonautomerge.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// buttontestmonsters
			// 
			this.buttontestmonsters.Checked = true;
			this.buttontestmonsters.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttontestmonsters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttontestmonsters.Image = global::CodeImp.DoomBuilder.Properties.Resources.Monster2;
			this.buttontestmonsters.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttontestmonsters.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttontestmonsters.Name = "buttontestmonsters";
			this.buttontestmonsters.Size = new System.Drawing.Size(23, 22);
			this.buttontestmonsters.Text = "Test with monsters";
			this.buttontestmonsters.Click += new System.EventHandler(this.buttontestmonsters_Click);
			// 
			// buttontest
			// 
			this.buttontest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttontest.Image = global::CodeImp.DoomBuilder.Properties.Resources.Test;
			this.buttontest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttontest.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttontest.Name = "buttontest";
			this.buttontest.Size = new System.Drawing.Size(32, 22);
			this.buttontest.Tag = "builder_testmap";
			this.buttontest.Text = "Test Map";
			this.buttontest.ButtonClick += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemnewmap
			// 
			this.itemnewmap.Image = global::CodeImp.DoomBuilder.Properties.Resources.File;
			this.itemnewmap.Name = "itemnewmap";
			this.itemnewmap.ShortcutKeyDisplayString = "";
			this.itemnewmap.Size = new System.Drawing.Size(201, 22);
			this.itemnewmap.Tag = "builder_newmap";
			this.itemnewmap.Text = "New Map";
			this.itemnewmap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemopenmap
			// 
			this.itemopenmap.Image = global::CodeImp.DoomBuilder.Properties.Resources.OpenMap;
			this.itemopenmap.Name = "itemopenmap";
			this.itemopenmap.Size = new System.Drawing.Size(201, 22);
			this.itemopenmap.Tag = "builder_openmap";
			this.itemopenmap.Text = "Open Map...";
			this.itemopenmap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemsavemap
			// 
			this.itemsavemap.Image = global::CodeImp.DoomBuilder.Properties.Resources.SaveMap;
			this.itemsavemap.Name = "itemsavemap";
			this.itemsavemap.Size = new System.Drawing.Size(201, 22);
			this.itemsavemap.Tag = "builder_savemap";
			this.itemsavemap.Text = "Save Map";
			this.itemsavemap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemtestmap
			// 
			this.itemtestmap.Image = global::CodeImp.DoomBuilder.Properties.Resources.Test;
			this.itemtestmap.Name = "itemtestmap";
			this.itemtestmap.Size = new System.Drawing.Size(201, 22);
			this.itemtestmap.Tag = "builder_testmap";
			this.itemtestmap.Text = "Test Map";
			this.itemtestmap.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemundo
			// 
			this.itemundo.Image = global::CodeImp.DoomBuilder.Properties.Resources.Undo;
			this.itemundo.Name = "itemundo";
			this.itemundo.Size = new System.Drawing.Size(165, 22);
			this.itemundo.Tag = "builder_undo";
			this.itemundo.Text = "Undo";
			this.itemundo.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemredo
			// 
			this.itemredo.Image = global::CodeImp.DoomBuilder.Properties.Resources.Redo;
			this.itemredo.Name = "itemredo";
			this.itemredo.Size = new System.Drawing.Size(165, 22);
			this.itemredo.Tag = "builder_redo";
			this.itemredo.Text = "Redo";
			this.itemredo.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemcut
			// 
			this.itemcut.Image = global::CodeImp.DoomBuilder.Properties.Resources.Cut;
			this.itemcut.Name = "itemcut";
			this.itemcut.Size = new System.Drawing.Size(165, 22);
			this.itemcut.Tag = "builder_cutselection";
			this.itemcut.Text = "Cut";
			this.itemcut.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemcopy
			// 
			this.itemcopy.Image = global::CodeImp.DoomBuilder.Properties.Resources.Copy;
			this.itemcopy.Name = "itemcopy";
			this.itemcopy.Size = new System.Drawing.Size(165, 22);
			this.itemcopy.Tag = "builder_copyselection";
			this.itemcopy.Text = "Copy";
			this.itemcopy.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itempaste
			// 
			this.itempaste.Image = global::CodeImp.DoomBuilder.Properties.Resources.Paste;
			this.itempaste.Name = "itempaste";
			this.itempaste.Size = new System.Drawing.Size(165, 22);
			this.itempaste.Tag = "builder_pasteselection";
			this.itempaste.Text = "Paste";
			this.itempaste.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemsnaptogrid
			// 
			this.itemsnaptogrid.Checked = true;
			this.itemsnaptogrid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.itemsnaptogrid.Image = global::CodeImp.DoomBuilder.Properties.Resources.Grid4;
			this.itemsnaptogrid.Name = "itemsnaptogrid";
			this.itemsnaptogrid.Size = new System.Drawing.Size(165, 22);
			this.itemsnaptogrid.Tag = "builder_togglesnap";
			this.itemsnaptogrid.Text = "Snap to Grid";
			this.itemsnaptogrid.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemautomerge
			// 
			this.itemautomerge.Checked = true;
			this.itemautomerge.CheckState = System.Windows.Forms.CheckState.Checked;
			this.itemautomerge.Image = global::CodeImp.DoomBuilder.Properties.Resources.mergegeometry2;
			this.itemautomerge.Name = "itemautomerge";
			this.itemautomerge.Size = new System.Drawing.Size(165, 22);
			this.itemautomerge.Tag = "builder_toggleautomerge";
			this.itemautomerge.Text = "Merge Geometry";
			this.itemautomerge.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemgridsetup
			// 
			this.itemgridsetup.Image = global::CodeImp.DoomBuilder.Properties.Resources.Grid2;
			this.itemgridsetup.Name = "itemgridsetup";
			this.itemgridsetup.Size = new System.Drawing.Size(165, 22);
			this.itemgridsetup.Tag = "builder_gridsetup";
			this.itemgridsetup.Text = "Grid Setup...";
			this.itemgridsetup.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// itemmapoptions
			// 
			this.itemmapoptions.Image = global::CodeImp.DoomBuilder.Properties.Resources.Properties;
			this.itemmapoptions.Name = "itemmapoptions";
			this.itemmapoptions.Size = new System.Drawing.Size(165, 22);
			this.itemmapoptions.Tag = "builder_mapoptions";
			this.itemmapoptions.Text = "Map Options....";
			this.itemmapoptions.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1012, 693);
			this.Controls.Add(this.display);
			this.Controls.Add(this.panelinfo);
			this.Controls.Add(this.statusbar);
			this.Controls.Add(this.toolbar);
			this.Controls.Add(this.menumain);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menumain;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Doom Builder";
			this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.Activated += new System.EventHandler(this.MainForm_Activated);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			this.Move += new System.EventHandler(this.MainForm_Move);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
			this.menumain.ResumeLayout(false);
			this.menumain.PerformLayout();
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.statusbar.ResumeLayout(false);
			this.statusbar.PerformLayout();
			this.panelinfo.ResumeLayout(false);
			this.panelinfo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menumain;
		private System.Windows.Forms.ToolStrip toolbar;
		private System.Windows.Forms.StatusStrip statusbar;
		private System.Windows.Forms.Panel panelinfo;
		private System.Windows.Forms.ToolStripMenuItem menufile;
		private System.Windows.Forms.ToolStripMenuItem itemnewmap;
		private System.Windows.Forms.ToolStripMenuItem itemopenmap;
		private System.Windows.Forms.ToolStripMenuItem itemsavemap;
		private System.Windows.Forms.ToolStripMenuItem itemsavemapas;
		private System.Windows.Forms.ToolStripMenuItem itemsavemapinto;
		private System.Windows.Forms.ToolStripMenuItem itemexit;
		private System.Windows.Forms.ToolStripStatusLabel statuslabel;
		private System.Windows.Forms.ToolStripMenuItem itemclosemap;
		private System.Windows.Forms.Timer redrawtimer;
		private System.Windows.Forms.ToolStripMenuItem menuhelp;
		private System.Windows.Forms.ToolStripMenuItem itemhelpabout;
		private CodeImp.DoomBuilder.Controls.RenderTargetControl display;
		private System.Windows.Forms.ToolStripMenuItem itemnorecent;
		private System.Windows.Forms.ToolStripStatusLabel xposlabel;
		private System.Windows.Forms.ToolStripStatusLabel yposlabel;
		private System.Windows.Forms.ToolStripButton buttonnewmap;
		private System.Windows.Forms.ToolStripButton buttonopenmap;
		private System.Windows.Forms.ToolStripButton buttonsavemap;
		private System.Windows.Forms.ToolStripStatusLabel zoomlabel;
		private System.Windows.Forms.ToolStripDropDownButton buttonzoom;
		private System.Windows.Forms.ToolStripMenuItem itemzoomfittoscreen;
		private System.Windows.Forms.ToolStripMenuItem itemzoom100;
		private System.Windows.Forms.ToolStripMenuItem itemzoom200;
		private System.Windows.Forms.ToolStripMenuItem itemzoom50;
		private System.Windows.Forms.ToolStripMenuItem itemzoom25;
		private System.Windows.Forms.ToolStripMenuItem itemzoom10;
		private System.Windows.Forms.ToolStripMenuItem itemzoom5;
		private System.Windows.Forms.ToolStripMenuItem menutools;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuedit;
		private System.Windows.Forms.ToolStripMenuItem itemmapoptions;
		private System.Windows.Forms.ToolStripButton buttonmapoptions;
		private System.Windows.Forms.ToolStripMenuItem itemreloadresources;
		private CodeImp.DoomBuilder.Controls.LinedefInfoPanel linedefinfo;
		private CodeImp.DoomBuilder.Controls.VertexInfoPanel vertexinfo;
		private CodeImp.DoomBuilder.Controls.SectorInfoPanel sectorinfo;
		private CodeImp.DoomBuilder.Controls.ThingInfoPanel thinginfo;
		private System.Windows.Forms.ToolStripButton buttonthingsfilter;
		private System.Windows.Forms.ToolStripComboBox thingfilters;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripStatusLabel gridlabel;
		private System.Windows.Forms.ToolStripDropDownButton buttongrid;
		private System.Windows.Forms.ToolStripMenuItem itemgrid1024;
		private System.Windows.Forms.ToolStripMenuItem itemgrid256;
		private System.Windows.Forms.ToolStripMenuItem itemgrid128;
		private System.Windows.Forms.ToolStripMenuItem itemgrid64;
		private System.Windows.Forms.ToolStripMenuItem itemgrid32;
		private System.Windows.Forms.ToolStripMenuItem itemgrid16;
		private System.Windows.Forms.ToolStripMenuItem itemgrid4;
		private System.Windows.Forms.ToolStripMenuItem itemgrid8;
		private System.Windows.Forms.ToolStripMenuItem itemgridcustom;
		private System.Windows.Forms.ToolStripMenuItem itemgrid512;
		private System.Windows.Forms.ToolStripStatusLabel poscommalabel;
		private System.Windows.Forms.ToolStripMenuItem itemundo;
		private System.Windows.Forms.ToolStripMenuItem itemredo;
		private System.Windows.Forms.ToolStripButton buttonundo;
		private System.Windows.Forms.ToolStripButton buttonredo;
		private System.Windows.Forms.ToolStripButton buttonsnaptogrid;
		private System.Windows.Forms.ToolStripMenuItem itemsnaptogrid;
		private System.Windows.Forms.ToolStripButton buttonautomerge;
		private System.Windows.Forms.ToolStripMenuItem itemautomerge;
		private System.Windows.Forms.ToolStripSeparator buttoneditmodesseperator;
		private System.Windows.Forms.Timer processor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem itemtestmap;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem itemgridinc;
		private System.Windows.Forms.ToolStripMenuItem itemgriddec;
		private System.Windows.Forms.ToolStripMenuItem itemgridsetup;
		private System.Windows.Forms.Label modename;
		private System.Windows.Forms.Timer warningtimer;
		private System.Windows.Forms.Timer warningflasher;
		private System.Windows.Forms.ToolStripSplitButton buttontest;
		private System.Windows.Forms.ToolStripButton buttoncut;
		private System.Windows.Forms.ToolStripButton buttoncopy;
		private System.Windows.Forms.ToolStripButton buttonpaste;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem itemcut;
		private System.Windows.Forms.ToolStripMenuItem itemcopy;
		private System.Windows.Forms.ToolStripMenuItem itempaste;
		private System.Windows.Forms.ToolStripStatusLabel configlabel;
		private System.Windows.Forms.ToolStripMenuItem menumode;
		private System.Windows.Forms.ToolStripButton buttontestmonsters;
		private System.Windows.Forms.ToolStripButton buttonviewnormal;
		private System.Windows.Forms.ToolStripButton buttonviewbrightness;
		private System.Windows.Forms.ToolStripButton buttonviewfloors;
		private System.Windows.Forms.ToolStripButton buttonviewceilings;
	}
}