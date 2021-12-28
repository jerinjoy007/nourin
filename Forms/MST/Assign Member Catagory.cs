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

namespace project.Forms.MST
{
    public partial class Assign_Member_Catagory : GrbForm
    {
        public static Assign_Member_Catagory instance;
        public static Assign_Member_Catagory Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Assign_Member_Catagory();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Assign_Member_Catagory();
                }
                return instance;
            }
        }
        public Assign_Member_Catagory()
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
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SCH", "Member_Catagory");
            t.PrimaryKeys.Add("MembCatid");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtMembCatid;

            this.TableName = t;
            return true;
        }
        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(CmbSubshe, "SCH.Sub_Scheme", "SchemeName", "SubSchId", "IsActive='True'");
            Gramboo.General.Setupcombo(cnbAddshe, "SCH.Additional_Scheme", "AddSchemeName", "AddSchemeId", "IsActive='True'");
            Gramboo.General.Setupcombo(cmbMemcate, "SCH.Main_Scheme", "MainSchemeName", "MainSchemeId", "IsActive='True'");
        }
    }
}
