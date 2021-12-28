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
    public partial class UserRegistration : Gramboo.Controls.GrbForm
    {

        private static UserRegistration instance;

        public static UserRegistration Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new UserRegistration();
                }
                else if (instance.IsDisposed)
                {
                    instance = new UserRegistration();
                }
                return instance;
            }
        }
        public UserRegistration()
        {
            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };
        }
        public override bool GenerateID(Table table_name)
        {
            try
            {
                table_name.IdTextBox.Text = project.Classes.Common.GetNextID(table_name, table_name.IdTextBox.DataField, DBConn, Convert.ToInt32(base.txtcompId.Text), Convert.ToInt32(base.txtBranchID.Text)).ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public void AdjustColumnsWidth()
        {

            dgv.Columns["User Name"].Width = 200;
            dgv.Columns["User Category Name"].Width = 200;
            dgv.Columns["Created By"].Width = 100;
            dgv.Columns["Created Date"].Width = 125;
            dgv.Columns["Last Modified By"].Width = 125;
            dgv.Columns["Last Modified Date"].Width = 140;
            dgv.Columns["Is Active"].Width = 75;
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "Username");
            t.PrimaryKeys.Add("user_id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtUserID;
            this.TableName = t;
            return true;
        }

        //public override bool ValidateControls()
        //{
        //    bool flag=true  ;

        //    if (base.ValidateControls())
        //    {
        //        if (TxtPassword.Text != TxtConfirmPass.Text)
        //        {
        //            flag = false;
        //            TxtConfirmPass.ShowMessage("Passwords Do Not Match");
        //            TxtConfirmPass.Focus();
        //        }
        //        return flag;
        //    }
        //    else
        //    {
        //        return false; 
        //    }

        //}
        private void PopulateGrid()
        {
            dgv.EntryFormName = this;
            dgv.ShowEdit = true;
            dgv.IsList = true;
            dgv.AutoGenerateColumns = true;
            dgv.DataFields = new List<string>() { "user_id", "[User Name]", "user_category_id", "[User Category Name]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]" };
            dgv.HiddenDataFields = new List<string>() {"user_id", "user_category_id", "Created_by", "user_password", "Last_modified_by", "Counter_id", "Company_id", "Branch_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VUserName", true));



        }
        public override void Init()
        {
            base.Init();
            TxtUsrName.Focus();
            Chk_IsActive.Checked = true;
            AdjustColumnsWidth();
        }

        public override void RefreshData()
        {
            Gramboo.General.Setupcombo(cmb_MenuGroup, "SYST.MenuGroupMaster", "GroupName", "GroupId", "IsActive='True'");

            Gramboo.General.Setupcombo(Cmb_UserCategory, "SYST.UserCategory", "user_category_name", "user_category_id", "IsActive='True'");
            PopulateGrid();
           
            
        }
   
     
    }
}
