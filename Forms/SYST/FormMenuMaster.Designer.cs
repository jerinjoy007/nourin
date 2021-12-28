namespace project.Forms.SYST
{
    partial class FormMenuMaster
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_load = new Gramboo.Controls.GrbButton();
            this.cmbMenuParentName = new Gramboo.Controls.GrbComboBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtMenuId = new Gramboo.Controls.GrbTextBox();
            this.txtMenuName = new Gramboo.Controls.GrbTextBox();
            this.txtMenuUrl = new Gramboo.Controls.GrbTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(884, 309);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(907, 307);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(921, 309);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(921, 283);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(884, 283);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(907, 283);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(907, 335);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(910, 335);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_load);
            this.groupBox1.Controls.Add(this.cmbMenuParentName);
            this.groupBox1.Controls.Add(this.chkISActive);
            this.groupBox1.Controls.Add(this.txtMenuId);
            this.groupBox1.Controls.Add(this.txtMenuName);
            this.groupBox1.Controls.Add(this.txtMenuUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_load.BackgroundImage")));
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btn_load.FlatAppearance.BorderSize = 2;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Location = new System.Drawing.Point(366, 69);
            this.btn_load.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btn_load.MouseDownImage")));
            this.btn_load.Name = "btn_load";
            this.btn_load.NormalImage = ((System.Drawing.Image)(resources.GetObject("btn_load.NormalImage")));
            this.btn_load.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btn_load.OnFocusImage")));
            this.btn_load.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btn_load.SelectedImage")));
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // cmbMenuParentName
            // 
            this.cmbMenuParentName.BindingProperty = "SelectedValue";
            this.cmbMenuParentName.DataField = "parentId";
            this.cmbMenuParentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMenuParentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMenuParentName.FormattingEnabled = true;
            this.cmbMenuParentName.Location = new System.Drawing.Point(123, 45);
            this.cmbMenuParentName.Name = "cmbMenuParentName";
            this.cmbMenuParentName.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmbMenuParentName.Size = new System.Drawing.Size(237, 21);
            this.cmbMenuParentName.TabIndex = 1;
            this.cmbMenuParentName.TableName = "";
            // 
            // chkISActive
            // 
            this.chkISActive.AcceptBlankValue = false;
            this.chkISActive.AutoSize = true;
            this.chkISActive.BindingProperty = "Checked";
            this.chkISActive.Checked = true;
            this.chkISActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkISActive.DataField = "IsActive";
            this.chkISActive.FalseValue = "0";
            this.chkISActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkISActive.Location = new System.Drawing.Point(123, 99);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(77, 20);
            this.chkISActive.TabIndex = 3;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "Is Active";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // txtMenuId
            // 
            this.txtMenuId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuId.DataField = "MenuId";
            this.txtMenuId.IsIDField = true;
            this.txtMenuId.Location = new System.Drawing.Point(397, 30);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtMenuId.Size = new System.Drawing.Size(97, 20);
            this.txtMenuId.TabIndex = 57;
            this.txtMenuId.Visible = false;
            // 
            // txtMenuName
            // 
            this.txtMenuName.AcceptBlankValue = false;
            this.txtMenuName.Alias = "[Menu Name]";
            this.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuName.DataField = "MenuName";
            this.txtMenuName.Location = new System.Drawing.Point(123, 18);
            this.txtMenuName.MaxLength = 20;
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtMenuName.Size = new System.Drawing.Size(237, 20);
            this.txtMenuName.TabIndex = 0;
            // 
            // txtMenuUrl
            // 
            this.txtMenuUrl.AcceptBlankValue = false;
            this.txtMenuUrl.Alias = "[Menu URL]";
            this.txtMenuUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuUrl.CheckDuplicates = true;
            this.txtMenuUrl.DataField = "MenuUrl";
            this.txtMenuUrl.Location = new System.Drawing.Point(123, 72);
            this.txtMenuUrl.Name = "txtMenuUrl";
            this.txtMenuUrl.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtMenuUrl.Size = new System.Drawing.Size(237, 20);
            this.txtMenuUrl.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Menu Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Menu URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Parent Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(6, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowGrouping = false;
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.DataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.DataFields")));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.DisplaySumRowHeader = false;
            this.dgvList.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.FilterList")));
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvList.GroupingFields = null;
            this.dgvList.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.HiddenDataFields")));
            this.dgvList.IsList = true;
            this.dgvList.Location = new System.Drawing.Point(6, 10);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvList.ShowDelete = false;
            this.dgvList.ShowEdit = true;
            this.dgvList.ShowMoveDown = false;
            this.dgvList.ShowMoveUp = false;
            this.dgvList.ShowSelectCheckBox = false;
            this.dgvList.ShowSerialNo = true;
            this.dgvList.Size = new System.Drawing.Size(849, 292);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = false;
            this.dgvList.TabIndex = 0;
            // 
            // FormMenuMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMenuMaster";
            this.Text = "Menu Master";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbButton btn_load;
        private Gramboo.Controls.GrbComboBox cmbMenuParentName;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtMenuId;
        private Gramboo.Controls.GrbTextBox txtMenuName;
        private Gramboo.Controls.GrbTextBox txtMenuUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgvList;
    }
}
