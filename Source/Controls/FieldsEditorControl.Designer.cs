namespace CodeImp.DoomBuilder.Controls
{
	partial class FieldsEditorControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.fieldslist = new System.Windows.Forms.DataGridView();
			this.fieldname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fieldtype = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.fieldvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deleterowstimer = new System.Windows.Forms.Timer(this.components);
			this.browsebutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fieldslist)).BeginInit();
			this.SuspendLayout();
			// 
			// fieldslist
			// 
			this.fieldslist.AllowUserToResizeColumns = false;
			this.fieldslist.AllowUserToResizeRows = false;
			this.fieldslist.BackgroundColor = System.Drawing.SystemColors.Window;
			this.fieldslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fieldslist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.fieldslist.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.fieldslist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.fieldslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.fieldslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldname,
            this.fieldtype,
            this.fieldvalue});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.fieldslist.DefaultCellStyle = dataGridViewCellStyle4;
			this.fieldslist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.fieldslist.Location = new System.Drawing.Point(0, 0);
			this.fieldslist.MultiSelect = false;
			this.fieldslist.Name = "fieldslist";
			this.fieldslist.RowHeadersVisible = false;
			this.fieldslist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
			this.fieldslist.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fieldslist.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.fieldslist.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.fieldslist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.fieldslist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fieldslist.Size = new System.Drawing.Size(444, 244);
			this.fieldslist.TabIndex = 1;
			this.fieldslist.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.fieldslist_UserDeletingRow);
			this.fieldslist.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.fieldslist_CellBeginEdit);
			this.fieldslist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldslist_CellEndEdit);
			this.fieldslist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldslist_CellClick);
			this.fieldslist.SelectionChanged += new System.EventHandler(this.fieldslist_SelectionChanged);
			// 
			// fieldname
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.NullValue = null;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.fieldname.DefaultCellStyle = dataGridViewCellStyle1;
			this.fieldname.Frozen = true;
			this.fieldname.HeaderText = "Property";
			this.fieldname.Name = "fieldname";
			this.fieldname.Width = 180;
			// 
			// fieldtype
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.fieldtype.DefaultCellStyle = dataGridViewCellStyle2;
			this.fieldtype.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.fieldtype.HeaderText = "Type";
			this.fieldtype.Name = "fieldtype";
			this.fieldtype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.fieldtype.Sorted = true;
			this.fieldtype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// fieldvalue
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.fieldvalue.DefaultCellStyle = dataGridViewCellStyle3;
			this.fieldvalue.HeaderText = "Value";
			this.fieldvalue.Name = "fieldvalue";
			this.fieldvalue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.fieldvalue.Width = 120;
			// 
			// deleterowstimer
			// 
			this.deleterowstimer.Interval = 1;
			this.deleterowstimer.Tick += new System.EventHandler(this.deleterowstimer_Tick);
			// 
			// browsebutton
			// 
			this.browsebutton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.browsebutton.Image = global::CodeImp.DoomBuilder.Properties.Resources.treeview;
			this.browsebutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.browsebutton.Location = new System.Drawing.Point(370, 43);
			this.browsebutton.Name = "browsebutton";
			this.browsebutton.Size = new System.Drawing.Size(30, 24);
			this.browsebutton.TabIndex = 2;
			this.browsebutton.UseVisualStyleBackColor = true;
			this.browsebutton.Visible = false;
			// 
			// FieldsEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.browsebutton);
			this.Controls.Add(this.fieldslist);
			this.Name = "FieldsEditorControl";
			this.Size = new System.Drawing.Size(474, 266);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FieldsEditorControl_Layout);
			this.Resize += new System.EventHandler(this.FieldsEditorControl_Resize);
			((System.ComponentModel.ISupportInitialize)(this.fieldslist)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView fieldslist;
		private System.Windows.Forms.Timer deleterowstimer;
		private System.Windows.Forms.Button browsebutton;
		private System.Windows.Forms.DataGridViewTextBoxColumn fieldname;
		private System.Windows.Forms.DataGridViewComboBoxColumn fieldtype;
		private System.Windows.Forms.DataGridViewTextBoxColumn fieldvalue;
	}
}
