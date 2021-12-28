using Gramboo.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace project.Forms.SYST
{
    public partial class CompanyMaster : Gramboo.Controls.GrbForm
    {
        string ImgLoc = "";
        public byte[] img = null;
        private static CompanyMaster instance;

        public static CompanyMaster Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new CompanyMaster();
                }
                else if (instance.IsDisposed)
                {
                    instance = new CompanyMaster();
                }
                return instance;
            }
        }
        public CompanyMaster()
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
        public override bool InitializeTables()
        {
            Table t = new Table(project.Classes.Common.DbName, "SYST", "CompanyMaster");
            t.PrimaryKeys.Add("Comp_id");
            t.NotUpdatables.Add("Company_id");
            t.NotUpdatables.Add("Branch_id");
            t.NotUpdatables.Add("Counter_id");
            t.IdTextBox = TxtCmpID;
            this.TableName = t;
            return true;
        }
        public override void RefreshData()
        {
            base.RefreshData();
            PopulateGrid();
            ChkIsActive.Checked = true;
            //Gramboo.General.Setupcombo(cmbBankAccName, "ACC.BankAccountMaster", "Acc_BankAccName", "Acc_BankAccId", "IsActive='True'");

            //for (int i = 0; i <= 12; i++)
            //{
            //    TxtCmpYearStart.Items.Add(Date); 
            //}
            //  txtCompanyyrstrt.Text = "1";
            //  if (TxtCmpYearStart.SelectedValue != null)
            // {

            // txtCompanyyrstrt.Text = TxtCmpYearStart.SelectedValue.ToString();
            // }
        }

        public override void Init()
        {
            base.Init();
            pictureBox1.Image = null;
            Cmb_CmpYearStart.Items.Clear();
            Cmb_CmpYearStart.Items.Add("--Select--");
            Cmb_CmpYearStart.Items.Add("January"); Cmb_CmpYearStart.Items.Add("February"); Cmb_CmpYearStart.Items.Add("March");
            Cmb_CmpYearStart.Items.Add("April"); Cmb_CmpYearStart.Items.Add("May"); Cmb_CmpYearStart.Items.Add("June");
            Cmb_CmpYearStart.Items.Add("July"); Cmb_CmpYearStart.Items.Add("August"); Cmb_CmpYearStart.Items.Add("September");
            Cmb_CmpYearStart.Items.Add("October"); Cmb_CmpYearStart.Items.Add("November"); Cmb_CmpYearStart.Items.Add("December");
            TxtCmpName.Focus();
            AdjustColumnsWidth();
            ChkIsActive.Checked = true;


        }
        private void PopulateGrid()
        {

            dgv.EntryFormName = this;
            dgv.ShowEdit = true;
            dgv.ShowDelete = true;
            dgv.IsList = true;
            dgv.AutoGenerateColumns = true;
            dgv.DataFields = new List<string>() { "Comp_id", "[Company Name]", "Address1", "Address2", "Place", "City", "District", "State", "Country", "Pin", "Phone", "Mobile", "CompanyLogo", " [Bank Account Name]", "Email", "TIN", "CST", "[CIN No]", "Symbol", "Color1", "Color2", "[Year From]", "[Books From]", "[Year Start Month]", "[Created By]", "[Created Date]", "[Last Modified By]", "[Last Modified Date]", "[Is Active]" };
            dgv.HiddenDataFields = new List<string>() { "Comp_id" };
            dgv.Fill(new Table(project.Classes.Common.DbName, "SYST", "VCompanyMaster", true));
        }
        public void AdjustColumnsWidth()
        {
            dgv.Columns["Company Name"].Width = 200;
            dgv.Columns["Address1"].Width = 170;
            dgv.Columns["Address2"].Width = 200;
            dgv.Columns["Place"].Width = 200;
            dgv.Columns["City"].Width = 200;
            dgv.Columns["District"].Width = 200;
            dgv.Columns["State"].Width = 200;
            dgv.Columns["Country"].Width = 200;
            dgv.Columns["Pin"].Width = 100;
            dgv.Columns["Phone"].Width = 100;
            dgv.Columns["Mobile"].Width = 100;
            dgv.Columns["Email"].Width = 200;
            dgv.Columns["TIN"].Width = 200;
            dgv.Columns["CST"].Width = 150;
            dgv.Columns["CIN No"].Width = 100;
            dgv.Columns["Symbol"].Width = 200;

            dgv.Columns["Year From"].Width = 200;
            dgv.Columns["Books From"].Width = 200;
            dgv.Columns["Year Start Month"].Width = 200;
            dgv.Columns["Created By"].Width = 100;
            dgv.Columns["Created Date"].Width = 125;
            dgv.Columns["Last Modified By"].Width = 125;
            dgv.Columns["Last Modified Date"].Width = 140;
            dgv.Columns["Is Active"].Width = 75;
        }

        private void TxtCmpYearStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Btn_OtherDetails_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string str;
                str = colorDialog1.Color.Name;
                txtColor1.Text = str;
            }
        }

        private void Btn_Colpik2_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDialog2 = new ColorDialog();
            if (ColorDialog2.ShowDialog() == DialogResult.OK)
            {
                string str;
                str = ColorDialog2.Color.Name;
                txtColor2.Text = str; 
            }
        }
        public override bool Save()
        {

            //byte[] temp;
            //if (grbPictureBox1.BinaryValue == null)
            //{
            //    grbPictureBox1.ShowMessage("Select Image");
            //    return false;
            //}
            //else
            //{
            //    temp = grbPictureBox1.BinaryValue;
            //    grbPictureBox1.BinaryValue = new byte[] { 0 };
            //}
            if (base.Save())
            {
                imagesave();
                //using (TransactionScope transactionScope = new TransactionScope())
                //{
                //    //grbPictureBox1.BinaryValue = temp;

                //    //string filePath1 = (string)DBConn.GetData(new SqlCommand(" Select ISNULL(ProductImage.PathName(),'') As Path From  SYST.CompanyMaster Where Comp_id =" + TxtCmpID.Text)).Tables[0].Rows[0][0];

                //    if (filePath1.Length > 0)
                //    {

                //////WrapperImpersonationContext context = new WrapperImpersonationContext(System.Environment.MachineName, "guest", "");
                //        ////context.Enter();
                //        ////Console.WriteLine("Current user: " + WindowsIdentity.GetCurrent().Name);
                //        //// SqlConnection sqlConnection2 = new SqlConnection("Data Source=" + DBConn.ConnectionProperties.ServerName + ";Database=JMSIMG;User ID=sa;Password=P@SSW0RD;Trusted_Connection=False;Integrated Security = true;");
                //        //SqlConnection sqlConnection2 = new SqlConnection("Server=" + DBConn.ConnectionProperties.ServerName + ";Database=" + DBConn.ConnectionProperties.DatabseName + ";Integrated Security = true");
                //        //// Server=LOCALHOST\SQL2008
                //        //SqlCommand sqlCommand2 = sqlConnection2.CreateCommand();
                //        //sqlCommand2.CommandText = "Select GET_FILESTREAM_TRANSACTION_CONTEXT() As TransactionContext";
                //        //sqlConnection2.Open();
                //        ////sqlConnection2.Close();
                //        ////DBConn.ConnectionProperties.ConnectionString = "Data Source=" + DBConn.ConnectionProperties.ServerName + ";Initial Catalog=JMSIMG;Integrated Security=true;User ID=" +
                //        ////       DBConn.ConnectionProperties.DBUsername + ";Password=" + DBConn.ConnectionProperties.DBPassword + ";";
                //        ////byte[] transactionContext1 = (byte[])DBConn.GetData(new SqlCommand("Select GET_FILESTREAM_TRANSACTION_CONTEXT() As TransactionContext")).Tables[0].Rows[0][0];
                //        //byte[] transactionContext1 = (byte[])sqlCommand2.ExecuteScalar();
                //        //// Gramboo.General.ShowMessage(filePath1);
                //        //SqlFileStream sqlFileStream1 = new SqlFileStream
                //        //    (filePath1, transactionContext1, FileAccess.Write);

                //        //byte[] ProductImage = grbPictureBox1.BinaryValue;
                //        //sqlFileStream1.Write(ProductImage, 0, ProductImage.Length);
                //        //sqlFileStream1.Close();
                //        //transactionScope.Complete();
                //        //context.Leave();

                //    }
                //}


                RefreshData();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CompanyMaster_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_BankAccName_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void imageselect()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            dlg.Title = "Please Choose An Image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ImgLoc = dlg.FileName.ToString();
                pictureBox1.ImageLocation = ImgLoc;

            }

        }

        void imagesave()
        {
            if (ImgLoc.Trim().Length >= 1)
            {
                FileStream fs = new FileStream(ImgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "Update SYST.CompanyMaster set ProductImage = @img where Comp_id=" + TxtCmpID.Text + "";
                //string sql = "INSERT INTO STK.CustomerOrderPicture(PicId,ItemPic)VALUES("+TxtCommentid.Text+",@img)";
                SqlConnection connectionstring = new SqlConnection(DBConn.ConnectionProperties.ConnectionString);
                connectionstring.Open();
                SqlCommand cmd = new SqlCommand(sql, connectionstring);
                cmd.Parameters.Add(new SqlParameter("@img", img));
                cmd.ExecuteNonQuery();
                connectionstring.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageselect();
        }



        public override bool FillData(Dictionary<string, object> PrimaryValues)
        {
            if (base.FillData(PrimaryValues))
            {
                Loadimage();
                return true;
            }
            else
            {
                return false;
            }
        }

        void Loadimage()
        {
            using (System.Data.DataTable dt = DBConn.GetData(new SqlCommand
                                     ("select * from SYST.CompanyMaster where comp_id='"+txtcompId.Text+"'")).Tables[0])
            {
                if (dt.Rows.Count > 0)
                {

                    if (!Convert.IsDBNull(dt.Rows[0]["ProductImage"]))
                    {
                        byte[] imgg = (byte[])(dt.Rows[0]["ProductImage"]);
                        MemoryStream ms = new MemoryStream(imgg);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }

            }
        }
    }
}       
          
           
        

    

