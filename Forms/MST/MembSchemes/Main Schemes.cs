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

namespace project.Forms.MST
{
    public partial class Main_Schemes : Gramboo.Controls.GrbForm
    {
        private static Main_Schemes instance;


        public static Main_Schemes Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Main_Schemes();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Main_Schemes();
                }
                return instance;
            }
        }
        public Main_Schemes()
        {
            InitializeComponent();
        }
        public override void Init()
        {
            base.Init();
            txtMainSchCode.Focus();
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
            Table t = new Table(project.Classes.Common.DbName, "SCH", "Main_Scheme");
            t.PrimaryKeys.Add("MainSchemeId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtMainSchId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "MainSchemeId", "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SCH", "Main_Scheme", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
    }
}
