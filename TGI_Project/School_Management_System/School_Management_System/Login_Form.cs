using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Login_Form : KryptonForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public static string Username;
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Mainfrm mf = new Mainfrm();
        User user = new User();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            string role="";
            if(txtuname.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Please enter your info!!", "Alert", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                role = user.loginUser(txtuname.Text.Trim(), txtpass.Text.Trim());
                if(role == "")
                {
                    MessageBox.Show( "Wrong Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Username = txtuname.Text;
                    this.Hide();
                    mf.Role = role;
                    mf.ShowDialog();
                }
            }
            //MessageBox.Show("role : " + User._role);

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
