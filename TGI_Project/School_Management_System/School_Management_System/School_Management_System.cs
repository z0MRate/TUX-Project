using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class School_Management_System : MaterialForm
    {
        public School_Management_System()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            if(txtuname.Text == "tgi")
            {
                if(txtpass.Text == "123")
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username...!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        
        private void tabPage5_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        //private void btnShowStudentList_Click(object sender, EventArgs e)
        //{
        //    StudentInfo si = new StudentInfo();
        //    dTable = si.ShowStudentList("*");
        //    dgridStudentList.DataSource = dTable;

        //}

        private void txtSearchStudentInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchStudentInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void School_Management_System_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtSearchStudentInfo_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbselectMajor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbselectMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgridStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
