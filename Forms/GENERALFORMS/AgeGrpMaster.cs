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

namespace project.Forms.GENERALFORMS
{
    public partial class AgeGrpMaster : Gramboo.Controls.GrbForm
    {
        private static AgeGrpMaster instance;

        public Gramboo.Controls.GrbForm parentform{get;set;}
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }
        
        public static AgeGrpMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgeGrpMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new AgeGrpMaster();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }
        public AgeGrpMaster()
        {
            InitializeComponent();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "GEN", "AgeGroupMaster");
            t.PrimaryKeys.Add("Entryid");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtEntryID;

            

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
        private void AgeGrpMaster_Load(object sender, EventArgs e)
        {

        }

        private void grbDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public override void RefreshData()
        {
            PopulateGrid();
        }
        private void PopulateGrid()
        {
            dgvAge.EntryFormName = this;
            dgvAge.ShowEdit = true;
            dgvAge.ShowDelete = true;
            dgvAge.AutoGenerateColumns = true;
            dgvAge.HiddenDataFields = new List<string>() { "Entryid", "[Created By]", "[Last Modified By]", "Branch_id", "Counter_id", "Company_id" };
            dgvAge.DataFields = new List<string>() { "Entryid", "[Age Group Name]", "[Age From]", "[Age To]", "[Created By]", "Created_date", "[Last Modified By]", "Last_modified_date", "IsActive", "Company_id" };
            dgvAge.Fill(new Table(project.Classes.Common.DbName, "GEN", "VAgeGroupMaster", true));
        }
        public override void Init()
        {
            base.Init();
            PopulateGrid();
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
                    cmb.Text = TxtEntryID.Text;
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
