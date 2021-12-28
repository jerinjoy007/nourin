namespace project.Forms.EMP
{
    partial class frmDepartmentMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.txtDeptId = new Gramboo.Controls.GrbTextBox();
            this.txtDeptName = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(729, 309);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(752, 307);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(766, 309);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(766, 283);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(729, 283);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(752, 283);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(752, 335);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(755, 335);
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
            this.chkISActive.Location = new System.Drawing.Point(89, 33);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(74, 20);
            this.chkISActive.TabIndex = 1;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "IsActive";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
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
            this.dgvList.Location = new System.Drawing.Point(1, 64);
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
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvList.ShowDelete = false;
            this.dgvList.ShowEdit = true;
            this.dgvList.ShowMoveDown = false;
            this.dgvList.ShowMoveUp = false;
            this.dgvList.ShowSelectCheckBox = false;
            this.dgvList.ShowSerialNo = true;
            this.dgvList.Size = new System.Drawing.Size(717, 375);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = false;
            this.dgvList.TabIndex = 2;
            // 
            // txtDeptId
            // 
            this.txtDeptId.AcceptBlankValue = false;
            this.txtDeptId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptId.DataField = "DeptId";
            this.txtDeptId.IsIDField = true;
            this.txtDeptId.Location = new System.Drawing.Point(312, 10);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtDeptId.Size = new System.Drawing.Size(24, 20);
            this.txtDeptId.TabIndex = 33;
            this.txtDeptId.Visible = false;
            // 
            // txtDeptName
            // 
            this.txtDeptName.AcceptBlankValue = false;
            this.txtDeptName.Alias = "[Department Name]";
            this.txtDeptName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeptName.CheckDuplicates = true;
            this.txtDeptName.DataField = "DeptName";
            this.txtDeptName.Location = new System.Drawing.Point(88, 10);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtDeptName.Size = new System.Drawing.Size(218, 20);
            this.txtDeptName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // frmDepartmentMaster
            // 
            this.AcceptControl = this.chkISActive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(722, 444);
            this.Controls.Add(this.chkISActive);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.label1);
            this.Name = "frmDepartmentMaster";
            this.Text = "Employee Department Master";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDeptName, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.dgvList, 0);
            this.Controls.SetChildIndex(this.chkISActive, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbDataGridView dgvList;
        private Gramboo.Controls.GrbTextBox txtDeptId;
        private Gramboo.Controls.GrbTextBox txtDeptName;
        private System.Windows.Forms.Label label1;
    }
}
