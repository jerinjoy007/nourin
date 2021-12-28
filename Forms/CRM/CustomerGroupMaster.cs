using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gramboo.Database;
using System.Data.SqlClient;
namespace project.Forms.CRM
{
    public partial class CustomerGroupMaster : Gramboo.Controls.GrbForm
    
    {

        private static CustomerGroupMaster instance;
        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }

        public static CustomerGroupMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerGroupMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CustomerGroupMaster();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }

        public CustomerGroupMaster()
        {
            InitializeComponent();
        }




        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
            txtCustGroupName.Focus();
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

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "CRM", "CustomerGroupMaster");
            t.PrimaryKeys.Add("CustGroupId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtCustGroupId;

            this.TableName = t;
            return true;
        }
        public override void Init()
        {
            base.Init();
            chkISActive.Checked = true;
            AdjustColumnsWidth();
            txtCustGroupName.Focus();
        }
        public void AdjustColumnsWidth()
        {
            dgvList.Columns["Customer Group Name"].Width = 170;
            dgvList.Columns["Created By"].Width = 100;
            dgvList.Columns["Created Date"].Width = 125;
            dgvList.Columns["Last Modified By"].Width = 125;
            dgvList.Columns["Last Modified Date"].Width = 140;
            dgvList.Columns["Is Active"].Width = 75;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            // dgvList.ShowDelete = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "Created_by", "Last_modified_by", "MergeCust", "CustGroupID", "Company_id", "Branch_id" };

            dgvList.Fill(new Table(project.Classes.Common.DbName, "CRM", "VCustGroupMaster", true));
        }

        private void CustomerGroupMaster_Load(object sender, EventArgs e)
        {

        }
        //////public override bool ValidateControls()
        //////{
        //////    bool flag = true;
        //////    flag = base.ValidateControls();
        //////    return flag;
        //////}


        //////public override bool Save()
        //////{
        //////    if (base.Save())
        //////    {
        //////        PopulateGrid();
        //////        return true;
        //////    }

        //////    else
        //////    {
        //////        return false;
        //////    }
        //////}

        //////public override bool Delete()
        //////{
        //////    int set;
        //////    bool flag = true;
        //////    for (int i = 0; i < dgvList.Rows.Count; i++)
        //////    {
        //////        DataGridViewRow dr = dgvList.Rows[i];
        //////        if (dr.Selected == true)
        //////        {
        //////            set = Convert.ToInt32(DBConn.GetData(new SqlCommand("Select CRM.CustGroupName_Validation('" + dr.Cells["CustGroupId"].Value + "')")).Tables[0].Rows[0][0]);//,'" + txtcompId.Text + "','" + txtBranchID.Text + "'
        //////            {
        //////                if (set == 1)
        //////                {
        //////                    flag = false;
        //////                    txtCustGroupName.ShowMessage("GroupName Selected Cannot be Deleted");
        //////                    return flag;
        //////                }
        //////                else
        //////                {
        //////                    return base.Delete();
        //////                }
        //////            }
        //////        }
        //////    }
        //////    return false;
        //////}
        public override bool Save()
        {
            if (base.Save())
            {
                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "[ACC].[ProcCreateCustomerLedger]";
                //cmd.CommandType = CommandType.StoredProcedure;
                ////connectionstring.Open(); 
                //cmd.Parameters.AddWithValue("@CustID", txtCustId.Text);
                //cmd.Parameters.AddWithValue("@CompanyId", txtcompId.Text);
                //cmd.Parameters.AddWithValue("@BranchId", txtBranchID.Text);
                //DBConn.ExecuteSqlTransaction(cmd, "CustLedger");
                if (sendercontrols != null)
                {
                    Gramboo.Controls.GrbTextBox cmb = new Gramboo.Controls.GrbTextBox();
                    cmb = (Gramboo.Controls.GrbTextBox)sendercontrols;
                    cmb.Text = txtCustGroupId.Text;
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
                else
                {
                    Init();
                }
                return true;

            }

            else
            {
                return false;
            }
        }

    }
}
