using Gramboo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Forms.GENERALFORMS
{
    public partial class frmTransfer : Gramboo.Controls.GrbForm
    {
        private bool backupflag,TransferFlag;
        DataController dc ;

        public frmTransfer()
        {
            InitializeComponent();
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            dc = new DataController();
            dc.ConnectionProperties.GenerateSQLConnectionString();
            backupflag = TransferFlag = false;

            grpTransfer.Visible = false;
            btnDelete.Enabled = false;


        }


        

        private bool Transfer()
        {
            string path;
            if (File.Exists(Application.StartupPath + "\\Trans.txt"))
            {
                try
                {
                      path = System.IO.File.ReadAllLines(Application.StartupPath + "\\Trans.txt")[0];
                }
                catch (Exception e)
                {
                    Gramboo.General.ShowMessage("Unable to read path", "", MessageBoxIcon.Asterisk, MessageBoxButtons.OK);
                    return false;

                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SYST.TransferData";
                 cmd.Parameters.AddWithValue("@Source", dc.ConnectionProperties.DatabseName);
                cmd.Parameters.AddWithValue("@Destin", path);

                cmd.Parameters.AddWithValue("@DateFrom", dtpFrom.Value.ToString("dd-MMM-yyyy"));
                cmd.Parameters.AddWithValue("@DateTo", DtpTo.Value.ToString("dd-MMM-yyyy"));
                cmd.CommandTimeout =0;
                try
                {

                if (dc.ExecuteSqlTransaction(cmd, "Transfer"))
                {
                    Gramboo.General.ShowMessage("Data Transfer Completed ", "", MessageBoxIcon.Information, MessageBoxButtons.OK);
                    return true;


                }
                else
                {
                    return false;
                }                 


                }
                catch (Exception ex)
                {
                                    Gramboo.General.ShowMessage(ex.Message.ToString(), "", MessageBoxIcon.Error, MessageBoxButtons.OK);
                                    return false;
                }
            }
            else
            {
                Gramboo.General.ShowMessage("Transfer Path Not Found", "", MessageBoxIcon.Asterisk, MessageBoxButtons.OK);
                return false;
            }
             
        }



        private bool Delete()
        {
            string path;
            if (File.Exists(Application.StartupPath + "\\Trans.txt"))
            {
                try
                {
                    path = System.IO.File.ReadAllLines(Application.StartupPath + "\\Trans.txt")[0];
                }
                catch (Exception e)
                {
                    Gramboo.General.ShowMessage("Unable to read path", "", MessageBoxIcon.Asterisk, MessageBoxButtons.OK);
                    return false;

                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SYST.DeleteData";
                cmd.Parameters.AddWithValue("@Source", dc.ConnectionProperties.DatabseName); 
                cmd.Parameters.AddWithValue("@DateFrom", dtpFrom.Value.ToString("dd-MMM-yyyy"));
                cmd.Parameters.AddWithValue("@DateTo", DtpTo.Value.ToString("dd-MMM-yyyy"));
                cmd.CommandTimeout = 0;

                if (dc.ExecuteSqlTransaction(cmd, "Delete"))
                {
                    Gramboo.General.ShowMessage("Data Deleted ", "", MessageBoxIcon.Information, MessageBoxButtons.OK);
                    return true;


                }

                else
                {
                    return false;
                }

                

            }
            else
            {
                Gramboo.General.ShowMessage("Transfer Path Not Found", "", MessageBoxIcon.Asterisk, MessageBoxButtons.OK);
                return false;
            }
        }

        private void btnBackp_Click(object sender, EventArgs e)
        {
            if (Gramboo.General.ShowMessage("Do you want to  backup data ?", "Backup", MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                 
                grpTransfer.Visible = backupflag;
                Classes.Common.InsertTLog("BACKUP", Convert.ToInt64( txtCrUserId.Text),DBConn );
            }
        }


        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (Gramboo.General.ShowMessage("Do you want to  Transfer data ?", "Backup", MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand
             ("SELECT TAction FROM SYST.TLog WHERE TDate >='" + dtpFrom.Value.Date.ToString("dd-MMM-yyyy") + "'  AND( TAction='DELETE' or TAction='DELETESALES' )")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {

                        Gramboo.General.ShowMessage("Invalid Transfer !! ");

                    }

                    else
                    {
                        TransferFlag = Transfer();
                        btnDelete.Enabled = TransferFlag;
                        Classes.Common.InsertTLog("TRANSFER", Convert.ToInt64(txtCrUserId.Text), DBConn);
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Gramboo.General.ShowMessage("Do you want to  Delete data ?", "Backup", MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Delete();
                Classes.Common.InsertTLog("DELETE", Convert.ToInt64(txtCrUserId.Text), DBConn);

            }
        }




    }
}
