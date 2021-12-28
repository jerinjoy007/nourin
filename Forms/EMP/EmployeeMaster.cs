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
    public partial class EmployeeMaster : Gramboo.Controls.GrbForm
    {
        private static EmployeeMaster instance;
        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }

        public static EmployeeMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new EmployeeMaster();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }
        public EmployeeMaster()
        {
            InitializeComponent();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "EMP", "EmployeeMaster");
            t.PrimaryKeys.Add("EmpId");
            // t.NotUpdatables.Add("Id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtEmpId;

            //Table t1 = new Table(project.Classes.Common.DbName, "EMP", "EmployeeDetail", true);
            //t1.PrimaryKeys.Add("Transid");
            //t1.FillView = new Table(project.Classes.Common.DbName, "EMP", "VEmployeeDetail", true);
            //t1.DatagridView = dgv;
           // t1.IsDatagridView = true;
           // t1.IdTextBox = txtTransid;
            //t.ChildTables.Add(t1);
            this.TableName = t;
            return true;
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
        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(cmbCustDesg, "EMP.DesignationMaster", "DesigName", "DesigID", "IsActive='True'");
            //Gramboo.General.Setupcombo(cmbServ, "SALE.Servicemaster", "ServiceName", "ServiceId", "IsActive='True'");
        }
        public override void Init()
        {
            base.Init();
            this.ListForm = project.Forms.EMP.EmployeeMasterList.Instance;
            txtEmployeeName.Focus();
            chkISActive.Checked = true;
            //dgv.EntryFormName = this;
            //dgv.ShowEdit = true;
            //dgv.AutoGenerateColumns = true;
           // dgv.HiddenDataFields = new List<string>() { "Transid","EmpId", "Company_id", "Branch_id", "Counter_id", "ServiceId", "[created by]", "Created_date", "[Last modified by]", "Last_modified_date"  };
           // dgv.DataFields = new List<string>() { "Transid", "EmpId", "ServiceId", "[Service Name]" };
            //dgv.Fill(new Table(project.Classes.Common.DbName, "EMP", "VEmployeeDetail", true), "1=2");
        }
        private void btnDesg_Click(object sender, EventArgs e)
        {
            project.Forms.EMP.frmDesignationMaster frm = new frmDesignationMaster();
            frm.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(frm);
            frm.sendercontrols = txtEmpDesId;
            frm.senderform = this;
            frm.parentcontrols = cmbCustDesg;
            frm.parentform = this;
            frm.MdiParent = this.ParentForm;
            frm.Focus();
        }
        private void btnAgeGrp_Click(object sender, EventArgs e)
        {
            //Txtservid.Text = cmbServ.SelectedValue.ToString();
            //dgv.Save();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeMaster_Load(object sender, EventArgs e)
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
                    cmb.Text = txtEmpId.Text;
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

        private void EmployeeMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                Txttype.Visible = true;
                Txttype.Focus();

            }
        }

        private void txtEmpDesId_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpDesId.Text != "")
            {
                Gramboo.General.Setupcombo(cmbCustDesg, "EMP.DesignationMaster", "DesigName", "DesigID", "IsActive='True'");
                cmbCustDesg.SelectedValue = txtEmpDesId.Text;
            }
        }
        
    }
}
