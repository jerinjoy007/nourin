namespace project.Forms.HR
{
    partial class ManualPunchEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualPunchEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpLoginTime = new Gramboo.Controls.GrbDTPicker();
            this.lbl_vouchTime = new System.Windows.Forms.Label();
            this.Dtp_LogoutTime = new Gramboo.Controls.GrbDTPicker();
            this.lblLogoutTime = new System.Windows.Forms.Label();
            this.Dtp_LoginDate = new Gramboo.Controls.GrbDTPicker();
            this.lbl_LoginDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_StaffName = new Gramboo.Controls.GrbComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.lbl_EntryNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIsactive = new Gramboo.Controls.GrbTextBox();
            this.TxtEntryNo = new Gramboo.Controls.GrbTextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(1200, 380);
            this.txtModifiedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifiedDate.Size = new System.Drawing.Size(13, 22);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(1231, 378);
            this.txtcreatedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcreatedDate.Size = new System.Drawing.Size(13, 22);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(1249, 380);
            this.txtcompId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcompId.Size = new System.Drawing.Size(13, 22);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(1249, 348);
            this.txtModuserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModuserID.Size = new System.Drawing.Size(13, 22);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(1200, 348);
            this.txtCrUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCrUserId.Size = new System.Drawing.Size(13, 22);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1231, 348);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Size = new System.Drawing.Size(13, 22);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(1231, 412);
            this.txtCounterId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCounterId.Size = new System.Drawing.Size(13, 22);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(1235, 412);
            this.txtBranchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBranchID.Size = new System.Drawing.Size(13, 22);
            // 
            // dtpLoginTime
            // 
            this.dtpLoginTime.AcceptBlankValue = false;
            this.dtpLoginTime.BindingProperty = "Value";
            this.dtpLoginTime.CustomFormat = "hh:mm:ss tt";
            this.dtpLoginTime.DataField = "LoginTime";
            this.dtpLoginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoginTime.Location = new System.Drawing.Point(624, 22);
            this.dtpLoginTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpLoginTime.Name = "dtpLoginTime";
            this.dtpLoginTime.NormalBorderColor = System.Drawing.Color.Gray;
            this.dtpLoginTime.ShowUpDown = true;
            this.dtpLoginTime.Size = new System.Drawing.Size(247, 22);
            this.dtpLoginTime.TabIndex = 2;
            // 
            // lbl_vouchTime
            // 
            this.lbl_vouchTime.AutoSize = true;
            this.lbl_vouchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vouchTime.Location = new System.Drawing.Point(451, 22);
            this.lbl_vouchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vouchTime.Name = "lbl_vouchTime";
            this.lbl_vouchTime.Size = new System.Drawing.Size(92, 20);
            this.lbl_vouchTime.TabIndex = 111;
            this.lbl_vouchTime.Text = "Login Time";
            // 
            // Dtp_LogoutTime
            // 
            this.Dtp_LogoutTime.AcceptBlankValue = false;
            this.Dtp_LogoutTime.BindingProperty = "Value";
            this.Dtp_LogoutTime.CustomFormat = "hh:mm:ss tt";
            this.Dtp_LogoutTime.DataField = "LogoutTime";
            this.Dtp_LogoutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_LogoutTime.Location = new System.Drawing.Point(624, 55);
            this.Dtp_LogoutTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_LogoutTime.Name = "Dtp_LogoutTime";
            this.Dtp_LogoutTime.NormalBorderColor = System.Drawing.Color.Gray;
            this.Dtp_LogoutTime.ShowUpDown = true;
            this.Dtp_LogoutTime.Size = new System.Drawing.Size(247, 22);
            this.Dtp_LogoutTime.TabIndex = 3;
            // 
            // lblLogoutTime
            // 
            this.lblLogoutTime.AutoSize = true;
            this.lblLogoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoutTime.Location = new System.Drawing.Point(451, 55);
            this.lblLogoutTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoutTime.Name = "lblLogoutTime";
            this.lblLogoutTime.Size = new System.Drawing.Size(102, 20);
            this.lblLogoutTime.TabIndex = 113;
            this.lblLogoutTime.Text = "Logout Time";
            // 
            // Dtp_LoginDate
            // 
            this.Dtp_LoginDate.AcceptBlankValue = false;
            this.Dtp_LoginDate.BindingProperty = "Value";
            this.Dtp_LoginDate.DataField = "LoginDate";
            this.Dtp_LoginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_LoginDate.Location = new System.Drawing.Point(188, 55);
            this.Dtp_LoginDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dtp_LoginDate.Name = "Dtp_LoginDate";
            this.Dtp_LoginDate.NormalBorderColor = System.Drawing.Color.Gray;
            this.Dtp_LoginDate.Size = new System.Drawing.Size(247, 22);
            this.Dtp_LoginDate.TabIndex = 1;
            // 
            // lbl_LoginDate
            // 
            this.lbl_LoginDate.AutoEllipsis = true;
            this.lbl_LoginDate.AutoSize = true;
            this.lbl_LoginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginDate.Location = new System.Drawing.Point(21, 55);
            this.lbl_LoginDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoginDate.Name = "lbl_LoginDate";
            this.lbl_LoginDate.Size = new System.Drawing.Size(91, 20);
            this.lbl_LoginDate.TabIndex = 115;
            this.lbl_LoginDate.Text = "Login Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 137;
            this.label5.Text = "Staff Name";
            // 
            // cmb_StaffName
            // 
            this.cmb_StaffName.AcceptBlankValue = false;
            this.cmb_StaffName.BindingProperty = "SelectedValue";
            this.cmb_StaffName.BindToDataGridview = true;
            this.cmb_StaffName.DataField = "StaffID";
            this.cmb_StaffName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_StaffName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_StaffName.FormattingEnabled = true;
            this.cmb_StaffName.Location = new System.Drawing.Point(188, 22);
            this.cmb_StaffName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_StaffName.Name = "cmb_StaffName";
            this.cmb_StaffName.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmb_StaffName.Size = new System.Drawing.Size(247, 23);
            this.cmb_StaffName.TabIndex = 0;
            this.cmb_StaffName.TableName = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_StaffName);
            this.groupBox4.Controls.Add(this.lbl_vouchTime);
            this.groupBox4.Controls.Add(this.dtpLoginTime);
            this.groupBox4.Controls.Add(this.lblLogoutTime);
            this.groupBox4.Controls.Add(this.Dtp_LogoutTime);
            this.groupBox4.Controls.Add(this.lbl_LoginDate);
            this.groupBox4.Controls.Add(this.Dtp_LoginDate);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, -1);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(921, 94);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowGrouping = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.DataFields")));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.DisplaySumRowHeader = true;
            this.dgv.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.FilterList")));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.GroupingFields = null;
            this.dgv.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.HiddenDataFields")));
            this.dgv.Location = new System.Drawing.Point(9, 100);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv.ShowDelete = true;
            this.dgv.ShowEdit = true;
            this.dgv.ShowMoveDown = false;
            this.dgv.ShowMoveUp = false;
            this.dgv.ShowSelectCheckBox = false;
            this.dgv.ShowSerialNo = true;
            this.dgv.Size = new System.Drawing.Size(1165, 438);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SummaryRowVisible = true;
            this.dgv.SumRowHeaderText = "Total";
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 5;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lbl_EntryNo
            // 
            this.lbl_EntryNo.AutoSize = true;
            this.lbl_EntryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntryNo.Location = new System.Drawing.Point(931, 54);
            this.lbl_EntryNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EntryNo.Name = "lbl_EntryNo";
            this.lbl_EntryNo.Size = new System.Drawing.Size(79, 20);
            this.lbl_EntryNo.TabIndex = 2;
            this.lbl_EntryNo.Text = " Entry No";
            this.lbl_EntryNo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(931, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Is Active";
            this.label3.Visible = false;
            // 
            // TxtIsactive
            // 
            this.TxtIsactive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIsactive.DataField = "IsActive";
            this.TxtIsactive.Location = new System.Drawing.Point(1021, 22);
            this.TxtIsactive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIsactive.Name = "TxtIsactive";
            this.TxtIsactive.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtIsactive.Size = new System.Drawing.Size(153, 22);
            this.TxtIsactive.TabIndex = 3;
            this.TxtIsactive.Visible = false;
            // 
            // TxtEntryNo
            // 
            this.TxtEntryNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEntryNo.DataField = "EntryId";
            this.TxtEntryNo.IsIDField = true;
            this.TxtEntryNo.Location = new System.Drawing.Point(1021, 52);
            this.TxtEntryNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEntryNo.Name = "TxtEntryNo";
            this.TxtEntryNo.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtEntryNo.Size = new System.Drawing.Size(153, 22);
            this.TxtEntryNo.TabIndex = 4;
            this.TxtEntryNo.Visible = false;
            // 
            // ManualPunchEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1191, 546);
            this.Controls.Add(this.lbl_EntryNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtIsactive);
            this.Controls.Add(this.TxtEntryNo);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManualPunchEntry";
            this.Text = "Manual Punch Entry";
            this.Load += new System.EventHandler(this.ManualPunchEntry_Load);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.TxtEntryNo, 0);
            this.Controls.SetChildIndex(this.TxtIsactive, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbl_EntryNo, 0);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbDTPicker dtpLoginTime;
        private System.Windows.Forms.Label lbl_vouchTime;
        private Gramboo.Controls.GrbDTPicker Dtp_LogoutTime;
        private System.Windows.Forms.Label lblLogoutTime;
        private Gramboo.Controls.GrbDTPicker Dtp_LoginDate;
        private System.Windows.Forms.Label lbl_LoginDate;
        private System.Windows.Forms.Label label5;
        private Gramboo.Controls.GrbComboBox cmb_StaffName;
        private System.Windows.Forms.GroupBox groupBox4;
        private Gramboo.Controls.GrbDataGridView dgv;
        private System.Windows.Forms.Label lbl_EntryNo;
        private System.Windows.Forms.Label label3;
        private Gramboo.Controls.GrbTextBox TxtIsactive;
        private Gramboo.Controls.GrbTextBox TxtEntryNo;
    }
}
