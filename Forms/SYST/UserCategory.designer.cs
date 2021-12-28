namespace project.Forms.SYST
{
    partial class UserCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chk_IsActive = new Gramboo.Controls.GrbCheckBox();
            this.TxtUserCategoryName = new Gramboo.Controls.GrbTextBox();
            this.Lbl_UserCategoryName = new System.Windows.Forms.Label();
            this.TxtUserCategoryID = new Gramboo.Controls.GrbTextBox();
            this.Lbl_UserCategoryID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.txtBranchID.Location = new System.Drawing.Point(1041, 359);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Chk_IsActive);
            this.groupBox1.Controls.Add(this.TxtUserCategoryName);
            this.groupBox1.Controls.Add(this.Lbl_UserCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 70);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Chk_IsActive
            // 
            this.Chk_IsActive.AcceptBlankValue = false;
            this.Chk_IsActive.BindingProperty = "Checked";
            this.Chk_IsActive.Checked = true;
            this.Chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_IsActive.DataField = "IsActive";
            this.Chk_IsActive.FalseValue = "0";
            this.Chk_IsActive.Location = new System.Drawing.Point(168, 45);
            this.Chk_IsActive.Name = "Chk_IsActive";
            this.Chk_IsActive.Size = new System.Drawing.Size(75, 20);
            this.Chk_IsActive.TabIndex = 2;
            this.Chk_IsActive.TableName = null;
            this.Chk_IsActive.Text = "Is Active";
            this.Chk_IsActive.TrueValue = "1";
            this.Chk_IsActive.UseVisualStyleBackColor = true;
            this.Chk_IsActive.Value = "1";
            // 
            // TxtUserCategoryName
            // 
            this.TxtUserCategoryName.AcceptBlankValue = false;
            this.TxtUserCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserCategoryName.DataField = "user_category_name";
            this.TxtUserCategoryName.Location = new System.Drawing.Point(168, 18);
            this.TxtUserCategoryName.Name = "TxtUserCategoryName";
            this.TxtUserCategoryName.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtUserCategoryName.Size = new System.Drawing.Size(237, 20);
            this.TxtUserCategoryName.TabIndex = 1;
            // 
            // Lbl_UserCategoryName
            // 
            this.Lbl_UserCategoryName.AutoSize = true;
            this.Lbl_UserCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserCategoryName.Location = new System.Drawing.Point(16, 18);
            this.Lbl_UserCategoryName.Name = "Lbl_UserCategoryName";
            this.Lbl_UserCategoryName.Size = new System.Drawing.Size(135, 16);
            this.Lbl_UserCategoryName.TabIndex = 140;
            this.Lbl_UserCategoryName.Text = "User Category Name";
            // 
            // TxtUserCategoryID
            // 
            this.TxtUserCategoryID.ActiveBackColor = System.Drawing.Color.LightGray;
            this.TxtUserCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserCategoryID.DataField = "user_category_id";
            this.TxtUserCategoryID.IsIDField = true;
            this.TxtUserCategoryID.Location = new System.Drawing.Point(492, 15);
            this.TxtUserCategoryID.Name = "TxtUserCategoryID";
            this.TxtUserCategoryID.NormalBackColor = System.Drawing.Color.LightGray;
            this.TxtUserCategoryID.NormalBorderColor = System.Drawing.Color.LightGray;
            this.TxtUserCategoryID.ReadOnly = true;
            this.TxtUserCategoryID.Size = new System.Drawing.Size(137, 20);
            this.TxtUserCategoryID.TabIndex = 0;
            this.TxtUserCategoryID.TabStop = false;
            this.TxtUserCategoryID.Visible = false;
            // 
            // Lbl_UserCategoryID
            // 
            this.Lbl_UserCategoryID.AutoSize = true;
            this.Lbl_UserCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserCategoryID.Location = new System.Drawing.Point(649, 15);
            this.Lbl_UserCategoryID.Name = "Lbl_UserCategoryID";
            this.Lbl_UserCategoryID.Size = new System.Drawing.Size(111, 16);
            this.Lbl_UserCategoryID.TabIndex = 0;
            this.Lbl_UserCategoryID.Text = "User Category ID";
            this.Lbl_UserCategoryID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(42, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Location = new System.Drawing.Point(6, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(999, 405);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv.DisplaySumRowHeader = false;
            this.dgv.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.FilterList")));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.GroupingFields = null;
            this.dgv.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.HiddenDataFields")));
            this.dgv.Location = new System.Drawing.Point(7, 13);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv.ShowDelete = false;
            this.dgv.ShowEdit = false;
            this.dgv.ShowMoveDown = false;
            this.dgv.ShowMoveUp = false;
            this.dgv.ShowSelectCheckBox = false;
            this.dgv.ShowSerialNo = true;
            this.dgv.Size = new System.Drawing.Size(986, 386);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SumRowHeaderText = null;
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 0;
            // 
            // UserCategory
            // 
            this.AcceptControl = this.Chk_IsActive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 492);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TxtUserCategoryID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lbl_UserCategoryID);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserCategory";
            this.Text = "User Category";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Lbl_UserCategoryID, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.TxtUserCategoryID, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Gramboo.Controls.GrbCheckBox Chk_IsActive;
        private Gramboo.Controls.GrbTextBox TxtUserCategoryID;
        private Gramboo.Controls.GrbTextBox TxtUserCategoryName;
        private System.Windows.Forms.Label Lbl_UserCategoryName;
        private System.Windows.Forms.Label Lbl_UserCategoryID;
        private Gramboo.Controls.GrbDataGridView dgv;
    }
}
