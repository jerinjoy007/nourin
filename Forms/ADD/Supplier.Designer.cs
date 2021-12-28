
namespace project.Forms.ADD
{
    partial class Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSupplierCode = new Gramboo.Controls.GrbTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupId = new Gramboo.Controls.GrbTextBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtSupplierName = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSupAdd1 = new Gramboo.Controls.GrbTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupAdd2 = new Gramboo.Controls.GrbTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupAdd3 = new Gramboo.Controls.GrbTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupWebSite = new Gramboo.Controls.GrbTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupMobile = new Gramboo.Controls.GrbTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupEmail = new Gramboo.Controls.GrbTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupPin = new Gramboo.Controls.GrbTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSupResPhone = new Gramboo.Controls.GrbTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvList = new Gramboo.Controls.GrbDataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(1155, 397);
            this.txtModifiedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(1178, 395);
            this.txtcreatedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(1192, 397);
            this.txtcompId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(1192, 373);
            this.txtModuserID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(1155, 373);
            this.txtCrUserId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1178, 373);
            this.txtUserName.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(1178, 422);
            this.txtCounterId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(1181, 422);
            this.txtBranchID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierCode.DataField = "SupplierCode";
            this.txtSupplierCode.Location = new System.Drawing.Point(149, 9);
            this.txtSupplierCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupplierCode.Size = new System.Drawing.Size(299, 22);
            this.txtSupplierCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 90;
            this.label2.Text = "Supplier Code";
            // 
            // txtSupId
            // 
            this.txtSupId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupId.DataField = "SupId";
            this.txtSupId.IsIDField = true;
            this.txtSupId.Location = new System.Drawing.Point(456, 13);
            this.txtSupId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupId.Name = "txtSupId";
            this.txtSupId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupId.Size = new System.Drawing.Size(10, 22);
            this.txtSupId.TabIndex = 89;
            this.txtSupId.Visible = false;
            this.txtSupId.TextChanged += new System.EventHandler(this.txtEntryId_TextChanged);
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
            this.chkISActive.Location = new System.Drawing.Point(572, 174);
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
            // txtSupplierName
            // 
            this.txtSupplierName.Alias = "[Item Name]";
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplierName.DataField = "SupplierName";
            this.txtSupplierName.Location = new System.Drawing.Point(149, 42);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupplierName.Size = new System.Drawing.Size(299, 22);
            this.txtSupplierName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Supplier Name";
            // 
            // txtSupAdd1
            // 
            this.txtSupAdd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupAdd1.DataField = "SupplierAddress1";
            this.txtSupAdd1.Location = new System.Drawing.Point(149, 77);
            this.txtSupAdd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupAdd1.Name = "txtSupAdd1";
            this.txtSupAdd1.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupAdd1.Size = new System.Drawing.Size(299, 22);
            this.txtSupAdd1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Address 1";
            // 
            // txtSupAdd2
            // 
            this.txtSupAdd2.Alias = "[Item Name]";
            this.txtSupAdd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupAdd2.DataField = "SupplierAddress2";
            this.txtSupAdd2.Location = new System.Drawing.Point(149, 110);
            this.txtSupAdd2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupAdd2.Name = "txtSupAdd2";
            this.txtSupAdd2.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupAdd2.Size = new System.Drawing.Size(299, 22);
            this.txtSupAdd2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 93;
            this.label4.Text = "Address 2";
            // 
            // txtSupAdd3
            // 
            this.txtSupAdd3.Alias = "[Item Name]";
            this.txtSupAdd3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupAdd3.DataField = "SupplierAddress3";
            this.txtSupAdd3.Location = new System.Drawing.Point(149, 140);
            this.txtSupAdd3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupAdd3.Name = "txtSupAdd3";
            this.txtSupAdd3.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupAdd3.Size = new System.Drawing.Size(299, 22);
            this.txtSupAdd3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Address 3";
            // 
            // txtSupWebSite
            // 
            this.txtSupWebSite.Alias = "[Item Name]";
            this.txtSupWebSite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupWebSite.DataField = "SupplierWebSite";
            this.txtSupWebSite.Location = new System.Drawing.Point(572, 144);
            this.txtSupWebSite.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupWebSite.Name = "txtSupWebSite";
            this.txtSupWebSite.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupWebSite.Size = new System.Drawing.Size(263, 22);
            this.txtSupWebSite.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(490, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 106;
            this.label6.Text = "Website";
            // 
            // txtSupMobile
            // 
            this.txtSupMobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupMobile.DataField = "SupplierMobile";
            this.txtSupMobile.Location = new System.Drawing.Point(572, 81);
            this.txtSupMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupMobile.Name = "txtSupMobile";
            this.txtSupMobile.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupMobile.Size = new System.Drawing.Size(263, 22);
            this.txtSupMobile.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(490, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Mobile";
            // 
            // txtSupEmail
            // 
            this.txtSupEmail.Alias = "[Item Name]";
            this.txtSupEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupEmail.DataField = "SupplierEmail";
            this.txtSupEmail.Location = new System.Drawing.Point(572, 114);
            this.txtSupEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupEmail.Name = "txtSupEmail";
            this.txtSupEmail.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupEmail.Size = new System.Drawing.Size(263, 22);
            this.txtSupEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(490, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 103;
            this.label8.Text = "Email";
            // 
            // txtSupPin
            // 
            this.txtSupPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupPin.DataField = "SupplierPin";
            this.txtSupPin.Location = new System.Drawing.Point(572, 13);
            this.txtSupPin.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupPin.Name = "txtSupPin";
            this.txtSupPin.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupPin.Size = new System.Drawing.Size(263, 22);
            this.txtSupPin.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label9.Location = new System.Drawing.Point(490, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = "Pin/Zip";
            // 
            // txtSupResPhone
            // 
            this.txtSupResPhone.Alias = "[Item Name]";
            this.txtSupResPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupResPhone.DataField = "SupplierResPhone";
            this.txtSupResPhone.Location = new System.Drawing.Point(572, 46);
            this.txtSupResPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupResPhone.Name = "txtSupResPhone";
            this.txtSupResPhone.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtSupResPhone.Size = new System.Drawing.Size(263, 22);
            this.txtSupResPhone.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(490, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 99;
            this.label10.Text = "Phone";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Location = new System.Drawing.Point(13, 217);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1122, 400);
            this.groupBox2.TabIndex = 107;
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
            this.dgvList.Size = new System.Drawing.Size(1106, 369);
            this.dgvList.SummaryColumns = null;
            this.dgvList.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgvList.SummaryRowSpace = 0;
            this.dgvList.SumRowHeaderText = null;
            this.dgvList.SumRowHeaderTextBold = false;
            this.dgvList.TabIndex = 0;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 630);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtSupWebSite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSupMobile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSupEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSupPin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSupResPhone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSupAdd3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSupAdd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupAdd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSupplierCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupId);
            this.Controls.Add(this.chkISActive);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtSupplierName, 0);
            this.Controls.SetChildIndex(this.chkISActive, 0);
            this.Controls.SetChildIndex(this.txtSupId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSupplierCode, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtSupAdd2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtSupAdd1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtSupAdd3, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.txtSupResPhone, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtSupPin, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtSupEmail, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtSupMobile, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtSupWebSite, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbTextBox txtSupplierCode;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbTextBox txtSupId;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox txtSupAdd1;
        private System.Windows.Forms.Label label3;
        private Gramboo.Controls.GrbTextBox txtSupAdd2;
        private System.Windows.Forms.Label label4;
        private Gramboo.Controls.GrbTextBox txtSupAdd3;
        private System.Windows.Forms.Label label5;
        private Gramboo.Controls.GrbTextBox txtSupWebSite;
        private System.Windows.Forms.Label label6;
        private Gramboo.Controls.GrbTextBox txtSupMobile;
        private System.Windows.Forms.Label label7;
        private Gramboo.Controls.GrbTextBox txtSupEmail;
        private System.Windows.Forms.Label label8;
        private Gramboo.Controls.GrbTextBox txtSupPin;
        private System.Windows.Forms.Label label9;
        private Gramboo.Controls.GrbTextBox txtSupResPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbDataGridView dgvList;
    }
}