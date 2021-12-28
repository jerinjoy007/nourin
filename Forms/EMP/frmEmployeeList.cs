using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SALON.Forms.EMP
{
    public partial class frmEmployeeList : Gramboo.Controls.GrbForm
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }
        private static frmEmployeeList instance;


        public static frmEmployeeList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmEmployeeList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new frmEmployeeList();
                }
                return instance;
            }
        }

         public override void  RefreshData()
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {

            grbDataGridView1.EntryFormName = project.Forms.EMP.EmployeeMaster.Instance;
            grbDataGridView1.ShowEdit = true;
            grbDataGridView1.AutoGenerateColumns = true;
            grbDataGridView1.ShowSerialNo = true;
            grbDataGridView1.HiddenDataFields = new List<string> { "EmpId", "Company_id", "Branch_id", "Counter_id" };
            grbDataGridView1.DataSource = this.DBConn.GetData(new SqlCommand("Select * From EMP.VEmployeeMaster WHERE Company_ID="+ txtcompId.Text )).Tables[0];
        }
    }
}
