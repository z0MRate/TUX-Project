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
        public StudentInformationfrm()
        {
            InitializeComponent();
        }
        public DataTable dTable = new DataTable();
        private void StudentInformationfrm_Load(object sender, EventArgs e)
        {
            StudentInfo si = new StudentInfo();
            dTable = si.ShowStudentList("*", " Studentlist_view ", "");
            dgridStudentList.DataSource = dTable;
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
            dTable = si.ShowStudentList("*", " Studentlist_view ", cmbselectMajor.Text);
            dgridStudentList.DataSource = dTable;
        }

        private void dgridStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            StudentInfo si = new StudentInfo();
            if (dgridStudentList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dgridStudentList.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                si.getStudentbyID(id);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
