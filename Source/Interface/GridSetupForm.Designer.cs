namespace CodeImp.DoomBuilder.Interface
{
	partial class GridSetupForm
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
			System.Windows.Forms.GroupBox groupBox1;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.GroupBox groupBox2;
			this.gridsize = new System.Windows.Forms.NumericUpDown();
			this.showbackground = new System.Windows.Forms.CheckBox();
			this.backoffsety = new System.Windows.Forms.NumericUpDown();
			this.backoffsetx = new System.Windows.Forms.NumericUpDown();
			this.backoffset = new System.Windows.Forms.Label();
			this.selectflat = new System.Windows.Forms.Button();
			this.selecttexture = new System.Windows.Forms.Button();
			this.backgroundimage = new System.Windows.Forms.Panel();
			this.cancel = new System.Windows.Forms.Button();
			this.apply = new System.Windows.Forms.Button();
			groupBox1 = new System.Windows.Forms.GroupBox();
			label1 = new System.Windows.Forms.Label();
			groupBox2 = new System.Windows.Forms.GroupBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridsize)).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.backoffsety)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backoffsetx)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(this.gridsize);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(285, 71);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = " Grid ";
			// 
			// gridsize
			// 
			this.gridsize.Location = new System.Drawing.Point(146, 28);
			this.gridsize.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.gridsize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.gridsize.Name = "gridsize";
			this.gridsize.Size = new System.Drawing.Size(79, 20);
			this.gridsize.TabIndex = 1;
			this.gridsize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(25, 31);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(115, 14);
			label1.TabIndex = 0;
			label1.Text = "Grid size in mappixels:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(this.showbackground);
			groupBox2.Controls.Add(this.backoffsety);
			groupBox2.Controls.Add(this.backoffsetx);
			groupBox2.Controls.Add(this.backoffset);
			groupBox2.Controls.Add(this.selectflat);
			groupBox2.Controls.Add(this.selecttexture);
			groupBox2.Controls.Add(this.backgroundimage);
			groupBox2.Location = new System.Drawing.Point(12, 89);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(285, 181);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = " Background ";
			// 
			// showbackground
			// 
			this.showbackground.AutoSize = true;
			this.showbackground.Location = new System.Drawing.Point(28, 29);
			this.showbackground.Name = "showbackground";
			this.showbackground.Size = new System.Drawing.Size(146, 18);
			this.showbackground.TabIndex = 7;
			this.showbackground.Text = "Show background image";
			this.showbackground.UseVisualStyleBackColor = true;
			this.showbackground.CheckedChanged += new System.EventHandler(this.showbackground_CheckedChanged);
			// 
			// backoffsety
			// 
			this.backoffsety.Enabled = false;
			this.backoffsety.Location = new System.Drawing.Point(197, 137);
			this.backoffsety.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.backoffsety.Name = "backoffsety";
			this.backoffsety.Size = new System.Drawing.Size(57, 20);
			this.backoffsety.TabIndex = 6;
			// 
			// backoffsetx
			// 
			this.backoffsetx.Enabled = false;
			this.backoffsetx.Location = new System.Drawing.Point(134, 137);
			this.backoffsetx.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.backoffsetx.Name = "backoffsetx";
			this.backoffsetx.Size = new System.Drawing.Size(57, 20);
			this.backoffsetx.TabIndex = 5;
			// 
			// backoffset
			// 
			this.backoffset.AutoSize = true;
			this.backoffset.Enabled = false;
			this.backoffset.Location = new System.Drawing.Point(25, 140);
			this.backoffset.Name = "backoffset";
			this.backoffset.Size = new System.Drawing.Size(103, 14);
			this.backoffset.TabIndex = 4;
			this.backoffset.Text = "Offset in mappixels:";
			// 
			// selectflat
			// 
			this.selectflat.Enabled = false;
			this.selectflat.Location = new System.Drawing.Point(92, 91);
			this.selectflat.Name = "selectflat";
			this.selectflat.Size = new System.Drawing.Size(117, 25);
			this.selectflat.TabIndex = 3;
			this.selectflat.Text = "Select Flat...";
			this.selectflat.UseVisualStyleBackColor = true;
			this.selectflat.Click += new System.EventHandler(this.selectflat_Click);
			// 
			// selecttexture
			// 
			this.selecttexture.Enabled = false;
			this.selecttexture.Location = new System.Drawing.Point(92, 60);
			this.selecttexture.Name = "selecttexture";
			this.selecttexture.Size = new System.Drawing.Size(117, 25);
			this.selecttexture.TabIndex = 2;
			this.selecttexture.Text = "Select Texture...";
			this.selecttexture.UseVisualStyleBackColor = true;
			this.selecttexture.Click += new System.EventHandler(this.selecttexture_Click);
			// 
			// backgroundimage
			// 
			this.backgroundimage.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.backgroundimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.backgroundimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.backgroundimage.Location = new System.Drawing.Point(28, 60);
			this.backgroundimage.Name = "backgroundimage";
			this.backgroundimage.Size = new System.Drawing.Size(58, 56);
			this.backgroundimage.TabIndex = 1;
			// 
			// cancel
			// 
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(185, 283);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(112, 25);
			this.cancel.TabIndex = 22;
			this.cancel.Text = "Cancel";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// apply
			// 
			this.apply.Location = new System.Drawing.Point(67, 283);
			this.apply.Name = "apply";
			this.apply.Size = new System.Drawing.Size(112, 25);
			this.apply.TabIndex = 21;
			this.apply.Text = "OK";
			this.apply.UseVisualStyleBackColor = true;
			this.apply.Click += new System.EventHandler(this.apply_Click);
			// 
			// GridSetupForm
			// 
			this.AcceptButton = this.apply;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(309, 318);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.apply);
			this.Controls.Add(groupBox2);
			this.Controls.Add(groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GridSetupForm";
			this.Opacity = 0;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Custom Grid Setup";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridsize)).EndInit();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.backoffsety)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backoffsetx)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown gridsize;
		private System.Windows.Forms.Panel backgroundimage;
		private System.Windows.Forms.Button selecttexture;
		private System.Windows.Forms.Button selectflat;
		private System.Windows.Forms.NumericUpDown backoffsety;
		private System.Windows.Forms.NumericUpDown backoffsetx;
		private System.Windows.Forms.CheckBox showbackground;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button apply;
		private System.Windows.Forms.Label backoffset;
	}
}