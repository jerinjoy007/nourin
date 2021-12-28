using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gramboo.Database;
using System.Data.SqlClient;
namespace project.Forms.SYST
{
    public partial class Counter_Master : Gramboo.Controls.GrbForm
    {

        private static Counter_Master instance;

        public static Counter_Master Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new Counter_Master();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Counter_Master();
                }
                return instance;
            }
        }
        public Counter_Master()
        {
            InitializeComponent();
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
            PopulateGrid();
        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "CounterMaster");
            t.PrimaryKeys.Add("CounterId");
            //t.NotUpdatables.Add("Company_id");
            //t.NotUpdatables.Add("Branch_id");
            //t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtCounterIdd;
            this.TableName = t;
            return true;
        }
        public void AdjustColumnsWidth()
        {
            dgv.Columns["Counter Name"].Width = 150;
            dgv.Columns["Created By"].Width = 100;
            dgv.Columns["Created Date"].Width = 125;
            dgv.Columns["Last Modified By"].Width = 125;
            dgv.Columns["Last Modified Date"].Width = 140;
            dgv.Columns["Is Active"].Width = 75;
        }

        public override void Init()
        {
            base.Init();
            txtCounterName.Focus();
            Chk_IsActive.Checked = true;
            AdjustColumnsWidth();
        }


        private void PopulateGrid()
        {
            dgv.EntryFormName = this;
            dgv.ShowEdit = true;
            dgv.IsList = true;
            dgv.AutoGenerateColumns = true;
            dgv.DataFields = new List<string>() { "CounterId", "[Counter Name]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]" };
            dgv.HiddenDataFields = new List<string>() { "CounterId", "Counter_id", "Created_by", "Last_modified_by", "Company_id", "Branch_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VCounterMaster", true));



        }



    }
}
