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
    public partial class frmDesignationMaster : Gramboo.Controls.GrbForm
    {
             
        private static frmDesignationMaster instance;
        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }

        public static frmDesignationMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmDesignationMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new frmDesignationMaster();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }

        public frmDesignationMaster()
        {

            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };

        }

        public override void Init()
        {
            base.Init();
          

            txtDesigName.Focus();


        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "EMP", "DesignationMaster");
            t.PrimaryKeys.Add("DesigId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtDesigId;

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
             dgvList.HiddenDataFields = new List<string>() { "Created_by", "Last_modified_by", "DesigId", "Company_id", "Branch_id" };
             dgvList.Fill(new Table(project.Classes.Common.DbName, "EMP", "VDesigMaster", true));
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
                    set = Convert.ToInt32(DBConn.GetData(new SqlCommand("Select EMP.DesignationMaster_Validation('" + dr.Cells["DesigId"].Value + "')")).Tables[0].Rows[0][0]);//,'" + txtcompId.Text + "','" + txtBranchID.Text + "'
                    {
                        if (set == 1)
                        {
                            flag = false;
                            txtDesigName.ShowMessage("Designation Name Selected Cannot be Deleted");
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
                    cmb.Text = txtDesigId.Text;
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
