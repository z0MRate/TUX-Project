using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class RegisterUserfrm : Form
    {
        public RegisterUserfrm()
        {
            InitializeComponent();
        }     
        User user = new User();
        private string id;
        private string condition="";

        //Edit User
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Make sure the password not empty and the password and cfpasssword is the same;
            if (txtPassword.Text.Trim() == "" || txtConfirmPassword.Text.Trim() == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please enter all of the information below!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Your password and Comfirm password is not the same!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            user.UpdateUser(txtUsername.Text.Trim(),cmbSubject.Text,txtPassword.Text.ToString(), cmbRole.Text, id);
            DataTable dt = new DataTable();
            dt = user.listUser("*", "User_Tbl",condition);
            dgridUser.DataSource = dt;
            
            MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Create User
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Make sure the password not empty and the password and cfpasssword is the same;
            if (txtPassword.Text.Trim() == "" || txtConfirmPassword.Text.Trim() == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please enter all of the information below!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Your password and Comfirm password is not the same!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            user.CreateUser(txtUsername.Text, txtPassword.Text, cmbRole.Text, cmbSubject.Text);
            DataTable dt = new DataTable();
            dt = user.listUser("*", "User_Tbl", condition);
            
            dgridUser.DataSource = dt;
            
            
        }


        //Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //To warn user before delete
            DialogResult dialogresult = MessageBox.Show("Are you sure to delete this USER?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            if(dialogresult == DialogResult.No)
            {
                return;
            }
            user.DeleteUser(id);
            DataTable dt = new DataTable();
            dt = user.listUser("*", "User_Tbl", condition);
            dgridUser.DataSource = dt;
            MessageBox.Show("The user has been deleted!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void RegisterAdminfrm_Load(object sender, EventArgs e)
        {
            //Show user in DatagridUser
            DataTable dt = new DataTable(); 
            if(User._role.ToLower() == "enroll")
            {
                condition = "Role NOT IN ('Admin','Enroll','Accountant')";

                cmbRole.Items.Remove("Admin");
                cmbRole.Items.Remove("Enroll");
                cmbRole.Items.Remove("Accountant");
            }
            else if(User._role.ToLower() == "admin")
            {
                condition = " Role <> ''";
            }
            dt = user.listUser("UserID,Username, Password, Role", "User_Tbl", condition);

            dgridUser.DataSource = dt;

            //ColumnSize
            dgridUser.Columns[0].Width = dgridUser.Width / 4;
            dgridUser.Columns[1].Width = dgridUser.Width / 4;
            dgridUser.Columns[2].Width = dgridUser.Width / 4;
            dgridUser.Columns[3].Width = dgridUser.Width / 4;

            //dgrid Select Mode
            dgridUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
            btnCreate.BackColor = Color.Gray;
            btnDelete.BackColor = Color.Gray;

        }

        private void dgridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Get data from User tbl
        private void dgridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            else if (e.ColumnIndex < 0)
            {
                id = dgridUser.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            else if (dgridUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dgridUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dgridUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dgridUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtConfirmPassword.Text = dgridUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbRole.Text = dgridUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userSubject();



                if (cmbRole.Text == "Lecturer")
                {
                    
                    cmbSubject.Items.Remove("None");
                    cmbRole.Text = dgridUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmbSubject.Enabled = true;
                    btnCreate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDelete.BackColor = Color.Red;
                    btnCreate.BackColor = Color.FromArgb(41, 51, 181);
                }

                else if (cmbRole.Text == "Student")
                {
                    cmbSubject.Items.Remove("None");
                    btnCreate.BackColor = Color.Gray;
                    btnDelete.BackColor = Color.Gray;
                    cmbSubject.Enabled = false;
                    btnCreate.Enabled = false;
                    btnDelete.Enabled = false;

                }
                else if (cmbRole.Text == "Enroll" || cmbRole.Text == "Admin" || cmbRole.Text == "Accountant")
                {
                    if (cmbSubject.Items.Count == 6 || cmbSubject.Items.Count == 5)
                    {
                        cmbSubject.Enabled = true;
                        cmbSubject.Items.Add("None");
                        cmbSubject.Text = "None";
                        cmbSubject.Enabled = false;
                        btnDelete.BackColor = Color.Red;
                        btnCreate.BackColor = Color.FromArgb(41, 51, 181);
                        btnDelete.Enabled = true;
                        btnCreate.Enabled = true;

                    }
                    else
                    {
                        cmbSubject.Enabled = true;
                        cmbSubject.Text = "None";
                        cmbSubject.Enabled = false;
                        btnDelete.BackColor = Color.Red;
                        btnCreate.BackColor = Color.FromArgb(41, 51, 181);
                        btnDelete.Enabled = true;
                        btnCreate.Enabled = true;
                    }

                }

            }
            

        }
        public void userSubject()
        {
            
            DataTable dt = new DataTable();
            
            dt = user.listUser("*", "User_Tbl", "UserID = " + id + "");
            foreach (DataRow dr in dt.Rows)
            {
                cmbSubject.Enabled = true;
                cmbSubject.SelectedItem = dr["Subject"].ToString();
                cmbSubject.Refresh();
                cmbRole.Refresh();
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(txtSearch.TextLength > 0)
            {
                dt = user.searchUser(txtSearch.Text.Trim(), condition);
            }
            else if(txtSearch.TextLength == 0)
            {
                dt = user.listUser("UserID,Username, Password, Role", "User_Tbl", condition);
            }
            
            dgridUser.DataSource = dt;
        }

        private void cmbRole_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            cmbRole.Text = "";
            id = "";
            cmbRole.Enabled = true;
            cmbSubject.Enabled = true;
            btnCreate.Enabled = true;
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.Red;
            btnCreate.BackColor = Color.FromArgb(41, 51, 181);

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cmbRole.Text == "Lecturer")
            {
                cmbSubject.Items.Remove("None");
                cmbSubject.Enabled = true;
                btnCreate.Enabled = true;
                btnDelete.Enabled=true; 
                btnDelete.BackColor = Color.Red;
                btnCreate.BackColor = Color.FromArgb(41, 51, 181);
            }
            
            else if(cmbRole.Text == "Student" )
            {
                cmbSubject.Items.Remove("None");
                btnCreate.BackColor = Color.Gray;
                btnDelete.BackColor = Color.Gray;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;

            }
            else if (cmbRole.Text == "Enroll" || cmbRole.Text == "Admin" || cmbRole.Text == "Accountant")
            {
                if (cmbSubject.Items.Count == 6 || cmbSubject.Items.Count == 5)
                {
                    cmbSubject.Enabled = true;
                    cmbSubject.Items.Add("None");
                    cmbSubject.Text = "None";
                    cmbSubject.Enabled = false;
                    btnDelete.BackColor = Color.Red;
                    btnCreate.BackColor = Color.FromArgb(41, 51, 181);
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = true;

                }
                else
                {
                    cmbSubject.Enabled = true;
                    cmbSubject.Text = "None";
                    cmbSubject.Enabled = false;
                    btnDelete.BackColor = Color.Red;
                    btnCreate.BackColor = Color.FromArgb(41, 51, 181);
                    btnDelete.Enabled = true;
                    btnCreate.Enabled = true;
                }

            }
        }
    }
}
