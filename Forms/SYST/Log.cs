using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.SYST
{
    public partial class Log : Gramboo.Controls.GrbForm
    {
        private static Log instance;

        public static Log Instance
        {
          get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Log();
                }
                return instance;
            }
        }
        public Log()
        {
            InitializeComponent();
        }
        public override void RefreshData()
        {
            PopulateGrid();
        }
        public override void Init()
        {
            base.Init();
            AdjustColumnsWidth();

        }
        public void AdjustColumnsWidth()
        {
            dgv.Columns["Date"].Width = 150;
            dgv.Columns["User Name"].Width = 150;
            dgv.Columns["Action"].Width = 150;
            dgv.Columns["Description"].Width = 150;
        
        }
        private void PopulateGrid()
        {
            //dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.ShowSerialNo = true;
            dgv.SummaryColumns = new string[] { };
            dgv.HiddenDataFields = new List<string>() { "Id" };
            dgv.DataSource = this.DBConn.GetData(new SqlCommand("Select " +
            "Id,Date,User_Id,[User Name],[Action],Description" +
            " From SYST.VLog WHERE Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text + " AND Date>='" + Dtp_From.Value.ToString("dd/MMM/yyyy") + "'  AND  Date<='" + dtp_to.Value.ToString("dd/MMM/yyyy") +"'")).Tables[0];

        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            toolTip1.Show(dgv.Rows[e.RowIndex].Cells["Description"].Value.ToString(),dgv ,(int)dgv.Rows[e.RowIndex].Cells["Description"].GetContentBounds(e.RowIndex).X, (int)dgv.Rows[e.RowIndex].Cells["Description"].GetContentBounds(e.RowIndex).Y);
        }
    }
}
