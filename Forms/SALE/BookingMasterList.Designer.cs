namespace project.Forms.SALE
{
    partial class BookingMasterList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingMasterList));
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(776, 303);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(799, 301);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(813, 303);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(813, 277);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(776, 277);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(799, 277);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(799, 329);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(802, 329);
            // 
            // dgv
            // 
            this.dgv.AllowGrouping = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.DataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.DataFields")));
            this.dgv.DisplaySumRowHeader = false;
            this.dgv.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.FilterList")));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.GroupingFields = null;
            this.dgv.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.HiddenDataFields")));
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            this.dgv.ShowDelete = false;
            this.dgv.ShowEdit = false;
            this.dgv.ShowMoveDown = false;
            this.dgv.ShowMoveUp = false;
            this.dgv.ShowSelectCheckBox = false;
            this.dgv.ShowSerialNo = false;
            this.dgv.Size = new System.Drawing.Size(942, 507);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SumRowHeaderText = null;
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 0;
            // 
            // BookingMasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 519);
            this.Controls.Add(this.dgv);
            this.Name = "BookingMasterList";
            this.Text = "Booking Master List";
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbDataGridView dgv;
    }
}