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
    public partial class Add_Country : GrbForm
    {
        public static Add_Country instance;
        public static Add_Country Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Add_Country();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Add_Country();
                }
                return instance;
            }
        }

        public Add_Country()
        {
            InitializeComponent();
        }
        public override void Init()
        {
            base.Init();
            txtCountryCode.Focus();
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
            Table t = new Table(project.Classes.Common.DbName, "SCH", "country");
            t.PrimaryKeys.Add("CountryId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtCountryId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "CountryId", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SCH", "country", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
