using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gramboo.Database;

namespace project.Forms.EMP
{
    public partial class EmployeeMasterList : Gramboo.Controls.GrbForm
    {
        private static EmployeeMasterList instance;


        public static EmployeeMasterList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeMasterList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new EmployeeMasterList();
                }
                return instance;
            }
        }
        public EmployeeMasterList()
        {
            InitializeComponent();
        }
        public override void RefreshData()
        {
            base.RefreshData();
            populate();
        }
        private void EmployeeMasterList_Load(object sender, EventArgs e)
        {

        }
        public void populate()
        {
            dgv.EntryFormName = EmployeeMaster.Instance;
            dgv.ShowEdit = true;
            dgv.IsList = true;
            dgv.AutoGenerateColumns = true;
            dgv.HiddenDataFields = new List<string>() { "EmpId", "EmpCode", "Salary", "EmpJoinDate", "DesigId", "NoOfLeaves", "Company_id", "Branch_id", "Counter_id", "IsActive" };
            dgv.DataFields = new List<string>() { "EmpId", "EmpCode", "EmpName", "EmpAddr1", "EmpAddr2", "EmpMob", "Salary", "EmpJoinDate", "DesigId", "NoOfLeaves", "[Created by]", "Created_date", "[Last modified by]", "Last_modified_date", "Company_id", "Branch_id", "Counter_id", "IsActive" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "EMP", "VEmployeeMasterList", true));
        }
    }
}
