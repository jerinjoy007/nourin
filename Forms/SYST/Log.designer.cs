namespace project.Forms.SYST
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.Button = new Gramboo.Controls.GrbButton();
            this.Dtp_From = new Gramboo.Controls.GrbDTPicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_to = new Gramboo.Controls.GrbDTPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.dgv.DisplaySumRowHeader = true;
            this.dgv.FilterList = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.FilterList")));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.GroupingFields = null;
            this.dgv.HiddenDataFields = ((System.Collections.Generic.List<string>)(resources.GetObject("dgv.HiddenDataFields")));
            this.dgv.IsList = true;
            this.dgv.Location = new System.Drawing.Point(2, 48);
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
            this.dgv.Size = new System.Drawing.Size(1005, 443);
            this.dgv.SummaryColumns = new string[0];
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SummaryRowVisible = true;
            this.dgv.SumRowHeaderText = "Total";
            this.dgv.SumRowHeaderTextBold = true;
            this.dgv.TabIndex = 28;
            this.dgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            // 
            // Button
            // 
            this.Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button.BackgroundImage")));
            this.Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.Button.FlatAppearance.BorderSize = 2;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(475, 5);
            this.Button.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("Button.MouseDownImage")));
            this.Button.Name = "Button";
            this.Button.NormalImage = ((System.Drawing.Image)(resources.GetObject("Button.NormalImage")));
            this.Button.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("Button.OnFocusImage")));
            this.Button.SelectedImage = ((System.Drawing.Image)(resources.GetObject("Button.SelectedImage")));
            this.Button.Size = new System.Drawing.Size(135, 30);
            this.Button.TabIndex = 29;
            this.Button.Text = "Clear Log";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // Dtp_From
            // 
            this.Dtp_From.AcceptBlankValue = false;
            this.Dtp_From.BindingProperty = "Value";
            this.Dtp_From.DataField = "VchDate";
            this.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_From.Location = new System.Drawing.Point(116, 12);
            this.Dtp_From.Name = "Dtp_From";
            this.Dtp_From.NormalBorderColor = System.Drawing.Color.Gray;
            this.Dtp_From.Size = new System.Drawing.Size(111, 20);
            this.Dtp_From.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "From Date";
            // 
            // dtp_to
            // 
            this.dtp_to.AcceptBlankValue = false;
            this.dtp_to.BindingProperty = "Value";
            this.dtp_to.DataField = "VchDate";
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(318, 12);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.NormalBorderColor = System.Drawing.Color.Gray;
            this.dtp_to.Size = new System.Drawing.Size(111, 20);
            this.dtp_to.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "To Date";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 492);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dtp_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.dgv);
            this.Name = "Log";
            this.Text = "Log";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.Button, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Dtp_From, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtp_to, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbDataGridView dgv;
        private Gramboo.Controls.GrbButton Button;
        private Gramboo.Controls.GrbDTPicker Dtp_From;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbDTPicker dtp_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
