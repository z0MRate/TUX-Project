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
    public partial class ResetPasswordfrm : Form
    {
        public ResetPasswordfrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.resetPassword(User.id, txtOldPassword.Text.Trim(), txtNewPassword.Text.Trim(), txtConfirmPassword.Text.Trim());
            if(User.changeSuccess == true)
            {
                this.Close();
                User.changeSuccess = false;
            }
            
        }

        private void ResetPasswordfrm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;  
        }
    }
}
