using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gramboo.Database;

namespace SALON.Forms.SYST
{
    public partial class FrmGreetings : Gramboo.Controls.GrbForm
    {
   
        private static FrmGreetings instance;

        public static FrmGreetings Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmGreetings();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FrmGreetings();
                }
                return instance;
            }

        }


        public FrmGreetings()
        {
            InitializeComponent();
        }



        public override void Init()
        {
            base.Init();
            txtGreetings.Focus();
            chkISActive.Checked = true;
            //AdjustColumnsWidth();

        }




        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "Settings");
            t.PrimaryKeys.Add("EntryId");
            t.IdTextBox = TxtEntryId;
            this.TableName = t;
            return true;
        }


        public override bool ValidateControls()
        {
            bool flag = true;
            flag = base.ValidateControls();
            return flag;
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
            PopulateGrid();
            // AdjustColumnsWidth();
        }


        private void PopulateGrid()
        {
            using (DataTable dt = DBConn.GetData(new SqlCommand("Select SalesBillGreetingsMsg,SalesBillFooterNote from SYST.Settings Where EntryId=" + 11010001 + "")).Tables[0])
            {
                if (dt.Rows.Count > 0)
                {
                    txtGreetings.Text = dt.Rows[0]["SalesBillGreetingsMsg"].ToString();
                    txtFooter.Text = dt.Rows[0]["SalesBillFooterNote"].ToString();
                   

                }
            }     
        }

        public override bool Save()
        {
            //    if (base.Save())
            //    {
            using (DataTable dt = DBConn.GetData(new SqlCommand("Select SalesBillGreetingsMsg,SalesBillFooterNote from SYST.Settings Where EntryId=" + 11010001 + "")).Tables[0])
            {
                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "UPDATE SYST .Settings  SET SalesBillGreetingsMsg='" + txtGreetings.Text + "',SalesBillFooterNote='" + txtFooter.Text + "'  WHERE EntryId=11010001";
                    DBConn.ExecuteSqlTransaction(cmd, "update");
                    Gramboo.General.ShowMessage("Data Updated");
                    return true;
                }

                else if (dt.Rows.Count == 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO SYST.Settings VALUES('" + 11010001 + "','" + "Path" + "','" + 0 + "','" + 800 + "','" + 80 + "','" + txtGreetings.Text + "','" + txtFooter.Text + "','" + txtCrUserId.Text + "','" + txtcreatedDate.Text + "','" + txtModuserID.Text + "','" + txtModifiedDate.Text + "','" + txtcompId.Text + "','" + txtBranchID.Text + "','" + txtCounterId.Text + "','" + true + "') ";
                    DBConn.ExecuteSqlTransaction(cmd, "insert");
                    Gramboo.General.ShowMessage("Data Saved");
                    return true;
                }

                else
                {
                    return false;
                }

            }

         
        }






    }
}
