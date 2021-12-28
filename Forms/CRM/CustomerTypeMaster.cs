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
    public partial class CustomerTypeMaster : Gramboo.Controls.GrbForm
    {
        private static CustomerTypeMaster instance;
        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }

        public static CustomerTypeMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerTypeMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CustomerTypeMaster();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }

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

        public CustomerTypeMaster()
        {
            InitializeComponent();
        }



        public override void RefreshData()
        {
            base.RefreshData();
            txtCustTypeName.Focus();
            PopulateGrid();
        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "CRM", "CustomerTypeMaster");
            t.PrimaryKeys.Add("CustTypeId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtCustTypeId;
            this.TableName = t;
            return true;
        }
        public override void Init()
        {
            base.Init();
            Chk_IsActive.Checked = true;
            AdjustColumnsWidth();
            txtCustTypeName.Focus();
        }
        public void AdjustColumnsWidth()
        {
            dgvList.Columns["Customer Type Name"].Width = 170;
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
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "Created_by", "Last_modified_by", "CustTypeId", "Company_id", "Branch_id" };

            dgvList.Fill(new Table(project.Classes.Common.DbName, "CRM", "VCustTypeMaster", true));



        }

        private void CustomerTypeMaster_Load(object sender, EventArgs e)
        {

        }
        public override bool Save()
        {
            //base.Save();
            //Init();
            //return true;
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
                    cmb.Text = txtCustTypeId.Text;
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
