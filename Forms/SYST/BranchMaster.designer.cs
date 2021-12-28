namespace project.Forms.SYST
{
    partial class BranchMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtBranchName = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBrancId = new Gramboo.Controls.GrbTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(1015, 333);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(1038, 331);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(1052, 333);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(1052, 307);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(1015, 307);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1038, 307);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(1038, 359);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(808, 30);
            this.txtBranchID.Size = new System.Drawing.Size(55, 20);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkISActive);
            this.groupBox2.Controls.Add(this.txtBranchName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 69);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
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
            this.chkISActive.Location = new System.Drawing.Point(139, 45);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(77, 20);
            this.chkISActive.TabIndex = 31;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "Is Active";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // txtBranchName
            // 
            this.txtBranchName.AcceptBlankValue = false;
            this.txtBranchName.Alias = "[Menu Group Name]";
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranchName.CheckDuplicates = true;
            this.txtBranchName.DataField = "BranchName";
            this.txtBranchName.Location = new System.Drawing.Point(139, 18);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtBranchName.Size = new System.Drawing.Size(237, 20);
            this.txtBranchName.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Branch Name";
            // 
            // TxtBrancId
            // 
            this.TxtBrancId.AcceptBlankValue = false;
            this.TxtBrancId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBrancId.DataField = "BranchId";
            this.TxtBrancId.IsIDField = true;
            this.TxtBrancId.Location = new System.Drawing.Point(459, 19);
            this.TxtBrancId.Name = "TxtBrancId";
            this.TxtBrancId.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtBrancId.Size = new System.Drawing.Size(91, 20);
            this.TxtBrancId.TabIndex = 35;
            this.TxtBrancId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(6, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 417);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
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
            this.dgvList.Location = new System.Drawing.Point(6, 11);
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
            this.dgvList.Size = new System.Drawing.Size(985, 398);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = true;
            this.dgvList.TabIndex = 32;
            // 
            // BranchMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TxtBrancId);
            this.Name = "BranchMaster";
            this.Text = "Branch Master";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.TxtBrancId, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtBranchName;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox TxtBrancId;
        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbDataGridView dgvList;
    }
}
