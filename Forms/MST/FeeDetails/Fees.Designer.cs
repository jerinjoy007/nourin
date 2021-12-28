
namespace project.Forms.MST.FeeDetails
{
    partial class Fees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbCheckBox1 = new Gramboo.Controls.GrbCheckBox();
            this.cmbAmount = new Gramboo.Controls.GrbComboBox();
            this.txtFeeAmount = new Gramboo.Controls.GrbTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFeeName = new Gramboo.Controls.GrbTextBox();
            this.txtFeeCode = new Gramboo.Controls.GrbTextBox();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtfeeId = new Gramboo.Controls.GrbTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFeeType = new Gramboo.Controls.GrbComboBox();
            this.cmbFeeGroup = new Gramboo.Controls.GrbComboBox();
            this.grbComboBox1 = new Gramboo.Controls.GrbComboBox();
            this.Cmbcashamt = new Gramboo.Controls.GrbComboBox();
            this.groupBox1.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cmbcashamt);
            this.groupBox1.Controls.Add(this.grbComboBox1);
            this.groupBox1.Controls.Add(this.cmbFeeGroup);
            this.groupBox1.Controls.Add(this.cmbFeeType);
            this.groupBox1.Controls.Add(this.grbCheckBox1);
            this.groupBox1.Controls.Add(this.cmbAmount);
            this.groupBox1.Controls.Add(this.txtFeeAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFeeName);
            this.groupBox1.Controls.Add(this.txtFeeCode);
            this.groupBox1.Controls.Add(this.chkISActive);
            this.groupBox1.Controls.Add(this.txtfeeId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 426);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // grbCheckBox1
            // 
            this.grbCheckBox1.AcceptBlankValue = false;
            this.grbCheckBox1.BindingProperty = "Value";
            this.grbCheckBox1.Checked = true;
            this.grbCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grbCheckBox1.DataField = "CommonFeeStat";
            this.grbCheckBox1.Location = new System.Drawing.Point(156, 340);
            this.grbCheckBox1.Name = "grbCheckBox1";
            this.grbCheckBox1.Size = new System.Drawing.Size(149, 24);
            this.grbCheckBox1.TabIndex = 98;
            this.grbCheckBox1.TableName = null;
            this.grbCheckBox1.Text = "Common Fee";
            this.grbCheckBox1.UseVisualStyleBackColor = true;
            // 
            // cmbAmount
            // 
            this.cmbAmount.DataField = "AccountCode";
            this.cmbAmount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Location = new System.Drawing.Point(156, 269);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmbAmount.Size = new System.Drawing.Size(220, 23);
            this.cmbAmount.TabIndex = 96;
            this.cmbAmount.TableName = "";
            // 
            // txtFeeAmount
            // 
            this.txtFeeAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeAmount.DataField = "FeeAmount";
            this.txtFeeAmount.Location = new System.Drawing.Point(156, 192);
            this.txtFeeAmount.Name = "txtFeeAmount";
            this.txtFeeAmount.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeAmount.Size = new System.Drawing.Size(219, 22);
            this.txtFeeAmount.TabIndex = 95;
            this.txtFeeAmount.Text = "grbTextBox3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 94;
            this.label7.Text = "Cash Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Amount";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 92;
            this.label4.Text = "Fee Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Fee Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Fee Group";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFeeName
            // 
            this.txtFeeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeName.DataField = "FeeName";
            this.txtFeeName.Location = new System.Drawing.Point(156, 63);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeName.Size = new System.Drawing.Size(219, 22);
            this.txtFeeName.TabIndex = 89;
            this.txtFeeName.Text = "grbTextBox2";
            // 
            // txtFeeCode
            // 
            this.txtFeeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFeeCode.DataField = "FeeCode";
            this.txtFeeCode.Location = new System.Drawing.Point(156, 22);
            this.txtFeeCode.Name = "txtFeeCode";
            this.txtFeeCode.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFeeCode.Size = new System.Drawing.Size(220, 22);
            this.txtFeeCode.TabIndex = 88;
            this.txtFeeCode.Text = "grbTextBox1";
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
            this.chkISActive.Location = new System.Drawing.Point(156, 376);
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
            // txtfeeId
            // 
            this.txtfeeId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfeeId.DataField = "Feeid";
            this.txtfeeId.IsIDField = true;
            this.txtfeeId.Location = new System.Drawing.Point(383, 22);
            this.txtfeeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtfeeId.Name = "txtfeeId";
            this.txtfeeId.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtfeeId.Size = new System.Drawing.Size(10, 22);
            this.txtfeeId.TabIndex = 86;
            this.txtfeeId.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fee Type ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fee Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.DataField = "Feetypeid";
            this.cmbFeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFeeType.FormattingEnabled = true;
            this.cmbFeeType.Location = new System.Drawing.Point(156, 108);
            this.cmbFeeType.Name = "cmbFeeType";
            this.cmbFeeType.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmbFeeType.Size = new System.Drawing.Size(220, 23);
            this.cmbFeeType.TabIndex = 19;
            this.cmbFeeType.TableName = "";
            // 
            // cmbFeeGroup
            // 
            this.cmbFeeGroup.DataField = "FeeGroupid";
            this.cmbFeeGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFeeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFeeGroup.FormattingEnabled = true;
            this.cmbFeeGroup.Location = new System.Drawing.Point(156, 150);
            this.cmbFeeGroup.Name = "cmbFeeGroup";
            this.cmbFeeGroup.NormalBorderColor = System.Drawing.Color.Gray;
            this.cmbFeeGroup.Size = new System.Drawing.Size(220, 23);
            this.cmbFeeGroup.TabIndex = 19;
            this.cmbFeeGroup.TableName = "";
            // 
            // grbComboBox1
            // 
            this.grbComboBox1.DataField = "FeeCatid";
            this.grbComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grbComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbComboBox1.FormattingEnabled = true;
            this.grbComboBox1.Location = new System.Drawing.Point(156, 230);
            this.grbComboBox1.Name = "grbComboBox1";
            this.grbComboBox1.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbComboBox1.Size = new System.Drawing.Size(219, 23);
            this.grbComboBox1.TabIndex = 19;
            this.grbComboBox1.TableName = "";
            // 
            // Cmbcashamt
            // 
            this.Cmbcashamt.DataField = "CashAccountCode";
            this.Cmbcashamt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmbcashamt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cmbcashamt.FormattingEnabled = true;
            this.Cmbcashamt.Location = new System.Drawing.Point(156, 314);
            this.Cmbcashamt.Name = "Cmbcashamt";
            this.Cmbcashamt.NormalBorderColor = System.Drawing.Color.Gray;
            this.Cmbcashamt.Size = new System.Drawing.Size(220, 23);
            this.Cmbcashamt.TabIndex = 99;
            this.Cmbcashamt.TableName = "";
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fees";
            this.Text = "Fees";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Gramboo.Controls.GrbTextBox txtFeeName;
        private Gramboo.Controls.GrbTextBox txtFeeCode;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtfeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbCheckBox grbCheckBox1;
        private Gramboo.Controls.GrbComboBox cmbAmount;
        private Gramboo.Controls.GrbTextBox txtFeeAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Gramboo.Controls.GrbComboBox Cmbcashamt;
        private Gramboo.Controls.GrbComboBox grbComboBox1;
        private Gramboo.Controls.GrbComboBox cmbFeeGroup;
        private Gramboo.Controls.GrbComboBox cmbFeeType;
    }
}