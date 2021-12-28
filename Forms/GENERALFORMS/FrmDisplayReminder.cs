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
using System.Data.SqlClient;

namespace project.Forms.GENERALFORMS
{
    
    public partial class FrmDisplayReminder : Gramboo .Controls.GrbForm
    {

        public FrmDisplayReminder D1;
        private static FrmDisplayReminder instance;

        public static FrmDisplayReminder Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new FrmDisplayReminder();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FrmDisplayReminder();
                }
                return instance;
            }
        }


        public FrmDisplayReminder()
        {
            InitializeComponent();
        }



        private void PopulateGrid()
        {    
                dgv.ShowDelete = false;
                dgv.ShowEdit = false;
                dgv.HiddenDataFields = new List<string>() { "ReminderId", "Repeats On", "Date" };
                dgv.DataSource = this.DBConn.GetData(new SqlCommand("Select * From GEN.GetReminder('" + dtp_date.Value.Date.ToString("dd-MMM-yyyy") + "'," + 1 + "," + 101 + ")")).Tables[0];                                                                                                        

        }



        public override void Init()
        {
            base.Init();
            txtreminderflag.Text = "0";
          
        }


        public void AdjustColumnsWidth()
        {
            //             ReminderId bigint,
            //[Date] date,
            //[Repeats On] varchar(50),
            //[Reminder Subject]  VARCHAR(50)
            dgv.Columns["Date"].Width = 130;
            dgv.Columns["Repeats On"].Width = 170;
            dgv.Columns["Reminder Subject"].Width = 1260;


        }



        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
            AdjustColumnsWidth();
        }



        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            PopulateGrid();
            AdjustColumnsWidth();
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            txtreminderflag.Text = "1";
 
        }







    }
}
