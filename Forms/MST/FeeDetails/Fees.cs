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

namespace project.Forms.MST.FeeDetails
{
    public partial class Fees : GrbForm
    {
        public static Fees instance;
        public static Fees Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Fees();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Fees();
                }
                return instance;
            }
        }
        public Fees()
        {
            InitializeComponent();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SCH", "Fee");
            t.PrimaryKeys.Add("AddNew_id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtfeeId;

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
        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(cmbFeeType, "SCH.Fee_Type", "FEETYPENAME", "FeeTypeId", "IsActive='True'");
            Gramboo.General.Setupcombo(cmbFeeGroup, "SCH.Fee_Group", "FeeGroupName", "FeeGroupId", "IsActive='True'");
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
