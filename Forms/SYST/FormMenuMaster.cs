using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gramboo.Database;
using System.Data.SqlClient;

namespace project.Forms.SYST
{
    public partial class FormMenuMaster : Gramboo.Controls.GrbForm
    {

        private static FormMenuMaster instance;
        private string menuurl;

        public static FormMenuMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMenuMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FormMenuMaster();
                }
                return instance;
            }
        }
        public FormMenuMaster()
        {
            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };
        }


        public override bool GenerateID(Table table_name)
        {
            if (this.TableName == table_name)
            {
                if (txtMenuId.Text != "0")
                {
                    txtMenuId.Text = project.Classes.Common.GetNextID(table_name, table_name.IdTextBox.DataField, DBConn, Convert.ToInt32(base.txtcompId.Text), Convert.ToInt32(base.txtBranchID.Text)).ToString();
                }
            }
            return true;
        }

        public override void RefreshData()
        {
           
            PopulateGrid();
            Gramboo.General.Setupcombo(cmbMenuParentName, "SYST.Menumaster", "Menuurl", "menuId");
        }

        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "Menumaster");

            t.PrimaryKeys.Add("menuId");
            t.IdTextBox = txtMenuId;

            this.TableName = t;
            return true;
        }

        public override void Init()
        {
            base.Init();
            txtMenuName.Focus();
            chkISActive.Checked = true; 
        }

        private void PopulateGrid()
        {
            dgvList.EntryFormName = this;
            dgvList.ShowEdit = true;
            dgvList.IsList = true;
            dgvList.AutoGenerateColumns = true;
            //dgvList.DataFields = new List<string>{"*"};
            dgvList.HiddenDataFields = new List<string>() { "MenuId", "ParentId", "Created_by", "Last_modified_by", "Company_id", "Branch_id", "Counter_id" };

            // dgvList.Fill(new Table("JMSRET", "SYST", "VMenuMaster", true));
            dgvList.Fill(new Table(project.Classes.Common.DbName, "SYST", "VMenuMaster", true));


        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //Gramboo.DataController.CommandCollection cmdcol = new Gramboo.DataController.CommandCollection();
            //cmdcol.Add(new System.Data.SqlClient.SqlCommand("DELETE FROM SYST.MENUMASTER WHERE Company_ID=" + txtcompId.Text + " AND Branch_id =" + txtBranchID.Text));
            //DBConn.ExecuteSqlTransaction(cmdcol, "Mnumaster");

            frmmenu frm = new frmmenu();
            menuurl = "";
            InsertToMenuMaster(frm.TreeView_Master);
            menuurl = "";
            InsertToMenuMaster(frm.TreeView_Transaction);
            menuurl = "";
            InsertToMenuMaster(frm.treeView_reports);
            menuurl = "";
            InsertToMenuMaster(frm.TreeView_Add_new);

        }
        private void InsertToMenuMaster(TreeView tr)
        {

            foreach (TreeNode n in tr.Nodes)
            {
                if (n.Level == 0)
                {
                    txtMenuName.Text = n.Text;



                    if (n.Parent != null)
                    {
                        cmbMenuParentName.SelectedIndex = cmbMenuParentName.FindStringExact(n.Parent.Text);
                    }
                    txtMenuUrl.Text = menuurl + @"\" + n.Text;
                    Save();
                    Init();
                    if (n.GetNodeCount(true) > 0)
                    {
                        menuurl = menuurl + @"\" + n.Text;
                        InsertChildren(n, menuurl);
                    }

                }
            }
        }

        private void InsertChildren(TreeNode node, string parenturl)
        {
            foreach (TreeNode n in node.Nodes)
            {
                txtMenuName.Text = n.Text;
                if (n.Parent != null)
                    cmbMenuParentName.SelectedIndex = cmbMenuParentName.FindStringExact(parenturl);
                txtMenuUrl.Text = parenturl + @"\" + n.Text;
                Save();
                Init();
                if (n.GetNodeCount(true) > 0)
                {
                    menuurl = parenturl + @"\" + n.Text;
                    InsertChildren(n, menuurl);
                }
            }
        }


  

    }
}
