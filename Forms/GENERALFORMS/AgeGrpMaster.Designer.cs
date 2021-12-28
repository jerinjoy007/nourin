namespace project.Forms.GENERALFORMS
{
    partial class AgeGrpMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeGrpMaster));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtEntryID = new Gramboo.Controls.GrbTextBox();
            this.IsActive = new System.Windows.Forms.GroupBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AgTo = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AgFrom = new Gramboo.Controls.GrbTextBox();
            this.txt_AgGrpName = new Gramboo.Controls.GrbTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAge = new Gramboo.Controls.GrbDataGridView();
            this.IsActive.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(919, 303);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(942, 301);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(956, 303);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(956, 277);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(919, 277);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(942, 277);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(942, 329);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(945, 329);
            // 
            // TxtEntryID
            // 
            this.TxtEntryID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEntryID.DataField = "Entryid";
            this.TxtEntryID.Location = new System.Drawing.Point(491, 24);
            this.TxtEntryID.Name = "TxtEntryID";
            this.TxtEntryID.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtEntryID.Size = new System.Drawing.Size(43, 20);
            this.TxtEntryID.TabIndex = 37;
            this.TxtEntryID.Visible = false;
            // 
            // IsActive
            // 
            this.IsActive.Controls.Add(this.chkISActive);
            this.IsActive.Controls.Add(this.label5);
            this.IsActive.Controls.Add(this.label2);
            this.IsActive.Controls.Add(this.txt_AgTo);
            this.IsActive.Controls.Add(this.label1);
            this.IsActive.Controls.Add(this.txt_AgFrom);
            this.IsActive.Controls.Add(this.txt_AgGrpName);
            this.IsActive.Location = new System.Drawing.Point(12, 12);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(473, 117);
            this.IsActive.TabIndex = 0;
            this.IsActive.TabStop = false;
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
            this.chkISActive.Location = new System.Drawing.Point(178, 91);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(74, 20);
            this.chkISActive.TabIndex = 3;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "IsActive";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Age To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Age From";
            // 
            // txt_AgTo
            // 
            this.txt_AgTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AgTo.DataField = "AgeTo";
            this.txt_AgTo.InputMask = Gramboo.Controls.GrbTextBox.Mask.Digit;
            this.txt_AgTo.Location = new System.Drawing.Point(178, 65);
            this.txt_AgTo.Name = "txt_AgTo";
            this.txt_AgTo.NormalBorderColor = System.Drawing.Color.Gray;
            this.txt_AgTo.Size = new System.Drawing.Size(179, 20);
            this.txt_AgTo.TabIndex = 2;
            this.txt_AgTo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Age Group Name";
            // 
            // txt_AgFrom
            // 
            this.txt_AgFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AgFrom.DataField = "AgeFrom";
            this.txt_AgFrom.InputMask = Gramboo.Controls.GrbTextBox.Mask.Digit;
            this.txt_AgFrom.Location = new System.Drawing.Point(178, 38);
            this.txt_AgFrom.Name = "txt_AgFrom";
            this.txt_AgFrom.NormalBorderColor = System.Drawing.Color.Gray;
            this.txt_AgFrom.Size = new System.Drawing.Size(179, 20);
            this.txt_AgFrom.TabIndex = 1;
            this.txt_AgFrom.Text = "0";
            // 
            // txt_AgGrpName
            // 
            this.txt_AgGrpName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AgGrpName.DataField = "AgeGroupName";
            this.txt_AgGrpName.Location = new System.Drawing.Point(178, 12);
            this.txt_AgGrpName.Name = "txt_AgGrpName";
            this.txt_AgGrpName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txt_AgGrpName.Size = new System.Drawing.Size(179, 20);
            this.txt_AgGrpName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvAge);
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // dgvAge
            // 
            this.dgvAge.AllowGrouping = false;
            this.dgvAge.AllowUserToAddRows = false;
            this.dgvAge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAge.DataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvAge.DataFields")));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAge.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAge.DisplaySumRowHeader = false;
            this.dgvAge.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAge.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvAge.FilterList")));
            this.dgvAge.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAge.GroupingFields = null;
            this.dgvAge.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgvAge.HiddenDataFields")));
            this.dgvAge.IsDataEntryGrid = true;
            this.dgvAge.IsList = true;
            this.dgvAge.Location = new System.Drawing.Point(9, 25);
            this.dgvAge.Name = "dgvAge";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAge.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAge.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgvAge.ShowDelete = false;
            this.dgvAge.ShowEdit = false;
            this.dgvAge.ShowMoveDown = false;
            this.dgvAge.ShowMoveUp = false;
            this.dgvAge.ShowSelectCheckBox = false;
            this.dgvAge.ShowSerialNo = false;
            this.dgvAge.Size = new System.Drawing.Size(908, 328);
            this.dgvAge.SummaryColumns = null;
            this.dgvAge.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvAge.SummaryRowSpace = 0;
            this.dgvAge.SumRowHeaderText = null;
            this.dgvAge.SumRowHeaderTextBold = false;
            this.dgvAge.TabIndex = 0;
            this.dgvAge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grbDataGridView1_CellContentClick);
            // 
            // AgeGrpMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtEntryID);
            this.Controls.Add(this.IsActive);
            this.Name = "AgeGrpMaster";
            this.Text = "Age Group Master";
            this.Load += new System.EventHandler(this.AgeGrpMaster_Load);
            this.Controls.SetChildIndex(this.IsActive, 0);
            this.Controls.SetChildIndex(this.TxtEntryID, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.IsActive.ResumeLayout(false);
            this.IsActive.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbTextBox TxtEntryID;
        private System.Windows.Forms.GroupBox IsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbTextBox txt_AgTo;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox txt_AgFrom;
        private Gramboo.Controls.GrbTextBox txt_AgGrpName;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbDataGridView dgvAge;
    }
}