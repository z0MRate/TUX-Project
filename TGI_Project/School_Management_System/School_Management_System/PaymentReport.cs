using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace School_Management_System
{
    public partial class PaymentReport : Form
    {
        public PaymentReport()
        {
            InitializeComponent();
        }

        private void pnlReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentReport_Load(object sender, EventArgs e)
        {
            lblName.Text = Paymentfrm.studentname;
            lblSex.Text = Paymentfrm.sex;
            lblSubject.Text = Paymentfrm.major;
            lblCoursePrice.Text = Paymentfrm.coursefee + " $";
            lblcourseStart.Text = Paymentfrm.coursestart.ToString();
            lblpayAmounnt.Text = Paymentfrm.paidamount + " $";
            lblreportData.Text = DateTime.Now.ToString();
        }

        private void print(Panel pnl)
        {
          
            pnlReport = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            //printDocument1.PrintPage += PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();   
        }
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            
            pnl.DrawToBitmap(memoryimg, new Rectangle(0,0,pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagarea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagarea.Width/2) - (this.pnlReport.Width/2)+100, this.pnlReport.Location.Y+75);   
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            print(this.pnlReport);
        }
    }
}
