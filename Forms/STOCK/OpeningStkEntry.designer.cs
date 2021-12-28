namespace project.Forms.STOCK
{
    partial class DepartmentOpeningStkEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentOpeningStkEntry));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbggender = new Gramboo.Controls.GrbRadioButtonGroup();
            this.rbtService = new Gramboo.Controls.GrbRadioButton();
            this.rbtSale = new Gramboo.Controls.GrbRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCash = new Gramboo.Controls.GrbTextBox();
            this.Cmb_DepartmentName = new Gramboo.Controls.GrbComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dtp_dt = new Gramboo.Controls.GrbDTPicker();
            this.TxtVoucherNo = new Gramboo.Controls.GrbTextBox();
            this.Lbl_voucherNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbDTPicker1 = new Gramboo.Controls.GrbDTPicker();
            this.Txtgenfrom = new Gramboo.Controls.GrbTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbTextBox2 = new Gramboo.Controls.GrbTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbTextBox1 = new Gramboo.Controls.GrbTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfloorid = new Gramboo.Controls.GrbTextBox();
            this.cmbFloorname = new Gramboo.Controls.GrbComboBox();
            this.txtProdCode = new Gramboo.Controls.GrbTextBox();
            this.txtProdCodeId = new Gramboo.Controls.GrbTextBox();
            this.txtitemid = new Gramboo.Controls.GrbTextBox();
            this.btn_add = new Gramboo.Controls.GrbButton();
            this.Cmb_ItemName = new Gramboo.Controls.GrbComboBox();
            this.TxtNos = new Gramboo.Controls.GrbTextBox();
            this.Lbl_ReceiptWt = new System.Windows.Forms.Label();
            this.dgv = new Gramboo.Controls.GrbDataGridView();
            this.lbl_Itemid = new System.Windows.Forms.Label();
            this.lbl_EntryNo = new System.Windows.Forms.Label();
            this.txtEntryNo = new Gramboo.Controls.GrbTextBox();
            this.TxtTranscId = new Gramboo.Controls.GrbTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIsactive = new Gramboo.Controls.GrbTextBox();
            this.cmb_VoucherTypeId = new Gramboo.Controls.GrbComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_vouctypeId = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.rbggender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(1049, 348);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(1072, 346);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(1086, 348);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(1086, 322);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(1049, 322);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(1072, 322);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(1072, 374);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(1075, 374);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbggender);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCash);
            this.groupBox2.Controls.Add(this.Cmb_DepartmentName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Dtp_dt);
            this.groupBox2.Controls.Add(this.TxtVoucherNo);
            this.groupBox2.Controls.Add(this.Lbl_voucherNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // rbggender
            // 
            this.rbggender.AcceptBlankValue = false;
            this.rbggender.Alias = "Gender";
            this.rbggender.BindingProperty = "Value";
            this.rbggender.Controls.Add(this.rbtService);
            this.rbggender.Controls.Add(this.rbtSale);
            this.rbggender.DataField = "DeptName";
            this.rbggender.DefaultRadioButton = this.rbtSale;
            this.rbggender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbggender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbggender.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbggender.Location = new System.Drawing.Point(146, 78);
            this.rbggender.Name = "rbggender";
            this.rbggender.Size = new System.Drawing.Size(195, 45);
            this.rbggender.TabIndex = 101;
            this.rbggender.TableName = null;
            this.rbggender.TabStop = false;
            this.rbggender.Text = "Department  Name";
            this.rbggender.Value = "S";
            // 
            // rbtService
            // 
            this.rbtService.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbtService.GroupName = null;
            this.rbtService.Location = new System.Drawing.Point(92, 15);
            this.rbtService.Name = "rbtService";
            this.rbtService.Size = new System.Drawing.Size(86, 24);
            this.rbtService.TabIndex = 1;
            this.rbtService.Text = "Service";
            this.rbtService.TrueValue = "SR";
            this.rbtService.UseVisualStyleBackColor = true;
            // 
            // rbtSale
            // 
            this.rbtSale.Checked = true;
            this.rbtSale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbtSale.GroupName = null;
            this.rbtSale.Location = new System.Drawing.Point(15, 15);
            this.rbtSale.Name = "rbtSale";
            this.rbtSale.Size = new System.Drawing.Size(71, 24);
            this.rbtSale.TabIndex = 0;
            this.rbtSale.TabStop = true;
            this.rbtSale.Text = "Sales";
            this.rbtSale.TrueValue = "S";
            this.rbtSale.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 100;
            this.label11.Text = "Cash";
            this.label11.Visible = false;
            // 
            // txtCash
            // 
            this.txtCash.AcceptBlankValue = false;
            this.txtCash.BindToDataGridview = true;
            this.txtCash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCash.DataField = "Cash";
            this.txtCash.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.txtCash.Location = new System.Drawing.Point(492, 46);
            this.txtCash.Name = "txtCash";
            this.txtCash.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtCash.Size = new System.Drawing.Size(195, 20);
            this.txtCash.TabIndex = 2;
            this.txtCash.Text = "0";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.Visible = false;
            // 
            // Cmb_DepartmentName
            // 
            this.Cmb_DepartmentName.BindingProperty = "SelectedValue";
            this.Cmb_DepartmentName.DataField = "DeptID";
            this.Cmb_DepartmentName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_DepartmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_DepartmentName.FormattingEnabled = true;
            this.Cmb_DepartmentName.Location = new System.Drawing.Point(492, 19);
            this.Cmb_DepartmentName.Name = "Cmb_DepartmentName";
            this.Cmb_DepartmentName.NormalBorderColor = System.Drawing.Color.Gray;
            this.Cmb_DepartmentName.Size = new System.Drawing.Size(195, 21);
            this.Cmb_DepartmentName.TabIndex = 1;
            this.Cmb_DepartmentName.TableName = "";
            this.Cmb_DepartmentName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Department  Name";
            this.label7.Visible = false;
            // 
            // Dtp_dt
            // 
            this.Dtp_dt.AcceptBlankValue = false;
            this.Dtp_dt.BindingProperty = "Value";
            this.Dtp_dt.DataField = "VchDate";
            this.Dtp_dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_dt.Location = new System.Drawing.Point(146, 45);
            this.Dtp_dt.Name = "Dtp_dt";
            this.Dtp_dt.NormalBorderColor = System.Drawing.Color.Gray;
            this.Dtp_dt.Size = new System.Drawing.Size(195, 20);
            this.Dtp_dt.TabIndex = 0;
            // 
            // TxtVoucherNo
            // 
            this.TxtVoucherNo.ActiveBackColor = System.Drawing.Color.LightGray;
            this.TxtVoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtVoucherNo.DataField = "VchNo";
            this.TxtVoucherNo.Location = new System.Drawing.Point(146, 18);
            this.TxtVoucherNo.Name = "TxtVoucherNo";
            this.TxtVoucherNo.NormalBackColor = System.Drawing.Color.LightGray;
            this.TxtVoucherNo.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtVoucherNo.ReadOnly = true;
            this.TxtVoucherNo.Size = new System.Drawing.Size(195, 20);
            this.TxtVoucherNo.TabIndex = 0;
            this.TxtVoucherNo.TabStop = false;
            // 
            // Lbl_voucherNo
            // 
            this.Lbl_voucherNo.AutoSize = true;
            this.Lbl_voucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_voucherNo.Location = new System.Drawing.Point(16, 18);
            this.Lbl_voucherNo.Name = "Lbl_voucherNo";
            this.Lbl_voucherNo.Size = new System.Drawing.Size(79, 16);
            this.Lbl_voucherNo.TabIndex = 49;
            this.Lbl_voucherNo.Text = "Voucher No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Voucher Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.grbDTPicker1);
            this.groupBox1.Controls.Add(this.Txtgenfrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.grbTextBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grbTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfloorid);
            this.groupBox1.Controls.Add(this.cmbFloorname);
            this.groupBox1.Controls.Add(this.txtProdCode);
            this.groupBox1.Controls.Add(this.txtProdCodeId);
            this.groupBox1.Controls.Add(this.txtitemid);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.Cmb_ItemName);
            this.groupBox1.Controls.Add(this.TxtNos);
            this.groupBox1.Controls.Add(this.Lbl_ReceiptWt);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.lbl_Itemid);
            this.groupBox1.Location = new System.Drawing.Point(6, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "Unit Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 108;
            this.label9.Text = "Expire date";
            // 
            // grbDTPicker1
            // 
            this.grbDTPicker1.AcceptBlankValue = false;
            this.grbDTPicker1.BindingProperty = "Value";
            this.grbDTPicker1.DataField = "ExperDate";
            this.grbDTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.grbDTPicker1.Location = new System.Drawing.Point(354, 39);
            this.grbDTPicker1.Name = "grbDTPicker1";
            this.grbDTPicker1.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbDTPicker1.Size = new System.Drawing.Size(104, 20);
            this.grbDTPicker1.TabIndex = 2;
            // 
            // Txtgenfrom
            // 
            this.Txtgenfrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtgenfrom.DataField = "Genfrom";
            this.Txtgenfrom.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.Txtgenfrom.Location = new System.Drawing.Point(813, 9);
            this.Txtgenfrom.Name = "Txtgenfrom";
            this.Txtgenfrom.NormalBorderColor = System.Drawing.Color.Gray;
            this.Txtgenfrom.Size = new System.Drawing.Size(10, 20);
            this.Txtgenfrom.TabIndex = 107;
            this.Txtgenfrom.Text = "0";
            this.Txtgenfrom.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(769, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Purchase Cost";
            // 
            // grbTextBox2
            // 
            this.grbTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grbTextBox2.DataField = "PurchaseCost";
            this.grbTextBox2.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.grbTextBox2.Location = new System.Drawing.Point(772, 40);
            this.grbTextBox2.Name = "grbTextBox2";
            this.grbTextBox2.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbTextBox2.Size = new System.Drawing.Size(94, 20);
            this.grbTextBox2.TabIndex = 6;
            this.grbTextBox2.Text = "0";
            this.grbTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 104;
            this.label4.Text = "Mrp";
            // 
            // grbTextBox1
            // 
            this.grbTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grbTextBox1.DataField = "MRP";
            this.grbTextBox1.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.grbTextBox1.Location = new System.Drawing.Point(685, 40);
            this.grbTextBox1.Name = "grbTextBox1";
            this.grbTextBox1.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbTextBox1.Size = new System.Drawing.Size(82, 20);
            this.grbTextBox1.TabIndex = 5;
            this.grbTextBox1.Text = "0";
            this.grbTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 102;
            this.label3.Text = "Batch No";
            // 
            // txtfloorid
            // 
            this.txtfloorid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfloorid.DataField = "UnitId";
            this.txtfloorid.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.txtfloorid.Location = new System.Drawing.Point(587, 20);
            this.txtfloorid.Name = "txtfloorid";
            this.txtfloorid.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtfloorid.Size = new System.Drawing.Size(10, 20);
            this.txtfloorid.TabIndex = 101;
            this.txtfloorid.Text = "0";
            this.txtfloorid.Visible = false;
            // 
            // cmbFloorname
            // 
            this.cmbFloorname.Alias = "Floor Name";
            this.cmbFloorname.BindToDataGridview = true;
            this.cmbFloorname.DataField = "Unit Name";
            this.cmbFloorname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFloorname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFloorname.FormattingEnabled = true;
            this.cmbFloorname.Location = new System.Drawing.Point(464, 39);
            this.cmbFloorname.Name = "cmbFloorname";
            this.cmbFloorname.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmbFloorname.ShowComplusoryMark = false;
            this.cmbFloorname.Size = new System.Drawing.Size(133, 21);
            this.cmbFloorname.TabIndex = 3;
            this.cmbFloorname.TableName = "";
            // 
            // txtProdCode
            // 
            this.txtProdCode.BindToDataGridview = true;
            this.txtProdCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdCode.DataField = "BatchNo";
            this.txtProdCode.Location = new System.Drawing.Point(227, 40);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtProdCode.Size = new System.Drawing.Size(121, 20);
            this.txtProdCode.TabIndex = 1;
            this.txtProdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProdCodeId
            // 
            this.txtProdCodeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdCodeId.Location = new System.Drawing.Point(191, 9);
            this.txtProdCodeId.Name = "txtProdCodeId";
            this.txtProdCodeId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtProdCodeId.Size = new System.Drawing.Size(17, 20);
            this.txtProdCodeId.TabIndex = 87;
            this.txtProdCodeId.Visible = false;
            // 
            // txtitemid
            // 
            this.txtitemid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtitemid.DataField = "ItemID";
            this.txtitemid.Location = new System.Drawing.Point(157, 17);
            this.txtitemid.Name = "txtitemid";
            this.txtitemid.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtitemid.Size = new System.Drawing.Size(28, 20);
            this.txtitemid.TabIndex = 64;
            this.txtitemid.Visible = false;
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btn_add.FlatAppearance.BorderSize = 2;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(873, 38);
            this.btn_add.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btn_add.MouseDownImage")));
            this.btn_add.Name = "btn_add";
            this.btn_add.NormalImage = ((System.Drawing.Image)(resources.GetObject("btn_add.NormalImage")));
            this.btn_add.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btn_add.OnFocusImage")));
            this.btn_add.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btn_add.SelectedImage")));
            this.btn_add.Size = new System.Drawing.Size(36, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Cmb_ItemName
            // 
            this.Cmb_ItemName.AcceptBlankValue = false;
            this.Cmb_ItemName.BindToDataGridview = true;
            this.Cmb_ItemName.DataField = "Item Name";
            this.Cmb_ItemName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_ItemName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmb_ItemName.FormattingEnabled = true;
            this.Cmb_ItemName.Location = new System.Drawing.Point(7, 40);
            this.Cmb_ItemName.Name = "Cmb_ItemName";
            this.Cmb_ItemName.NormalBorderColor = System.Drawing.Color.Gray;
            this.Cmb_ItemName.ShowComplusoryMark = false;
            this.Cmb_ItemName.Size = new System.Drawing.Size(217, 21);
            this.Cmb_ItemName.TabIndex = 0;
            this.Cmb_ItemName.TableName = "";
            this.Cmb_ItemName.SelectedValueChanged += new System.EventHandler(this.Cmb_ItemName_SelectedValueChanged);
            // 
            // TxtNos
            // 
            this.TxtNos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNos.DataField = "Qty";
            this.TxtNos.InputMask = Gramboo.Controls.GrbTextBox.Mask.Decimal;
            this.TxtNos.Location = new System.Drawing.Point(603, 40);
            this.TxtNos.Name = "TxtNos";
            this.TxtNos.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtNos.Size = new System.Drawing.Size(76, 20);
            this.TxtNos.TabIndex = 4;
            this.TxtNos.Text = "0";
            this.TxtNos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Lbl_ReceiptWt
            // 
            this.Lbl_ReceiptWt.AutoSize = true;
            this.Lbl_ReceiptWt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReceiptWt.Location = new System.Drawing.Point(626, 21);
            this.Lbl_ReceiptWt.Name = "Lbl_ReceiptWt";
            this.Lbl_ReceiptWt.Size = new System.Drawing.Size(28, 16);
            this.Lbl_ReceiptWt.TabIndex = 62;
            this.Lbl_ReceiptWt.Text = "Qty";
            // 
            // dgv
            // 
            this.dgv.AllowEmptyRows = false;
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
            this.dgv.Location = new System.Drawing.Point(6, 66);
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
            this.dgv.ShowDelete = true;
            this.dgv.ShowEdit = true;
            this.dgv.ShowMoveDown = false;
            this.dgv.ShowMoveUp = false;
            this.dgv.ShowSelectCheckBox = false;
            this.dgv.ShowSerialNo = true;
            this.dgv.Size = new System.Drawing.Size(1019, 309);
            this.dgv.SummaryColumns = null;
            this.dgv.SummaryRowBackColor = System.Drawing.Color.Empty;
            this.dgv.SummaryRowSpace = 0;
            this.dgv.SummaryRowVisible = true;
            this.dgv.SumRowHeaderText = "Total";
            this.dgv.SumRowHeaderTextBold = false;
            this.dgv.TabIndex = 8;
            this.dgv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_KeyPress);
            // 
            // lbl_Itemid
            // 
            this.lbl_Itemid.AutoSize = true;
            this.lbl_Itemid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Itemid.Location = new System.Drawing.Point(9, 22);
            this.lbl_Itemid.Name = "lbl_Itemid";
            this.lbl_Itemid.Size = new System.Drawing.Size(73, 16);
            this.lbl_Itemid.TabIndex = 59;
            this.lbl_Itemid.Text = "Item Name";
            // 
            // lbl_EntryNo
            // 
            this.lbl_EntryNo.AutoSize = true;
            this.lbl_EntryNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EntryNo.Location = new System.Drawing.Point(912, 19);
            this.lbl_EntryNo.Name = "lbl_EntryNo";
            this.lbl_EntryNo.Size = new System.Drawing.Size(62, 16);
            this.lbl_EntryNo.TabIndex = 100;
            this.lbl_EntryNo.Text = " Entry No";
            this.lbl_EntryNo.Visible = false;
            // 
            // txtEntryNo
            // 
            this.txtEntryNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntryNo.DataField = "EntryId";
            this.txtEntryNo.IsIDField = true;
            this.txtEntryNo.Location = new System.Drawing.Point(980, 17);
            this.txtEntryNo.Name = "txtEntryNo";
            this.txtEntryNo.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtEntryNo.Size = new System.Drawing.Size(29, 20);
            this.txtEntryNo.TabIndex = 101;
            this.txtEntryNo.Visible = false;
            // 
            // TxtTranscId
            // 
            this.TxtTranscId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTranscId.DataField = "TransId";
            this.TxtTranscId.IsIDField = true;
            this.TxtTranscId.Location = new System.Drawing.Point(854, 17);
            this.TxtTranscId.Name = "TxtTranscId";
            this.TxtTranscId.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtTranscId.Size = new System.Drawing.Size(56, 20);
            this.TxtTranscId.TabIndex = 102;
            this.TxtTranscId.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(916, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 103;
            this.label6.Text = "Is Active";
            this.label6.Visible = false;
            // 
            // TxtIsactive
            // 
            this.TxtIsactive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtIsactive.DataField = "IsActive";
            this.TxtIsactive.Location = new System.Drawing.Point(980, 38);
            this.TxtIsactive.Name = "TxtIsactive";
            this.TxtIsactive.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtIsactive.Size = new System.Drawing.Size(29, 20);
            this.TxtIsactive.TabIndex = 104;
            this.TxtIsactive.Visible = false;
            // 
            // cmb_VoucherTypeId
            // 
            this.cmb_VoucherTypeId.BindingProperty = "SelectedValue";
            this.cmb_VoucherTypeId.DataField = "VoucherTypeId";
            this.cmb_VoucherTypeId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_VoucherTypeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_VoucherTypeId.FormattingEnabled = true;
            this.cmb_VoucherTypeId.Location = new System.Drawing.Point(854, 39);
            this.cmb_VoucherTypeId.Name = "cmb_VoucherTypeId";
            this.cmb_VoucherTypeId.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmb_VoucherTypeId.Size = new System.Drawing.Size(56, 21);
            this.cmb_VoucherTypeId.TabIndex = 106;
            this.cmb_VoucherTypeId.TableName = "";
            this.cmb_VoucherTypeId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(744, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 105;
            this.label8.Text = "Transaction Id";
            this.label8.Visible = false;
            // 
            // Lbl_vouctypeId
            // 
            this.Lbl_vouctypeId.AutoSize = true;
            this.Lbl_vouctypeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vouctypeId.Location = new System.Drawing.Point(744, 39);
            this.Lbl_vouctypeId.Name = "Lbl_vouctypeId";
            this.Lbl_vouctypeId.Size = new System.Drawing.Size(103, 16);
            this.Lbl_vouctypeId.TabIndex = 107;
            this.Lbl_vouctypeId.Text = "VoucherTypeID";
            this.Lbl_vouctypeId.Visible = false;
            // 
            // DepartmentOpeningStkEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1042, 523);
            this.Controls.Add(this.lbl_EntryNo);
            this.Controls.Add(this.txtEntryNo);
            this.Controls.Add(this.TxtTranscId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIsactive);
            this.Controls.Add(this.cmb_VoucherTypeId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Lbl_vouctypeId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DepartmentOpeningStkEntry";
            this.Text = "Opening Stock Entry";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Lbl_vouctypeId, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmb_VoucherTypeId, 0);
            this.Controls.SetChildIndex(this.TxtIsactive, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtTranscId, 0);
            this.Controls.SetChildIndex(this.txtEntryNo, 0);
            this.Controls.SetChildIndex(this.lbl_EntryNo, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.rbggender.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbComboBox Cmb_DepartmentName;
        private System.Windows.Forms.Label label7;
        private Gramboo.Controls.GrbDTPicker Dtp_dt;
        private Gramboo.Controls.GrbTextBox TxtVoucherNo;
        private System.Windows.Forms.Label Lbl_voucherNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbTextBox txtProdCodeId;
        private Gramboo.Controls.GrbTextBox txtitemid;
        private Gramboo.Controls.GrbButton btn_add;
        private Gramboo.Controls.GrbTextBox TxtNos;
        private System.Windows.Forms.Label Lbl_ReceiptWt;
        private System.Windows.Forms.Label lbl_Itemid;
        private Gramboo.Controls.GrbDataGridView dgv;
        private System.Windows.Forms.Label lbl_EntryNo;
        private Gramboo.Controls.GrbTextBox txtEntryNo;
        private Gramboo.Controls.GrbTextBox TxtTranscId;
        private System.Windows.Forms.Label label6;
        private Gramboo.Controls.GrbTextBox TxtIsactive;
        private Gramboo.Controls.GrbComboBox cmb_VoucherTypeId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl_vouctypeId;
        private Gramboo.Controls.GrbTextBox txtProdCode;
        private Gramboo.Controls.GrbComboBox Cmb_ItemName;
        private System.Windows.Forms.Label label11;
        private Gramboo.Controls.GrbTextBox txtCash;
        private Gramboo.Controls.GrbTextBox txtfloorid;
        private Gramboo.Controls.GrbComboBox cmbFloorname;
        private System.Windows.Forms.Label label4;
        private Gramboo.Controls.GrbTextBox grbTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Gramboo.Controls.GrbTextBox grbTextBox2;
        private Gramboo.Controls.GrbTextBox Txtgenfrom;
        private System.Windows.Forms.Label label9;
        private Gramboo.Controls.GrbDTPicker grbDTPicker1;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbRadioButtonGroup rbggender;
        private Gramboo.Controls.GrbRadioButton rbtService;
        private Gramboo.Controls.GrbRadioButton rbtSale;
    }
}
