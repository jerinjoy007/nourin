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
using Gramboo.Controls;

namespace project.Forms.MST
{
    public partial class Fee_Group : GrbForm
    {
        public static Fee_Group instance;
        public static Fee_Group Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Fee_Group();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Fee_Group();
                }
                return instance;
            }
        }
        public Fee_Group()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public override void Init()
        {
            base.Init();
            txtFeeGorpCode.Focus();
            chkISActive.Checked = true;
            PopulateGrid();
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
            Table t = new Table(project.Classes.Common.DbName, "SCH", "Fee_Group");
            t.PrimaryKeys.Add("FeeGroupId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtFeeGorpId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "FeeGroupId", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SCH", "Fee_Group", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
