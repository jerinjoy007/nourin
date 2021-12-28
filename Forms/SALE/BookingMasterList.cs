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

namespace project.Forms.SALE
{
    public partial class BookingMasterList : Gramboo.Controls.GrbForm
    {
        private static BookingMasterList instance;


        public static BookingMasterList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingMasterList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new BookingMasterList();
                }
                return instance;
            }
        }
        public BookingMasterList()
        {
            InitializeComponent();
        }
        public override void RefreshData()
        {
            base.RefreshData();
            populate();
        }
        public void populate()
        {
            dgv.EntryFormName = FrmBooking.Instance;
            dgv.ShowEdit = true;
            dgv.IsList = true;
            dgv.AutoGenerateColumns = true;
            dgv.HiddenDataFields = new List<string>() { "Entryid", "Company_id", "Branch_id", "Counter_id", "Created_date", "Last_modified_date" };
            dgv.DataFields = new List<string>() { "Entryid", "BookingNo", "BookingDate", "CustomerType", "CustName", "PhoneNo", "HairType", "MembName", "BookedTimeFrom", "BookedTimeTo", "EmpName", "[Created by]", "Created_date", "[Last modified by]", "Last_modified_date", "Company_id", "Branch_id", "Counter_id", "IsActive" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SALE", "VBookingMasterList", true));
        }
    }
}
