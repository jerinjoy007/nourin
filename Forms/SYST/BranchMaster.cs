using Gramboo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.SYST
{
    public partial class BranchMaster : Gramboo.Controls.GrbForm
    {
        private static BranchMaster instance;


        public static BranchMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BranchMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new BranchMaster();
                }
                return instance;
            }
        }
        public BranchMaster()
        {
            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };
        }
        public override void Init()
        {
            base.Init();
            txtBranchName.Focus();
            chkISActive.Checked = true;
            AdjustColumnsWidth();
           
        }
        public void AdjustColumnsWidth()
        {
            dgvList.Columns["Branch Name"].Width = 150;
            dgvList.Columns["Created By"].Width = 100;
            dgvList.Columns["Created Date"].Width = 125;
            dgvList.Columns["Last Modified By"].Width = 125;
            dgvList.Columns["Last Modified Date"].Width = 140;
            dgvList.Columns["Is Active"].Width = 75;
        }
        
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "BranchMaster");
            t.PrimaryKeys.Add("BranchId");
            t.IdTextBox = TxtBrancId;
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
        public override void RefreshData()
        {
            PopulateGrid();
        }
         private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.DataFields = new List<string>() { "BranchId", "[Branch Name]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]" };
            dgvList.HiddenDataFields = new List<string>() { "BranchId", "Created_by", "Last_modified_by", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SYST", "VBranchMaster", true));



        }

    }
}
