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

namespace School_Management_System
{
    public partial class Login_Form : KryptonForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuname.Text == "tgi")
            {
                if(txtpass.Text == "123")
                {
                    if(txtcpass.Text == "123")
                    {
                        Mainfrm mainform = new Mainfrm();
                        mainform.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Confirm Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid User Name..!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
