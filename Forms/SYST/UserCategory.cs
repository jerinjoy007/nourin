using Gramboo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.SYST
{
    public partial class UserCategory : Gramboo.Controls.GrbForm
    {
        private static UserCategory instance;

        public static UserCategory Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new UserCategory();
                }
                else if (instance.IsDisposed)
                {
                    instance = new UserCategory();
                }
                return instance;
            }
        }
        public UserCategory()
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
        public override void Init()
        {
            base.Init();
            TxtUserCategoryName.Focus();
            Chk_IsActive.Checked = true;
            AdjustColumnsWidth();
            PopulateGrid();
        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "UserCategory");
            t.PrimaryKeys.Add("user_category_id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtUserCategoryID;
            this.TableName = t;
            return true;
        }
        public override void RefreshData()
        {
             PopulateGrid();
           
         }
        public void AdjustColumnsWidth()
        {

            dgv.Columns["User Category Name"].Width = 200;
            dgv.Columns["Created By"].Width = 100;
            dgv.Columns["Created Date"].Width = 125;
            dgv.Columns["Last Modified By"].Width = 125;
            dgv.Columns["Last Modified Date"].Width = 140;
            dgv.Columns["Is Active"].Width = 75;
        }
     
        private void PopulateGrid()
        {
            dgv.EntryFormName = this;
            dgv.ShowEdit = true;
            dgv.IsList = true; 
            dgv.AutoGenerateColumns = true;
            dgv.DataFields = new List<string>() { "user_category_id", "[User Category Name]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]" };
            dgv.HiddenDataFields = new List<string>() { "user_category_id", "Created_by", "user_password", "Last_modified_by", "Counter_id", "Company_id", "Branch_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VUserCategory", true));

       }
        //public override bool Delete()
        //{
        //    int set;
        //    bool flag = true;
        //    for (int i = 0; i < dgv.Rows.Count; i++)
        //    {
        //        DataGridViewRow dr = dgv.Rows[i];
        //        if (dr.Selected == true)
        //        {
        //            set = Convert.ToInt32(DBConn.GetData(new SqlCommand("Select SYST.UserCategory_Validation('" + dr.Cells["user_category_id"].Value + "')")).Tables[0].Rows[0][0]);//,'" + txtcompId.Text + "','" + txtBranchID.Text + "
        //            {
        //                if (set == 1)
        //                {
        //                    flag = false;
        //                    TxtUserCategoryName.ShowMessage("UserCategoryName Selected Cannot be Deleted");
        //                    return flag;
        //                }
        //                else
        //                {
        //                    return base.Delete();
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}
       
    }
}
