namespace project.Forms.SYST
{
    partial class ChangePassword
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
            this.TxtOldPass = new Gramboo.Controls.GrbTextBox();
            this.TxtconfirmPassword = new Gramboo.Controls.GrbTextBox();
            this.TxtNewPassword = new Gramboo.Controls.GrbTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_GroupName = new System.Windows.Forms.Label();
            this.TxtUserID = new Gramboo.Controls.GrbTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(807, 309);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(830, 307);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(844, 309);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(844, 283);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(807, 283);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(830, 283);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(830, 335);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(833, 335);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtOldPass);
            this.groupBox1.Controls.Add(this.TxtconfirmPassword);
            this.groupBox1.Controls.Add(this.TxtNewPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(309, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 123);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // TxtOldPass
            // 
            this.TxtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtOldPass.Location = new System.Drawing.Point(157, 18);
            this.TxtOldPass.Name = "TxtOldPass";
            this.TxtOldPass.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtOldPass.Size = new System.Drawing.Size(237, 20);
            this.TxtOldPass.TabIndex = 24;
            // 
            // TxtconfirmPassword
            // 
            this.TxtconfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtconfirmPassword.Location = new System.Drawing.Point(157, 90);
            this.TxtconfirmPassword.Name = "TxtconfirmPassword";
            this.TxtconfirmPassword.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtconfirmPassword.Size = new System.Drawing.Size(237, 20);
            this.TxtconfirmPassword.TabIndex = 23;
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewPassword.DataField = "user_password";
            this.TxtNewPassword.Location = new System.Drawing.Point(157, 54);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtNewPassword.Size = new System.Drawing.Size(237, 20);
            this.TxtNewPassword.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Old Password";
            // 
            // Lbl_GroupName
            // 
            this.Lbl_GroupName.AutoSize = true;
            this.Lbl_GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GroupName.Location = new System.Drawing.Point(261, 41);
            this.Lbl_GroupName.Name = "Lbl_GroupName";
            this.Lbl_GroupName.Size = new System.Drawing.Size(53, 16);
            this.Lbl_GroupName.TabIndex = 140;
            this.Lbl_GroupName.Text = "User ID";
            this.Lbl_GroupName.Visible = false;
            // 
            // TxtUserID
            // 
            this.TxtUserID.AcceptBlankValue = false;
            this.TxtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUserID.DataField = "user_id";
            this.TxtUserID.IsIDField = true;
            this.TxtUserID.Location = new System.Drawing.Point(407, 37);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.NormalBorderColor = System.Drawing.Color.Gray;
            this.TxtUserID.ReadOnly = true;
            this.TxtUserID.Size = new System.Drawing.Size(195, 20);
            this.TxtUserID.TabIndex = 139;
            this.TxtUserID.TabStop = false;
            this.TxtUserID.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.Lbl_GroupName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtUserID);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.TxtUserID, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Lbl_GroupName, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Gramboo.Controls.GrbTextBox TxtOldPass;
        private Gramboo.Controls.GrbTextBox TxtconfirmPassword;
        private Gramboo.Controls.GrbTextBox TxtNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_GroupName;
        private Gramboo.Controls.GrbTextBox TxtUserID;
    }
}
