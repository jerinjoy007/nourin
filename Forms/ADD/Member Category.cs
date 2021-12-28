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

namespace project.Forms.ADD
{
    public partial class Member_category : Gramboo.Controls.GrbForm
    {
        private static Member_category instance;


        public static Member_category Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Member_category();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Member_category();
                }
                return instance;
            }
        }
        public Member_category()
        {
            InitializeComponent();
        }
        public override void Init()
        {
            base.Init();
            txtMemCatCode.Focus();
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
            Table t = new Table(project.Classes.Common.DbName, "ITM", "Member_Category");
            t.PrimaryKeys.Add("MemCatId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtMemCatId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "MemCatId", "MemCat_Code", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "ITM", "Member_Category", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
