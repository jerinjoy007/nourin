using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Gramboo.Database;

namespace project.Forms.SYST
{
    public partial class MenuGroupMasterList : Gramboo.Controls.GrbForm
    {

        private static MenuGroupMasterList instance;
     
        public static MenuGroupMasterList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuGroupMasterList();
                }
                else if (instance.IsDisposed)
                {
                    instance = new MenuGroupMasterList();
                }
                return instance;
            }
        }




        public MenuGroupMasterList()
        {
            InitializeComponent();
        }


        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
        }

        public override void Init()
        {
            base.Init();
        }



        private void PopulateGrid()
        {

            
          //  dgv.EntryFormName = FormMenuGroupMaster.Instance;
            dgv.ShowEdit = true;
            dgv.AutoGenerateColumns = true;
            dgv.ShowSerialNo = true;
            dgv.DataFields = new List<string> { "GroupId", "[Menu Group Name]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]", "Company_id", "Branch_id" };
            dgv.HiddenDataFields = new List<string> { "Created_by", "GroupId", "Last_modified_by", "Branch_id", "Company_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VMenuGroupMasterList", true), "Company_id=" + txtcompId.Text);


        }



    }


}
