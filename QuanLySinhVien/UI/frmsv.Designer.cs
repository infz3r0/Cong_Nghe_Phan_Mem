﻿namespace UI_Tier
{
    partial class frmsv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsv));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.txtmailsv = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaLopSV = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtdienthoaisv = new DevExpress.XtraEditors.TextEdit();
            this.txtcmndsv = new DevExpress.XtraEditors.TextEdit();
            this.txtmssv = new DevExpress.XtraEditors.TextEdit();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtdicchisv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ngaysinhsv = new System.Windows.Forms.DateTimePicker();
            this.txttensv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnthemsv = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuasv = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatsv = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoasv = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridviewsv = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailsv.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoaisv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmndsv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmssv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdicchisv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttensv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsv)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // txtmailsv
            // 
            this.txtmailsv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmailsv.Location = new System.Drawing.Point(909, 193);
            this.txtmailsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmailsv.Name = "txtmailsv";
            this.txtmailsv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmailsv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmailsv.Properties.Appearance.Options.UseBackColor = true;
            this.txtmailsv.Properties.Appearance.Options.UseForeColor = true;
            this.txtmailsv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmailsv.Properties.Mask.EditMask = "([a-z]|[0-9]|\\.|_)+@([a-z]|[0-9])+\\.([a-z]|[0-9])+";
            this.txtmailsv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmailsv.Size = new System.Drawing.Size(310, 22);
            this.txtmailsv.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbMaLopSV);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtdienthoaisv);
            this.groupBox1.Controls.Add(this.txtcmndsv);
            this.groupBox1.Controls.Add(this.txtmssv);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.txtmailsv);
            this.groupBox1.Controls.Add(this.txtdicchisv);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.ngaysinhsv);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1345, 311);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbMaLopSV
            // 
            this.cbbMaLopSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbMaLopSV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbMaLopSV.FormattingEnabled = true;
            this.cbbMaLopSV.Location = new System.Drawing.Point(909, 246);
            this.cbbMaLopSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaLopSV.Name = "cbbMaLopSV";
            this.cbbMaLopSV.Size = new System.Drawing.Size(310, 31);
            this.cbbMaLopSV.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(792, 245);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 29);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Mã lớp";
            // 
            // txtdienthoaisv
            // 
            this.txtdienthoaisv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdienthoaisv.Location = new System.Drawing.Point(909, 143);
            this.txtdienthoaisv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdienthoaisv.Name = "txtdienthoaisv";
            this.txtdienthoaisv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtdienthoaisv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtdienthoaisv.Properties.Appearance.Options.UseBackColor = true;
            this.txtdienthoaisv.Properties.Appearance.Options.UseForeColor = true;
            this.txtdienthoaisv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtdienthoaisv.Properties.Mask.EditMask = "\\d{8,12}";
            this.txtdienthoaisv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtdienthoaisv.Size = new System.Drawing.Size(310, 22);
            this.txtdienthoaisv.TabIndex = 6;
            // 
            // txtcmndsv
            // 
            this.txtcmndsv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcmndsv.Location = new System.Drawing.Point(909, 87);
            this.txtcmndsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcmndsv.Name = "txtcmndsv";
            this.txtcmndsv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtcmndsv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtcmndsv.Properties.Appearance.Options.UseBackColor = true;
            this.txtcmndsv.Properties.Appearance.Options.UseForeColor = true;
            this.txtcmndsv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtcmndsv.Properties.Mask.EditMask = "\\d+";
            this.txtcmndsv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtcmndsv.Properties.MaxLength = 15;
            this.txtcmndsv.Size = new System.Drawing.Size(310, 22);
            this.txtcmndsv.TabIndex = 5;
            // 
            // txtmssv
            // 
            this.txtmssv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmssv.Location = new System.Drawing.Point(297, 39);
            this.txtmssv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmssv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmssv.Properties.Appearance.Options.UseBackColor = true;
            this.txtmssv.Properties.Appearance.Options.UseForeColor = true;
            this.txtmssv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmssv.Properties.Mask.EditMask = "\\d{10}";
            this.txtmssv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmssv.Size = new System.Drawing.Size(310, 22);
            this.txtmssv.TabIndex = 0;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(297, 187);
            this.cbbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(310, 31);
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // txtdicchisv
            // 
            this.txtdicchisv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdicchisv.Location = new System.Drawing.Point(909, 41);
            this.txtdicchisv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdicchisv.Name = "txtdicchisv";
            this.txtdicchisv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtdicchisv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtdicchisv.Properties.Appearance.Options.UseBackColor = true;
            this.txtdicchisv.Properties.Appearance.Options.UseForeColor = true;
            this.txtdicchisv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtdicchisv.Properties.MaxLength = 500;
            this.txtdicchisv.Size = new System.Drawing.Size(310, 22);
            this.txtdicchisv.TabIndex = 4;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(794, 190);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 29);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Email";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(794, 139);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(108, 29);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Điện thoại";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(794, 86);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 29);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "CMND";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(794, 34);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 29);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // ngaysinhsv
            // 
            this.ngaysinhsv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ngaysinhsv.CustomFormat = "dd/MM/yyyy";
            this.ngaysinhsv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaysinhsv.Location = new System.Drawing.Point(297, 134);
            this.ngaysinhsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ngaysinhsv.Name = "ngaysinhsv";
            this.ngaysinhsv.Size = new System.Drawing.Size(310, 30);
            this.ngaysinhsv.TabIndex = 2;
            // 
            // txttensv
            // 
            this.txttensv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensv.Location = new System.Drawing.Point(297, 87);
            this.txttensv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttensv.Name = "txttensv";
            this.txttensv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttensv.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttensv.Properties.Appearance.Options.UseBackColor = true;
            this.txttensv.Properties.Appearance.Options.UseForeColor = true;
            this.txttensv.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txttensv.Properties.MaxLength = 50;
            this.txttensv.Size = new System.Drawing.Size(310, 22);
            this.txttensv.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(181, 186);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 29);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Giới tính";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(181, 132);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 29);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(181, 81);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Họ tên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(181, 33);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 29);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mssv";
            // 
            // btnthemsv
            // 
            this.btnthemsv.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemsv.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemsv.Appearance.Options.UseFont = true;
            this.btnthemsv.Appearance.Options.UseForeColor = true;
            this.btnthemsv.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnthemsv.AppearanceDisabled.Options.UseBackColor = true;
            this.btnthemsv.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnthemsv.AppearanceHovered.Options.UseBackColor = true;
            this.btnthemsv.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnthemsv.AppearancePressed.Options.UseBackColor = true;
            this.btnthemsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemsv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemsv.ImageOptions.Image")));
            this.btnthemsv.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemsv.Location = new System.Drawing.Point(75, 31);
            this.btnthemsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemsv.Name = "btnthemsv";
            this.btnthemsv.Size = new System.Drawing.Size(112, 41);
            this.btnthemsv.TabIndex = 8;
            this.btnthemsv.Text = "Thêm";
            this.btnthemsv.Click += new System.EventHandler(this.btnthemsv_Click);
            // 
            // btnsuasv
            // 
            this.btnsuasv.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuasv.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuasv.Appearance.Options.UseFont = true;
            this.btnsuasv.Appearance.Options.UseForeColor = true;
            this.btnsuasv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuasv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuasv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuasv.ImageOptions.Image")));
            this.btnsuasv.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuasv.Location = new System.Drawing.Point(194, 31);
            this.btnsuasv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuasv.Name = "btnsuasv";
            this.btnsuasv.Size = new System.Drawing.Size(112, 41);
            this.btnsuasv.TabIndex = 9;
            this.btnsuasv.Text = "Sửa ";
            this.btnsuasv.Click += new System.EventHandler(this.btnsuasv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatsv);
            this.groupBox2.Controls.Add(this.btnxoasv);
            this.groupBox2.Controls.Add(this.btnsuasv);
            this.groupBox2.Controls.Add(this.btnthemsv);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(784, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(572, 94);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatsv
            // 
            this.btnthoatsv.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatsv.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatsv.Appearance.Options.UseFont = true;
            this.btnthoatsv.Appearance.Options.UseForeColor = true;
            this.btnthoatsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatsv.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatsv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatsv.ImageOptions.Image")));
            this.btnthoatsv.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatsv.Location = new System.Drawing.Point(432, 31);
            this.btnthoatsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatsv.Name = "btnthoatsv";
            this.btnthoatsv.Size = new System.Drawing.Size(112, 41);
            this.btnthoatsv.TabIndex = 11;
            this.btnthoatsv.Text = "Đóng";
            this.btnthoatsv.Click += new System.EventHandler(this.btnthoatsv_Click);
            // 
            // btnxoasv
            // 
            this.btnxoasv.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoasv.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoasv.Appearance.Options.UseFont = true;
            this.btnxoasv.Appearance.Options.UseForeColor = true;
            this.btnxoasv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoasv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoasv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoasv.ImageOptions.Image")));
            this.btnxoasv.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoasv.Location = new System.Drawing.Point(313, 31);
            this.btnxoasv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoasv.Name = "btnxoasv";
            this.btnxoasv.Size = new System.Drawing.Size(112, 41);
            this.btnxoasv.TabIndex = 10;
            this.btnxoasv.Text = "Xóa";
            this.btnxoasv.Click += new System.EventHandler(this.btnxoasv_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewsv);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 426);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1345, 302);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridviewsv
            // 
            this.gridviewsv.AllowUserToAddRows = false;
            this.gridviewsv.AllowUserToDeleteRows = false;
            this.gridviewsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewsv.BackgroundColor = System.Drawing.Color.White;
            this.gridviewsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.SoCMND,
            this.DienThoai,
            this.Email,
            this.MaLop});
            this.gridviewsv.Location = new System.Drawing.Point(7, 27);
            this.gridviewsv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridviewsv.MultiSelect = false;
            this.gridviewsv.Name = "gridviewsv";
            this.gridviewsv.ReadOnly = true;
            this.gridviewsv.RowHeadersVisible = false;
            this.gridviewsv.Size = new System.Drawing.Size(1331, 267);
            this.gridviewsv.TabIndex = 9;
            this.gridviewsv.TabStop = false;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MaSV.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaSV.HeaderText = "MSSV";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.HoTen.DefaultCellStyle = dataGridViewCellStyle2;
            this.HoTen.HeaderText = "Họ và Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.NgaySinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.GioiTinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoCMND
            // 
            this.SoCMND.DataPropertyName = "SoCMND";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.SoCMND.DefaultCellStyle = dataGridViewCellStyle6;
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            this.SoCMND.ReadOnly = true;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "Sdt";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.DienThoai.DefaultCellStyle = dataGridViewCellStyle7;
            this.DienThoai.HeaderText = "Điện thoại";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.Email.DefaultCellStyle = dataGridViewCellStyle8;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.MaLop.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // frmsv
            // 
            this.AcceptButton = this.btnthemsv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoatsv;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmsv";
            this.Text = "QUẢN LÍ SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsv_FormClosing);
            this.Load += new System.EventHandler(this.frmsv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmailsv.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdienthoaisv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcmndsv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmssv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdicchisv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttensv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit txtmailsv;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtdicchisv;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker ngaysinhsv;
        private DevExpress.XtraEditors.TextEdit txttensv;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnthemsv;
        private DevExpress.XtraEditors.SimpleButton btnsuasv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoatsv;
        private DevExpress.XtraEditors.SimpleButton btnxoasv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridviewsv;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private DevExpress.XtraEditors.TextEdit txtdienthoaisv;
        private DevExpress.XtraEditors.TextEdit txtcmndsv;
        private DevExpress.XtraEditors.TextEdit txtmssv;
        private System.Windows.Forms.ComboBox cbbMaLopSV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
    }
}