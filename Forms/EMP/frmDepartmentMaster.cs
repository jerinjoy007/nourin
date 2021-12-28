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
    public partial class frmDepartmentMaster : Gramboo.Controls.GrbForm
    {
       
       
        private static frmDepartmentMaster instance;


        public static frmDepartmentMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmDepartmentMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new frmDepartmentMaster();
                }
                return instance;
            }
        }

        public frmDepartmentMaster()
        {

            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };

        }

        public override void Init()
        {
            base.Init();
          

            txtDeptName.Focus();


        }

         public override void  RefreshData()
        {
            PopulateGrid();
        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "EMP", "DepartmentMaster");
            t.PrimaryKeys.Add("DeptId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtDeptId;
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
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.ShowDelete= true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "Created_by", "Last_modified_by", "DeptId", "Company_id", "Branch_id" };

            dgvList.Fill(new Table(project.Classes.Common.DbName, "EMP", "VDeptMaster", true));
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
                    set = Convert.ToInt32(DBConn.GetData(new SqlCommand("Select EMP.DepartmentMaster_Validation('" + dr.Cells["DeptId"].Value + "')")).Tables[0].Rows[0][0]);//,'" + txtcompId.Text + "','" + txtBranchID.Text + "'
                    {
                        if (set == 1)
                        {
                            flag = false;
                            txtDeptName.ShowMessage("Department Name Selected Cannot be Deleted");
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
