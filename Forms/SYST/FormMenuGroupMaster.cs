using Gramboo.Database;
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
    public partial class FormMenuGroupMaster : Gramboo.Controls.GrbForm
    {
        private static FormMenuGroupMaster instance;
        private bool updatingTreeView;
        DataTable dt;
        private bool fillflag = false;
        private bool refreshflag = false;
        public static FormMenuGroupMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormMenuGroupMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FormMenuGroupMaster();
                }
                return instance;
            }
        }

        public FormMenuGroupMaster()
        {

            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };

        }

        public override void Init()
        {
            refreshflag = true;
            base.Init();
            txtMenuGroupName.Focus();
            dgv.DataFields = new List<string> { "RelId", "GroupId", "Menuid", "MenuName", "MenuAdd", "MenuUpdate", "MenuDelete", "Company_id", "Branch_id", "MenuUrl" };
            dgv.HiddenDataFields = new List<string> { "RelId", "GroupId", "Menuid", "Company_id", "Branch_id", "MenuUrl" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VMenuGroupRelation", true), "1=2");
            dgv.Columns["col_AutoSlno"].DataPropertyName = "SlNo";

            dt = new DataTable();
            dt.Columns.Add("RelId", typeof(Int64));
            dt.Columns.Add("GroupId", typeof(int));
            dt.Columns.Add("Menuid", typeof(int));
            dt.Columns.Add("MenuName", typeof(string));
            dt.Columns.Add("MenuAdd", typeof(bool));
            dt.Columns.Add("MenuUpdate", typeof(bool));
            dt.Columns.Add("MenuDelete", typeof(bool));
            dt.Columns.Add("MenuUrl", typeof(string));
            dgv.DataSource = dt;
            refreshflag = false;

            //this.ListForm = MenuGroupMasterList.Instance;

           
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
            Table t = new Table(project.Classes.Common.DbName, "SYST", "MenuGroupMaster");
            t.PrimaryKeys.Add("GroupId");
            t.IdTextBox = txtMenuGroupId;
            Table t1 = new Table(project.Classes.Common.DbName, "SYST", "MenuGroupRelation", true);
            t1.PrimaryKeys.Add("RelId");
            t1.FillView = new Table(project.Classes.Common.DbName, "SYST", "VMenuGroupRelation");
            t1.DatagridView = dgv;
            t1.IsDatagridView = true;
            t1.IdTextBox = txtRelId;
            t.ChildTables.Add(t1);
            this.TableName = t;
            return true;

        }
        public override bool ValidateControls()
        {
            bool flag = true;
            flag = base.ValidateControls();
            return flag;
        }
        

        public override void RefreshData()
        {
            Gramboo.General.Setupcombo(Cmb_ParentName, "SYST.Menumaster", "MenuName", "Parentid", "IsActive='True' AND  Parentid=0");
            Gramboo.General.Setupcombo(cmbList, "SYST.VMenugroupmaster", "[Group Name]", "GroupId", "IsActive='True'  ");
            PopulateMenus();
            if (txtMenuGroupId.Text != "")
            {
                cmbList.SelectedValue = txtMenuGroupId.Text;
            }
            refreshflag = false;
        }

        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            DataTable dtchildc = DBConn.GetData(new SqlCommand("Select * FROM [SYST].[VMenuMaster] Where ParentId=" + parentId + " Order by MenuId"), "MenuMaster").Tables[0];
            TreeNode childNode;
            foreach (DataRow dr in dtchildc.Rows)
            {
                if (parentNode == null)
                    childNode = treeView1.Nodes.Add(dr["Menu Name"].ToString());
                else
                    childNode = parentNode.Nodes.Add(dr["Menu Name"].ToString());
                PopulateTreeView(Convert.ToInt32(dr["menuId"].ToString()), childNode);
            }
        }
        private void PopulateMenus(string MenuName = "")
        {
            TreeNode parentNode;
            string str = "";
            treeView1.Nodes.Clear();
            if (MenuName.Length == 0)
            {
                str = "Select * FROM [SYST].[VMenuMaster] WHERE ParentId=0 Order by MenuId";

            }
            else
            {
                str = "Select * FROM [SYST].[VMenuMaster] where [Menu Name]='" + MenuName + "' and  ParentId =0 Order by MenuId";
            }
            DataTable dt = DBConn.GetData(new SqlCommand(str), "MenuMaster").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                parentNode = treeView1.Nodes.Add(dr["Menu Name"].ToString());
                PopulateTreeView(Convert.ToInt32( dr["menuId"].ToString()), parentNode);
            }
            treeView1.ExpandAll();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            dgv.EndEdit();
            List<DataGridViewRow> l = new List<DataGridViewRow>();

            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (r.Cells["col_CheckBox"].Value == null)
                {

                    r.Cells["col_CheckBox"].Value = false;
                }
                if ((bool)((DataGridViewCheckBoxCell)r.Cells["col_CheckBox"]).Value == true)
                {
                    foreach (TreeNode n in treeView1.GetAllNodes())
                    {

                        if (n.Text == r.Cells["MenuUrl"].Value.ToString())
                        {
                            n.Checked = false;

                            break;
                        }


                    }
                    l.Add(r);

                }

            }


            foreach (DataGridViewRow r in l)
            {
                dgv.Rows.Remove(r);

            }
          
        }

        private void Cmb_ParentName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_ParentName.SelectedValue != null)
                PopulateMenus(Cmb_ParentName.Text);
        }

        private void Treeviewcheck()
        {

            foreach (TreeNode n in treeView1.GetAllNodes())
            {
                if (n.Checked)
                {
                    DataRow dr = dt.NewRow();
                    if (n.Text != "")
                    {
                        if (dt.Select(@"MenuUrl='\" + n.FullPath + "'").Length == 0)
                        {
                            dr.ItemArray = DBConn.GetData(new SqlCommand(@"Select  0 as RelId,0 as GroupId,Menuid,MenuName,1 as MenuAdd,1 as MenuUpdate, 1 as MenuDelete,MenuUrl FROM SYST.Menumaster WHERE MenuUrl='\" + n.FullPath + "'")).Tables[0].Rows[0].ItemArray;
                            dt.Rows.Add(dr);
                        }
                    }
                }
            }
            if (IsEditMode == true)
            {
                dgv.DataSource = dt;

            }
        }



        private void grbButton1_Click(object sender, EventArgs e)
        {
          
            Treeviewcheck();
       
         
        }





        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {


        }

      
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {

            if (updatingTreeView) return;
            foreach (TreeNode n in e.Node.Nodes)
            {
                n.Checked = e.Node.Checked;

            }
            updatingTreeView = true;
            SelectParents(e.Node, e.Node.Checked);
            updatingTreeView = false;
 
        }
        private void SelectParents(TreeNode node, Boolean isChecked)
        {
            var parent = node.Parent;

            if (parent == null)
                return;

            if (!isChecked && HasCheckedNode(parent))
                return;

            parent.Checked = isChecked;
            SelectParents(parent, isChecked);
        }

        private bool HasCheckedNode(TreeNode node)
        {
            bool flag = false;

            foreach (TreeNode n in node.Nodes)
            {
                if (n.Checked)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private void Cmb_ParentName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            cmbList.Visible = true;
            txtMenuGroupName.Visible = false;
        }

        private void cmbList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (refreshflag || fillflag)
                return;

            if (cmbList.SelectedValue != null)
            {
                Dictionary<string, object> p = new Dictionary<string, object>();
                p.Add("GroupId", cmbList.SelectedValue);
                fillflag = true;
                FillData(p);
                fillflag = false;
                cmbList.Visible = false;
                txtMenuGroupName.Visible = true;
                updatingTreeView = true;
                foreach (TreeNode tr in treeView1.GetAllNodes())
                {
                    if (((DataTable)dgv.DataSource).Select(@"menuurl='\" + tr.FullPath + "'").Length > 0)
                    {
                        tr.Checked = true;
                    }
                }
                updatingTreeView = false;
            }
            else
            {
                cmbList.Visible = false;
                txtMenuGroupName.Visible = true;

            }
        }
    }
}