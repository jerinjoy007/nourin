namespace project.Forms.GENERALFORMS
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.btnBackp = new Gramboo.Controls.GrbButton();
            this.grpTransfer = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Gramboo.Controls.GrbButton();
            this.btnTransfer = new Gramboo.Controls.GrbButton();
            this.DtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(743, 314);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(766, 312);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(780, 314);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(780, 288);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(743, 288);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(766, 288);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(766, 340);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(769, 340);
            // 
            // btnBackp
            // 
            this.btnBackp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackp.BackgroundImage")));
            this.btnBackp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btnBackp.FlatAppearance.BorderSize = 2;
            this.btnBackp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackp.Location = new System.Drawing.Point(80, 39);
            this.btnBackp.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnBackp.MouseDownImage")));
            this.btnBackp.Name = "btnBackp";
            this.btnBackp.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnBackp.NormalImage")));
            this.btnBackp.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btnBackp.OnFocusImage")));
            this.btnBackp.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btnBackp.SelectedImage")));
            this.btnBackp.Size = new System.Drawing.Size(296, 52);
            this.btnBackp.TabIndex = 0;
            this.btnBackp.Text = "Back Up Database";
            this.btnBackp.UseVisualStyleBackColor = true;
            this.btnBackp.Click += new System.EventHandler(this.btnBackp_Click);
            // 
            // grpTransfer
            // 
            this.grpTransfer.Controls.Add(this.btnDelete);
            this.grpTransfer.Controls.Add(this.btnTransfer);
            this.grpTransfer.Controls.Add(this.DtpTo);
            this.grpTransfer.Controls.Add(this.dtpFrom);
            this.grpTransfer.Controls.Add(this.label2);
            this.grpTransfer.Controls.Add(this.label1);
            this.grpTransfer.Location = new System.Drawing.Point(70, 125);
            this.grpTransfer.Name = "grpTransfer";
            this.grpTransfer.Size = new System.Drawing.Size(318, 169);
            this.grpTransfer.TabIndex = 1;
            this.grpTransfer.TabStop = false;
            this.grpTransfer.Text = "Transfer Data";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(16, 104);
            this.btnDelete.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.MouseDownImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.NormalImage")));
            this.btnDelete.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.OnFocusImage")));
            this.btnDelete.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.SelectedImage")));
            this.btnDelete.Size = new System.Drawing.Size(296, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.BackgroundImage")));
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.btnTransfer.FlatAppearance.BorderSize = 2;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Location = new System.Drawing.Point(16, 46);
            this.btnTransfer.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.MouseDownImage")));
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.NormalImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.NormalImage")));
            this.btnTransfer.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.OnFocusImage")));
            this.btnTransfer.SelectedImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.SelectedImage")));
            this.btnTransfer.Size = new System.Drawing.Size(296, 52);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "Transfer Data";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // DtpTo
            // 
            this.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpTo.Location = new System.Drawing.Point(190, 19);
            this.DtpTo.Name = "DtpTo";
            this.DtpTo.Size = new System.Drawing.Size(100, 20);
            this.DtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(55, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 327);
            this.Controls.Add(this.grpTransfer);
            this.Controls.Add(this.btnBackp);
            this.Name = "frmTransfer";
            this.Text = "Backup Data";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.Controls.SetChildIndex(this.btnBackp, 0);
            this.Controls.SetChildIndex(this.grpTransfer, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.grpTransfer.ResumeLayout(false);
            this.grpTransfer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gramboo.Controls.GrbButton btnBackp;
        private System.Windows.Forms.GroupBox grpTransfer;
        private Gramboo.Controls.GrbButton btnTransfer;
        private System.Windows.Forms.DateTimePicker DtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Gramboo.Controls.GrbButton btnDelete;
    }
}