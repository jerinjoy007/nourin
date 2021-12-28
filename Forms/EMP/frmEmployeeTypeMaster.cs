using Gramboo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.EMP
{
    public partial class frmEmployeeTypeMaster : Gramboo.Controls.GrbForm
    {
      private static frmEmployeeTypeMaster instance;


        public static frmEmployeeTypeMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmEmployeeTypeMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new frmEmployeeTypeMaster();
                }
                return instance;
            }
        }

        public frmEmployeeTypeMaster()
        {

            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };

        }

        public override void Init()
        {
            base.Init();

            txtEmpTypeName.Focus();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "EMP", "EmpTypeMaster");
            t.PrimaryKeys.Add("EmpTypeId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtEmpTypeId;
            this.TableName = t;
            return true;
        }
        public override bool ValidateControls()
        {
            bool flag = true;
            flag = base.ValidateControls();
            return flag;
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
         public override void  RefreshData()
        {
            PopulateGrid();
        }
         private void PopulateGrid()
         {
             dgvList.EntryFormName = this;
             dgvList.ShowEdit = true;
             dgvList.ShowDelete = true;
             dgvList.AutoGenerateColumns = true;
             dgvList.HiddenDataFields = new List<string>() { "Created_by", "Last_modified_by", "EmpTypeId", "Company_id", "Branch_id" };
             dgvList.Fill(new Table(project.Classes.Common.DbName, "EMP", "VEmpTypeMaster", true));
         }
         public override bool Delete()
         {
             int set;
             bool flag = true;
             for (int i = 0; i < dgvList.Rows.Count; i++)
             {
                 DataGridViewRow dr = dgvList.Rows[i];
                 if (dr.Selected == true)
                 {
                     set = Convert.ToInt32(DBConn.GetData(new SqlCommand("Select EMP.EmployeeType_Validation('" + dr.Cells["EmpTypeId"].Value + "')")).Tables[0].Rows[0][0]);//,'" + txtcompId.Text + "','" + txtBranchID.Text + "'
                     {
                         if (set == 1)
                         {
                             flag = false;
                             txtEmpTypeName.ShowMessage("EmployeeType Name Selected Cannot be Deleted");
                             return flag;
                         }
                         else
                         {
                             return base.Delete();
                         }
                     }
                 }
             }
             return base.Delete();
         }


        
    }
}
