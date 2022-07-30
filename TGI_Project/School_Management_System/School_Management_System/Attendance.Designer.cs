namespace School_Management_System
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgridAttendance = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridAttendance
            // 
            this.dgridAttendance.AllowUserToAddRows = false;
            this.dgridAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgridAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridAttendance.Location = new System.Drawing.Point(53, 12);
            this.dgridAttendance.Name = "dgridAttendance";
            this.dgridAttendance.RowHeadersWidth = 51;
            this.dgridAttendance.RowTemplate.Height = 24;
            this.dgridAttendance.Size = new System.Drawing.Size(1629, 581);
            this.dgridAttendance.TabIndex = 0;
            this.dgridAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridAttendance_CellClick);
            this.dgridAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridAttendance_CellContentClick);
            this.dgridAttendance.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgridAttendance_EditingControlShowing);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1402, 632);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 42);
            this.btnSubmit.TabIndex = 158;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1713, 831);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgridAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "RegisterLecturer";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridAttendance;
        public System.Windows.Forms.Button btnSubmit;
    }
}