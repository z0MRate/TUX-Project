namespace School_Management_System
{
    partial class Paymentfrm
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
            this.dgridStudentPayment = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStudentID = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCourseFee = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPaidFee = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtReaminFee = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPaymentList = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMajor = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpCourseStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSex = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudentPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgridStudentPayment
            // 
            this.dgridStudentPayment.AllowUserToAddRows = false;
            this.dgridStudentPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridStudentPayment.Location = new System.Drawing.Point(44, 45);
            this.dgridStudentPayment.Name = "dgridStudentPayment";
            this.dgridStudentPayment.ReadOnly = true;
            this.dgridStudentPayment.RowHeadersWidth = 51;
            this.dgridStudentPayment.RowTemplate.Height = 24;
            this.dgridStudentPayment.Size = new System.Drawing.Size(759, 866);
            this.dgridStudentPayment.TabIndex = 0;
            this.dgridStudentPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridStudentPayment_CellClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(846, 144);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.HideSelection = true;
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(1000, 129);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(582, 48);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(846, 227);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "StudentID :";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.AnimateReadOnly = false;
            this.txtStudentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStudentID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStudentID.Depth = 0;
            this.txtStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStudentID.HideSelection = true;
            this.txtStudentID.LeadingIcon = null;
            this.txtStudentID.Location = new System.Drawing.Point(1000, 212);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PrefixSuffixText = null;
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.SelectionLength = 0;
            this.txtStudentID.SelectionStart = 0;
            this.txtStudentID.ShortcutsEnabled = true;
            this.txtStudentID.Size = new System.Drawing.Size(582, 48);
            this.txtStudentID.TabIndex = 13;
            this.txtStudentID.TabStop = false;
            this.txtStudentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStudentID.TrailingIcon = null;
            this.txtStudentID.UseSystemPasswordChar = false;
            this.txtStudentID.Click += new System.EventHandler(this.txtStudentID_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(846, 310);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.HideSelection = true;
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(1000, 295);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(582, 48);
            this.txtUsername.TabIndex = 17;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(846, 616);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(87, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Course Fee :";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.AnimateReadOnly = false;
            this.txtCourseFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCourseFee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCourseFee.Depth = 0;
            this.txtCourseFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseFee.HideSelection = true;
            this.txtCourseFee.LeadingIcon = null;
            this.txtCourseFee.Location = new System.Drawing.Point(1000, 601);
            this.txtCourseFee.MaxLength = 32767;
            this.txtCourseFee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.PasswordChar = '\0';
            this.txtCourseFee.PrefixSuffixText = null;
            this.txtCourseFee.ReadOnly = false;
            this.txtCourseFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCourseFee.SelectedText = "";
            this.txtCourseFee.SelectionLength = 0;
            this.txtCourseFee.SelectionStart = 0;
            this.txtCourseFee.ShortcutsEnabled = true;
            this.txtCourseFee.Size = new System.Drawing.Size(582, 48);
            this.txtCourseFee.TabIndex = 19;
            this.txtCourseFee.TabStop = false;
            this.txtCourseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCourseFee.TrailingIcon = null;
            this.txtCourseFee.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(846, 699);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(70, 19);
            this.materialLabel5.TabIndex = 22;
            this.materialLabel5.Text = "Paid Fee :";
            // 
            // txtPaidFee
            // 
            this.txtPaidFee.AnimateReadOnly = false;
            this.txtPaidFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPaidFee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPaidFee.Depth = 0;
            this.txtPaidFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaidFee.HideSelection = true;
            this.txtPaidFee.LeadingIcon = null;
            this.txtPaidFee.Location = new System.Drawing.Point(1000, 684);
            this.txtPaidFee.MaxLength = 32767;
            this.txtPaidFee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPaidFee.Name = "txtPaidFee";
            this.txtPaidFee.PasswordChar = '\0';
            this.txtPaidFee.PrefixSuffixText = null;
            this.txtPaidFee.ReadOnly = false;
            this.txtPaidFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPaidFee.SelectedText = "";
            this.txtPaidFee.SelectionLength = 0;
            this.txtPaidFee.SelectionStart = 0;
            this.txtPaidFee.ShortcutsEnabled = true;
            this.txtPaidFee.Size = new System.Drawing.Size(582, 48);
            this.txtPaidFee.TabIndex = 21;
            this.txtPaidFee.TabStop = false;
            this.txtPaidFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPaidFee.TrailingIcon = null;
            this.txtPaidFee.UseSystemPasswordChar = false;
            this.txtPaidFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidFee_KeyPress);
            this.txtPaidFee.TextChanged += new System.EventHandler(this.txtPaidFee_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(846, 782);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(92, 19);
            this.materialLabel6.TabIndex = 24;
            this.materialLabel6.Text = "Remain Fee :";
            // 
            // txtReaminFee
            // 
            this.txtReaminFee.AnimateReadOnly = false;
            this.txtReaminFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtReaminFee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtReaminFee.Depth = 0;
            this.txtReaminFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtReaminFee.HideSelection = true;
            this.txtReaminFee.LeadingIcon = null;
            this.txtReaminFee.Location = new System.Drawing.Point(1000, 767);
            this.txtReaminFee.MaxLength = 32767;
            this.txtReaminFee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtReaminFee.Name = "txtReaminFee";
            this.txtReaminFee.PasswordChar = '\0';
            this.txtReaminFee.PrefixSuffixText = null;
            this.txtReaminFee.ReadOnly = false;
            this.txtReaminFee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtReaminFee.SelectedText = "";
            this.txtReaminFee.SelectionLength = 0;
            this.txtReaminFee.SelectionStart = 0;
            this.txtReaminFee.ShortcutsEnabled = true;
            this.txtReaminFee.Size = new System.Drawing.Size(582, 48);
            this.txtReaminFee.TabIndex = 23;
            this.txtReaminFee.TabStop = false;
            this.txtReaminFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReaminFee.TrailingIcon = null;
            this.txtReaminFee.UseSystemPasswordChar = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(835, 851);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 60);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(1364, 851);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(194, 60);
            this.btnReport.TabIndex = 26;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(846, 60);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(102, 19);
            this.materialLabel7.TabIndex = 28;
            this.materialLabel7.Text = "Payment List: ";
            // 
            // cmbPaymentList
            // 
            this.cmbPaymentList.AutoResize = false;
            this.cmbPaymentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPaymentList.Depth = 0;
            this.cmbPaymentList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbPaymentList.DropDownHeight = 174;
            this.cmbPaymentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentList.DropDownWidth = 121;
            this.cmbPaymentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbPaymentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbPaymentList.FormattingEnabled = true;
            this.cmbPaymentList.IntegralHeight = false;
            this.cmbPaymentList.ItemHeight = 43;
            this.cmbPaymentList.Items.AddRange(new object[] {
            "All Student",
            "New Student",
            "Not Finished Payment",
            "Finished Payment"});
            this.cmbPaymentList.Location = new System.Drawing.Point(1000, 45);
            this.cmbPaymentList.MaxDropDownItems = 4;
            this.cmbPaymentList.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbPaymentList.Name = "cmbPaymentList";
            this.cmbPaymentList.Size = new System.Drawing.Size(582, 49);
            this.cmbPaymentList.StartIndex = 0;
            this.cmbPaymentList.TabIndex = 29;
            this.cmbPaymentList.TextChanged += new System.EventHandler(this.cmbPaymentList_TextChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(846, 476);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(50, 19);
            this.materialLabel8.TabIndex = 31;
            this.materialLabel8.Text = "Major :";
            // 
            // txtMajor
            // 
            this.txtMajor.AnimateReadOnly = false;
            this.txtMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtMajor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMajor.Depth = 0;
            this.txtMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMajor.HideSelection = true;
            this.txtMajor.LeadingIcon = null;
            this.txtMajor.Location = new System.Drawing.Point(1000, 461);
            this.txtMajor.MaxLength = 32767;
            this.txtMajor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.PasswordChar = '\0';
            this.txtMajor.PrefixSuffixText = null;
            this.txtMajor.ReadOnly = false;
            this.txtMajor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMajor.SelectedText = "";
            this.txtMajor.SelectionLength = 0;
            this.txtMajor.SelectionStart = 0;
            this.txtMajor.ShortcutsEnabled = true;
            this.txtMajor.Size = new System.Drawing.Size(582, 48);
            this.txtMajor.TabIndex = 30;
            this.txtMajor.TabStop = false;
            this.txtMajor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMajor.TrailingIcon = null;
            this.txtMajor.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(846, 546);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(96, 19);
            this.materialLabel9.TabIndex = 33;
            this.materialLabel9.Text = "Course Start :";
            // 
            // dtpCourseStart
            // 
            this.dtpCourseStart.Location = new System.Drawing.Point(1000, 544);
            this.dtpCourseStart.Name = "dtpCourseStart";
            this.dtpCourseStart.Size = new System.Drawing.Size(582, 22);
            this.dtpCourseStart.TabIndex = 34;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(846, 393);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(39, 19);
            this.materialLabel10.TabIndex = 36;
            this.materialLabel10.Text = "Sex : ";
            // 
            // txtSex
            // 
            this.txtSex.AnimateReadOnly = false;
            this.txtSex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSex.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSex.Depth = 0;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSex.HideSelection = true;
            this.txtSex.LeadingIcon = null;
            this.txtSex.Location = new System.Drawing.Point(1000, 378);
            this.txtSex.MaxLength = 32767;
            this.txtSex.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSex.Name = "txtSex";
            this.txtSex.PasswordChar = '\0';
            this.txtSex.PrefixSuffixText = null;
            this.txtSex.ReadOnly = false;
            this.txtSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSex.SelectedText = "";
            this.txtSex.SelectionLength = 0;
            this.txtSex.SelectionStart = 0;
            this.txtSex.ShortcutsEnabled = true;
            this.txtSex.Size = new System.Drawing.Size(582, 48);
            this.txtSex.TabIndex = 35;
            this.txtSex.TabStop = false;
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSex.TrailingIcon = null;
            this.txtSex.UseSystemPasswordChar = false;
            // 
            // Paymentfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1638, 945);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.dtpCourseStart);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.cmbPaymentList);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txtReaminFee);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtPaidFee);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtCourseFee);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.dgridStudentPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paymentfrm";
            this.Text = "LecturerInformation";
            this.Load += new System.EventHandler(this.Paymentfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudentPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgridStudentPayment;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtStudentID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsername;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtCourseFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtPaidFee;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtReaminFee;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReport;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cmbPaymentList;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtMajor;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DateTimePicker dtpCourseStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox2 txtSex;
    }
}