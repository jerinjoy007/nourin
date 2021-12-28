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
    public partial class Add_Address_Type : GrbForm
    {
        public static Add_Address_Type instance;
        public static Add_Address_Type Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Add_Address_Type();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Add_Address_Type();
                }
                return instance;
            }
        }

        public Add_Address_Type()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public override void Init()
        {
            base.Init();
            txtAddTycode.Focus();
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
            Table t = new Table(project.Classes.Common.DbName, "SCH", "AddressType");
            t.PrimaryKeys.Add("AddTypeId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtAddtyId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "AddTypeId", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SCH", "AddressType", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
