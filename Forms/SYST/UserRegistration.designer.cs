namespace project.Forms.SYST
{
    partial class UserRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_MenuGroup = new Gramboo.Controls.GrbComboBox();
            this.Cmb_UserCategory = new Gramboo.Controls.GrbComboBox();
            this.Lbl_UserCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtConfirmPass = new Gramboo.Controls.GrbTextBox();
            this.TxtPassword = new Gramboo.Controls.GrbTextBox();
            this.TxtUsrName = new Gramboo.Controls.GrbTextBox();
            this.Chk_IsActive = new Gramboo.Controls.GrbCheckBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.Lbl_Under = new System.Windows.Forms.Label();
            this.Lbl_GroupName = new System.Windows.Forms.Label();
            this.TxtUserID = new Gramboo.Controls.GrbTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_MenuGroup);
            this.groupBox1.Controls.Add(this.Cmb_UserCategory);
            this.groupBox1.Controls.Add(this.Lbl_UserCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtConfirmPass);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtUsrName);
            this.groupBox1.Controls.Add(this.Chk_IsActive);
            this.groupBox1.Controls.Add(this.lbl_ItemName);
            this.groupBox1.Controls.Add(this.Lbl_Under);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 147;
            this.label2.Text = "Menu Group";
            // 
            // cmb_MenuGroup
            // 
            this.cmb_MenuGroup.BindingProperty = "SelectedValue";
            this.cmb_MenuGroup.DataField = "GroupId";
            this.cmb_MenuGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_MenuGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_MenuGroup.FormattingEnabled = true;
            this.cmb_MenuGroup.Location = new System.Drawing.Point(149, 126);
            this.cmb_MenuGroup.Name = "cmb_MenuGroup";
            this.cmb_MenuGroup.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmb_MenuGroup.Size = new System.Drawing.Size(237, 21);
            this.cmb_MenuGroup.TabIndex = 4;
            this.cmb_MenuGroup.TableName = "";
            // 
            // Cmb_UserCategory
            // 
            this.Cmb_UserCategory.BindingProperty = "SelectedValue";
            this.Cmb_UserCategory.DataField = "user_category_id";
            this.Cmb_UserCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_UserCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_UserCategory.FormattingEnabled = true;
            this.Cmb_UserCategory.Location = new System.Drawing.Point(149, 99);
            this.Cmb_UserCategory.Name = "Cmb_UserCategory";
            this.Cmb_UserCategory.NormalBorderColor = System.Drawing.Color.Gray;
            this.Cmb_UserCategory.Size = new System.Drawing.Size(237, 21);
            this.Cmb_UserCategory.TabIndex = 3;
            this.Cmb_UserCategory.TableName = "";
            // 
            // Lbl_UserCategory
            // 
            this.Lbl_UserCategory.AutoSize = true;
            this.Lbl_UserCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserCategory.Location = new System.Drawing.Point(16, 99);
            this.Lbl_UserCategory.Name = "Lbl_UserCategory";
            this.Lbl_UserCategory.Size = new System.Drawing.Size(98, 16);
            this.Lbl_UserCategory.TabIndex = 145;
            this.Lbl_UserCategory.Text = "User Category ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "Confirm Password";
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.AcceptBlankValue = false;
            this.TxtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtConfirmPass.Location = new System.Drawing.Point(149, 72);
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtConfirmPass.PasswordChar = '*';
            this.TxtConfirmPass.Size = new System.Drawing.Size(237, 20);
            this.TxtConfirmPass.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.AcceptBlankValue = false;
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.DataField = "user_password";
            this.TxtPassword.Location = new System.Drawing.Point(149, 45);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(237, 20);
            this.TxtPassword.TabIndex = 1;
            // 
            // TxtUsrName
            // 
            this.TxtUsrName.AcceptBlankValue = false;
            this.TxtUsrName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsrName.CheckDuplicates = true;
            this.TxtUsrName.DataField = "user_name";
            this.TxtUsrName.Location = new System.Drawing.Point(149, 18);
            this.TxtUsrName.Name = "TxtUsrName";
            this.TxtUsrName.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtUsrName.Size = new System.Drawing.Size(237, 20);
            this.TxtUsrName.TabIndex = 0;
            // 
            // Chk_IsActive
            // 
            this.Chk_IsActive.AcceptBlankValue = false;
            this.Chk_IsActive.BindingProperty = "Checked";
            this.Chk_IsActive.Checked = true;
            this.Chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_IsActive.DataField = "IsActive";
            this.Chk_IsActive.FalseValue = "0";
            this.Chk_IsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Chk_IsActive.Location = new System.Drawing.Point(149, 171);
            this.Chk_IsActive.Name = "Chk_IsActive";
            this.Chk_IsActive.Size = new System.Drawing.Size(80, 20);
            this.Chk_IsActive.TabIndex = 4;
            this.Chk_IsActive.TableName = null;
            this.Chk_IsActive.Text = "Is Active";
            this.Chk_IsActive.TrueValue = "1";
            this.Chk_IsActive.UseVisualStyleBackColor = true;
            this.Chk_IsActive.Value = "1";
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(16, 45);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(68, 16);
            this.lbl_ItemName.TabIndex = 140;
            this.lbl_ItemName.Text = "Password";
            // 
            // Lbl_Under
            // 
            this.Lbl_Under.AutoSize = true;
            this.Lbl_Under.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Under.Location = new System.Drawing.Point(16, 18);
            this.Lbl_Under.Name = "Lbl_Under";
            this.Lbl_Under.Size = new System.Drawing.Size(77, 16);
            this.Lbl_Under.TabIndex = 136;
            this.Lbl_Under.Text = "User Name";
            // 
            // Lbl_GroupName
            // 
            this.Lbl_GroupName.AutoSize = true;
            this.Lbl_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GroupName.Location = new System.Drawing.Point(457, 19);
            this.Lbl_GroupName.Name = "Lbl_GroupName";
            this.Lbl_GroupName.Size = new System.Drawing.Size(53, 16);
            this.Lbl_GroupName.TabIndex = 138;
            this.Lbl_GroupName.Text = "User ID";
            this.Lbl_GroupName.Visible = false;
            // 
            // TxtUserID
            // 
            this.TxtUserID.AcceptBlankValue = false;
            this.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserID.DataField = "user_id";
            this.TxtUserID.IsIDField = true;
            this.TxtUserID.Location = new System.Drawing.Point(516, 19);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtUserID.ReadOnly = true;
            this.TxtUserID.Size = new System.Drawing.Size(195, 20);
            this.TxtUserID.TabIndex = 0;
            this.TxtUserID.TabStop = false;
            this.TxtUserID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(7, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(989, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
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
            this.dgv.Location = new System.Drawing.Point(5, 13);
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
            this.dgv.Size = new System.Drawing.Size(978, 304);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SumRowHeaderText = null;
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 0;
            // 
            // UserRegistration
            // 
            this.AcceptControl = this.Chk_IsActive;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_GroupName);
            this.Controls.Add(this.TxtUserID);
            this.Name = "UserRegistration";
            this.Text = "User Registration";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.TxtUserID, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.Lbl_GroupName, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbCheckBox Chk_IsActive;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label Lbl_GroupName;
        private Gramboo.Controls.GrbTextBox TxtUserID;
        private System.Windows.Forms.Label Lbl_Under;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgv;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox TxtConfirmPass;
        private Gramboo.Controls.GrbTextBox TxtPassword;
        private Gramboo.Controls.GrbTextBox TxtUsrName;
        private System.Windows.Forms.Label Lbl_UserCategory;
        private Gramboo.Controls.GrbComboBox Cmb_UserCategory;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbComboBox cmb_MenuGroup;
    }
}
