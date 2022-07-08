﻿namespace School_Management_System
{
    partial class StudentInformationfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbselectMajor = new MaterialSkin.Controls.MaterialComboBox();
            this.txtSearchStudentInfo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.dgridStudentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(850, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 49);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbselectMajor
            // 
            this.cmbselectMajor.AutoResize = false;
            this.cmbselectMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbselectMajor.Depth = 0;
            this.cmbselectMajor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbselectMajor.DropDownHeight = 174;
            this.cmbselectMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbselectMajor.DropDownWidth = 121;
            this.cmbselectMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbselectMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbselectMajor.FormattingEnabled = true;
            this.cmbselectMajor.IntegralHeight = false;
            this.cmbselectMajor.ItemHeight = 43;
            this.cmbselectMajor.Items.AddRange(new object[] {
            "Artificial Intelligence",
            "App/Web Development",
            "Cyber Security",
            "Digital Marketing",
            "Fintech",
            "UX/UI Design"});
            this.cmbselectMajor.Location = new System.Drawing.Point(454, 17);
            this.cmbselectMajor.MaxDropDownItems = 4;
            this.cmbselectMajor.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbselectMajor.Name = "cmbselectMajor";
            this.cmbselectMajor.Size = new System.Drawing.Size(316, 49);
            this.cmbselectMajor.StartIndex = 0;
            this.cmbselectMajor.TabIndex = 10;
            this.cmbselectMajor.TextChanged += new System.EventHandler(this.cmbselectMajor_TextChanged);
            // 
            // txtSearchStudentInfo
            // 
            this.txtSearchStudentInfo.AllowPromptAsInput = true;
            this.txtSearchStudentInfo.AnimateReadOnly = false;
            this.txtSearchStudentInfo.AsciiOnly = false;
            this.txtSearchStudentInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchStudentInfo.BeepOnError = false;
            this.txtSearchStudentInfo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearchStudentInfo.Depth = 0;
            this.txtSearchStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchStudentInfo.HidePromptOnLeave = false;
            this.txtSearchStudentInfo.HideSelection = true;
            this.txtSearchStudentInfo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSearchStudentInfo.LeadingIcon = null;
            this.txtSearchStudentInfo.Location = new System.Drawing.Point(26, 17);
            this.txtSearchStudentInfo.Mask = "";
            this.txtSearchStudentInfo.MaxLength = 32767;
            this.txtSearchStudentInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchStudentInfo.Name = "txtSearchStudentInfo";
            this.txtSearchStudentInfo.PasswordChar = '\0';
            this.txtSearchStudentInfo.PrefixSuffixText = null;
            this.txtSearchStudentInfo.PromptChar = '_';
            this.txtSearchStudentInfo.ReadOnly = false;
            this.txtSearchStudentInfo.RejectInputOnFirstFailure = false;
            this.txtSearchStudentInfo.ResetOnPrompt = true;
            this.txtSearchStudentInfo.ResetOnSpace = true;
            this.txtSearchStudentInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchStudentInfo.SelectedText = "";
            this.txtSearchStudentInfo.SelectionLength = 0;
            this.txtSearchStudentInfo.SelectionStart = 0;
            this.txtSearchStudentInfo.ShortcutsEnabled = true;
            this.txtSearchStudentInfo.Size = new System.Drawing.Size(316, 48);
            this.txtSearchStudentInfo.SkipLiterals = true;
            this.txtSearchStudentInfo.TabIndex = 9;
            this.txtSearchStudentInfo.TabStop = false;
            this.txtSearchStudentInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchStudentInfo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSearchStudentInfo.TrailingIcon = null;
            this.txtSearchStudentInfo.UseSystemPasswordChar = false;
            this.txtSearchStudentInfo.ValidatingType = null;
            this.txtSearchStudentInfo.TextChanged += new System.EventHandler(this.txtSearchStudentInfo_TextChanged);
            // 
            // dgridStudentList
            // 
            this.dgridStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgridStudentList.BackgroundColor = System.Drawing.Color.White;
            this.dgridStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridStudentList.Location = new System.Drawing.Point(26, 85);
            this.dgridStudentList.MultiSelect = false;
            this.dgridStudentList.Name = "dgridStudentList";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgridStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgridStudentList.RowHeadersWidth = 51;
            this.dgridStudentList.RowTemplate.Height = 24;
            this.dgridStudentList.Size = new System.Drawing.Size(1592, 779);
            this.dgridStudentList.TabIndex = 8;
            this.dgridStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridStudentList_CellClick);
            // 
            // StudentInformationfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 890);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbselectMajor);
            this.Controls.Add(this.txtSearchStudentInfo);
            this.Controls.Add(this.dgridStudentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentInformationfrm";
            this.Text = "StudentInformationfrm";
            this.Load += new System.EventHandler(this.StudentInformationfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private MaterialSkin.Controls.MaterialComboBox cmbselectMajor;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtSearchStudentInfo;
        private System.Windows.Forms.DataGridView dgridStudentList;
    }
}