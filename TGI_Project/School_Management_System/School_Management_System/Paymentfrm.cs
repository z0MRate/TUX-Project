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
    public partial class Paymentfrm : Form
    {
        public Paymentfrm()
        {
            InitializeComponent();
        }
        public static string studentname;
        public static string sex;
        public static string major;
        public static string coursefee;
        public static string paidamount;
        public static DateTime coursestart;

        public string condition;
        private void btnReport_Click(object sender, EventArgs e)
        {
            PaymentReport pr = new PaymentReport();
            pr.StartPosition = FormStartPosition.CenterScreen;  
            pr.ShowDialog();
        }

        private void Paymentfrm_Load(object sender, EventArgs e)
        {
            //Default Payment list
            
            //load payment list for all student include Paid, and Unpaid
            DataTable dt = new DataTable(); 
            PaymentMgmt pmt = new PaymentMgmt();
            //getPaymentList(selection, from which tbl, join with which tbl, on what condition)
            dt = pmt.douJoining("ID, FirstName+LastName AS StudentName,Sex, Major, Payment_tbl.Course_Fee, Payment_tbl.Paid_Fee, Payment_tbl.Remain_Fee", "StudentInformation_Tbl", "Payment_tbl", "ID = Payment_ID", " Payment_tbl.Remain_Fee <> -1");
            dgridStudentPayment.DataSource = dt;

            //Disabled unneeded fill txtfill
            txtStudentID.Enabled = false;
            txtUsername.Enabled = false;
            txtMajor.Enabled = false;
            txtReaminFee.Enabled = false;
            txtCourseFee.Enabled = false;   
            txtSex.Enabled = false; 
            //Allow only select row
            dgridStudentPayment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PaymentMgmt pmt = new PaymentMgmt();
            pmt.UpdatePayment(int.Parse(txtStudentID.Text), float.Parse(txtPaidFee.Text));

            //Set value to the static variable for making report
            studentname = txtUsername.Text;
            sex = txtSex.Text;
            major = txtMajor.Text;
            coursestart = dtpCourseStart.Value;
            coursefee = txtCourseFee.Text;
            paidamount = txtPaidFee.Text;

            DataTable dt = new DataTable();
            //Call the paymentlist again to reload datagrid
            //getPaymentList(selection, from which tbl, join with which tbl, on what condition)
            dt = pmt.douJoining("ID, FirstName+LastName AS StudentName,Sex, Major, Payment_tbl.Course_Fee, Payment_tbl.Paid_Fee, Payment_tbl.Remain_Fee", "StudentInformation_Tbl", "Payment_tbl", "ID = Payment_ID", " Payment_tbl.Remain_Fee <> 0");
            dgridStudentPayment.DataSource= dt;
        }

        private void dgridStudentPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else if (e.ColumnIndex < 0)
            {
                txtStudentID.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSex.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMajor.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCourseFee.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPaidFee.Text = 0.ToString();
                txtReaminFee.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
            else if (dgridStudentPayment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                txtStudentID.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSex.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMajor.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCourseFee.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPaidFee.Text = 0.ToString();
                txtReaminFee.Text = dgridStudentPayment.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            PaymentMgmt pmt = new PaymentMgmt();
            //getPaymentList(selection, from which tbl, join with which tbl, on what condition, condition)
            dt = pmt.douJoining("ID, FirstName+LastName AS StudentName,Sex, Major, Payment_tbl.Course_Fee, Payment_tbl.Paid_Fee, Payment_tbl.Remain_Fee", "StudentInformation_Tbl", "Payment_tbl", "ID = Payment_ID", "Payment_tbl.Remain_Fee <> 0 AND ID LIKE '%"+txtSearch.Text + "%' OR FirstName + LastName LIKE '%" + txtSearch.Text+"%' OR Major LIKE '%" + txtSearch.Text + "%'");
            dgridStudentPayment.DataSource = dt;    
            
            
            
        }

        private void txtStudentID_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPaymentList_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(cmbPaymentList.Text == "Not Finished Payment")
            {
                condition = "Payment_tbl.Remain_Fee <> 0";
            }
            else if(cmbPaymentList.Text == "All Student")
            {
                condition = "Payment_tbl.Remain_Fee <> -1";
            }
            else if(cmbPaymentList.Text == "New Student")
            {
                condition = "Payment_tbl.Remain_Fee = 1200";
            }
            else if(cmbPaymentList.Text == "Finished Payment")
            {
                condition = "Payment_tbl.Remain_Fee = 0";
            }
            PaymentMgmt pmt = new PaymentMgmt();
            //getPaymentList(selection, from which tbl, join with which tbl, on what condition)
            dt = pmt.douJoining("ID, FirstName+LastName AS StudentName,Sex, Major, Payment_tbl.Course_Fee, Payment_tbl.Paid_Fee, Payment_tbl.Remain_Fee", "StudentInformation_Tbl", "Payment_tbl", "ID = Payment_ID", condition);
            dgridStudentPayment.DataSource = dt;
        }

        private void txtPaidFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaidFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
