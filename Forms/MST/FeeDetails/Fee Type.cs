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
    public partial class Fee_Type :  GrbForm
    {
        public static Fee_Type instance;

        public static Fee_Type Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Fee_Type();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Fee_Type();
                }
                return instance;
            }
        }
        public Fee_Type()
        {
            InitializeComponent();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SCH", "Fee_Type");
            t.PrimaryKeys.Add("FeeTypeId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtFeeId;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
