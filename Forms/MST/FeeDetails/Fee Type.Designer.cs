
namespace project.Forms.MST
{
    partial class Fee_Type
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fee_Type));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbRadioButtonGroup1 = new Gramboo.Controls.GrbRadioButtonGroup();
            this.PeFee = new Gramboo.Controls.GrbRadioButton();
            this.ReDp = new Gramboo.Controls.GrbRadioButton();
            this.Admfee = new Gramboo.Controls.GrbRadioButton();
            this.txtFeeCode = new Gramboo.Controls.GrbTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeeId = new Gramboo.Controls.GrbTextBox();
            this.txtFeeName = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.grbRadioButtonGroup1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(807, 307);
            this.txtModifiedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(830, 305);
            this.txtcreatedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(844, 307);
            this.txtcompId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(844, 283);
            this.txtModuserID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(807, 283);
            this.txtCrUserId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(830, 283);
            this.txtUserName.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(830, 332);
            this.txtCounterId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(833, 332);
            this.txtBranchID.Size = new System.Drawing.Size(10, 22);
            // 
            // grbRadioButtonGroup1
            // 
            this.grbRadioButtonGroup1.BindingProperty = "Value";
            this.grbRadioButtonGroup1.Controls.Add(this.PeFee);
            this.grbRadioButtonGroup1.Controls.Add(this.ReDp);
            this.grbRadioButtonGroup1.Controls.Add(this.Admfee);
            this.grbRadioButtonGroup1.DataField = "FEETYPE";
            this.grbRadioButtonGroup1.Location = new System.Drawing.Point(228, 75);
            this.grbRadioButtonGroup1.Name = "grbRadioButtonGroup1";
            this.grbRadioButtonGroup1.Size = new System.Drawing.Size(216, 110);
            this.grbRadioButtonGroup1.TabIndex = 18;
            this.grbRadioButtonGroup1.TableName = null;
            this.grbRadioButtonGroup1.TabStop = false;
            this.grbRadioButtonGroup1.Value = "AD";
            // 
            // PeFee
            // 
            this.PeFee.GroupName = null;
            this.PeFee.Location = new System.Drawing.Point(25, 80);
            this.PeFee.Name = "PeFee";
            this.PeFee.Size = new System.Drawing.Size(142, 24);
            this.PeFee.TabIndex = 2;
            this.PeFee.Text = "Periodical Fee";
            this.PeFee.TrueValue = "Pefee";
            this.PeFee.UseVisualStyleBackColor = true;
            // 
            // ReDp
            // 
            this.ReDp.GroupName = null;
            this.ReDp.Location = new System.Drawing.Point(25, 48);
            this.ReDp.Name = "ReDp";
            this.ReDp.Size = new System.Drawing.Size(171, 24);
            this.ReDp.TabIndex = 1;
            this.ReDp.Text = "Refundable Deposit";
            this.ReDp.TrueValue = "Re";
            this.ReDp.UseVisualStyleBackColor = true;
            // 
            // Admfee
            // 
            this.Admfee.Checked = true;
            this.Admfee.GroupName = null;
            this.Admfee.Location = new System.Drawing.Point(25, 16);
            this.Admfee.Name = "Admfee";
            this.Admfee.Size = new System.Drawing.Size(171, 24);
            this.Admfee.TabIndex = 0;
            this.Admfee.TabStop = true;
            this.Admfee.Text = "Addmission Fee";
            this.Admfee.TrueValue = "AD";
            this.Admfee.UseVisualStyleBackColor = true;
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeCode.DataField = "FEETYPECODE";
            this.txtFeeCode.Location = new System.Drawing.Point(227, 9);
            this.txtFeeCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeCode.Size = new System.Drawing.Size(217, 22);
            this.txtFeeCode.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Fee Code";
            // 
            // txtFeeId
            // 
            this.txtFeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeId.DataField = "FeeTypeId";
            this.txtFeeId.IsIDField = true;
            this.txtFeeId.Location = new System.Drawing.Point(452, 42);
            this.txtFeeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeId.Name = "txtFeeId";
            this.txtFeeId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeId.Size = new System.Drawing.Size(10, 22);
            this.txtFeeId.TabIndex = 76;
            this.txtFeeId.Visible = false;
            // 
            // txtFeeName
            // 
            this.txtFeeName.Alias = "[Item Name]";
            this.txtFeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeName.DataField = "FEETYPENAME";
            this.txtFeeName.Location = new System.Drawing.Point(227, 42);
            this.txtFeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeName.Size = new System.Drawing.Size(217, 22);
            this.txtFeeName.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Fee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Fee Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(3, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(795, 234);
            this.groupBox2.TabIndex = 79;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.DataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.DataFields")));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.DisplaySumRowHeader = false;
            this.dgvList.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.FilterList")));
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvList.GroupingFields = null;
            this.dgvList.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvList.HiddenDataFields")));
            this.dgvList.IsList = true;
            this.dgvList.Location = new System.Drawing.Point(8, 23);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvList.ShowDelete = false;
            this.dgvList.ShowEdit = true;
            this.dgvList.ShowMoveDown = false;
            this.dgvList.ShowMoveUp = false;
            this.dgvList.ShowSelectCheckBox = false;
            this.dgvList.ShowSerialNo = true;
            this.dgvList.Size = new System.Drawing.Size(781, 203);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = false;
            this.dgvList.TabIndex = 0;
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
            this.chkISActive.Location = new System.Drawing.Point(228, 192);
            this.chkISActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(90, 24);
            this.chkISActive.TabIndex = 80;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "IsActive";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // Fee_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkISActive);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFeeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFeeId);
            this.Controls.Add(this.txtFeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbRadioButtonGroup1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fee_Type";
            this.Text = "Fee_Type";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.grbRadioButtonGroup1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtFeeName, 0);
            this.Controls.SetChildIndex(this.txtFeeId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtFeeCode, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.chkISActive, 0);
            this.grbRadioButtonGroup1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbRadioButtonGroup grbRadioButtonGroup1;
        private Gramboo.Controls.GrbRadioButton PeFee;
        private Gramboo.Controls.GrbRadioButton ReDp;
        private Gramboo.Controls.GrbRadioButton Admfee;
        private Gramboo.Controls.GrbTextBox txtFeeCode;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbTextBox txtFeeId;
        private Gramboo.Controls.GrbTextBox txtFeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgvList;
        private Gramboo.Controls.GrbCheckBox chkISActive;
    }
}