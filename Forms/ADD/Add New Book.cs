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

namespace project.Forms.ADD
{
    public partial class Add_New_Book : GrbForm
    {
        public static Add_New_Book instance;
        public static Add_New_Book Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Add_New_Book();
                }
                else if(instance.IsDisposed)
                {
                    instance = new Add_New_Book();
                }
                return instance;
            }
        }
        public Add_New_Book()
        {
            InitializeComponent();
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "ITM", "Add_New");
            t.PrimaryKeys.Add("AddNew_id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = Txt_AddnewId;

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
        public override void Init()
        {
            base.Init();
        }
        public override void RefreshData()
        {
            base.Refresh();
            Gramboo.General.Setupcombo(cmb_VoucherTypeId, "ACC.VoucherTypeMaster", "VoucherTypeName", "VoucherTypeId", "IsActive='True'");

            Gramboo.General.Setupcombo(CombClassifi, "ITM.Classification", "Classification_Name", "Classification_Id", "IsActive='True'");
            Gramboo.General.Setupcombo(CombCato, "ITM.Member_Category", "MemCat_Name", "MemCatId", "IsActive='True'");
            Gramboo.General.Setupcombo(CombSub, "ITM.Book_subject", "Subject_Name", "SubjectId", "IsActive='True'");
            Gramboo.General.Setupcombo(CombLang, "ITM.Book_language", "Lang_Name", "Language_Id", "IsActive='True'");

            Gramboo.General.Setupcombo(CombPub, "ITM.Publisher", "Publisher_Name", "PublisherId", "IsActive='True'");
           
 
            cmb_VoucherTypeId.SelectedValue = 72;
            if (txtBranchID.Text != "")
            {
                if (!IsEditMode)
                    txtBook_Code.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, dtpRegDate.Value,

                        DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));
            }
        }

        private void grbComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
