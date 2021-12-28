using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gramboo.Database;

namespace project.Forms.CRM
{
    public partial class CustomerMasterList : Gramboo.Controls.GrbForm
    {
        private static CustomerMasterList instance;


        public static CustomerMasterList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerMasterList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CustomerMasterList();
                }
                return instance;
            }
        }
        public CustomerMasterList()
        {
            InitializeComponent();
        }

        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
        }
        public override void Init()
        {
            base.Init();
            AdjustColumnsWidth();
        }
        public void AdjustColumnsWidth()
        {
            dgv.Columns["Customer Name"].Width = 200;
            dgv.Columns["Customer Type"].Width = 170;
            dgv.Columns["Gender"].Width = 200;
            //dgv.Columns["Address1"].Width = 200;
            //dgv.Columns["Address2"].Width = 200;
            dgv.Columns["Place"].Width = 200;
            dgv.Columns["City"].Width = 200;
            //dgv.Columns["Phone No"].Width = 200;
            dgv.Columns["Mobile No"].Width = 200;
            dgv.Columns["Contact Person"].Width = 150;
            dgv.Columns["Contact No"].Width = 100;
           // dgv.Columns["Ledger Head"].Width = 130;
            dgv.Columns["Is Active"].Width = 75;
        }

        private void PopulateGrid()
        {

            dgv.EntryFormName = CustomerMasterr.Instance;
            dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.ShowSerialNo = true;
            dgv.DataFields = new List<string> { "CustId", "[Customer Name]", "[Customer Type]", "Gender","Place", "City" , "[Mobile No]", "[Contact Person]", "[Contact No]" , "Company_id", "Branch_id", "Counter_id", "[Is Active]" };
            dgv.HiddenDataFields = new List<string> { "CustId", "Company_id", "Branch_id", "Counter_id", "CustTypeId", "CustGroupId", "Companyid" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "CRM", "VCustomerMasterList", true), "Company_id=" + txtcompId.Text);
        }
    }
}
