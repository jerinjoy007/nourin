using Gramboo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.SYST
{
    public partial class ChangePassword : Gramboo.Controls.GrbForm
    {
        private static ChangePassword instance;

        public static ChangePassword Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ChangePassword();
                }
                else if (instance.IsDisposed)
                {
                    instance = new ChangePassword();
                }
                return instance;
            }
        }
        public ChangePassword()
        {
            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "Username");
            t.PrimaryKeys.Add("user_id");
            t.IdTextBox = TxtUserID;
            this.TableName = t;
            return true;
        }
        public override bool ValidateControls()
        {
            bool flag = true;
           
            if (base.ValidateControls())
                {

                    if ((bool )DBConn.GetData(new System.Data.SqlClient.SqlCommand("select  SYST.CheckOldPassword(" + txtCrUserId.Text + ",'" + TxtOldPass.Text + "')")).Tables[0].Rows[0][0]== false)
                    {
                        flag = false;
                        TxtOldPass.ShowMessage("Invalid Password");
                        TxtOldPass.Focus();

                    }

                    else if (TxtNewPassword.Text != TxtconfirmPassword.Text)
                    {
                        flag = false;
                        TxtconfirmPassword.ShowMessage("Passwords Do Not Match");
                        TxtconfirmPassword.Focus();
                    }
                    return flag;
                }
                else
                {
                    return false;
                }
        }
       
      public override void Init()
        {
            base.Init();
            //TxtUser.Focus();
            TxtOldPass.Focus();
            TxtUserID.Text = txtCrUserId.Text;

        }
        public override bool Save()
        {
            return base.Save();

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

    }
}
