
namespace project.Forms.ADD
{
    partial class PaymentandMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentandMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbTextName = new Gramboo.Controls.GrbTextBox();
            this.grbTextPhone = new Gramboo.Controls.GrbTextBox();
            this.grbTextEmail = new Gramboo.Controls.GrbTextBox();
            this.grbButton1 = new Gramboo.Controls.GrbButton();
            this.grbButton2 = new Gramboo.Controls.GrbButton();
            this.grbButton3 = new Gramboo.Controls.GrbButton();
            this.grbButton4 = new Gramboo.Controls.GrbButton();
            this.richTextMessbody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_amount = new Gramboo.Controls.GrbTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.Location = new System.Drawing.Point(807, 307);
            this.txtModifiedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcreatedDate
            // 
            this.txtcreatedDate.Location = new System.Drawing.Point(830, 305);
            this.txtcreatedDate.Size = new System.Drawing.Size(10, 22);
            // 
            // txtcompId
            // 
            this.txtcompId.Location = new System.Drawing.Point(844, 307);
            this.txtcompId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtModuserID
            // 
            this.txtModuserID.Location = new System.Drawing.Point(844, 283);
            this.txtModuserID.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCrUserId
            // 
            this.txtCrUserId.Location = new System.Drawing.Point(807, 283);
            this.txtCrUserId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(830, 283);
            this.txtUserName.Size = new System.Drawing.Size(10, 22);
            // 
            // txtCounterId
            // 
            this.txtCounterId.Location = new System.Drawing.Point(830, 332);
            this.txtCounterId.Size = new System.Drawing.Size(10, 22);
            // 
            // txtBranchID
            // 
            this.txtBranchID.Location = new System.Drawing.Point(833, 332);
            this.txtBranchID.Size = new System.Drawing.Size(10, 22);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Reference_id";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grbTextName
            // 
            this.grbTextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grbTextName.Location = new System.Drawing.Point(141, 22);
            this.grbTextName.Name = "grbTextName";
            this.grbTextName.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbTextName.Size = new System.Drawing.Size(177, 22);
            this.grbTextName.TabIndex = 21;
            this.grbTextName.Text = " ";
            // 
            // grbTextPhone
            // 
            this.grbTextPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grbTextPhone.Location = new System.Drawing.Point(141, 64);
            this.grbTextPhone.Name = "grbTextPhone";
            this.grbTextPhone.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbTextPhone.Size = new System.Drawing.Size(177, 22);
            this.grbTextPhone.TabIndex = 22;
            this.grbTextPhone.Text = " ";
            // 
            // grbTextEmail
            // 
            this.grbTextEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grbTextEmail.Location = new System.Drawing.Point(141, 106);
            this.grbTextEmail.Name = "grbTextEmail";
            this.grbTextEmail.NormalBorderColor = System.Drawing.Color.Gray;
            this.grbTextEmail.Size = new System.Drawing.Size(177, 22);
            this.grbTextEmail.TabIndex = 23;
            this.grbTextEmail.Text = " ";
            this.grbTextEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbButton1
            // 
            this.grbButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.BackgroundImage")));
            this.grbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.grbButton1.FlatAppearance.BorderSize = 2;
            this.grbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbButton1.Location = new System.Drawing.Point(144, 362);
            this.grbButton1.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.MouseDownImage")));
            this.grbButton1.Name = "grbButton1";
            this.grbButton1.NormalImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.NormalImage")));
            this.grbButton1.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.OnFocusImage")));
            this.grbButton1.SelectedImage = ((System.Drawing.Image)(resources.GetObject("grbButton1.SelectedImage")));
            this.grbButton1.Size = new System.Drawing.Size(87, 34);
            this.grbButton1.TabIndex = 24;
            this.grbButton1.Text = "Call";
            this.grbButton1.UseVisualStyleBackColor = true;
            this.grbButton1.Click += new System.EventHandler(this.grbButton1_Click);
            // 
            // grbButton2
            // 
            this.grbButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbButton2.BackgroundImage")));
            this.grbButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.grbButton2.FlatAppearance.BorderSize = 2;
            this.grbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbButton2.Location = new System.Drawing.Point(237, 362);
            this.grbButton2.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("grbButton2.MouseDownImage")));
            this.grbButton2.Name = "grbButton2";
            this.grbButton2.NormalImage = ((System.Drawing.Image)(resources.GetObject("grbButton2.NormalImage")));
            this.grbButton2.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("grbButton2.OnFocusImage")));
            this.grbButton2.SelectedImage = ((System.Drawing.Image)(resources.GetObject("grbButton2.SelectedImage")));
            this.grbButton2.Size = new System.Drawing.Size(95, 34);
            this.grbButton2.TabIndex = 25;
            this.grbButton2.Text = "Payment link";
            this.grbButton2.UseVisualStyleBackColor = true;
            this.grbButton2.Click += new System.EventHandler(this.grbButton2_Click);
            // 
            // grbButton3
            // 
            this.grbButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbButton3.BackgroundImage")));
            this.grbButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.grbButton3.FlatAppearance.BorderSize = 2;
            this.grbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbButton3.Location = new System.Drawing.Point(338, 362);
            this.grbButton3.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("grbButton3.MouseDownImage")));
            this.grbButton3.Name = "grbButton3";
            this.grbButton3.NormalImage = ((System.Drawing.Image)(resources.GetObject("grbButton3.NormalImage")));
            this.grbButton3.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("grbButton3.OnFocusImage")));
            this.grbButton3.SelectedImage = ((System.Drawing.Image)(resources.GetObject("grbButton3.SelectedImage")));
            this.grbButton3.Size = new System.Drawing.Size(87, 34);
            this.grbButton3.TabIndex = 26;
            this.grbButton3.Text = "Message";
            this.grbButton3.UseVisualStyleBackColor = true;
            this.grbButton3.Click += new System.EventHandler(this.grbButton3_Click);
            // 
            // grbButton4
            // 
            this.grbButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbButton4.BackgroundImage")));
            this.grbButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(229)))));
            this.grbButton4.FlatAppearance.BorderSize = 2;
            this.grbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbButton4.Location = new System.Drawing.Point(431, 363);
            this.grbButton4.MouseDownImage = ((System.Drawing.Image)(resources.GetObject("grbButton4.MouseDownImage")));
            this.grbButton4.Name = "grbButton4";
            this.grbButton4.NormalImage = ((System.Drawing.Image)(resources.GetObject("grbButton4.NormalImage")));
            this.grbButton4.OnFocusImage = ((System.Drawing.Image)(resources.GetObject("grbButton4.OnFocusImage")));
            this.grbButton4.SelectedImage = ((System.Drawing.Image)(resources.GetObject("grbButton4.SelectedImage")));
            this.grbButton4.Size = new System.Drawing.Size(95, 34);
            this.grbButton4.TabIndex = 27;
            this.grbButton4.Text = "Whatsapp";
            this.grbButton4.UseVisualStyleBackColor = true;
            this.grbButton4.Click += new System.EventHandler(this.grbButton4_Click);
            // 
            // richTextMessbody
            // 
            this.richTextMessbody.Location = new System.Drawing.Point(141, 201);
            this.richTextMessbody.Name = "richTextMessbody";
            this.richTextMessbody.Size = new System.Drawing.Size(327, 138);
            this.richTextMessbody.TabIndex = 28;
            this.richTextMessbody.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Message to send";
            // 
            // txt_amount
            // 
            this.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_amount.Location = new System.Drawing.Point(144, 156);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.NormalBorderColor = System.Drawing.Color.Gray;
            this.txt_amount.Size = new System.Drawing.Size(174, 22);
            this.txt_amount.TabIndex = 30;
            this.txt_amount.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Pay_amount";
            // 
            // PaymentandMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextMessbody);
            this.Controls.Add(this.grbButton4);
            this.Controls.Add(this.grbButton3);
            this.Controls.Add(this.grbButton2);
            this.Controls.Add(this.grbButton1);
            this.Controls.Add(this.grbTextEmail);
            this.Controls.Add(this.grbTextPhone);
            this.Controls.Add(this.grbTextName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentandMessage";
            this.Text = "PaymentandMessage";
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtCrUserId, 0);
            this.Controls.SetChildIndex(this.txtModuserID, 0);
            this.Controls.SetChildIndex(this.txtcompId, 0);
            this.Controls.SetChildIndex(this.txtcreatedDate, 0);
            this.Controls.SetChildIndex(this.txtModifiedDate, 0);
            this.Controls.SetChildIndex(this.txtBranchID, 0);
            this.Controls.SetChildIndex(this.txtCounterId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.grbTextName, 0);
            this.Controls.SetChildIndex(this.grbTextPhone, 0);
            this.Controls.SetChildIndex(this.grbTextEmail, 0);
            this.Controls.SetChildIndex(this.grbButton1, 0);
            this.Controls.SetChildIndex(this.grbButton2, 0);
            this.Controls.SetChildIndex(this.grbButton3, 0);
            this.Controls.SetChildIndex(this.grbButton4, 0);
            this.Controls.SetChildIndex(this.richTextMessbody, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_amount, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Gramboo.Controls.GrbTextBox grbTextName;
        private Gramboo.Controls.GrbTextBox grbTextPhone;
        private Gramboo.Controls.GrbTextBox grbTextEmail;
        private Gramboo.Controls.GrbButton grbButton1;
        private Gramboo.Controls.GrbButton grbButton2;
        private Gramboo.Controls.GrbButton grbButton3;
        private Gramboo.Controls.GrbButton grbButton4;
        private System.Windows.Forms.RichTextBox richTextMessbody;
        private System.Windows.Forms.Label label4;
        private Gramboo.Controls.GrbTextBox txt_amount;
        private System.Windows.Forms.Label label5;
    }
}