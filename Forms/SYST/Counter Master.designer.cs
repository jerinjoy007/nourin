namespace project.Forms.SYST
{
    partial class Counter_Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter_Master));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_GroupName = new System.Windows.Forms.Label();
            this.txtCounterName = new Gramboo.Controls.GrbTextBox();
            this.Chk_IsActive = new Gramboo.Controls.GrbCheckBox();
            this.txtCounterIdd = new Gramboo.Controls.GrbTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(694, 355);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(717, 353);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(731, 355);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(731, 329);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(694, 329);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(717, 329);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(717, 381);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(720, 381);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_GroupName);
            this.groupBox1.Controls.Add(this.txtCounterName);
            this.groupBox1.Controls.Add(this.Chk_IsActive);
            this.groupBox1.Controls.Add(this.txtCounterIdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 77);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            // 
            // Lbl_GroupName
            // 
            this.Lbl_GroupName.AutoSize = true;
            this.Lbl_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GroupName.Location = new System.Drawing.Point(16, 18);
            this.Lbl_GroupName.Name = "Lbl_GroupName";
            this.Lbl_GroupName.Size = new System.Drawing.Size(94, 16);
            this.Lbl_GroupName.TabIndex = 140;
            this.Lbl_GroupName.Text = "Counter Name";
            // 
            // txtCounterName
            // 
            this.txtCounterName.AcceptBlankValue = false;
            this.txtCounterName.Alias = "Petty Cash Category Name";
            this.txtCounterName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounterName.DataField = "CounterName";
            this.txtCounterName.Location = new System.Drawing.Point(135, 18);
            this.txtCounterName.Name = "txtCounterName";
            this.txtCounterName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtCounterName.Size = new System.Drawing.Size(237, 20);
            this.txtCounterName.TabIndex = 139;
            // 
            // Chk_IsActive
            // 
            this.Chk_IsActive.AcceptBlankValue = false;
            this.Chk_IsActive.BindingProperty = "Checked";
            this.Chk_IsActive.Checked = true;
            this.Chk_IsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_IsActive.DataField = "IsActive";
            this.Chk_IsActive.FalseValue = "0";
            this.Chk_IsActive.Location = new System.Drawing.Point(135, 45);
            this.Chk_IsActive.Name = "Chk_IsActive";
            this.Chk_IsActive.Size = new System.Drawing.Size(75, 20);
            this.Chk_IsActive.TabIndex = 143;
            this.Chk_IsActive.TableName = null;
            this.Chk_IsActive.Text = "Is Active";
            this.Chk_IsActive.TrueValue = "1";
            this.Chk_IsActive.UseVisualStyleBackColor = true;
            this.Chk_IsActive.Value = "1";
            // 
            // txtCounterIdd
            // 
            this.txtCounterIdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCounterIdd.DataField = "CounterId";
            this.txtCounterIdd.IsIDField = true;
            this.txtCounterIdd.Location = new System.Drawing.Point(238, 46);
            this.txtCounterIdd.Name = "txtCounterIdd";
            this.txtCounterIdd.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtCounterIdd.Size = new System.Drawing.Size(39, 20);
            this.txtCounterIdd.TabIndex = 142;
            this.txtCounterIdd.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(6, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 439);
            this.groupBox2.TabIndex = 148;
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
            this.dgv.Location = new System.Drawing.Point(6, 12);
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
            this.dgv.Size = new System.Drawing.Size(657, 421);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SumRowHeaderText = null;
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 141;
            // 
            // Counter_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 536);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(6, 1);
            this.Name = "Counter_Master";
            this.Text = "Counter Master";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_GroupName;
        private Gramboo.Controls.GrbTextBox txtCounterName;
        private Gramboo.Controls.GrbCheckBox Chk_IsActive;
        private Gramboo.Controls.GrbTextBox txtCounterIdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgv;
    }
}
