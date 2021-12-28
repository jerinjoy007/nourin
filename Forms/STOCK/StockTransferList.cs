using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project.Forms.STOCK
{
    public partial class StockTransferList : Gramboo.Controls.GrbForm
    {
        private int _vchtype = 1;


        [Browsable(false)]
        [DefaultValue(1)]
        public int VoucherType
        {

            get
            {
                return _vchtype;
            }

            set
            {
                try
                {
                    _vchtype = value;
                    if (DBConn.GetData(new System.Data.SqlClient.SqlCommand("select * FROM Acc.VoucherTypeMaster WHERE VoucherTypeId=" + value)).Tables[0].Rows.Count <= 0)
                    {


                        throw new Exception("Voucher Type is Invalid");
                    }
                }
                catch
                {
                }
            }
        }
        public StockTransferList(int vouchetype)
        {
            InitializeComponent();
            VoucherType = vouchetype;
        }
        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
            string vtypename = "";
            vtypename = (DBConn.GetData(new System.Data.SqlClient.SqlCommand("select * FROM Acc.VoucherTypeMaster WHERE VoucherTypeId=" + VoucherType + "")).Tables[0].Rows[0]["VoucherTypeName"]).ToString();
            this.Text = " List[" + vtypename + "]";
            
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            dgv.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
        }

        public override void Init()
        {
            base.Init();
            AdjustColumnsWidth();
        }

        private void PopulateGrid()
        {
            dgv.EntryFormName = new StockTransferEntryNew(VoucherType);
            dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.ShowSerialNo = true;
            dgv.HiddenDataFields = new List<string> { "EntryId", "SuppId", "VoucherTypeId", "Company_id", "Branch_id" };
            dgv.DataSource = this.DBConn.GetData(new SqlCommand("Select EntryId,EmpId,[Voucher No],[Voucher Date]," +
               " [Supplier Name],TotalChargeAmount,TotalAmount,[Created By],[Created Date],[Last Modified By],"+            
            "[Last Modified Date] From STK.VStockTransferMasterList WHERE Company_id =" + txtcompId.Text 
            + " AND Branch_id =" + txtBranchID.Text + " AND  VoucherTypeId =" + VoucherType)).Tables[0];//+ " AND  VoucherTypeId =" + VoucherType


        }
        public void AdjustColumnsWidth()
        {

            dgv.Columns["Voucher No"].Width = 100;
            //dgv.Columns["TotalMc"].Width = 120;
            //dgv.Columns["TotalChargeAmount"].Width = 150;            dgv.Columns["Voucher Date"].Width = 110;
            dgv.Columns["Supplier Name"].Width = 120;

            dgv.Columns["TotalAmount"].Width = 150; 
            dgv.Columns["TotalAmount"].Width = 150; 
            dgv.Columns["Created By"].Width = 100;
            dgv.Columns["Created Date"].Width = 125;
            dgv.Columns["Last Modified By"].Width = 125;
            dgv.Columns["Last Modified Date"].Width = 140;
            //dgv.Columns["Is Active"].Width = 75;
        }
    }
}
