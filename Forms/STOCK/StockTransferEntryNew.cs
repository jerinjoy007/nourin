using Gramboo.Database;
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
    public partial class StockTransferEntryNew : Gramboo.Controls.GrbForm
    {
        private int SaleCurrentRow = -1;
        private bool FillFlag = false;
        private bool CalcFlag = false;
        private bool flag;
        private int _vchtype = 15;
        [Browsable(false)]
        [DefaultValue(15)]
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
        public StockTransferEntryNew(int vouchetype)
        {
            InitializeComponent();
            VoucherType = vouchetype;
        }
        public override bool GenerateID(Table table_name)
        {
            try
            {
                table_name.IdTextBox.Text = project.Classes.Common.GetNextID(table_name, table_name.IdTextBox.DataField, DBConn, Convert.ToInt32(base.txtcompId.Text), Convert.ToInt32(base.txtBranchID.Text)).ToString();
                cmb_VoucherTypeId.SelectedValue = VoucherType;
                string vtypename = "";
                vtypename = (DBConn.GetData(new System.Data.SqlClient.SqlCommand("select * FROM Acc.VoucherTypeMaster WHERE VoucherTypeId=" + VoucherType + "")).Tables[0].Rows[0]["VoucherTypeName"]).ToString();
                this.Text = "" + vtypename + "";

                if (!IsEditMode)
                    TxtVoucherNo.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, dtp_dt.Value,
                DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool FillData(Dictionary<string, object> PrimaryValues)
        {
            FillFlag = true;
            if (base.FillData(PrimaryValues))
            {
                FillFlag = false;
                foreach (DataGridViewRow r in dgv_itemDetails.Rows)
                {
                    if (r.Cells["Batchid"].Value.ToString().Length > 3)
                    {
                        
                        break;
                    }
                }
                return true;

            }
            else
            {
                FillFlag = false;
                return false;
            }
        }
        private void LoadProdCodes()
        {
            SqlCommand cmd = new SqlCommand();
            if (txtcompId.Text == "")
                return;
            Cmb_ProdCode.Visible = false;
            if (txtEntryNo.Text.Trim().Length > 0)
            {
                cmd.CommandText = "SELECT BatchNo,Batchid FROM  [STK].[WatchStatus]('" + txtDeptName.Text + "'," + (Cmb_FloorName.SelectedValue == null ? "0" : Cmb_FloorName.SelectedValue) + ",'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "'," + txtcompId.Text + "," + txtBranchID.Text + ") "
                    + " UNION SELECT BatchNo,Batchid FROM SALE.BatchMaster WHERE EXISTS (select Batchid FROM STK.StockTransferDetails WHERE EntryId=" + txtEntryNo.Text + "  AND STK.StockTransferDetails.Batchid=SALE.BatchMaster.Batchid) Order By BatchNo";
            }
            else
            {
                cmd.CommandText = "SELECT BatchNo,Batchid FROM  [STK].[WatchStatus]('" + txtDeptName.Text + "'," + (Cmb_FloorName.SelectedValue == null ? "0" : Cmb_FloorName.SelectedValue) + ",'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "'," + txtcompId.Text + "," + txtBranchID.Text + ")  Order By ProdCode";
                //" + txtBranchID.Text + "," + (Cmb_DepartmentName.SelectedValue == null ? "0" : Cmb_DepartmentName.SelectedValue) + "
            }

            Cmb_ProdCode.DisplayMember = "BatchNo";
            Cmb_ProdCode.ValueMember = "Batchid";

            Cmb_ProdCode.DataSource = DBConn.GetData(cmd, "BatchNo").Tables[0];
            //Cmb_ProdCode.Visible = true;
        }
        public override void RefreshData()
        {
            base.RefreshData();

            Gramboo.General.Setupcombo(cmb_VoucherTypeId, "ACC.VoucherTypeMaster", "VoucherTypeName", "VoucherTypeId", "IsActive='True'");
            cmb_VoucherTypeId.SelectedValue = VoucherType;
            string vtypename = "";
            vtypename = (DBConn.GetData(new System.Data.SqlClient.SqlCommand("select * FROM Acc.VoucherTypeMaster WHERE VoucherTypeId=" + VoucherType + "")).Tables[0].Rows[0]["VoucherTypeName"]).ToString();
            this.Text = "" + vtypename + "";

            if (!IsEditMode)
                TxtVoucherNo.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, dtp_dt.Value,
            DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));




            //Gramboo.General.Setupcombo(Cmb_ProdCode, "SALE.BatchMaster", "BatchNo", "Batchid");
            Gramboo.General.Setupcombo(Cmb_FloorName, "ITM.UnitofMeasuremet", "UnitName", "EntryID", "IsActive='True'AND Company_id=" + txtcompId.Text + " AND Branch_id=" + txtBranchID.Text);
            if (Cmb_FloorName.Items.Count == 1)
                Cmb_FloorName.SelectedIndex = 0;
            Gramboo.General.Setupcombo(Cmb_ItemName, "ITM.ItemMaster", "[ItemName]", "ItemId", "[IsActive]='True'");
            Gramboo.General.Setupcombo(Cmb_SupplierName, "EMP.EmployeeMaster", "EmpName", "EmpId", "IsActive='True' AND  Company_Id=" + txtcompId.Text);
            //Gramboo.General.Setupcombo(Cmb_Description, "STK.StockTransferCharges", "Description", "", "[IsActive]='True'");
            if (dgv_itemDetails.NewRowIndex > -1)
            {
                dgv_itemDetails.CurrentCell = dgv_itemDetails.Rows[dgv_itemDetails.NewRowIndex].Cells["BatchNo"];
                dgv_itemDetails.BeginEdit(true);
            }

            cmb_purity.Visible = false;
            txtDeptName.Text = Convert.ToString(((frmMain)this.ParentForm).dept);
            if (Cmb_FloorName.SelectedValue != null)
            {
                // LoadProdCodes();
            }
            else
            {
                Cmb_ProdCode.Text = "";
            }
        }
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "STK", "StockTransferMaster");
            t.PrimaryKeys.Add("EntryId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtEntryNo;
            Table t1 = new Table(project.Classes.Common.DbName, "STK", "StockTransferDetails", true);
            t1.PrimaryKeys.Add("TransId");
            t1.FillView = new Table(project.Classes.Common.DbName, "STK", "VStockTransferDetails");
            t1.DatagridView = dgv_itemDetails;
            t1.IsDatagridView = true;
            t1.IdTextBox = TxtTranscId;
            t.ChildTables.Add(t1);
            Table t2 = new Table(project.Classes.Common.DbName, "STK", "StockTransferCharges", true);
            t1.PrimaryKeys.Add("TransId");
            t2.FillView = new Table(project.Classes.Common.DbName, "STK", "StockTransferCharges", true);
            t2.DatagridView = dgv_OtherCharges;
            t2.IsDatagridView = true;
            t2.IdTextBox = TxtTranscId;
            t.ChildTables.Add(t2);


            this.TableName = t;
            return true;
        }
        public override void Init()
        {
            base.Init();
            this.ListForm = new StockTransferList(VoucherType);
            TxtIsactive.Text = "1";
            dgv_itemDetails.IsDataEntryGrid = true;
            dgv_itemDetails.DataFields = new List<string> { "EntryId","TransId", "ItemID", "Batchid", "[Item Name]","BatchNo", "ExperDate","UnitName" ,"ItemUnitId",
               "Qty","Amount","ItemRemarks","[Is Receipt]" };
            dgv_itemDetails.HiddenDataFields = new List<string> { "EntryId", "TransId" , "ItemID", "Batchid","ItemUnitId",  
            "Is Receipt" };
            dgv_itemDetails.SummaryColumns = new string[] { "Qty", "Amount" };
            dgv_itemDetails.Fill(new Table(project.Classes.Common.DbName, "STK", "VStockTransferDetails", true), "1=2");
            dgv_itemDetails.Columns["col_AutoSlno"].DataPropertyName = "SlNo";


            Cmb_ProdCode.Visible = false;
            CalcFlag = true;

            dgv_itemDetails.RowTemplate.Height = Cmb_ProdCode.Height;
            ((System.Data.DataTable)dgv_itemDetails.DataSource).Rows.Add(((System.Data.DataTable)dgv_itemDetails.DataSource).NewRow());
            dgv_itemDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //dgv_itemDetails.CurrentCell = dgv_itemDetails.Rows[0].Cells["Item Name"];
            dgv_itemDetails.BeginEdit(true);
            AdjustColumnWidths();

            dgv_OtherCharges.SummaryRowVisible = true;
            dgv_OtherCharges.DataFields = new List<string>() { "TransId", "EntryId", "Description", "ChargeAmount" };
            dgv_OtherCharges.HiddenDataFields = new List<string>() { "TransId", "EntryId" };
            dgv_OtherCharges.SummaryColumns = new string[] { "ChargeAmount" };
            dgv_OtherCharges.Fill(new Table(project.Classes.Common.DbName, "STK", "StockTransferCharges", true), "1=2");
            dgv_OtherCharges.Columns["col_AutoSlno"].DataPropertyName = "SlNo";
            AdjustColumnWidthsOther();


           
            if (this.TableName != null)
                GenerateID(this.TableName);
            CalcFlag = false;
            SaleCurrentRow = -1;
           // this.btnAddNewSupplier.MasterForm = SALON.Forms.PUR.SupplierMaster.Instance;
           // this.btnAddNewSupplier.ParentForm = new SALON.Forms.STOCK.StockTransferEntryNew(15);
            this.btnAddNewSupplier.ParentControl = Cmb_SupplierName;
            dgv_itemDetails.CurrentRow.Cells["ExperDate"].Value = grbDTPicker1.Value.ToString("dd/MMM/yyyy");
        }
        private void AdjustColumnWidths()
        {
            dgv_itemDetails.RowHeadersVisible = false;
            dgv_itemDetails.Columns[0].Width = 40;
            dgv_itemDetails.Columns["Item Name"].Width = Cmb_ItemName.Width;
            dgv_itemDetails.Columns["Qty"].Width = 40;
            dgv_itemDetails.Columns["ItemRemarks"].Width = 140;
            dgv_itemDetails.Columns["Amount"].Width = 110;
            dgv_itemDetails.Columns["Item Name"].ReadOnly = true;

            foreach (DataGridViewRow r in dgv_itemDetails.Rows)
            {
                if (Cmb_FloorName.SelectedValue != null)
                {
                    r.Cells["ItemUnitId"].Value = Cmb_FloorName.SelectedValue;
                    r.Cells["UnitName"].Value = Cmb_FloorName.Text;
                }
            }

        }


        public void AdjustColumnWidthsOther()
        {
            dgv_OtherCharges.Columns[0].Width = 40;
            dgv_OtherCharges.Columns["Description"].Width = Cmb_Description.Width + 5;
            dgv_OtherCharges.Columns["ChargeAmount"].Width = txtChargeAmount.Width + 5;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_itemDetails.CurrentCell != null)
            {
                if (dgv_itemDetails.SelectedCells.Count > 0)
                {
                    SaleCurrentRow = dgv_itemDetails.SelectedCells[0].RowIndex;

                    if (dgv_itemDetails.SelectedCells[0].OwningColumn.DataPropertyName == "Item Name")
                    {
                        SetComboLocation(dgv_itemDetails, Cmb_ItemName, dgv_itemDetails.CurrentCell.ColumnIndex, dgv_itemDetails.CurrentCell.RowIndex);
                    }
                    else if (dgv_itemDetails.SelectedCells[0].OwningColumn.DataPropertyName == "BatchNo")
                    {
                        SetComboLocation(dgv_itemDetails, Cmb_ProdCode, dgv_itemDetails.CurrentCell.ColumnIndex, dgv_itemDetails.CurrentCell.RowIndex);
                    }
                    else if (dgv_itemDetails.SelectedCells[0].OwningColumn.DataPropertyName == "UnitName")
                    {
                        SetComboLocation(dgv_itemDetails, Cmb_FloorName, dgv_itemDetails.CurrentCell.ColumnIndex, dgv_itemDetails.CurrentCell.RowIndex);
                    }

                    else if (dgv_itemDetails.SelectedCells[0].OwningColumn.DataPropertyName == "ExperDate")
                    {
                        try
                        {
                            //DateTime vb = DateTime.Now.ToLocalTime();
                            dgv_itemDetails.CurrentRow.Cells["ExperDate"].Value = grbDTPicker1.Value.ToString("dd/MMM/yyyy");
                            grbDTPicker1.Visible = true;
                            grbDTPicker1.Value = Convert.ToDateTime(dgv_itemDetails.SelectedCells[0].Value.ToString());
                            System.Drawing.Point p = new System.Drawing.Point();
                            p = dgv_itemDetails.GetCellDisplayRectangle(dgv_itemDetails.SelectedCells[0].ColumnIndex, dgv_itemDetails.SelectedCells[0].RowIndex, true).Location;
                            grbDTPicker1.Location = new System.Drawing.Point(p.X + dgv_itemDetails.Parent.Location.X, p.Y + dgv_itemDetails.Parent.Location.Y);
                            grbDTPicker1.Size = dgv_itemDetails.GetCellDisplayRectangle(dgv_itemDetails.SelectedCells[0].ColumnIndex, dgv_itemDetails.SelectedCells[0].RowIndex, true).Size;
                            grbDTPicker1.BringToFront();
                            grbDTPicker1.Focus();

                        }
                        catch { }

                    }
                    else
                    {
                        Cmb_ItemName.Visible = false;
                        grbDTPicker1.Visible = false;
                    }


                }
                else
                {
                    Cmb_ProdCode.Visible = false;
                    SaleCurrentRow = -1;
                }
            }
        }




        private void AfterComboLeave(Gramboo.Controls.GrbDataGridView dgv_itemDetails, Gramboo.Controls.GrbComboBox cmb, int valuecolumnindex = -1)
        {

          
            if (dgv_itemDetails.CurrentCell == null)
                return;


            cmb.Visible = false;
           
            //if (valuecolumnindex >= 0 && (cmb.SelectedValue == null || cmb.Text == ""))
            //{
            //    dgv_itemDetails.CurrentCell.Value = "";
            //    dgv_itemDetails.Rows[dgv_itemDetails.CurrentCell.RowIndex].Cells[valuecolumnindex].Value = 0;
            //    return;
            //}
            //else if (dgv_itemDetails.CurrentCell == null)
            //    return;

            //if (cmb.CheckDuplicates)
            //{
            //    if (((System.Data.DataTable)dgv_itemDetails.DataSource).Select("[" + dgv_itemDetails.CurrentCell.OwningColumn.Name + "]='" + cmb.Text + "'").Length != 0)
            //    {
            //        return;
            //    }
            //}
            //dgv_itemDetails.CurrentCell.Value = cmb.Text;
            //if (valuecolumnindex > -1 && cmb.Text != "")
            //    dgv_itemDetails.Rows[dgv_itemDetails.CurrentCell.RowIndex].Cells[valuecolumnindex].Value = cmb.SelectedValue;
        }

        private void ComboKeydown(Gramboo.Controls.GrbDataGridView dgv_itemDetails, Gramboo.Controls.GrbComboBox cmb, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {

                dgv_itemDetails.Focus();
                cmb.Visible = false;
            }
        }


        private void SetComboLocation(Gramboo.Controls.GrbDataGridView dgv_itemDetails, Gramboo.Controls.GrbComboBox cmb, int columnindex, int rowindex)
        {

            int SaleCurrentRow = rowindex;
            cmb.Parent = dgv_itemDetails.Parent;
            cmb.Visible = true;
            cmb.Text = dgv_itemDetails.SelectedCells[0].Value.ToString();

            System.Drawing.Point p = new System.Drawing.Point();
            p = dgv_itemDetails.GetCellDisplayRectangle(dgv_itemDetails.SelectedCells[0].ColumnIndex, dgv_itemDetails.SelectedCells[0].RowIndex, true).Location;
            cmb.Location = new System.Drawing.Point(p.X + dgv_itemDetails.Parent.Location.X - 5, p.Y + dgv_itemDetails.Parent.Location.Y - 15);


            cmb.Size = dgv_itemDetails.GetCellDisplayRectangle(dgv_itemDetails.SelectedCells[0].ColumnIndex, dgv_itemDetails.SelectedCells[0].RowIndex, true).Size;
            cmb.BringToFront();
            cmb.Focus();
            cmb.DroppedDown = true;

        }


        private void Cmb_FloorName_Leave(object sender, EventArgs e)
        {
            Cmb_FloorName.Visible = false;


            if (Cmb_FloorName.Text != "" && Cmb_FloorName.SelectedValue != null)
            {

                dgv_itemDetails.CurrentRow.Cells["ItemUnitId"].Value = Cmb_FloorName.SelectedValue.ToString();
                dgv_itemDetails.CurrentRow.Cells["UnitName"].Value = Cmb_FloorName.Text;
            }

             
        }
        private void Cmb_ItemName_Leave(object sender, EventArgs e)
        {
            Cmb_ItemName.Visible = false;


            if (Cmb_ItemName.Text != "" && Cmb_ItemName.SelectedValue != null)
            {

                dgv_itemDetails.CurrentRow.Cells["ItemID"].Value = Cmb_ItemName.SelectedValue.ToString();
                dgv_itemDetails.CurrentRow.Cells["Item Name"].Value = Cmb_ItemName.Text;
            }
 
        }

        private void cmb_purity_Leave(object sender, EventArgs e)
        {
            //AfterComboLeave(dgv_itemDetails, cmb_purity, dgv_itemDetails.Columns["PurityId"].Index);
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (FillFlag)
                return;
            if (dgv_itemDetails.Columns[e.ColumnIndex].DataPropertyName == "Item Name")
            { 
                    Itemchange(dgv_itemDetails);
            }
            if (dgv_itemDetails.Columns[e.ColumnIndex].DataPropertyName == "BatchNo")
            {
                if (VoucherType == 15)
                {
                    Batchchange(dgv_itemDetails);
                }
                else
                {
                    RptBatchchange(dgv_itemDetails);
                }

            }

            if (VoucherType == 6)
            {
                    Reciept.Checked = true;  
                dgv_itemDetails.CurrentRow.Cells["Is Receipt"].Value = true;
            }
            else
            {
                    Issue.Checked = true;  
                dgv_itemDetails.CurrentRow.Cells["Is Receipt"].Value = false;
            }
        
        }
        private void Itemchange(Gramboo.Controls.GrbDataGridView dgv)
        {
            if (Cmb_ItemName.SelectedValue != null)
            {
                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select  [Unit Name], UnitofMstmtid  from ITM.VItemMaster where ItemId=" + Cmb_ItemName.SelectedValue + "  ")).Tables[0])
                {
                    string unitid, unitname, taxper, brandname;
                    double id;
                    //unitid = Convert.ToString(dt.Rows[0]["UnitofMstmtid"] == null ? "" : dt.Rows[0]["UnitofMstmtid"].ToString());
                    //unitname = Convert.ToString(dt.Rows[0]["Unit Name"] == null ? "" : dt.Rows[0]["Unit Name"].ToString());

                    if (dt.Rows.Count > 0)
                    {
                        //dgv.CurrentRow.Cells["ItemUnitId"].Value = unitid.ToString();
                        //dgv.CurrentRow.Cells["UnitName"].Value = unitname.ToString();
                        dgv.CurrentRow.Cells["Qty"].Value = 1.ToString();
                    }
                }
                if (VoucherType == 15)
                {
                    using (DataTable DR = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select Batchid from [STK].[SalesStockStatus](DATEADD(DAY,1,'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "')," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + "  ")).Tables[0])
                    {
                        if (DR.Rows.Count > 0)
                        {
                            LoadBatch();
                        }
                        else
                        {
                            Gramboo.General.ShowMessage("Not in Stock");
                        }
                    }
                }
                else
                {
                    using (DataTable Dy = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select Batchid from [STK].[ServiceStockStatus](DATEADD(DAY,1,'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "')," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + "  ")).Tables[0])
                    {
                        if (Dy.Rows.Count > 0)
                        {
                            LoadBatch();
                        }
                        else
                        {
                            Gramboo.General.ShowMessage("Not in Stock");
                        }
                    }

                }

            }
        }
        private void Cmb_ProdCode_Leave(object sender, EventArgs e)
        
        {
            if (Cmb_ProdCode.SelectedValue != null)
            {
                dgv_itemDetails.CurrentRow.Cells["Batchid"].Value = Cmb_ProdCode.SelectedValue.ToString();
                dgv_itemDetails.CurrentRow.Cells["BatchNo"].Value = Cmb_ProdCode.Text;
            }
            Cmb_ProdCode.Visible = false;
            //if (Cmb_ProdCode.SelectedValue != null && Cmb_ProdCode.Text.Trim().Length > 0  )
            //{
                
               
            //}
            //if (dgv_itemDetails.Rows.Count > 0)
            //{
            //    if (dgv_itemDetails.Rows[dgv_itemDetails.Rows.Count - 1].Cells["Batchid"].Value.ToString() != "")
            //    {
            //        ((System.Data.DataTable)dgv_itemDetails.DataSource).Rows.Add(((System.Data.DataTable)dgv_itemDetails.DataSource).NewRow());

            //        dgv_itemDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //        dgv_itemDetails.CurrentCell = dgv_itemDetails.Rows[ dgv_itemDetails.Rows.Count-1].Cells[0]; 
            //        dgv_itemDetails.Select();
            //    }
            //}
            // Cmb_ProdCode.Visible = false; 
        }
        //private void enable_disable(Gramboo.Controls.GrbDataGridView dgv, int row, bool ReadOnly)
        //{
        //    SetEnable(dgv, "Touch", row, ReadOnly);
        //    SetEnable(dgv, "Qty", row, ReadOnly);
        //    SetEnable(dgv, "Gwt", row, ReadOnly);
        //    SetEnable(dgv, "MetalRate", row, ReadOnly);
        //    SetEnable(dgv, "MC", row, ReadOnly);
        //    SetEnable(dgv, "Wastage", row, ReadOnly);
        //    SetEnable(dgv, "VA", row, ReadOnly);
        //    SetEnable(dgv, "VAPerc", row, ReadOnly);

        //}

        private void SetEnable(Gramboo.Controls.GrbDataGridView dgv, string Column, int row, bool ReadOnly)
        {
            //if (dgv.Columns.Contains(Column))
            //    dgv.Rows[row].Cells[Column].ReadOnly = ReadOnly;
        }

        private void dgv_SummaryCalculated(object source, EventArgs e)
        {
            txtTotalAmount.Text = dgv_itemDetails.SummaryRow.SummaryCells["Amount"].Text;
            
        }

        private void dgv_OtherCharges_SummaryCalculated(object source, EventArgs e)
        {
            //txtTotalChargeAmount.Text = dgv_OtherCharges.SummaryRow.SummaryCells["ChargeAmount"].Text;
        }

        private void linkLbl_OtherCharges_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlOtherCharges.Visible == false)
            {
                pnlOtherCharges.Size = new System.Drawing.Size(600, 300);
                pnlOtherCharges.Parent = this;
                pnlOtherCharges.Visible = true;
                pnlOtherCharges.BringToFront();

                pnlOtherCharges.Location = new Point(LableExp233.Location.X - 200 + LableExp233.Parent.Location.X - 200,
                LableExp233.Parent.Location.Y + 100 + LableExp233.Location.Y + 100);

                pnlOtherCharges.Show();
                pnlOtherCharges.BringToFront();
                LableExp233.Text = "Hide Charges Details";

            }
            else
            {
                pnlOtherCharges.Visible = false;
                pnlOtherCharges.SendToBack();
                pnlOtherCharges.Hide();
                LableExp233.Text = "Show Charges Details";

            }
        }

        private void Btn_OtherDetails_Click(object sender, EventArgs e)
        {
            if (Cmb_Description.Text != "" && txtChargeAmount.Text != "")
            {
                dgv_OtherCharges.Save();
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_itemDetails.RowTemplate.Height = Cmb_ItemName.Height;
            foreach (DataGridViewColumn c in dgv_itemDetails.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
     
        public override void Print()
        {
            if (txtEntryNo.Text != null)
            {
                if (VoucherType == 15)
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                    //cr = new SALON.REPORTS.STOCK.StockTransferIssue();
                    project.Classes.Common.SetDatabaseLogon(cr, DBConn);
                    cr.SetDatabaseLogon(DBConn.ConnectionProperties.DBUsername, DBConn.ConnectionProperties.DBPassword);
                    // cr.SetParameterValue("@Printed By", txtUserName.Text);
                    cr.VerifyDatabase();
                    cr.SetParameterValue("@Printed By", txtUserName.Text);
                    cr.SetParameterValue("@IsContinues", false);
                    cr.RecordSelectionFormula = " {VStockTransferReportIssue.EntryId} =" + txtEntryNo.Text;
                    Gramboo.Controls.GrbReport rpt = new Gramboo.Controls.GrbReport(cr);
                    rpt.MdiParent = this.MdiParent;

                    ((frmMain)this.MdiParent).ShowChild(rpt);

                }
                else if (VoucherType == 6)
                {
                    CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
                   // cr = new project.REPORTS.STOCK.StockTransferReceipt();
                    project.Classes.Common.SetDatabaseLogon(cr, DBConn);
                    cr.SetDatabaseLogon(DBConn.ConnectionProperties.DBUsername, DBConn.ConnectionProperties.DBPassword);
                    //cr.SetParameterValue("@Printed By", txtUserName.Text);
                     cr.VerifyDatabase();
                    cr.SetParameterValue("@Printed By", txtUserName.Text);
                    cr.SetParameterValue("@IsContinues", false);
                    cr.RecordSelectionFormula = " {VStockTransferReportReceipt.EntryId} =" + txtEntryNo.Text;
                    Gramboo.Controls.GrbReport rpt = new Gramboo.Controls.GrbReport(cr);
                    rpt.MdiParent = this.MdiParent;

                    ((frmMain)this.MdiParent).ShowChild(rpt);
                }

            }
        }

        private void Cmb_FloorName_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (Cmb_FloorName.SelectedValue != null)
            //{
            //    //LoadProdCodes();
            //    //foreach (DataGridViewRow r in dgv_itemDetails.Rows)
            //    {
            //        r.Cells["FloorId"].Value = Cmb_FloorName.SelectedValue;
            //        r.Cells["Floor Name"].Value = Cmb_FloorName.Text;
            //    //}
            //}
            //else
            //{
            //    Cmb_ProdCode.Text = "";
            //}
        }

       

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && dgv_itemDetails.CurrentCell.OwningColumn.Index == dgv_itemDetails.Columns.Count - 1)
            {


                if (dgv_itemDetails.Rows.Count > 0)
                {
                    if (/*dgv_itemDetails.Rows[dgv_itemDetails.Rows.Count - 1].Cells["ProdcodeID"].Value.ToString() != "" ||*/
                        dgv_itemDetails.Rows[dgv_itemDetails.Rows.Count - 1].Cells["ItemUnitId"].Value.ToString() != "")
                    {
                        ((System.Data.DataTable)dgv_itemDetails.DataSource).Rows.Add(((System.Data.DataTable)dgv_itemDetails.DataSource).NewRow());

                        dgv_itemDetails.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        //dgv_itemDetails.CurrentCell = dgv_itemDetails.Rows[dgv_itemDetails.Rows.Count - 1].Cells["ProdCode"];
                        e.Handled = true;
                        dgv_itemDetails.BeginEdit(false);
                        // Cmb_ItemName.DroppedDown = true;  
                    }
                }
            }
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

           

            if (dgv_itemDetails. CurrentCell == null)
                return;
            
                Cmb_ProdCode.Focus();
        
            Cmb_ItemName.Focus();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            float purewt = 0 ;

            foreach (DataGridViewRow r in dgv_itemDetails.Rows)
            {
                if (dgv_itemDetails.CurrentRow.Cells["PureWt"].Value.ToString() != "")
                {
                    purewt = Convert.ToSingle(dgv_itemDetails.CurrentRow.Cells["PureWt"].Value);
                    //dgv_itemDetails.CurrentRow.Cells["MetalCash"].Value = (purewt * Convert.ToSingle(txtRate.Text)).ToString("f2");
                }
            }
        }


        private void Cmb_ItemName_KeyDown(object sender, KeyEventArgs e)
        {
            ComboKeydown(dgv_itemDetails, Cmb_ItemName, e);
        }

        private void dgv_itemDetails_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dgv_itemDetails.Rows)
            {
                //string SelectedText = Convert.ToString(r.Cells["Floor Name"].Value.ToString());
                //Cmb_FloorName.Text = SelectedText;
            }
            
        }


        private void Cmb_ItemName_KeyDown_1(object sender, KeyEventArgs e)
        {
            ComboKeydown(dgv_itemDetails, Cmb_ItemName, e);

        }


        private void Cmb_FloorName_KeyDown(object sender, KeyEventArgs e)
        {
            ComboKeydown(dgv_itemDetails, Cmb_FloorName, e);

        }


        public override bool ValidateControls()
        {
            if (!IsEditMode)
                TxtVoucherNo.Text = project.Classes.Common.GetNextVoucherNo((int)cmb_VoucherTypeId.SelectedValue, dtp_dt.Value,
            DBConn, Convert.ToInt32(txtcompId.Text), Convert.ToInt32(txtBranchID.Text));

            bool flag = true;
            if (base.ValidateControls())
            {
                foreach (DataGridViewRow rows in dgv_itemDetails.Rows)
                {
                    if (Cmb_ItemName.SelectedValue != null)
                    {
                        using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand
                         ("Select HasExp FROM itm.ItemMaster where  ItemId=" + Cmb_ItemName.SelectedValue + "")).Tables[0])
                        {
                            if (dt.Rows.Count > 0)
                            {
                                if (dt.Rows[0]["HasExp"].ToString() == "0")
                                {
                                    if (rows.Cells["BatchNo"].Value.ToString() == "")
                                    {
                                        Gramboo.General.ShowMessage("Enter the Batch Number to " + rows.Cells["Item Name"].Value.ToString() + "");
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (DataGridViewRow r in dgv_itemDetails.Rows)
                {
                    if ((Convert.ToString(r.Cells["ItemUnitId"].Value) == "0"))
                    {
                    //    Gramboo.General.ShowMessage("Floor Name Cannot Be Empty");
                    //    return false;
                    }

                }
                return flag;
            }
            else
            {
                return false;
            }
        }



        private void TxtRemarks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgv_itemDetails.Focus();
        }

        private void grbDTPicker1_Leave(object sender, EventArgs e)
        {
            if (dgv_itemDetails.CurrentRow.Cells["BatchNo"].Value.ToString() == "")
            {
            dgv_itemDetails.CurrentRow.Cells["ExperDate"].Value = grbDTPicker1.Value.ToString("dd/MMM/yyyy");
            }
        }

        private void LoadBatch()
        {

            SqlCommand cmd = new SqlCommand();
            if (txtcompId.Text == "")
                return;
            if (VoucherType == 15)
            {
                cmd.CommandText = "select Batchid,BatchNo from [STK].[SalesStockStatus](DATEADD(DAY,1,'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "')," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + "  Order By ExpiredDate";
            }
            else
            {
                cmd.CommandText = "select Batchid,BatchNo from [STK].[ServiceStockStatus](DATEADD(DAY,1,'" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "')," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + "  Order By ExpiredDate";
            }
            Cmb_ProdCode.DisplayMember = "BatchNo";
            Cmb_ProdCode.ValueMember = "Batchid";
            Cmb_ProdCode.DataSource = DBConn.GetData(cmd, "BatchNo").Tables[0];

        }
        private void Batchchange(Gramboo.Controls.GrbDataGridView dgv)
        {
            if (Cmb_ProdCode.SelectedValue != null)
            {
                using (DataTable DR = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select Batchid,Qty,Mrp,ExpiredDate,HasExp,UnitID,[Unit Name] from sale.ChkExpiredItmList('" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "'," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + " and Batchid=" + Cmb_ProdCode.SelectedValue + "  ")).Tables[0])
                {
                    string Qtys, Mrp, HasExp, unitname, unitid; 
                    double Datediff;
                    DateTime exdate, predate;
                    Qtys = Convert.ToString(DR.Rows[0]["Qty"] == null ? "" : DR.Rows[0]["Qty"].ToString());
                    Mrp = Convert.ToString(DR.Rows[0]["Mrp"] == null ? "" : DR.Rows[0]["Mrp"].ToString());
                    HasExp = Convert.ToString(DR.Rows[0]["HasExp"] == null ? "0" : DR.Rows[0]["HasExp"].ToString());
                    unitname = Convert.ToString(DR.Rows[0]["Unit Name"] == null ? "" : DR.Rows[0]["Unit Name"].ToString());
                    unitid = Convert.ToString(DR.Rows[0]["UnitID"] == null ? "" : DR.Rows[0]["UnitID"].ToString());
                    exdate = Convert.ToDateTime(DR.Rows[0]["ExpiredDate"]);
                    predate = dtp_dt.Value;
                    Datediff = (exdate - predate).TotalDays;
                    if (DR.Rows.Count > 0)
                    {
                        if (HasExp == "0")
                        {
                            if (Datediff <= 7)
                            {
                                LableExp.Visible = true;
                                LableExp.BringToFront();
                                LableExp.Text = "This Item is Expired on " + exdate.ToShortDateString() + "";
                                LableExp.Font = new Font(LableExp.Font, FontStyle.Bold);
                                LableExp.ForeColor = System.Drawing.Color.Red;
                            }
                            else
                            {
                                LableExp.Visible = false;
                                dgv.CurrentRow.Cells["ItemUnitId"].Value = unitid.ToString();
                                dgv.CurrentRow.Cells["UnitName"].Value = unitname.ToString();
                                dgv.CurrentRow.Cells["Qty"].Value = 1.ToString();
                                dgv.CurrentRow.Cells["Amount"].Value = Mrp.ToString();
                                dgv.CurrentRow.Cells["ExperDate"].Value = exdate.ToString();
                            }
                        }
                        else
                        {
                            LableExp.Visible = false;
                            dgv.CurrentRow.Cells["ItemUnitId"].Value = unitid.ToString();
                            dgv.CurrentRow.Cells["UnitName"].Value = unitname.ToString();
                            dgv.CurrentRow.Cells["Qty"].Value = 1.ToString();
                            dgv.CurrentRow.Cells["Amount"].Value = Mrp.ToString();
                            dgv.CurrentRow.Cells["ExperDate"].Value = exdate.ToString();
                        }
                    }
                }
            }
        }

        private void RptBatchchange(Gramboo.Controls.GrbDataGridView dgv)
        {
            if (Cmb_ProdCode.SelectedValue != null)
            {
                using (DataTable DR = DBConn.GetData(new System.Data.SqlClient.SqlCommand("select Batchid,Qty,Mrp,ExpiredDate,HasExp,UnitID,[Unit Name] from STK.ChkServiceExpiredItmList('" + dtp_dt.Value.Date.ToString("dd-MMM-yyyy") + "'," + txtcompId.Text + "," + txtBranchID.Text + ") where ItemId=" + Cmb_ItemName.SelectedValue + " and Batchid=" + Cmb_ProdCode.SelectedValue + "  ")).Tables[0])
                {
                    string Qtys, Mrp, HasExp, unitname, unitid;
                    double Datediff;
                    DateTime exdate, predate;
                    Qtys = Convert.ToString(DR.Rows[0]["Qty"] == null ? "" : DR.Rows[0]["Qty"].ToString());
                    Mrp = Convert.ToString(DR.Rows[0]["Mrp"] == null ? "" : DR.Rows[0]["Mrp"].ToString());
                    HasExp = Convert.ToString(DR.Rows[0]["HasExp"] == null ? "0" : DR.Rows[0]["HasExp"].ToString());
                    unitname = Convert.ToString(DR.Rows[0]["Unit Name"] == null ? "" : DR.Rows[0]["Unit Name"].ToString());
                    unitid = Convert.ToString(DR.Rows[0]["UnitID"] == null ? "" : DR.Rows[0]["UnitID"].ToString());
                    exdate = Convert.ToDateTime(DR.Rows[0]["ExpiredDate"]);
                    predate = dtp_dt.Value;
                    Datediff = (exdate - predate).TotalDays;
                    if (DR.Rows.Count > 0)
                    {
                        if (HasExp == "0")
                        {
                            if (Datediff <= 7)
                            {
                                LableExp.Visible = true;
                                LableExp.BringToFront();
                                LableExp.Text = "This Item is Expired on " + exdate.ToShortDateString() + "";
                                LableExp.Font = new Font(LableExp.Font, FontStyle.Bold);
                                LableExp.ForeColor = System.Drawing.Color.Red;
                            }
                            else
                            {
                                LableExp.Visible = false;
                                dgv.CurrentRow.Cells["ItemUnitId"].Value = unitid.ToString();
                                dgv.CurrentRow.Cells["UnitName"].Value = unitname.ToString();
                                dgv.CurrentRow.Cells["Qty"].Value = 1.ToString();
                                dgv.CurrentRow.Cells["Amount"].Value = Mrp.ToString();
                                dgv.CurrentRow.Cells["ExperDate"].Value = exdate.ToString();
                            }
                        }
                        else
                        {
                            LableExp.Visible = false;
                            dgv.CurrentRow.Cells["ItemUnitId"].Value = unitid.ToString();
                            dgv.CurrentRow.Cells["UnitName"].Value = unitname.ToString();
                            dgv.CurrentRow.Cells["Qty"].Value = 1.ToString();
                            dgv.CurrentRow.Cells["Amount"].Value = Mrp.ToString();
                            dgv.CurrentRow.Cells["ExperDate"].Value = exdate.ToString();
                        }
                    }
                }
            }
        }
    }
}

















