
namespace project.Forms.MST.Addressdetails
{
    partial class Add_State
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_State));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtStateCode = new Gramboo.Controls.GrbTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtStateName = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.TxtstateId = new Gramboo.Controls.GrbTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(706, 285);
            this.txtModifiedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(729, 283);
            this.txtcreatedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(743, 285);
            this.txtcompId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(743, 261);
            this.txtModuserID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(706, 261);
            this.txtCrUserId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(729, 261);
            this.txtUserName.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(729, 310);
            this.txtCounterId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(732, 310);
            this.txtBranchID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtStateCode
            // 
            this.txtStateCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStateCode.DataField = " Author_Code";
            this.txtStateCode.Location = new System.Drawing.Point(147, 9);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtStateCode.Size = new System.Drawing.Size(217, 22);
            this.txtStateCode.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "State Code";
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
            this.chkISActive.Location = new System.Drawing.Point(147, 74);
            this.chkISActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(90, 24);
            this.chkISActive.TabIndex = 87;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "IsActive";
            this.chkISActive.TrueValue = "1";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            // 
            // txtStateName
            // 
            this.txtStateName.Alias = "[Item Name]";
            this.txtStateName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStateName.DataField = " ";
            this.txtStateName.Location = new System.Drawing.Point(147, 42);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtStateName.Size = new System.Drawing.Size(217, 22);
            this.txtStateName.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "State Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(3, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(794, 332);
            this.groupBox2.TabIndex = 90;
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
            this.dgvList.Location = new System.Drawing.Point(8, 23);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvList.RowHeadersWidth = 51;
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
            this.dgvList.Size = new System.Drawing.Size(780, 301);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = false;
            this.dgvList.TabIndex = 0;
            // 
            // TxtstateId
            // 
            this.TxtstateId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtstateId.Location = new System.Drawing.Point(371, 12);
            this.TxtstateId.Name = "TxtstateId";
            this.TxtstateId.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtstateId.Size = new System.Drawing.Size(13, 22);
            this.TxtstateId.TabIndex = 91;
            this.TxtstateId.Text = "grbTextBox1";
            // 
            // Add_State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtstateId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkISActive);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Add_State";
            this.Text = "Add_State";
            this.Load += new System.EventHandler(this.Add_State_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtStateName, 0);
            this.Controls.SetChildIndex(this.chkISActive, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtStateCode, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.TxtstateId, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbTextBox txtStateCode;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtStateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgvList;
        private Gramboo.Controls.GrbTextBox TxtstateId;
    }
}