namespace SALON.Forms.SYST
{
    partial class FrmGreetings
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtEntryId = new Gramboo.Controls.GrbTextBox();
            this.txtFooter = new Gramboo.Controls.GrbTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkISActive = new Gramboo.Controls.GrbCheckBox();
            this.txtGreetings = new Gramboo.Controls.GrbTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(818, 303);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(841, 301);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(855, 303);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(855, 277);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(818, 277);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(841, 277);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(841, 329);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(844, 329);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEntryId);
            this.groupBox2.Controls.Add(this.txtFooter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkISActive);
            this.groupBox2.Controls.Add(this.txtGreetings);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 126);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // TxtEntryId
            // 
            this.TxtEntryId.AcceptBlankValue = false;
            this.TxtEntryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEntryId.DataField = "EntryId";
            this.TxtEntryId.IsIDField = true;
            this.TxtEntryId.Location = new System.Drawing.Point(463, 82);
            this.TxtEntryId.Name = "TxtEntryId";
            this.TxtEntryId.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtEntryId.Size = new System.Drawing.Size(44, 20);
            this.TxtEntryId.TabIndex = 41;
            this.TxtEntryId.Visible = false;
            // 
            // txtFooter
            // 
            this.txtFooter.AcceptBlankValue = false;
            this.txtFooter.Alias = "none";
            this.txtFooter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFooter.CheckDuplicates = true;
            this.txtFooter.DataField = "SalesBillFooterNote";
            this.txtFooter.Location = new System.Drawing.Point(169, 50);
            this.txtFooter.Multiline = true;
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtFooter.Size = new System.Drawing.Size(359, 26);
            this.txtFooter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Footer Note";
            // 
            // chkISActive
            // 
            this.chkISActive.AcceptBlankValue = false;
            this.chkISActive.AutoSize = true;
            this.chkISActive.BindingProperty = "Checked";
            this.chkISActive.DataField = "IsActive";
            this.chkISActive.FalseValue = "0";
            this.chkISActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkISActive.Location = new System.Drawing.Point(169, 82);
            this.chkISActive.Name = "chkISActive";
            this.chkISActive.Size = new System.Drawing.Size(77, 20);
            this.chkISActive.TabIndex = 31;
            this.chkISActive.TableName = null;
            this.chkISActive.Text = "Is Active";
            this.chkISActive.TrueValue = "True";
            this.chkISActive.UseVisualStyleBackColor = true;
            this.chkISActive.Value = "1";
            this.chkISActive.Visible = false;
            // 
            // txtGreetings
            // 
            this.txtGreetings.AcceptBlankValue = false;
            this.txtGreetings.Alias = "none";
            this.txtGreetings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreetings.CheckDuplicates = true;
            this.txtGreetings.DataField = "SalesBillGreetingsMsg";
            this.txtGreetings.Location = new System.Drawing.Point(169, 18);
            this.txtGreetings.Multiline = true;
            this.txtGreetings.Name = "txtGreetings";
            this.txtGreetings.NormalBorderColor = System.Drawing.Color.Gray;
            this.txtGreetings.Size = new System.Drawing.Size(359, 26);
            this.txtGreetings.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Greetings Message";
            // 
            // FrmGreetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 545);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmGreetings";
            this.Text = "Greetings";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Gramboo.Controls.GrbTextBox txtFooter;
        private System.Windows.Forms.Label label2;
        private Gramboo.Controls.GrbCheckBox chkISActive;
        private Gramboo.Controls.GrbTextBox txtGreetings;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbTextBox TxtEntryId;
    }
}