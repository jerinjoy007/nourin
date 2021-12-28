namespace project.Forms.SYST
{
    partial class FavFrmmenuMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavFrmmenuMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMenuId = new Gramboo.Controls.GrbTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.Cmb_ParentName = new Gramboo.Controls.GrbComboBox();
            this.treeView1 = new project.Classes.GrbTreeview();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.grbButton1 = new Gramboo.Controls.GrbButton();
            this.btn_Remove = new Gramboo.Controls.GrbButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRelId = new Gramboo.Controls.GrbTextBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtuser = new Gramboo.Controls.GrbTextBox();
            this.txtUserId = new Gramboo.Controls.GrbTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(855, 325);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(878, 323);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(892, 325);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(892, 299);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(855, 299);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(878, 299);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(878, 351);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(881, 351);
            // 
            // txtMenuId
            // 
            this.txtMenuId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenuId.DataField = "FavMenuId";
            this.txtMenuId.IsIDField = true;
            this.txtMenuId.Location = new System.Drawing.Point(710, 34);
            this.txtMenuId.Name = "txtMenuId";
            this.txtMenuId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtMenuId.Size = new System.Drawing.Size(126, 20);
            this.txtMenuId.TabIndex = 57;
            this.txtMenuId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.Cmb_ParentName);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 415);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(16, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 16);
            this.label21.TabIndex = 161;
            this.label21.Text = "Parent Menu";
            // 
            // Cmb_ParentName
            // 
            this.Cmb_ParentName.AcceptBlankValue = false;
            this.Cmb_ParentName.BindToDataGridview = true;
            this.Cmb_ParentName.CheckDuplicates = true;
            this.Cmb_ParentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_ParentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_ParentName.FormattingEnabled = true;
            this.Cmb_ParentName.Location = new System.Drawing.Point(114, 19);
            this.Cmb_ParentName.Name = "Cmb_ParentName";
            this.Cmb_ParentName.NormalBorderColor = System.Drawing.Color.Gray;
            this.Cmb_ParentName.ShowComplusoryMark = false;
            this.Cmb_ParentName.Size = new System.Drawing.Size(237, 21);
            this.Cmb_ParentName.TabIndex = 0;
            this.Cmb_ParentName.TableName = "";
            this.Cmb_ParentName.SelectedValueChanged += new System.EventHandler(this.Cmb_ParentName_SelectedValueChanged);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(6, 53);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(355, 356);
            this.treeView1.TabIndex = 150;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgv);
            this.groupBox3.Location = new System.Drawing.Point(454, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 415);
            this.groupBox3.TabIndex = 160;
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
            this.dgv.DisplaySumRowHeader = false;
            this.dgv.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.FilterList")));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.GroupingFields = null;
            this.dgv.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.HiddenDataFields")));
            this.dgv.Location = new System.Drawing.Point(6, 53);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv.ShowDelete = false;
            this.dgv.ShowEdit = false;
            this.dgv.ShowMoveDown = false;
            this.dgv.ShowMoveUp = false;
            this.dgv.ShowSelectCheckBox = true;
            this.dgv.ShowSerialNo = true;
            this.dgv.Size = new System.Drawing.Size(370, 356);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SummaryRowVisible = true;
            this.dgv.SumRowHeaderText = null;
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 1;
            // 
            // grbButton1
            // 
            this.grbButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.BackgroundImage")));
            this.grbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.grbButton1.FlatAppearance.BorderSize = 2;
            this.grbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbButton1.Location = new System.Drawing.Point(396, 204);
            this.grbButton1.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.MouseDownImage")));
            this.grbButton1.Name = "grbButton1";
            this.grbButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.NormalImage")));
            this.grbButton1.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.OnFocusImage")));
            this.grbButton1.SelectedImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.SelectedImage")));
            this.grbButton1.Size = new System.Drawing.Size(36, 23);
            this.grbButton1.TabIndex = 163;
            this.grbButton1.Text = ">>";
            this.grbButton1.UseVisualStyleBackColor = true;
            this.grbButton1.Click += new System.EventHandler(this.grbButton1_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.BackgroundImage")));
            this.btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btn_Remove.FlatAppearance.BorderSize = 2;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(396, 255);
            this.btn_Remove.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.MouseDownImage")));
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.NormalImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.NormalImage")));
            this.btn_Remove.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.OnFocusImage")));
            this.btn_Remove.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btn_Remove.SelectedImage")));
            this.btn_Remove.Size = new System.Drawing.Size(36, 23);
            this.btn_Remove.TabIndex = 162;
            this.btn_Remove.Text = "<<";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 163;
            this.label1.Text = "User Name";
            // 
            // txtRelId
            // 
            this.txtRelId.AcceptBlankValue = false;
            this.txtRelId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRelId.DataField = "Id";
            this.txtRelId.IsIDField = true;
            this.txtRelId.Location = new System.Drawing.Point(681, 8);
            this.txtRelId.Name = "txtRelId";
            this.txtRelId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtRelId.Size = new System.Drawing.Size(14, 20);
            this.txtRelId.TabIndex = 164;
            this.txtRelId.Visible = false;
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
            this.chkISActive.Location = new System.Drawing.Point(126, 39);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(77, 20);
            this.chkISActive.TabIndex = 165;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "Is Active";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // txtuser
            // 
            this.txtuser.ActiveBackColor = System.Drawing.Color.LightGray;
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.IsIDField = true;
            this.txtuser.Location = new System.Drawing.Point(126, 8);
            this.txtuser.Name = "txtuser";
            this.txtuser.NormalBackColor = System.Drawing.Color.LightGray;
            this.txtuser.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtuser.ReadOnly = true;
            this.txtuser.Size = new System.Drawing.Size(247, 20);
            this.txtuser.TabIndex = 166;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // txtUserId
            // 
            this.txtUserId.AcceptBlankValue = false;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.DataField = "user_id";
            this.txtUserId.IsIDField = true;
            this.txtUserId.Location = new System.Drawing.Point(710, 8);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtUserId.Size = new System.Drawing.Size(126, 20);
            this.txtUserId.TabIndex = 167;
            this.txtUserId.Visible = false;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // FavFrmmenuMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(848, 477);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.chkISActive);
            this.Controls.Add(this.txtRelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbButton1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.txtMenuId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FavFrmmenuMaster";
            this.Text = "Favorite Menu Master";
            this.Load += new System.EventHandler(this.FavFrmmenuMaster_Load);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.txtMenuId, 0);
            this.Controls.SetChildIndex(this.btn_Remove, 0);
            this.Controls.SetChildIndex(this.grbButton1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtRelId, 0);
            this.Controls.SetChildIndex(this.chkISActive, 0);
            this.Controls.SetChildIndex(this.txtuser, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbTextBox txtMenuId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private Gramboo.Controls.GrbComboBox Cmb_ParentName;
        private Classes.GrbTreeview treeView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Gramboo.Controls.GrbDataGridView dgv;
        private Gramboo.Controls.GrbButton grbButton1;
        private Gramboo.Controls.GrbButton btn_Remove;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox txtRelId;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtuser;
        private Gramboo.Controls.GrbTextBox txtUserId;
    }
}
