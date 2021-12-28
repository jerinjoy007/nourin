using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gramboo.Database;
using System.Data.SqlClient;
namespace project.Forms.CRM
{
    public partial class CustomerMasterr : Gramboo.Controls.GrbForm
    {
        private static CustomerMasterr instance;

        public Gramboo.Controls.GrbForm parentform { get; set; }
        public Gramboo.Controls.GrbComboBox parentcontrols { get; set; }
        public static CustomerMasterr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerMasterr();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CustomerMasterr();
                }
                return instance;
            }
        }
        public Gramboo.Controls.GrbForm senderform { get; set; }
        public Control sendercontrols { get; set; }
        public CustomerMasterr()
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

        public override void RefreshData()
        {
            base.RefreshData();
            Gramboo.General.Setupcombo(cmb_VoucherTypeId, "ACC.VoucherTypeMaster", "VoucherTypeName", "VoucherTypeId", "IsActive='True'");

            cmb_VoucherTypeId.SelectedValue = 68;
            if (txtBranchID.Text != "")
            {
                if (!IsEditMode)
                    txtcode.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, dtpRegDate.Value,

                        DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));
            }
           Gramboo.General.Setupcombo(cmbCustType, "SCH.Main_Scheme", "MainSchemeName", "MainSchemeId", "IsActive='True'");
            Gramboo.General.Setupcombo(cmbCustGroup, "SCH.Additional_Scheme", "AddSchemeName", "AddSchemeId", "IsActive='True'");
            //Gramboo.General.Setupcombo(cmbCountry, "GEN.CountryMaster", "CountryName", "CountryId");
            Gramboo.General.Setupcombo(cmbStateId, "GEN.StateCodeMaster", "StateName", "StateID");
            //Gramboo.General.Setupcombo(cmbDistrict, "GEN.DistrictMaster", "DistrictName", "DistrictId", "IsActive=1" + (cmbState.SelectedValue != null ? " AND StateID=" + cmbState.SelectedValue : ""));
            //Gramboo.General.Setupcombo(cmbLedger, "ACC.LedgerMaster", "Acc_LedgerName", "Acc_LedgerId", "IsActive=1");
            Gramboo.General.Setupcombo(cmbAge, "GEN.AgeGroupMaster", "AgeGroupName", "Entryid", "IsActive='True'");
            //Gramboo.General.Setupcombo(cmbPreSerPro, "SALE.Servicemaster", "ServiceName", "ServiceId", "IsActive='True'");
            using (System.Data.DataTable dt = DBConn.GetData(new SqlCommand
             ("SELECT t2.StateId, t2.Statecode FROM SYST.CompanyMaster t1,GEN.StateCodeMaster t2 WHERE t1.Statecode=t2.Stateid And Company_id =" + txtcompId.Text)).Tables[0])
            {
                if (dt.Rows.Count > 0)
                {
                    //cmbState.SelectedValue = (dt.Rows[0]["StateId"] == DBNull.Value ? "" : dt.Rows[0]["StateId"].ToString());
                    
                }

            }
            if (this.txtcompId.Text.Trim() != "")
            {
                //Gramboo.General.Setupcombo(cmbCompany, "SYST.CompanyMaster", "Comp_Name", "Comp_Id", "IsActive=1 AND Comp_id <> " + Convert.ToInt16(this.txtcompId.Text) + " ");
                //Gramboo.General.Setupcombo(cmbLedger, "ACC.LedgerMaster", "Acc_LedgerName", "Acc_LedgerId", "IsActive=1 AND Company_id = " + Convert.ToInt16(this.txtcompId.Text));
                //new FA.AccountsHelper().LoadLedgerCombo(cmbLedger, this.DBConn, FA.MasterPageLedgerGroup.CustomerMaster, this.txtcompId.Text, this.txtBranchID.Text);
                //cmbLedger.SelectedIndex = -1;
            }
            //if (sjoin != null)
            //{
            //  //  sjoin.Cmb_CustName.Text = txtCustomerName.Text;
            //  //  sjoin.Cmb_CustName.SelectedValue = txtCustId.Text;   
            // //   sjoin.Cmb_CustName.DisplayMember = txtCustomerName.Text;
            //   // sjoin.Cmb_CustName.ValueMember = txtCustId.Text;  
            //    //sjoin.Cmb_CustName.SelectedValue = txtCustId.Text;   
            //   // s.txt_OldGoldReceipt.Text = txtTotAmount.Text;
            //  //  s.txt_OldGoldReceipt.Tag = TxtEntryNo.Text;
            //  //  txtSalesID.Text = s.TxtSaleId.Text;
            //}

        }
        //public override bool ValidateControls()
        //{
        //    if (sjoin != null)
        //    {
        //        sjoin.Cmb_CustName.Text = txtCustomerName.Text;
        //        sjoin.Cmb_CustName.SelectedValue = txtCustId.Text;   
        //    }

        //    return base.ValidateControls();
        //}


        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "CRM", "CustomerMaster");
            t.PrimaryKeys.Add("CustId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtCustId;

            this.TableName = t;
            return true;
            

        }
        public override void Init()
        {
            base.Init();
          
            txtCustomerName.Focus();
            rbtMale.TabStop = true;
            this.ListForm = CustomerMasterList.Instance;
            chkISActive.Checked = true;
            cmbStateId.SelectedValue = 18;
            //btnAddLedger.GrpId = new FA.AccountsHelper().GetGroupHierarchy(this.DBConn,FA.MasterPageLedgerGroup.CustomerMaster, this.txtcompId.Text, this.txtBranchID.Text);
            //cmbLedger.SelectedIndex = -1;
            //if (SJoin != null)
            //{
            //    SJoin.Cmb_CustName.DisplayMember = txtCustomerName.Text;
            //   // SJoin. 
            //}
        }

        private void cmbCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbCountry.ValueMember != "" && cmbCountry.SelectedValue != null)
                //Gramboo.General.Setupcombo(cmbState, "GEN.StateMaster", "StateName", "StateId", "IsActive=1" + (cmbCountry.SelectedValue != null ? " AND CountryID=" + cmbCountry.SelectedValue : ""));

        }

        private void cmbState_SelectedValueChanged(object sender, EventArgs e)
        {

            //if (cmbState.ValueMember != "" && cmbState.SelectedValue != null)
                //Gramboo.General.Setupcombo(cmbDistrict, "GEN.DistrictMaster", "DistrictName", "DistrictId", "IsActive=1" + (cmbState.SelectedValue != null ? " AND StateID=" + cmbState.SelectedValue : ""));

        }

        private void cmbLedger_DropDown(object sender, EventArgs e)
        {
            //Gramboo.General.Setupcombo(cmbLedger, "ACC.LedgerMaster", "Acc_LedgerName", "Acc_LedgerId", "IsActive=1 AND Company_id = " + Convert.ToInt16(this.txtcompId.Text));
            //new FA.AccountsHelper().LoadLedgerCombo(cmbLedger, this.DBConn, FA.MasterPageLedgerGroup.CustomerMaster, this.txtcompId.Text, this.txtBranchID.Text);
        }

        private void CustomerMasterr_Load(object sender, EventArgs e)
        {

        }

        private void btnAddLedger_AfterAddLedger(object sender, FA.LedgerControl.AddLegerArgs e)
        {
            //new FA.AccountsHelper().LoadLedgerCombo(cmbLedger, this.DBConn, FA. MasterPageLedgerGroup.CustomerMaster, this.txtcompId.Text, this.txtBranchID.Text);
            //cmbLedger.SelectedValue = e.LedgerId;
            //cmbLedger.Select();
        }

        private void btn_Type_Click(object sender, EventArgs e)
        {
            project.Forms.CRM.CustomerTypeMaster frm = new CustomerTypeMaster();
            frm.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(frm);
            frm.sendercontrols = txtCustTypeId;
            frm.senderform = this;
            frm.parentcontrols = cmbCustType;
            frm.parentform = this;
            frm.MdiParent = this.ParentForm;
            frm.Focus();
        }

        private void grbButton1_Click(object sender, EventArgs e)
        {
            project.Forms.CRM.CustomerGroupMaster rm = new CustomerGroupMaster();
            rm.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(rm);
            rm.sendercontrols = txtCustGrpId;
            rm.senderform = this;
            rm.parentcontrols = cmbCustGroup;
            rm.parentform = this;
            rm.MdiParent = this.ParentForm;
            rm.Focus();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            // //using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand
            //       ("select StateCode from GEN.StateCodeMaster where StateName='"
            //       //+ cmbState.Text+ "'")).Tables[0])
            //if (dt.Rows.Count>0)
            //{
            //    //txtstatecode.Text = (dt.Rows[0]["StateCode"] == DBNull.Value ? "" : dt.Rows[0]["StateCode"].ToString());
            //}
        }

        private void grbRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnAgeGrp_Click(object sender, EventArgs e)
        {
            project.Forms.GENERALFORMS.AgeGrpMaster a = new GENERALFORMS.AgeGrpMaster();
            a.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(a);
            a.sendercontrols = txtAgeGrpId;
            a.senderform = this;
            a.parentcontrols = cmbAge;
            a.parentform = this;
            a.MdiParent = this.ParentForm;
            a.Focus();

            
        }

        private void cmbAge_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            project.Forms.EMP.EmployeeMaster sm = new EMP.EmployeeMaster();
            sm.MdiParent = this.ParentForm;
            ((frmMain)this.ParentForm).ShowChild(sm);
            sm.sendercontrols = txtSerProvId;
            sm.senderform = this;
            sm.parentcontrols = cmbPreSerPro;

            sm.parentform = this;
            sm.MdiParent = this.ParentForm;
            sm.Focus();
        }
        private void grbCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkanndate.Checked == true)
            {
                dtpAvsyDate.Enabled = true; 
            }
            else
            {
                dtpAvsyDate.Enabled = false;
            }
        }
        private void cmbCustType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TxtEntryID_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtEntryID.Text != "")
            {
                Gramboo.General.Setupcombo(cmbAge, "GEN.AgeGroupMaster", "AgeGroupName", "Entryid", "IsActive='True'");
                cmbAge.SelectedValue = TxtEntryID.Text.ToString();
            }
        }
        public override bool Save()
        {
            if (base.Save())
            {
                //SqlCommand cmd = new SqlCommand();
              //  cmd.CommandText = "[ACC].[ProcCreateCustomerLedger]";
               // cmd.CommandType = CommandType.StoredProcedure;
                //connectionstring.Open(); 
                //cmd.Parameters.AddWithValue("@CustID", txtCustId.Text);
                //cmd.Parameters.AddWithValue("@CompanyId", txtcompId.Text);
                //cmd.Parameters.AddWithValue("@BranchId", txtBranchID.Text);
                //DBConn.ExecuteSqlTransaction(cmd, "CustLedger");
                if (sendercontrols != null)
                {
                    Gramboo.Controls.GrbTextBox cmb = new Gramboo.Controls.GrbTextBox();
                    cmb = (Gramboo.Controls.GrbTextBox)sendercontrols;
                    cmb.Text = txtCustId.Text;
                    // SenderForm.RefreshData();
                    senderform.Focus();
                    ParentForm.Focus();
                    this.Close();
                    this.Dispose();
                }
                if (parentcontrols != null)
                {

                    parentform.Show();
                    parentform.Focus();
                    this.Close();

                }
                else
                {
                    Init();
                }
                    return true;
                 
            }

            else
            {
                return false;
            }
            
        }

        private void chkanndate_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCustTypeId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustTypeId.Text!="")
            {
                Gramboo.General.Setupcombo(cmbCustType, "CRM.CustomerTypeMaster", "CustTypeName", "CustTypeId", "IsActive='True'");
                cmbCustType.SelectedValue = txtCustTypeId.Text;
            }
        }

        private void txtSerProvId_TextChanged(object sender, EventArgs e)
        {
            if (txtSerProvId.Text != "")
            {
                Gramboo.General.Setupcombo(cmbPreSerPro, "EMP.EmployeeMaster", "EmpName", "EmpId", "IsActive='True'");
                cmbPreSerPro.SelectedValue = txtSerProvId.Text;
            }
        }

        private void txtCustGrpId_TextChanged(object sender, EventArgs e)
        {
            if (txtCustGrpId.Text != "")
            {
                Gramboo.General.Setupcombo(cmbCustGroup, "CRM.CustomerGroupMaster", "CustGroupName", "CustGroupId", "IsActive='True'");
                cmbCustGroup.SelectedValue = txtCustGrpId.Text;
            }
        }

        private void txtAgeGrpId_TextChanged(object sender, EventArgs e)
        {
            if (txtAgeGrpId.Text != "")
            {
                Gramboo.General.Setupcombo(cmbAge, "GEN.AgeGroupMaster", "AgeGroupName", "Entryid", "IsActive='True'");
                cmbAge.SelectedValue = txtAgeGrpId.Text;
            }
        }

        
    }
}
