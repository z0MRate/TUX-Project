using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class StudentInformationfrm : Form
    {
        Mainfrm mf = new Mainfrm();
        public StudentInformationfrm()
        {
            InitializeComponent();
            
        }
        public StudentInformationfrm(Mainfrm main) {
            mf = main;
        }
        public static string id;
        //private string tempid;
        public DataTable dTable = new DataTable();
        private void StudentInformationfrm_Load(object sender, EventArgs e)
        {
            if(User._role == "Accountant")
            {
                btnEdit.Hide();
            }
            StudentInformationfrm.id = "";
            StudentInfo si = new StudentInfo();
            dTable = si.ShowStudentList("*", " Studentlist_view ", "Major <> ''");
            dgridStudentList.DataSource = dTable;
            dgridStudentList.Columns[0].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[1].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[2].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[3].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[4].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[5].Width = dgridStudentList.Width / 7;
            dgridStudentList.Columns[6].Width = dgridStudentList.Width / 7;

            //dgrid Select Mode
            dgridStudentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtSearchStudentInfo_TextChanged(object sender, EventArgs e)
        {
            StudentInfo si = new StudentInfo();
            dTable = si.SearchStudent(txtSearchStudentInfo.Text);
            dgridStudentList.DataSource = dTable;
        }

        private void cmbselectMajor_TextChanged(object sender, EventArgs e)
        {    
            StudentInfo si = new StudentInfo();
            dTable = si.ShowStudentList("*", " Studentlist_view ", " Major= '" + cmbselectMajor.Text + "'");
            dgridStudentList.DataSource = dTable;
        }

        private void dgridStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            StudentInfo si = new StudentInfo();
            if (e.RowIndex < 0)
            {               
                return;
            }
            else if(e.ColumnIndex < 0)
            {
                id = dgridStudentList.Rows[e.RowIndex].Cells[0].Value.ToString();
                
            }
            else if(dgridStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dgridStudentList.Rows[e.RowIndex].Cells[0].Value.ToString();               
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            RegisterStudentfrm rs = new RegisterStudentfrm();
            rs.MdiParent = mf.MdiParent;
            rs.FormBorderStyle = FormBorderStyle.Sizable;
            rs.Dock = DockStyle.Fill;
            rs.Text = "Edit Student Information";
            rs.btnSubmit.Hide();
            rs.btnUpdate.Location = new Point(1465, 785);
            if (id != "")
            {
                rs.UpdateStudentInfo();
                rs.Show();
            }
            else
            {
                MessageBox.Show("There is no student selected!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dgridStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
