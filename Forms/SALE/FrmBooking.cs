using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gramboo.Database ;
using System.Data.SqlClient;
using Gramboo.Controls;

namespace project.Forms.SALE
{
    public partial class FrmBooking : Gramboo.Controls.GrbForm
    {
        private static FrmBooking instance;
        // public SchemeJoiningEntry sjoin;
        // private JMS_RET.Forms.SALE.SchemeJoiningEntry SJoin = new SALE.SchemeJoiningEntry();
        public bool flag;
        public bool flagsave;
        //public project.REPORTS.SALE.BookingReports report;
        public long entryid;
        //public Gramboo.Controls.GrbForm ParentForm { get; set; }
        //public Gramboo.Controls.GrbComboBox Parentcontrol { get; set; }
        public bool AllowInit { get; set; }
        public static FrmBooking Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FrmBooking();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FrmBooking();
                }
                return instance;
            }
        }
        //public Control SenderControl { get; set; }
        //public Gramboo.Controls.GrbForm SenderForm { get; set; }
        //public string SenderProperty { get; set; }
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

        public FrmBooking()
        {
            InitializeComponent();
            //txtPrice.TextChanged += new EventHandler(calcu);
            //txtMeMpshipDisc.TextChanged += new EventHandler(calcu);
            //txtPackDisc.TextChanged += new EventHandler(calcu);
            Cmb_CustName.SelectedValueChanged += new EventHandler(MEMBSHIP);
            cmbServiceName.SelectedValueChanged += new EventHandler(MEMBSHIP);
            cmbServiceName.SelectedValueChanged += new EventHandler(packagesel);
            cmbServiceName.SelectedValueChanged += new EventHandler(servprcHair);
            cmbHairType.SelectedValueChanged += new EventHandler(servprcHair);
            txtPrice.TextChanged += new EventHandler(Totalamt);
            txtMeMpshipDisc.TextChanged += new EventHandler(Totalamt);
            txtPackDisc.TextChanged += new EventHandler(Totalamt);

        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SALE", "BookingMaster");
            t.PrimaryKeys.Add("EntryId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtEntryid;
        
            Table t1 = new Table(project.Classes.Common.DbName, "SALE", "BookingDetails", true);
            t1.PrimaryKeys.Add("TransId");
            t1.FillView = new Table(project.Classes.Common.DbName, "SALE", "VBookingDetails", true);
            t1.DatagridView = dgv;
            t1.IsDatagridView = true;
            t1.IdTextBox = TrancsId;
            t.ChildTables.Add(t1);

            this.TableName = t;
            return true;
        }
        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(Cmb_CustType, "CRM.CustomerTypeMaster", "CustTypeName", "CustTypeId", "IsActive='True'");
            Gramboo.General.Setupcombo(Cmb_CustName, "CRM.CustomerMaster", "CustName", "CustId", "IsActive='true'");
            Gramboo.General.Setupcombo(cmbHairType, "CRM.HairTypeMaster", "HairType", "EntryId", "IsActive='true'");
            Gramboo.General.Setupcombo(cmbServiceName, "SALE.Servicemaster", "ServiceName", "ServiceId", "IsActive='true'");
            Gramboo.General.Setupcombo(cmbEmpName, "EMP.EmployeeMaster", "EmpName", "EmpId", "IsActive='true'");
            Gramboo.General.Setupcombo(cmb_VoucherTypeId, "ACC.VoucherTypeMaster", "VoucherTypeName", "VoucherTypeId", "IsActive='True'");
            cmb_VoucherTypeId.SelectedValue = 66;
            if (!IsEditMode && txtcompId.Text != "")
                txtBookingNo.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, grbDTBkDate.Value,
                DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));
        }
        public override void Init()
        {
            base.Init();
            //this.Butcust.MasterForm = SALON.Forms.CRM.CustomerMasterr.Instance;
            //this.Butcust.ParentForm = SALON.Forms.SALE.FrmBooking.Instance;
            //this.Butcust.ParentControl = Cmb_CustName;
            this.ListForm = project.Forms.SALE.BookingMasterList.Instance;
            cmbseltype.SelectedIndex = 0;
            txtPrice.Text = "0";
            txtMeMpshipDisc.Text = "0";
            txtPackDisc.Text = "0";
            chkISActive.Checked = true;
            cmbMembName.DataSource = null;
            panel1.Visible = false;
            flag = false;
            TxtbookingId.Text = "";
            dgv.HiddenDataFields = new List<string>() { "Salestype", "TransId", "EntryId", "Counter_id", "IsActive", "Serviceid", "Branch_id", "Company_id", "Last_modified_date", "Created_date", "Created_by", "Counter_id", "IsActive" };
            dgv.DataFields = new List<string>() { "Salestype", "TransId", "EntryId", "Serviceid", "ServiceName", "Price", "MembershipDisc", "PackageDisc", "Amount", "Branch_id", "Company_id", "Last_modified_date", "Created_date", "Created_by", "Counter_id", "IsActive" };
            dgv.SummaryRowVisible = true;
            dgv.SummaryColumns = new string[] { "Price", "MembershipDisc", "PackageDisc", "Amount" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SALE", "VBookingDetails", true), "1=2");
            //if (this.TableName != null)
            //    GenerateID(this.TableName);
          
            dtpBookedFrom.Value = DateTime.Now.ToLocalTime();
            DateTime joindate = Convert.ToDateTime(dtpBookedFrom.Text);
            dtpBookedTo.Value = joindate.AddHours(1);

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        private void FrmBooking_Load(object sender, EventArgs e)
        {
        }

        private void grbButton1_Click(object sender, EventArgs e)
        {
            
            if (cmbServiceName.SelectedValue != null)
            {
                
                Txtserviceid.Text = cmbServiceName.SelectedValue.ToString();
                dgv.Save();
            }
        }
        public void calcu(object sender, EventArgs e)
        {
            double pric, dismemb, PackDisc, total;
            pric = Convert.ToSingle(txtPrice.Text == "" ? "0" : txtPrice.Text);
            dismemb = Convert.ToSingle(txtMeMpshipDisc.Text == "" ? "0" : txtMeMpshipDisc.Text);
            PackDisc = Convert.ToSingle(txtPackDisc.Text == "" ? "0" : txtPackDisc.Text);

            total = pric - (dismemb + PackDisc) ;

            txtTotal.Text = total.ToString("f2");

        }
        public override bool Save()
        {
            DialogResult d =
               Gramboo.General.ShowMessage(

               " You Want to Perform This Action ? \n\n" +
               " 1. Press 'Yes' to Save and Print \n" +
               " 2. Press 'No' to Save Only \n" +
               " 2. Press 'Cancel' to Cancel This Action \n", "Save", MessageBoxIcon.Question, MessageBoxButtons.YesNoCancel, MessageBoxDefaultButton.Button1);

            if (d == DialogResult.Cancel)
            {
                return false;
            }
            else
            {
                if (base.Save())
                {
                    if (d == DialogResult.Yes)
                    {
                        if (TxtbookingId.Text != "")
                        {
                        delete();
                        }
                        Print();     
                    }

                    if (flagsave==true)
                              {
                              //  panel2.Visible = true;
                              //    panel2.BringToFront();
                              //     label20.Text = "Sending...............wait ";
                              //Classes.Common.SendSMS(DBConn,"Welcome", entryid, Convert.ToInt32(txtBranchID.Text));
                              //label20.Text = "Success............... ";
                              //   panel2.Visible = false;
                              Init();
                              return true;
                               }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }

        }
        public override bool ValidateControls()
        {
              base.ValidateControls();
              entryid = Convert.ToInt64(txtEntryid.Text);
              if (txtavailab.Text != "1")
              {
                  Gramboo.General.ShowMessage("Check your Employee Status");      
                  flagsave = false;
                  return false;
              }
              else
              {
                  flagsave = true;
                  return true;
              }

        }
      
        private void btnFindInvoice_Click(object sender, EventArgs e)
        {
            project.Forms.CRM.CustomerSearch a = new CRM.CustomerSearch();
            a.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(a);
            a.sendercontrols = Txtcustid;
            a.senderform = this;
            a.parentcontrols = Cmb_CustName;

            a.parentform = this;
            a.MdiParent = this.ParentForm;
            a.Focus();
        }

        private void dtpBookedFrom_ValueChanged(object sender, EventArgs e)
        {
            employeeavailable();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_CustName_SelectedValueChanged(object sender, EventArgs e)
        {
            //membershipdisplay();
            //custdetails();
        }
        public void MEMBSHIP(object sender, EventArgs e)
        {
            //double MEMPSHIP = 0;
            if (Cmb_CustName.SelectedValue != null && cmbServiceName.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select SALE.CheckMembership (" + Cmb_CustName.SelectedValue + "," + cmbServiceName.SelectedValue + "," + txtBranchID.Text + "," + txtcompId.Text + ",'" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "')")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtMeMpshipDisc.Text = (dt.Rows[0][0] == null ? "" : dt.Rows[0][0].ToString());
                    }
                    else
                    {
                        txtMeMpshipDisc.Text = "";

                    }
                }
            }
        }

        private void cmbseltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbseltype.SelectedIndex == 0)
            {
                Gramboo.General.Setupcombo(cmbServiceName, "SALE.Servicemaster", "ServiceName", "ServiceId", "IsActive='true'");
                txtSalestype.Text = "S";
                label1.Text = "Service Name";

            }
            else if (cmbseltype.SelectedIndex == 1)
            {
                Gramboo.General.Setupcombo(cmbServiceName, "SALE.PackageMaster", "PackageName", "EntryID", "IsActive='true'");
                txtSalestype.Text = "P";
                label1.Text = "Package Name";
            }
        }

        public void packagesel(object sender, EventArgs e)
        {
            if (cmbseltype.SelectedIndex == 1)
            {
                txtPrice.Clear();
                txtMeMpshipDisc.Clear();
            }
            if (cmbseltype.SelectedIndex == 1 && cmbServiceName.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select PackageName,Validity,LimFrom,LimTo,ActualPrice,Price from sale.vbillpack where EntryID=" + cmbServiceName.SelectedValue + " and Validity=1")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        double actpric, pri, discpri;
                        actpric = Convert.ToSingle(dt.Rows[0]["ActualPrice"].ToString());
                        pri = Convert.ToSingle(dt.Rows[0]["Price"].ToString());
                        discpri = (pri / actpric) * 100;
                        txtPrice.Text = (dt.Rows[0]["ActualPrice"] == null ? "" : dt.Rows[0]["ActualPrice"].ToString());
                        txtPackDisc.Text = discpri.ToString("f2");
                    }
                    else
                    {
                        using (DataTable dx = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select PackageName,Validity,LimFrom,LimTo,ActualPrice,Price from sale.vbillpack where EntryID=" + cmbServiceName.SelectedValue + " and Validity=0 and LimFrom>='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' and LimTo<='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' ")).Tables[0])
                        {
                            if (dx.Rows.Count > 0)
                            {
                                double actpric, pri, discpri;
                                actpric = Convert.ToSingle(dx.Rows[0]["ActualPrice"].ToString());
                                pri = Convert.ToSingle(dx.Rows[0]["Price"].ToString());
                                discpri = (pri / actpric) * 100;
                                txtPrice.Text = (dx.Rows[0]["ActualPrice"] == null ? "" : dx.Rows[0]["ActualPrice"].ToString());
                                txtPackDisc.Text = discpri.ToString("f2");
                            }
                            else
                            {
                                txtPrice.Text = "Unavailable";
                                txtPackDisc.Text = "Unavailable";
                            }
                        }

                    }
                    //txtPrice.Text = "";
                    //txtPackageDisc.Text = "";
                }


            }
        }
        public void servprcHair(object sender, EventArgs e)
        {

            if (cmbServiceName.SelectedValue != null && cmbHairType.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select Price from SALE.vbillserv where Serviceid=" + cmbServiceName.SelectedValue + " and HairTypeId=" + cmbHairType.SelectedValue + "")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        
                        txtPrice.Text = (dt.Rows[0]["Price"] == null ? "" : dt.Rows[0]["Price"].ToString());
                        //txtHairType.Text = (dt.Rows[0]["MembershipDisc"] == null ? "" : dt.Rows[0]["MembershipDisc"].ToString());
                    }
                    else
                    {
                         //txtPrice.Text = "";
                        cmbHairType.Text = "";
                        servipricex();
                        
                    }
                }
            }
            else if (cmbServiceName.SelectedValue != null && cmbseltype.SelectedIndex != 1)
            {
                using (DataTable dr = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select ServicePrice from SALE.Servicemaster where Serviceid=" + cmbServiceName.SelectedValue + "")).Tables[0])
                {
                    if (dr.Rows.Count > 0)
                    {
                        txtPrice.Text = (dr.Rows[0]["ServicePrice"] == null ? "" : dr.Rows[0]["ServicePrice"].ToString());
                        //txtMembershipDisc.Text = (dt.Rows[0]["MembershipDisc"] == null ? "" : dt.Rows[0]["MembershipDisc"].ToString());
                    }
                    else
                    {
                        txtPrice.Text = "";
                        cmbHairType.Text = "";
                    }
                }

            }

        }

        private void txtMembshipId_TextChanged(object sender, EventArgs e)
        {
            if (txtMembshipId.Text != "")
            {
                Gramboo.General.Setupcombo(cmbMembName, "ITM.MembershipTypeMaster", "MembName", "Entryid", "IsActive='true'");
                cmbMembName.SelectedValue = txtMembshipId.Text;
            }
            else
            {
                cmbMembName.Text = "";
            }
        }
        public void Totalamt(object sender, EventArgs e)
        {
            if (txtPrice.Text != "" && (txtMeMpshipDisc.Text != "" || txtPackDisc.Text != ""))
            {

                double pric, membdisc, packdisc, Amount;
                pric = Convert.ToSingle(txtPrice.Text == "" ? "0" : txtPrice.Text);
                membdisc = Convert.ToSingle(txtMeMpshipDisc.Text == "" ? "0" : txtMeMpshipDisc.Text);
                packdisc = Convert.ToSingle(txtPackDisc.Text == "" ? "0" : txtPackDisc.Text);
                if (membdisc != 0)
                {
                    Amount = pric-(pric * (membdisc / 100));
                }
                else if (packdisc != 0)
                {
                    Amount = pric-(pric * (packdisc / 100));
                }
                else
                {
                    Amount = pric;
                }
                txtTotal.Text = Amount.ToString("f2");
            }
        }
        public void membershipdisplay()
        {
            DateTime nerj;
            nerj = Convert.ToDateTime(grbDTBkDate.Value.ToString());
            if (Cmb_CustName.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select MembershipTypeId  from ITM.MembershipMaster where CustomerId=" + Cmb_CustName.SelectedValue + " AND LastvalidDate>='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "'")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtMembshipId.Text = (dt.Rows[0]["MembershipTypeId"] == DBNull.Value ? "" : dt.Rows[0]["MembershipTypeId"].ToString());
                    }
                    else
                    {
                        txtMembshipId.Text = "";
                    }
                }
            }
        }
        public void custdetails()
        {
           
            if (Cmb_CustName.SelectedValue != null  )
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select CustWhatsAppNo,CustTypeId from CRM.CustomerMaster where CustId=" + Cmb_CustName.SelectedValue + "")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtContPhone.Text = (dt.Rows[0]["CustWhatsAppNo"] == null ? "" : dt.Rows[0]["CustWhatsAppNo"].ToString());
                        Cmb_CustType.SelectedValue = (dt.Rows[0]["CustTypeId"] == null ? "" : dt.Rows[0]["CustTypeId"].ToString());
                    }
                    else
                    {
                        txtContPhone.Text = "";
                        Cmb_CustType.Text = "";
 

                    }
                }
                //txtContPhone.Enabled = false;
                //Cmb_CustType.Enabled = false;
 
            }
            else
            {
                txtContPhone.Text = "";
                Cmb_CustType.Text = "";
 
            }
        }

        private void cmbEmpName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbEmpName.SelectedValue != null)
            {
                empavailablegrd();
               // employeeavailable();
            }
        }
        public void employeeavailable()
        {
            if (cmbEmpName.SelectedValue != null)
            {
                using (DataTable dx = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select * from HR.LeaveEntry where StaffId=" + cmbEmpName.SelectedValue + " and FromDate<='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' and ToDate>='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' ")).Tables[0])
                {
                    if (dx.Rows.Count > 0)
                    {
                        label19.Text = "" + cmbEmpName.Text + " Is Leave";
                        label19.Font = new Font(label19.Font, FontStyle.Bold);
                        label19.ForeColor = System.Drawing.Color.Red;
                        txtavailab.Text = "";
                        flag = true;
                        //dgvavaillist.HiddenDataFields = new List<string>() { "Empid", "Branch_id", "Company_id", "Empid" };
                        dgvavaillist.DataFields = new List<string>() { "EmpName",  "Leavefrom", "leaveto" , "Reason"  };
                        dgvavaillist.Fill(new Table(project.Classes.Common.DbName, "SALE", "vbookingEmployeeLeave", true), "Company_id=" + txtcompId.Text + " and Branch_id=" + txtBranchID.Text + " and Empid=" + cmbEmpName.SelectedValue + " and Leavefrom<='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' and leaveto>='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' ");

                    }
                    else
                    {
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select leaveto,Leavefrom,BookingDate,BookedTimeFrom,BookedTimeTo,HalfDay,BookingNo,EmpName,leaveId from SALE.vbookingEmployeeAvai where Empid=" + cmbEmpName.SelectedValue + " and BookingDate='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "'  ")).Tables[0])
                    {
                        if (dt.Rows.Count > 0)
                        {
                            if (Convert.ToString(dt.Rows[0]["BookingNo"]) != null)
                            {
                                DateTime bookingtimeto, emplowktimeto, emplowktimefrom, bookingtimefrom;
                                emplowktimeto = Convert.ToDateTime(dt.Rows[0]["BookedTimeTo"].ToString());
                                emplowktimefrom = Convert.ToDateTime(dt.Rows[0]["BookedTimeFrom"].ToString());
                                bookingtimeto = Convert.ToDateTime(dtpBookedTo.Text);
                                bookingtimefrom = Convert.ToDateTime(dtpBookedFrom.Text);

                                if (bookingtimeto < emplowktimefrom)
                                {
                                    label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is Available";
                                    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    label19.ForeColor = System.Drawing.Color.Blue;
                                    txtavailab.Text = "1";
                                    //label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is available after " + (dt.Rows[0]["BookedTimeTo"] == DBNull.Value ? "" : dt.Rows[0]["BookedTimeTo"].ToString()) + "";
                                    //label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    //label19.ForeColor = System.Drawing.Color.Red;
                                }
                                else if (bookingtimefrom > emplowktimeto)
                                {
                                    //    label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is available after " + (dt.Rows[0]["BookedTimeTo"] == DBNull.Value ? "" : dt.Rows[0]["BookedTimeTo"].ToString()) + "";
                                    //    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    //    label19.ForeColor = System.Drawing.Color.Red;
                                    label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is Available";
                                    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    label19.ForeColor = System.Drawing.Color.Blue;
                                    txtavailab.Text = "1";
                                }
                                else
                                {
                                    label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is available after " + (dt.Rows[0]["BookedTimeTo"] == DBNull.Value ? "" : dt.Rows[0]["BookedTimeTo"].ToString()) + "";
                                    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    label19.ForeColor = System.Drawing.Color.Red;
                                    //label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is Available";
                                    //label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    //label19.ForeColor = System.Drawing.Color.Blue;
                                    txtavailab.Text = "";
                                }


                            }
                            if (txtavailab.Text != "")
                            {
                                //    label19.Text = "LEAVE";
                                //    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                //    label19.ForeColor = System.Drawing.Color.Red;
                                //}

                                if (Convert.ToString(dt.Rows[0]["HalfDay"]) == "1")
                                {
                                    label19.Text = "HalfDay";
                                    label19.Font = new Font(label19.Font, FontStyle.Bold);
                                    label19.ForeColor = System.Drawing.Color.Red;
                                    txtavailab.Text = "";
                                }
                                else
                                {
                                    label19.Text = "" + (dt.Rows[0]["EmpName"] == DBNull.Value ? "" : dt.Rows[0]["EmpName"].ToString()) + " is Available";
                                    txtavailab.Text = "1";
                                }
                            }
                        }
                        else
                        {
                            label19.Text = "" + cmbEmpName.Text + " is Available";
                            label19.Font = new Font(label19.Font, FontStyle.Bold);
                            label19.ForeColor = System.Drawing.Color.Blue;
                            txtavailab.Text = "1";
                        }
                    }
                }
            }
        }

        private void dtpBookedTo_ValueChanged(object sender, EventArgs e)
        {
            employeeavailable();
        }

        private void grbDTBkDate_ValueChanged(object sender, EventArgs e)
        {
            empavailablegrd();
            employeeavailable();
        }

        public void servipricex()
        {
            if (cmbServiceName.SelectedValue != null && cmbseltype.SelectedIndex != 1)
            {
                using (DataTable dr = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select ServicePrice from SALE.Servicemaster where Serviceid=" + cmbServiceName.SelectedValue + "")).Tables[0])
                {
                    if (dr.Rows.Count > 0)
                    {
                        txtPrice.Text = (dr.Rows[0]["ServicePrice"] == null ? "" : dr.Rows[0]["ServicePrice"].ToString());
                        //txtMembershipDisc.Text = (dt.Rows[0]["MembershipDisc"] == null ? "" : dt.Rows[0]["MembershipDisc"].ToString());
                    }
                    else
                    {
                        txtPrice.Text = "";
                        cmbHairType.Text = "";
                    }
                }

            } 
        }
        public override void Print()
        {
            base.Print();
            if (txtEntryid.Text != null)
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                //cr = new project.REPORTS.SALE.RptBookingMaster();
                Classes.Common.SetDatabaseLogon(cr, DBConn);
                cr.SetDatabaseLogon(DBConn.ConnectionProperties.DBUsername, DBConn.ConnectionProperties.DBPassword);
                cr.VerifyDatabase();
                cr.RecordSelectionFormula = "{VRptBookingMaster.EntryId}=" + txtEntryid.Text;
                // cr.PrintToPrinter(1, false, 1, 1);
                //Gramboo.Controls.GrbReport rpt = new Gramboo.Controls.GrbReport(cr);
                //rpt.MdiParent = this.MdiParent;
                //((frmMain)this.MdiParent).ShowChild(rpt);
                cr.PrintToPrinter(2, false, 1, 1);
            }
        }
        public void empavailablegrd()
        {
            if (cmbEmpName.SelectedValue != null)
            {
                panel1.Visible = true;
                dgvavaillist.DataSource = null;
                dgvavaillist.HiddenDataFields = new List<string>() { "Empid", "Branch_id", "Company_id", "Empid" };
                dgvavaillist.DataFields = new List<string>() { "EmpName", "BookingNo", "BookingDate", "BookedTimeFrom", "BookedTimeTo", "Empid", "Leavefrom", "leaveto", "HalfDay", "Reason", "leaveId", "Branch_id", "Company_id" };
                dgvavaillist.Fill(new Table(project.Classes.Common.DbName, "SALE", "vbookingEmployeeAvai", true), "Company_id=" + txtcompId.Text + " and Branch_id=" + txtBranchID.Text + " and Empid=" + cmbEmpName.SelectedValue + " and BookingDate='" + grbDTBkDate.Value.Date.ToString("dd-MMM-yyyy") + "' ");
                AdjustColumnsWidth();
            }
        }
        public void AdjustColumnsWidth()
        {
            //dgvList.Columns["Item Code"].Width = 130;
            dgvavaillist.Columns["EmpName"].Width = 130;
            dgvavaillist.Columns["BookingNo"].Width = 130;

            dgvavaillist.Columns["BookingDate"].Width = 130;
            //dgvList.Columns["Item Type"].Width = 130;
            //dgvList.Columns["Category Name"].Width = 130;
            //dgvList.Columns["Group Name"].Width = 130;
            //dgvList.Columns["Purity Name"].Width = 130;
            //dgvList.Columns["Purity Value"].Width = 130;
            //dgvList.Columns["Calculated On"].Width = 130;
            dgvavaillist.Columns["BookedTimeFrom"].Width = 100;
            dgvavaillist.Columns["BookedTimeTo"].Width = 125;
            //dgvavaillist.Columns["Last Modified By"].Width = 125;
            //dgvavaillist.Columns["Last Modified Date"].Width = 140;
            //dgvavaillist.Columns["Is Active"].Width = 75;
        }

        private void dgv_SummaryCalculated(object source, EventArgs e)
        {
            txttotalamnt.Text = dgv.SummaryRow.SummaryCells["Amount"].Text;
        }

        private void TxtbookingId_TextChanged(object sender, EventArgs e)
        {
            txtEntryid.Text = TxtbookingId.Text;
           
            frmbookingrep();
            employeeavailable();
        }

        public void frmbookingrep()
        {
            if (TxtbookingId.Text != "")
            {
                using (DataTable dt = DBConn.GetData(new SqlCommand("Select * from Sale.BookingMaster Where Entryid='" + TxtbookingId.Text + "'")).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {

                        //Cmb_CustName.Text = dt.Rows[0]["Customer Name"].ToString();
                        Cmb_CustName.SelectedValue = dt.Rows[0]["Custid"].ToString();
                        cmbHairType.SelectedValue = dt.Rows[0]["HairTypeId"].ToString();
                        cmbMembName.SelectedValue = dt.Rows[0]["Membshipid"].ToString();
                        txtContPhone.Text = dt.Rows[0]["PhoneNo"].ToString();
                        cmbEmpName.SelectedValue = dt.Rows[0]["Empid"].ToString();
                        cmb_VoucherTypeId.SelectedValue = dt.Rows[0]["VoucherTypeId"].ToString();
                        txtBookingNo.Text = dt.Rows[0]["BookingNo"].ToString();
                        grbDTBkDate.Value = Convert.ToDateTime(dt.Rows[0]["BookingDate"].ToString());
                        dtpBookedFrom.Value = Convert.ToDateTime(dt.Rows[0]["BookedTimeFrom"].ToString());
                        dtpBookedTo.Value = Convert.ToDateTime(dt.Rows[0]["BookedTimeTo"].ToString());


                        dgv.SummaryRowVisible = false;
                        dgv.HiddenDataFields = new List<string>() { "TransId", "EntryId", "Counter_id", "IsActive", "Serviceid", "Branch_id", "Company_id", "Last_modified_date", "Created_date", "Created_by", "Counter_id", "IsActive" };
                        dgv.DataFields = new List<string>() { "TransId", "EntryId", "Serviceid", "ServiceName", "Price", "MembershipDisc", "PackageDisc", "Amount", "Branch_id", "Company_id", "Last_modified_date", "Created_date", "Created_by", "Counter_id", "IsActive" };
                        dgv.Fill(new Table(project.Classes.Common.DbName, "SALE", "VBookingDetails", true), "Entryid='" + TxtbookingId.Text + "'", "TransId");
                        //dgv_advanceDetails .Fill(new Table(SAFA.Classes.Common.DbName, "SALE", "VAdvanceDetailsEst", true), "SalesID='" + cmbEstno.SelectedValue + "'", "Id");                     
                    }
                }
            }
            else
            {
                //   Init();
                Cmb_CustName.Text = "";
                cmbHairType.Text = "0";
                txtBookingNo.Text = "";
                cmbMembName.Text = "";
                txtContPhone.Text = "";
                //txtCustPAn.Text = "";
                //CmbManager.Text = "";
                cmb_VoucherTypeId.Text = "";
            }
        }
        public void delete()
        {
            if (TxtbookingId.Text != "0")
            {
                SqlConnection con = new SqlConnection(DBConn.ConnectionProperties.GenerateSQLConnectionString());
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from SALE.BookingMaster where  company_id=" + txtcompId.Text + " and branch_id=" + txtBranchID.Text
                    + " AND  EntryId =" + TxtbookingId.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                Gramboo.General.ShowMessage("Retake Completed");
         
            }
        }

        private void Butcust_Click(object sender, EventArgs e)
        {
            project.Forms.CRM.CustomerMasterr um = new CRM.CustomerMasterr();
            um.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(um);
            um.sendercontrols = Txtcustid;
            um.senderform = this;
            um.parentcontrols = Cmb_CustName;
            um.parentform = this;
            um.MdiParent = this.ParentForm;
            um.Focus();
        }

        private void Txtcustid_TextChanged(object sender, EventArgs e)
        {
            if (Txtcustid.Text != "")
            {
                Gramboo.General.Setupcombo(Cmb_CustName, "CRM.CustomerMaster", "CustName", "CustId", "IsActive='true'");
                Cmb_CustName.SelectedValue= Txtcustid.Text ;
            }
        }

        private void Cmb_CustName_Validating(object sender, CancelEventArgs e)
        {
            membershipdisplay();
            custdetails();
        }

        private void txttotalamnt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
