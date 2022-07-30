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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }
        AtendanceMgmt amt = new AtendanceMgmt();
        private void Attendance_Load(object sender, EventArgs e)
        {
            //dgridAttendance.ColumnCount = 8;
            DataTable dTable = new DataTable();
            
            //atendanceMgmt inherite from studentinfo
            
            dTable = amt.ShowStudentList("*", " Studentlist_view ", " Major = '" + User.Subject + "'");

            
            dgridAttendance.DataSource = dTable;
            DataGridViewComboBoxColumn cmbattendance = new DataGridViewComboBoxColumn();
            cmbattendance.HeaderText = "Status";
            cmbattendance.Name = "Attendance";
            cmbattendance.Items.Add("Present");
            cmbattendance.Items.Add("Absent");
            cmbattendance.Items.Add("Permission");
            //dgridAttendance.Columns.AddRange(new DataGridViewColumn[] {cmbattendance});
            

            dgridAttendance.Columns.Add(cmbattendance);
            dgridAttendance.Columns[0].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[1].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[2].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[3].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[4].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[5].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[6].Width = dgridAttendance.Width / 9;
            dgridAttendance.Columns[7].Width = dgridAttendance.Width / 9;

            
            //default atten

        }

        private void dgridAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgridAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    if(dgridAttendance.Rows[e.RowIndex].Cells[0].Value.ToString() == "Present")
            //    {
            //        MessageBox.Show(dgridAttendance.Rows[1].Cells[7].Value.ToString());
            //    }
                
                
            //}
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Loop through the attendance list to submit the attendance
            
            int present=0;
            int permission=0;
            int absent=0;
            bool blank = false;
            for (int i = 0; i < dgridAttendance.Rows.Count; i++)
            {
                if (dgridAttendance.Rows[i].Cells[0].Value == null)
                {
                    blank = true;
                    break;
                }
            }
            if (blank == false)
            {
                for (int i = 0; i < dgridAttendance.Rows.Count; i++)
                {
                    if (dgridAttendance.Rows[i].Cells[0].Value.ToString() == "Present")
                    {
                        present++;
                    }
                    else if (dgridAttendance.Rows[i].Cells[0].Value.ToString() == "Permission")
                    {
                        permission++;
                    }
                    else if (dgridAttendance.Rows[i].Cells[0].Value.ToString() == "Absent")
                    {
                        absent++;
                    }
                    amt.attendance(dgridAttendance.Rows[i].Cells[1].Value.ToString(), dgridAttendance.Rows[i].Cells[0].Value.ToString());
                }
                MessageBox.Show("Sumit Completed \n Present: " + present + ", Permission: " + permission + ", absent: " + absent);
                amt.attendanceRate(present, permission, absent);
            }
            else
            {
                MessageBox.Show("Please submit all of the attendance status!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        ComboBox combo = new ComboBox();
        private void dgridAttendance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //combo = e.Control as ComboBox;  
            //if(combo != null)
            //{
            //    combo.SelectedIndexChanged -= new EventHandler(combo_selectedIndexChanged);
            //    combo.SelectedIndexChanged += combo_selectedIndexChanged;
            //}
            
        }
        private void combo_selectedIndexChanged(object sender, EventArgs e)
        {
            //string selected = (sender as ComboBox).SelectedItem.ToString();
            //MessageBox.Show(selected);
        }

        private void dgridAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
