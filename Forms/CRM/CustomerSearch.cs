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
using System.Data.SqlClient;

namespace project.Forms.CRM
{
    public partial class CustomerSearch : Gramboo.Controls.GrbForm
    {
        private static CustomerSearch instance;
        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }

        public static CustomerSearch Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerSearch();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CustomerSearch();
                }
                return instance;
            }
        }
        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

        }
        public void loadcustomerdata()
        {
            string str = "SELECT t1.CustId, t1.CustName, t1.HouseName, t1.CustAddr1,t1.CustAddr2, t1.CustWhatsAppNo" +
 " FROM  CRM.vCustomerMaster t1 " +
 "where isactive='true'  ";

            if (txtCustName.Text != "")
            {
                str += " AND CustName like '" + txtCustName.Text + "%'";
            }
            if (txtHName.Text != "")
            {
                str += " AND HouseName like '" + txtHName.Text + "%'";
            }
            if (txtAdd1.Text != "")
            {
                str += " AND CustAddr1 like '" + txtAdd1.Text + "%'";
            }
            if (txtAdd2.Text != "")
            {
                str += " AND  CustAddr2 like '" + txtAdd2.Text + "%'";
            }
            if (txtPhNo.Text != "" && txtPhNo.Text != "0")
            {
                str += " AND  (CustWhatsAppNo like '" + txtPhNo.Text + "%'  )";
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SALE.CustomerSearch";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", dtp_InvDate.Value.ToString("dd-MMM-yyyy"));
            cmd.Parameters.AddWithValue("@SearchQuery", str);
            //cmd.Parameters.AddWithValue("@CardNo", (txt_custcardno.Text != "" ? txt_custcardno.Text : "0"));
            //cmd.Parameters.AddWithValue("@CustName", (TxtCustName.Text != "" ? TxtCustName.Text : "0"));
            //cmd.Parameters.AddWithValue("@HouseName", (TxtHouseName.Text != "" ? TxtHouseName.Text : "0"));
            //cmd.Parameters.AddWithValue("@Address1", (TxtAdd1.Text != "" ? TxtAdd1.Text : "0"));
            //cmd.Parameters.AddWithValue("@Address2", (TxtAdd2.Text != "" ? TxtAdd2.Text : "0"));
            //cmd.Parameters.AddWithValue("@PhoneNo", (TxtPhone.Text != "" ? TxtPhone.Text : "0"));
            cmd.Parameters.AddWithValue("@CompanyId", (txtcompId.Text != "" ? txtcompId.Text : "0"));
            cmd.Parameters.AddWithValue("@BranchId", (txtBranchID.Text != "" ? txtBranchID.Text : "0"));

            dgvcust.DataFields = new List<string> { "CustId", "[Customer Name]", "HouseName", "Address1", "Address2", "PhoneNo" };
            dgvcust.HiddenDataFields = new List<string> { "CustId" };
            //dgvcust.Columns["Address1"].Width = 150;
            //dgv.SummaryColumns = new string[] { "Nos", "Wt", "DiaNo", "DiaWt", "StoneNo", "StoneWt", "NetWt" };
            dgvcust.DataSource = DBConn.GetData(cmd).Tables[0];

            //dgvcust.Columns["Customer Name"].Width = 180;
            dgvcust.Columns["HouseName"].Width = 280;
            dgvcust.Columns["Address1"].Width = 100;
            dgvcust.Columns["Address2"].Width = 100;
            //dgvcust.Columns["CustPanNo"].Width = 100;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadcustomerdata();
        }

        private void dgvcust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Txtcustid.Text = dgvcust.CurrentRow.Cells["CustId"].Value.ToString();
            //if (sendercontrols != null)
            //{
            //    Gramboo.Controls.GrbTextBox cmb = new Gramboo.Controls.GrbTextBox();
            //    cmb = (Gramboo.Controls.GrbTextBox)sendercontrols;
            //    cmb.Text = Txtcustid.Text;
            //    // SenderForm.RefreshData();
            //    senderform.Focus();
            //    ParentForm.Focus();
            //    this.Close();
            //    //this.Dispose();
            //}
            //if (parentcontrols != null)
            //{

            //    parentform.Show();
            //    parentform.Focus();
            //    this.Close();

            //}

        }

        private void dgvcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Txtcustid.Text = dgvcust.CurrentRow.Cells["CustId"].Value.ToString();
            if (sendercontrols != null)
            {
                Gramboo.Controls.GrbTextBox cmb = new Gramboo.Controls.GrbTextBox();
                cmb = (Gramboo.Controls.GrbTextBox)sendercontrols;
                cmb.Text = Txtcustid.Text;
                // SenderForm.RefreshData();
                senderform.Focus();
                ParentForm.Focus();
                this.Close();
                this.Dispose();
            }
            if (parentcontrols != null)
            {

                parentform.Show();
                parentform.Focus();
                this.Close();

            }

        }
    }
}
