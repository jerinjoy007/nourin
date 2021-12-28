using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.STOCK
{
    public partial class DepartmentOpeningStkEntryList : Gramboo.Controls.GrbForm
    {

      private static DepartmentOpeningStkEntryList instance;

        public static DepartmentOpeningStkEntryList Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new DepartmentOpeningStkEntryList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new DepartmentOpeningStkEntryList();
                }
                return instance;
            }
        }
        public DepartmentOpeningStkEntryList()
        {
            InitializeComponent();
        }

        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();

        }
        private void PopulateGrid()
        {

            dgv.EntryFormName = project.Forms.STOCK.DepartmentOpeningStkEntry.Instance;
            dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.ShowSerialNo = true;
            dgv.SummaryColumns = new string[] { "Cash" };
            dgv.HiddenDataFields = new List<string>() { "EntryId" };
            dgv.DataSource = this.DBConn.GetData(new SqlCommand("Select " +
             "EntryId,[Voucher No],[Voucher Date],[Department Name],Cash,[Created By],[Created Date],[Last Modified By],[Last Modified Date] " +
            "From STK.VDepartmentOpeningStkEntryList WHERE  Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text)).Tables[0];

        }

    }
}
