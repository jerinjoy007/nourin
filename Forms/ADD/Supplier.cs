﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gramboo.Database;



namespace project.Forms.ADD
{
    public partial class Supplier : Gramboo.Controls.GrbForm
    {
        private static Supplier instance;

        public static Supplier Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Supplier();
                }
                else if (instance.IsDisposed)
                {
                    instance = new Supplier();
                }
                return instance;
            }
        }
        public Supplier()
        {
            InitializeComponent();
        }
        public override void Init()
        {
            base.Init();
            txtSupplierCode.Focus();
            chkISActive.Checked = true;
            PopulateGrid();

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
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "ITM", "Supplier");
            t.PrimaryKeys.Add("SupId");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = txtSupId;

            this.TableName = t;
            return true;
        }
        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            dgvList.HiddenDataFields = new List<string>() { "SupId", "SupplierName",  "Counter_id", "Created_by", "Last_modified_by", "ItemId", "Company_id", "Branch_id" };
            dgvList.Fill(new Table(project.Classes.Common.DbName, "ITM", "Supplier", true));
        }
        public override bool Save()
        {
            base.Save();
            Init();
            return true;
        }
        private void txtEntryId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
