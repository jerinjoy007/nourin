using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gramboo.Database;
using System.Data.SqlClient;

namespace project.Forms.HR
{
    public partial class ManualPunchEntry : Gramboo.Controls.GrbForm
    {
        private static ManualPunchEntry instance;

        public static ManualPunchEntry Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new ManualPunchEntry();
                }
                else if (instance.IsDisposed)
                {
                    instance = new ManualPunchEntry();
                }
                return instance;
            }
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
        public ManualPunchEntry()
        {
            InitializeComponent();
        }

        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(cmb_StaffName, "EMP.EmployeeMaster", "EmpName", "EmpId", "IsActive='True' AND Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text);
            populategrid();
            cmb_StaffName.Focus();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into  [HR].[ManualPunch] SELECT CAST(11010000+ROW_NUMBER () over( order by a2.EmpDate) as bigint),a2.EmpId,a2.EmpDate,a2.Emplogin,null,11010001,'2018-11-14',11010001,'2018-11-14',1,101,11010001,1 FROM (select distinct a1.EmpId,a1.EmpDate,a1.Emplogin,a1.Emplogout FROM [dbo].[Attend] as a1  ) as a2 where a2.EmpId not in ( select m1.StaffID from [HR].[ManualPunch] as m1 where m1.LoginDate = '2021-12-20')";
            DBConn.ExecuteSqlTransaction(cmd, "insert");
        }

        private void ManualPunchEntry_Load(object sender, EventArgs e)
        {

        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "HR", "ManualPunch");
            t.PrimaryKeys.Add("EntryId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtEntryNo;
            this.TableName = t;
            return true;
            
        }

        private void AdjustColumnWidths()
        {
          dgv.Columns["Login Time"].DefaultCellStyle.Format = "hh:mm:ss  tt";
          dgv.Columns["Logout Time"].DefaultCellStyle.Format ="hh:mm:ss  tt"; 
       }
        private void populategrid()
        {
            dgv.EntryFormName = this;
            dgv.IsList = true;
            dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.DataFields = new List<string> { "EntryId", "StaffID", "[Staff Name]", "[Login Date]", "[Login Time]", "[Logout Time]", "[Created By]", " [Created Date]", "[Last Modified By ]", " [Last Modified Date]", "Company_id", "Branch_id" };
            dgv.HiddenDataFields = new List<string> { "EntryId", "StaffID", "Company_id", "Branch_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "HR", "VManualPunchList", true));
            AdjustColumnWidths();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
