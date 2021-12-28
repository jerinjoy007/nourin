using Gramboo.Database;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Gramboo;

namespace project.Forms.STOCK
{
    public partial class DepartmentOpeningStkEntry : Gramboo.Controls.GrbForm
    {

      private static DepartmentOpeningStkEntry instance;
      private DataController dc = new DataController();
      public static DepartmentOpeningStkEntry Instance
      {

          get
          {
              if (instance == null)
              {
                  instance = new DepartmentOpeningStkEntry();
              }
              else if (instance.IsDisposed)
              {
                  instance = new DepartmentOpeningStkEntry();
              }
              return instance;
          }
      }
        public DepartmentOpeningStkEntry()
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
        public override bool FillData(Dictionary<string, object> PrimaryValues)
        {
            if (base.FillData(PrimaryValues))
            {
                AdjustColumnWidths();
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "STK", "DepartmentOpeningStockMaster");
            t.PrimaryKeys.Add("EntryId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.NotUpdatables.Add("Batchid");
            t.IdTextBox = txtEntryNo;
            Table t1 = new Table(project.Classes.Common.DbName, "STK", "DepartmentOpeningStockDetails", true);
            t1.PrimaryKeys.Add("TransId");
            t1.FillView = new Table(project.Classes.Common.DbName, "STK", "VDepartmentOpeningStockDetails");
            t1.DatagridView = dgv;
            t1.IsDatagridView = true;
            t1.IdTextBox = TxtTranscId;
            t.ChildTables.Add(t1);
            this.TableName = t;
            return true;
        }
        public override void Init()
        {

            base.Init();
            TxtIsactive.Text = "1";
            Cmb_ItemName.SelectedIndex = -1;
            cmbFloorname.Text = "";
            TxtNos.Text = "";
            rbtSale.Checked = true;
            dgv.DataFields = new List<string>() { "EntryId", "TransId", "UnitId", "ItemID", "[Item Name]", "BatchNo", "ExperDate", "[Unit Name]", "Qty", "MRP", "PurchaseCost" };
            dgv.HiddenDataFields = new List<string>() { "UnitId", "EntryId", "TransId" , "ItemID" };
            dgv.SummaryColumns = new string[] { "Qty" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "STK", "VDepartmentOpeningStockDetails", true), "1=2");
            dgv.Columns["col_AutoSlno"].DataPropertyName = "SlNo";
            AdjustColumnWidths();
            this.ListForm = DepartmentOpeningStkEntryList.Instance;
            Cmb_DepartmentName.Focus();

            if (this.TableName != null)
                GenerateID(this.TableName);
            Cmb_DepartmentName.SelectedValue = 11010001;
        }
        public override void RefreshData()
        {
           
            base.RefreshData();
          
            Gramboo.General.Setupcombo(cmb_VoucherTypeId, "ACC.VoucherTypeMaster", "VoucherTypeName", "VoucherTypeId", "IsActive='True'");
            cmb_VoucherTypeId.SelectedValue = (int)project.Classes.VoucherTypes.DepartmentOpeningStockMaster;
            if (!IsEditMode)
                TxtVoucherNo.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, Dtp_dt.Value,
             DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));
           // Gramboo.General.Setupcombo(Cmb_DepartmentName, "SYST.VUserDepartmentAccess", "DeptName", "DeptID", "AllowAccess='True' AND user_id=" + txtCrUserId.Text + " AND Company_id=" + txtcompId.Text);      
           Gramboo.General.Setupcombo(Cmb_DepartmentName, "STK.DepartmentMaster", "DeptName", "DeptID", "IsActive='True'AND Company_id=" + txtcompId.Text + "AND Branch_id=" + txtBranchID.Text);

