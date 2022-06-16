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

namespace School_Management_System
{
    public partial class School_Management_System : MaterialForm
    {
        public School_Management_System()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
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
    }
}
