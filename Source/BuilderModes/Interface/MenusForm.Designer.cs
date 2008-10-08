namespace CodeImp.DoomBuilder.BuilderModes
{
	partial class MenusForm
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
			this.menustrip = new System.Windows.Forms.MenuStrip();
			this.linedefsmenu = new System.Windows.Forms.ToolStripMenuItem();
			this.fliplinedefsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipsidedefsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.curvelinedefsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.splitlinedefsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.sectorsmenu = new System.Windows.Forms.ToolStripMenuItem();
			this.joinsectorsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.mergesectorsitem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.thingsmenu = new System.Windows.Forms.ToolStripMenuItem();
			this.rotatethingscwitem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotatethingsccwitem = new System.Windows.Forms.ToolStripMenuItem();
			this.globalstrip = new System.Windows.Forms.ToolStrip();
			this.manualstrip = new System.Windows.Forms.ToolStrip();
			this.buttonbrightnessgradient = new System.Windows.Forms.ToolStripButton();
			this.menustrip.SuspendLayout();
			this.manualstrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menustrip
			// 
			this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linedefsmenu,
            this.sectorsmenu,
            this.thingsmenu});
			this.menustrip.Location = new System.Drawing.Point(0, 0);
			this.menustrip.Name = "menustrip";
			this.menustrip.Size = new System.Drawing.Size(423, 24);
			this.menustrip.TabIndex = 0;
			this.menustrip.Text = "menustrip";
			// 
			// linedefsmenu
			// 
			this.linedefsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fliplinedefsitem,
            this.flipsidedefsitem,
            this.toolStripMenuItem1,
            this.curvelinedefsitem,
            this.toolStripMenuItem3,
            this.splitlinedefsitem});
			this.linedefsmenu.Name = "linedefsmenu";
			this.linedefsmenu.Size = new System.Drawing.Size(59, 20);
			this.linedefsmenu.Text = "Linedefs";
			this.linedefsmenu.Visible = false;
			// 
			// fliplinedefsitem
			// 
			this.fliplinedefsitem.Name = "fliplinedefsitem";
			this.fliplinedefsitem.Size = new System.Drawing.Size(158, 22);
			this.fliplinedefsitem.Tag = "fliplinedefs";
			this.fliplinedefsitem.Text = "Flip Linedefs";
			this.fliplinedefsitem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// flipsidedefsitem
			// 
			this.flipsidedefsitem.Name = "flipsidedefsitem";
			this.flipsidedefsitem.Size = new System.Drawing.Size(158, 22);
			this.flipsidedefsitem.Tag = "flipsidedefs";
			this.flipsidedefsitem.Text = "Flip Sidedefs";
			this.flipsidedefsitem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 6);
			// 
			// curvelinedefsitem
			// 
			this.curvelinedefsitem.Name = "curvelinedefsitem";
			this.curvelinedefsitem.Size = new System.Drawing.Size(158, 22);
			this.curvelinedefsitem.Tag = "curvelinesmode";
			this.curvelinedefsitem.Text = "Curve Linedefs...";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(155, 6);
			// 
			// splitlinedefsitem
			// 
			this.splitlinedefsitem.Name = "splitlinedefsitem";
			this.splitlinedefsitem.Size = new System.Drawing.Size(158, 22);
			this.splitlinedefsitem.Tag = "splitlinedefs";
			this.splitlinedefsitem.Text = "Split Linedefs";
			this.splitlinedefsitem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// sectorsmenu
			// 
			this.sectorsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinsectorsitem,
            this.mergesectorsitem,
            this.toolStripMenuItem2});
			this.sectorsmenu.Name = "sectorsmenu";
			this.sectorsmenu.Size = new System.Drawing.Size(55, 20);
			this.sectorsmenu.Text = "Sectors";
			this.sectorsmenu.Visible = false;
			// 
			// joinsectorsitem
			// 
			this.joinsectorsitem.Name = "joinsectorsitem";
			this.joinsectorsitem.Size = new System.Drawing.Size(143, 22);
			this.joinsectorsitem.Tag = "joinsectors";
			this.joinsectorsitem.Text = "Join Sectors";
			this.joinsectorsitem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// mergesectorsitem
			// 
			this.mergesectorsitem.Name = "mergesectorsitem";
			this.mergesectorsitem.Size = new System.Drawing.Size(143, 22);
			this.mergesectorsitem.Tag = "mergesectors";
			this.mergesectorsitem.Text = "Merge Sectors";
			this.mergesectorsitem.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 6);
			// 
			// thingsmenu
			// 
			this.thingsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotatethingscwitem,
            this.rotatethingsccwitem});
			this.thingsmenu.Name = "thingsmenu";
			this.thingsmenu.Size = new System.Drawing.Size(50, 20);
			this.thingsmenu.Text = "Things";
			this.thingsmenu.Visible = false;
			// 
			// rotatethingscwitem
			// 
			this.rotatethingscwitem.Name = "rotatethingscwitem";
			this.rotatethingscwitem.Size = new System.Drawing.Size(193, 22);
			this.rotatethingscwitem.Text = "Rotate Clockwise";
			// 
			// rotatethingsccwitem
			// 
			this.rotatethingsccwitem.Name = "rotatethingsccwitem";
			this.rotatethingsccwitem.Size = new System.Drawing.Size(193, 22);
			this.rotatethingsccwitem.Text = "Rotate Counterclockwise";
			// 
			// globalstrip
			// 
			this.globalstrip.Location = new System.Drawing.Point(0, 24);
			this.globalstrip.Name = "globalstrip";
			this.globalstrip.Size = new System.Drawing.Size(423, 25);
			this.globalstrip.TabIndex = 1;
			this.globalstrip.Text = "toolstrip";
			// 
			// manualstrip
			// 
			this.manualstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonbrightnessgradient});
			this.manualstrip.Location = new System.Drawing.Point(0, 49);
			this.manualstrip.Name = "manualstrip";
			this.manualstrip.Size = new System.Drawing.Size(423, 25);
			this.manualstrip.TabIndex = 2;
			this.manualstrip.Text = "toolStrip1";
			// 
			// buttonbrightnessgradient
			// 
			this.buttonbrightnessgradient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonbrightnessgradient.Image = global::CodeImp.DoomBuilder.BuilderModes.Properties.Resources.BrightnessGradient;
			this.buttonbrightnessgradient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.buttonbrightnessgradient.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonbrightnessgradient.Name = "buttonbrightnessgradient";
			this.buttonbrightnessgradient.Size = new System.Drawing.Size(23, 22);
			this.buttonbrightnessgradient.Tag = "gradientbrightness";
			this.buttonbrightnessgradient.Text = "Make Brightness Gradient";
			this.buttonbrightnessgradient.Click += new System.EventHandler(this.InvokeTaggedAction);
			// 
			// MenusForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(423, 248);
			this.Controls.Add(this.manualstrip);
			this.Controls.Add(this.globalstrip);
			this.Controls.Add(this.menustrip);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menustrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MenusForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "MenusForm";
			this.menustrip.ResumeLayout(false);
			this.menustrip.PerformLayout();
			this.manualstrip.ResumeLayout(false);
			this.manualstrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menustrip;
		private System.Windows.Forms.ToolStripMenuItem linedefsmenu;
		private System.Windows.Forms.ToolStripMenuItem sectorsmenu;
		private System.Windows.Forms.ToolStripMenuItem thingsmenu;
		private System.Windows.Forms.ToolStripMenuItem fliplinedefsitem;
		private System.Windows.Forms.ToolStripMenuItem flipsidedefsitem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem curvelinedefsitem;
		private System.Windows.Forms.ToolStripMenuItem joinsectorsitem;
		private System.Windows.Forms.ToolStripMenuItem mergesectorsitem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem rotatethingscwitem;
		private System.Windows.Forms.ToolStripMenuItem rotatethingsccwitem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem splitlinedefsitem;
		private System.Windows.Forms.ToolStrip globalstrip;
		private System.Windows.Forms.ToolStrip manualstrip;
		private System.Windows.Forms.ToolStripButton buttonbrightnessgradient;
	}
}