           //Gramboo.General.Setupcombo(cmb_ModelName, "ITM.VModelMaster", "[Model Name]", "ModelId", "[Is Active]='True' AND Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text);
           Gramboo.General.Setupcombo(Cmb_ItemName, "ITM.VItemMaster", "[Item Name]", "ItemId"   );
           //Gramboo.General.Setupcombo(cmb_Purity, "ITM.VPurityMaster", "[Purity Name]", "PurityId", "[Is Active]='True'");
           Gramboo.General.Setupcombo(cmbFloorname, "ITM.UnitofMeasuremet", "UnitName", "EntryID", "IsActive='True'AND Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text);


        }
        private void AdjustColumnWidths()
        {
          
            dgv.RowHeadersVisible = false;
            dgv.Columns[0].Width = 45;
            dgv.Columns["Item Name"].Width = Cmb_ItemName.Width + 2;
            dgv.Columns["Qty"].Width = TxtNos.Width + 2;


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Int64 floorid=0;
            if (dgv.ValidateControls())
            {

                if (cmbFloorname.SelectedValue != null)
                {
                    txtfloorid.Text = cmbFloorname.SelectedValue.ToString();

                }

                if (Cmb_ItemName.SelectedValue != null)
                {

                    txtitemid.Text = Cmb_ItemName.SelectedValue.ToString();
                     
                   
                }
                if (Cmb_ItemName.SelectedValue != null )
                {
                    using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand
                     ("Select HasExp FROM itm.ItemMaster where  ItemId=" + Cmb_ItemName.SelectedValue + "")).Tables[0])
                    {
                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["HasExp"].ToString() == "0")
                            {
                                if (txtProdCode.Text == "")
                                {
                                    txtProdCode.ShowMessage("Enter The Batch Number");

                                }
                                else
                                {
                                    dgv.Save();
                                }
                            }
                            else
                            {
                                dgv.Save();
                            }
                        }
                    }
                }             
               
            }

        }



        public override void Print()
        {

            if (txtEntryNo.Text != "")
            {
                CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
               // cr = new SALON.REPORTS.STOCK.DepartmentOpeningStkPrintReport();
                cr.SetDatabaseLogon(DBConn.ConnectionProperties.DBUsername, DBConn.ConnectionProperties.DBPassword);
                cr.VerifyDatabase();
                cr.RecordSelectionFormula = "{VDepartmentOpeningStkReport.EntryId} =" + txtEntryNo.Text;

                cr.SetParameterValue("@Printed By", txtUserName.Text);
                cr.SetParameterValue("@IsContinues", false);
                Gramboo.Controls.GrbReport rpt = new Gramboo.Controls.GrbReport(cr);

                rpt.MdiParent = this.MdiParent;

                ((frmMain)this.MdiParent).ShowChild(rpt);

            }
        }
        public void adjustcolumnwidth()
        {
 
        }
        private void cmb_Purity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtplwt_TextChanged(object sender, EventArgs e)
        {
            //calculateNetwt();
        }
        public override bool Save()
        {

            if (base.Save())
            { 
                foreach(DataGridViewRow row in dgv.Rows)
                {

                    if (row.Cells["BatchNo"].Value.ToString() != "")// && Cmb_ItemName.SelectedValue != null)
                    {
                      
                            SqlConnection con = new SqlConnection(DBConn.ConnectionProperties.ConnectionString);
                            SqlCommand cmd = new SqlCommand("SALE.GenerateBatchidOpening", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            con.Open();
                            cmd.Parameters.AddWithValue("@Entryid", row.Cells["TransId"].Value.ToString());
                            cmd.Parameters.AddWithValue("@ItemId", row.Cells["ItemID"].Value.ToString());
                            cmd.Parameters.AddWithValue("@CompanyId", txtcompId.Text);
                            cmd.Parameters.AddWithValue("@BranchId", txtBranchID.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                       
                        
                    }
                }

                Init();
                return true;

            }

            else
            {
                return false;
            }
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && dgv.CurrentCell.OwningColumn.DisplayIndex == dgv.Columns.Count - 1)
            {
                if (dgv.Rows.Count > 0)
                {
                    if (dgv.Rows[dgv.Rows.Count - 1].Cells["ItemID"].Value.ToString() != "")// &&
                        //dgv_SalesDetails.Rows[dgv_SalesDetails.Rows.Count - 1].Cells["Gwt"].Value.ToString() != "" &&
                        //dgv_SalesDetails.Rows[dgv_SalesDetails.Rows.Count - 1].Cells["Type"].Value.ToString() != "")
                    {
                        ((System.Data.DataTable)dgv.DataSource).Rows.Add(((System.Data.DataTable)dgv.DataSource).NewRow());
                        dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        dgv.CurrentCell = dgv.Rows[dgv.Rows.Count - 1].Cells["Item Name"];
                        e.Handled = true;
                        dgv.BeginEdit(false);
                        //Cmb_ItemName.DroppedDown = true;  
                        //dgv_SalesDetails.Focus();
                        // SetComboLocation(dgv_SalesDetails, Cmb_ProdCode_SDtl, dgv_SalesDetails.CurrentCell.OwningColumn.Index, dgv_SalesDetails.CurrentCell.RowIndex);
                    }
                }
            }
        }

        private void Cmb_ItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            Itemchange();
        }
        private void Itemchange()
        {
            if (Cmb_ItemName.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select  [Unit Name], UnitofMstmtid  from ITM.VItemMaster where ItemId=" + Cmb_ItemName.SelectedValue + "  ")).Tables[0])
                {
                    string unitid, unitname, taxper, brandname;
                    double id;
                    unitid = Convert.ToString(dt.Rows[0]["UnitofMstmtid"] == null ? "" : dt.Rows[0]["UnitofMstmtid"].ToString());
                    unitname = Convert.ToString(dt.Rows[0]["Unit Name"] == null ? "" : dt.Rows[0]["Unit Name"].ToString());

                    if (dt.Rows.Count > 0)
                    {
                        cmbFloorname.SelectedValue= unitid.ToString();
                        cmbFloorname.Text = unitname.ToString();
                        TxtNos.Text = 1.ToString();
                    }
                }
            }
        }
    }
}
