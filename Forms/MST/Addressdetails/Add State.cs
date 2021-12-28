using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gramboo.Controls;
using Gramboo.Database;


namespace project.Forms.MST.Addressdetails
{
    public partial class Add_State : GrbForm
    {
        public static Add_State instance;
        public static Add_State Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Add_State();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Add_State();
                }
                return instance;
            }
        }
        public Add_State()
        {
            InitializeComponent();
        }

        private void Add_State_Load(object sender, EventArgs e)
        {

        }
        public override void Init()
        {
            base.Init();
            txtStateCode.Focus();
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
            Table t = new Table(project.Classes.Common.DbName, "SCH", "State");
            t.PrimaryKeys.Add("StateId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtstateId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "StateId", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SCH", "State", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
