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
    public partial class FavFrmmenuMaster : Gramboo.Controls.GrbForm
    {


        private static FavFrmmenuMaster instance;
        private bool updatingTreeView;
        DataTable dt;
        private bool fillflag = false;
        private bool refreshflag = false;
        private bool loading = false;
        public static FavFrmmenuMaster Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FavFrmmenuMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new FavFrmmenuMaster();
                }
                return instance;
            }
        }
        public FavFrmmenuMaster()
        {
            InitializeComponent();
            this.DefaultPrimaryKeys = new List<string> { };
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
            refreshflag = true;
            base.RefreshData();

           
            //Gramboo.General.Setupcombo(cmb_User, "SYST.Username", "user_name", "user_id", "IsActive='True'");
            //PopulateGrid();

            txtuser.Text = txtUserName.Text;
              Gramboo.GRBConfig c = Gramboo.GRBConfig.Open();
              int i=    c.Login.UserId;
              txtUserId.Text = i.ToString();

            
              Gramboo.General.Setupcombo(Cmb_ParentName, "SYST.Menumaster", "MenuName", "Parentid", "IsActive='True' AND  Parentid=0");
              PopulateMenus();
            
             
              
              refreshflag = false;
        }


        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "FavoriteMenuMaster");
            t.PrimaryKeys.Add("FavMenuId");
            t.IdTextBox = txtMenuId;
            Table t1 = new Table(project.Classes.Common.DbName, "SYST", "FavoriteMenuDetails", true);
            t1.PrimaryKeys.Add("Id");
            t1.FillView = new Table(project.Classes.Common.DbName, "SYST", "VFavoriteMenuDetails");
            t1.DatagridView = dgv;
            t1.IsDatagridView = true;
            t1.IdTextBox = txtRelId;
            t.ChildTables.Add(t1);
            this.TableName = t;
            return true;
        }

        public override void Init()
        {
            refreshflag = true;
            base.Init();
            chkISActive.Checked = true;

            

            dgv.DataFields = new List<string> { "Id", "FavmenuId", "menuId", "[Menu Name]","Menuurl", "Company_id", "Branch_id" };
            dgv.HiddenDataFields = new List<string> { "FavmenuId", "menuId", "Id", "Company_id", "Branch_id", "Menuurl" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VFavoriteMenuDetails", true), "1=2");
            dgv.Columns["col_AutoSlno"].DataPropertyName = "SlNo";
            AdjustColumnWidths();

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(Int64));
            dt.Columns.Add("FavmenuId", typeof(Int64));
            dt.Columns.Add("menuId", typeof(int));
            dt.Columns.Add("MenuName", typeof(string));
            dt.Columns.Add("Menuurl", typeof(string));
            dgv.DataSource = dt;
           
            populateGrid();
         
            refreshflag = false;
            Cmb_ParentName.Focus();
            //populateGrid();
          
        }


        private void   AdjustColumnWidths()
        {
            dgv.Columns[0].Width = 50;
            dgv.Columns["Menu Name"].Width = 200;
        }

      
        private void PopulateTreeView(int parentId, TreeNode parentNode)
        {
            //Gramboo.GRBConfig c = Gramboo.GRBConfig.Open();
            //int i = c.Login.UserId;
            DataTable dtchildc = DBConn.GetData(new SqlCommand("Select * FROM [SYST].[VMenuGroupRelation] t1,SYST.Username t2  Where  t1.Groupid=t2.GroupId and t2.user_id=" + txtUserId.Text + " and t1.ParentId=" + parentId + " Order by t1.MenuId"), "VMenuGroupRelation").Tables[0];
            TreeNode childNode;
            foreach (DataRow dr in dtchildc.Rows)
            {
                if (parentNode == null)
                    childNode = treeView1.Nodes.Add(dr["MenuName"].ToString());
                else
                    childNode = parentNode.Nodes.Add(dr["MenuName"].ToString());
                PopulateTreeView(Convert.ToInt32(dr["menuId"].ToString()), childNode);
            }
        }
        private void PopulateMenus(string MenuName = "")
        {
            //Gramboo.GRBConfig c = Gramboo.GRBConfig.Open();
            //int i = c.Login.UserId;
            TreeNode parentNode;
            string str = "";
            treeView1.Nodes.Clear();
            if (MenuName.Length == 0)
            {
                str = "Select * FROM [SYST].[VMenuGroupRelation] t1, SYST.Username t2 WHERE  t1.Groupid=t2.GroupId and  t1.ParentId=0 and t2.user_id=" + txtUserId.Text + "  Order by t1.MenuId";

            }
            else
            {
                str = "Select * FROM [SYST].[VMenuGroupRelation] t1,SYST.Username t2 where t1.Groupid=t2.GroupId and  t1.MenuName='" + MenuName + "' and t2.user_id=" + txtUserId.Text + " and  t1.ParentId =0  Order by t1.MenuId";
            }
            DataTable dt = DBConn.GetData(new SqlCommand(str), "VMenuGroupRelation").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                parentNode = treeView1.Nodes.Add(dr["MenuName"].ToString());
                PopulateTreeView(Convert.ToInt32(dr["menuId"].ToString()), parentNode);
            }
            treeView1.ExpandAll();
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
                            dr.ItemArray = DBConn.GetData(new SqlCommand(@"Select  0 as Id,0 as FavmenuId,Menuid,MenuName,MenuUrl FROM SYST.Menumaster WHERE Menuurl='\" + n.FullPath + "'")).Tables[0].Rows[0].ItemArray;
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

        private void btn_Remove_Click(object sender, EventArgs e)
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

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            

           
           
        }

        private void populateGrid()
        {

            if (loading)
                return;
            loading = true;
            if (txtUserId.Text != "")
            {

                using (DataTable dt = DBConn.GetData(new System.Data.SqlClient.SqlCommand("Select FavmenuId FROM SYST.VFavMenu WHERE user_id=" + txtUserId.Text)).Tables[0])
                {
                    if (dt.Rows.Count > 0)
                    {
                        txtMenuId.Text = dt.Rows[0][0].ToString();
                        Dictionary<string, object> d = new Dictionary<string, object>();
                        d.Add("FavmenuId", txtMenuId.Text);
                        d.Add("Company_id", txtcompId.Text);
                        this.FillData(d);
                      

                        updatingTreeView = true;
                        foreach (TreeNode tr in treeView1.GetAllNodes())
                        {
                            if (((DataTable)dgv.DataSource).Select(@"menuurl='\" + tr.FullPath + "'").Length > 0)
                            {
                                tr.Checked = true;
                            }
                        }
                        loading = false;
                    }
                }
            }




        }

  

          

        private void grbButton2_Click(object sender, EventArgs e)
        {
       
        }

        private void FavFrmmenuMaster_Load(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void grbButton2_Click_1(object sender, EventArgs e)
        {
            populateGrid();
        }


        public override bool ValidateControls()
        {
            bool flag = true;
            flag = base.ValidateControls();
            return flag;
        }



    }
}
