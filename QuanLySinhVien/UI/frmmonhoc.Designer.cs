﻿namespace UI_Tier
{
    partial class frmmonhoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmonhoc));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridviewhp = new System.Windows.Forms.DataGridView();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoDQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongSoDThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrongSoDThi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTrongSoDQT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbLoaiHocPhan = new System.Windows.Forms.ComboBox();
            this.txtmahp = new DevExpress.XtraEditors.TextEdit();
            this.txtstchp = new DevExpress.XtraEditors.TextEdit();
            this.txttenhp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnthoathp = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnxoahp = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuahp = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemhp = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewhp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSoDThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSoDQT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstchp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenhp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewhp);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 315);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1119, 278);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridviewhp
            // 
            this.gridviewhp.AllowUserToAddRows = false;
            this.gridviewhp.AllowUserToDeleteRows = false;
            this.gridviewhp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewhp.BackgroundColor = System.Drawing.Color.White;
            this.gridviewhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewhp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.TenHP,
            this.SoTC,
            this.LoaiHP,
            this.TrongSoDQT,
            this.TrongSoDThi});
            this.gridviewhp.Location = new System.Drawing.Point(7, 28);
            this.gridviewhp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridviewhp.MultiSelect = false;
            this.gridviewhp.Name = "gridviewhp";
            this.gridviewhp.ReadOnly = true;
            this.gridviewhp.RowHeadersVisible = false;
            this.gridviewhp.Size = new System.Drawing.Size(1105, 236);
            this.gridviewhp.TabIndex = 9;
            this.gridviewhp.TabStop = false;
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MaHP";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MaHP.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaHP.HeaderText = "Mã học phần";
            this.MaHP.Name = "MaHP";
            this.MaHP.ReadOnly = true;
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.TenHP.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenHP.HeaderText = "Tên học phần";
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTinChi";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.SoTC.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            // 
            // LoaiHP
            // 
            this.LoaiHP.DataPropertyName = "LoaiHP";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.LoaiHP.DefaultCellStyle = dataGridViewCellStyle4;
            this.LoaiHP.HeaderText = "Loại học phần";
            this.LoaiHP.Name = "LoaiHP";
            this.LoaiHP.ReadOnly = true;
            // 
            // TrongSoDQT
            // 
            this.TrongSoDQT.DataPropertyName = "TrongSoDQT";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.TrongSoDQT.DefaultCellStyle = dataGridViewCellStyle5;
            this.TrongSoDQT.HeaderText = "Trọng số điểm quá trình";
            this.TrongSoDQT.Name = "TrongSoDQT";
            this.TrongSoDQT.ReadOnly = true;
            // 
            // TrongSoDThi
            // 
            this.TrongSoDThi.DataPropertyName = "TrongSoDThi";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.TrongSoDThi.DefaultCellStyle = dataGridViewCellStyle6;
            this.TrongSoDThi.HeaderText = "Trọng số điểm thi";
            this.TrongSoDThi.Name = "TrongSoDThi";
            this.TrongSoDThi.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtTrongSoDThi);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtTrongSoDQT);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cbbLoaiHocPhan);
            this.groupBox1.Controls.Add(this.txtmahp);
            this.groupBox1.Controls.Add(this.txtstchp);
            this.groupBox1.Controls.Add(this.txttenhp);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1119, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtTrongSoDThi
            // 
            this.txtTrongSoDThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrongSoDThi.Location = new System.Drawing.Point(838, 144);
            this.txtTrongSoDThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrongSoDThi.Name = "txtTrongSoDThi";
            this.txtTrongSoDThi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTrongSoDThi.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTrongSoDThi.Properties.Appearance.Options.UseBackColor = true;
            this.txtTrongSoDThi.Properties.Appearance.Options.UseForeColor = true;
            this.txtTrongSoDThi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtTrongSoDThi.Properties.Mask.EditMask = "0\\.\\d{1,4}";
            this.txtTrongSoDThi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTrongSoDThi.Size = new System.Drawing.Size(255, 22);
            this.txtTrongSoDThi.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(589, 138);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(188, 29);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Trọng số điểm thi";
            // 
            // txtTrongSoDQT
            // 
            this.txtTrongSoDQT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTrongSoDQT.Location = new System.Drawing.Point(838, 95);
            this.txtTrongSoDQT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrongSoDQT.Name = "txtTrongSoDQT";
            this.txtTrongSoDQT.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTrongSoDQT.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtTrongSoDQT.Properties.Appearance.Options.UseBackColor = true;
            this.txtTrongSoDQT.Properties.Appearance.Options.UseForeColor = true;
            this.txtTrongSoDQT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtTrongSoDQT.Properties.Mask.EditMask = "0\\.\\d{1,4}";
            this.txtTrongSoDQT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTrongSoDQT.Size = new System.Drawing.Size(255, 22);
            this.txtTrongSoDQT.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(589, 89);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 29);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Trọng số điểm quá trình";
            // 
            // cbbLoaiHocPhan
            // 
            this.cbbLoaiHocPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHocPhan.FormattingEnabled = true;
            this.cbbLoaiHocPhan.Items.AddRange(new object[] {
            "Học phần bắt buộc",
            "Học phần tự chọn ",
            "Học phần bắt buộc tự chọn tuỳ ý"});
            this.cbbLoaiHocPhan.Location = new System.Drawing.Point(838, 41);
            this.cbbLoaiHocPhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLoaiHocPhan.Name = "cbbLoaiHocPhan";
            this.cbbLoaiHocPhan.Size = new System.Drawing.Size(255, 31);
            this.cbbLoaiHocPhan.TabIndex = 3;
            // 
            // txtmahp
            // 
            this.txtmahp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmahp.Location = new System.Drawing.Point(183, 41);
            this.txtmahp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmahp.Name = "txtmahp";
            this.txtmahp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmahp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmahp.Properties.Appearance.Options.UseBackColor = true;
            this.txtmahp.Properties.Appearance.Options.UseForeColor = true;
            this.txtmahp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmahp.Properties.Mask.EditMask = "[A-Z]{3}\\d{3}";
            this.txtmahp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmahp.Size = new System.Drawing.Size(346, 22);
            this.txtmahp.TabIndex = 0;
            // 
            // txtstchp
            // 
            this.txtstchp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstchp.Location = new System.Drawing.Point(183, 139);
            this.txtstchp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstchp.Name = "txtstchp";
            this.txtstchp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtstchp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtstchp.Properties.Appearance.Options.UseBackColor = true;
            this.txtstchp.Properties.Appearance.Options.UseForeColor = true;
            this.txtstchp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtstchp.Properties.Mask.EditMask = "[1-9]\\d?";
            this.txtstchp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtstchp.Size = new System.Drawing.Size(346, 22);
            this.txtstchp.TabIndex = 2;
            // 
            // txttenhp
            // 
            this.txttenhp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenhp.Location = new System.Drawing.Point(183, 90);
            this.txttenhp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttenhp.Name = "txttenhp";
            this.txttenhp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttenhp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttenhp.Properties.Appearance.Options.UseBackColor = true;
            this.txttenhp.Properties.Appearance.Options.UseForeColor = true;
            this.txttenhp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txttenhp.Properties.Mask.EditMask = "\\w+( \\w+)*";
            this.txttenhp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txttenhp.Properties.MaxLength = 100;
            this.txttenhp.Size = new System.Drawing.Size(346, 22);
            this.txttenhp.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(589, 38);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(148, 29);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Loại học phần";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 133);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 29);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số tín chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 82);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(145, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên học phần";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 37);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 29);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã học phần";
            // 
            // btnthoathp
            // 
            this.btnthoathp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoathp.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoathp.Appearance.Options.UseFont = true;
            this.btnthoathp.Appearance.Options.UseForeColor = true;
            this.btnthoathp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoathp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoathp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoathp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoathp.ImageOptions.Image")));
            this.btnthoathp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoathp.Location = new System.Drawing.Point(446, 28);
            this.btnthoathp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoathp.Name = "btnthoathp";
            this.btnthoathp.Size = new System.Drawing.Size(112, 41);
            this.btnthoathp.TabIndex = 3;
            this.btnthoathp.Text = "Đóng";
            this.btnthoathp.Click += new System.EventHandler(this.btnthoathp_Click);
            // 
            // btnxoahp
            // 
            this.btnxoahp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoahp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoahp.Appearance.Options.UseFont = true;
            this.btnxoahp.Appearance.Options.UseForeColor = true;
            this.btnxoahp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoahp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoahp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoahp.ImageOptions.Image")));
            this.btnxoahp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoahp.Location = new System.Drawing.Point(327, 28);
            this.btnxoahp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoahp.Name = "btnxoahp";
            this.btnxoahp.Size = new System.Drawing.Size(112, 41);
            this.btnxoahp.TabIndex = 2;
            this.btnxoahp.Text = "Xóa";
            this.btnxoahp.Click += new System.EventHandler(this.btnxoahp_Click);
            // 
            // btnsuahp
            // 
            this.btnsuahp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuahp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuahp.Appearance.Options.UseFont = true;
            this.btnsuahp.Appearance.Options.UseForeColor = true;
            this.btnsuahp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuahp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuahp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuahp.ImageOptions.Image")));
            this.btnsuahp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuahp.Location = new System.Drawing.Point(208, 28);
            this.btnsuahp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsuahp.Name = "btnsuahp";
            this.btnsuahp.Size = new System.Drawing.Size(112, 41);
            this.btnsuahp.TabIndex = 1;
            this.btnsuahp.Text = "Sửa ";
            this.btnsuahp.Click += new System.EventHandler(this.btnsuahp_Click);
            // 
            // btnthemhp
            // 
            this.btnthemhp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemhp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemhp.Appearance.Options.UseFont = true;
            this.btnthemhp.Appearance.Options.UseForeColor = true;
            this.btnthemhp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemhp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemhp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemhp.ImageOptions.Image")));
            this.btnthemhp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemhp.Location = new System.Drawing.Point(89, 28);
            this.btnthemhp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemhp.Name = "btnthemhp";
            this.btnthemhp.Size = new System.Drawing.Size(112, 41);
            this.btnthemhp.TabIndex = 0;
            this.btnthemhp.Text = "Thêm";
            this.btnthemhp.Click += new System.EventHandler(this.btnthemhp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoathp);
            this.groupBox2.Controls.Add(this.btnxoahp);
            this.groupBox2.Controls.Add(this.btnsuahp);
            this.groupBox2.Controls.Add(this.btnthemhp);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(549, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(583, 87);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // frmmonhoc
            // 
            this.AcceptButton = this.btnthemhp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoathp;
            this.ClientSize = new System.Drawing.Size(1147, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmmonhoc";
            this.Text = "QUẢN LÍ MÔN HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmonhoc_FormClosing);
            this.Load += new System.EventHandler(this.frmmonhoc_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewhp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSoDThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSoDQT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstchp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenhp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridviewhp;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtstchp;
        private DevExpress.XtraEditors.TextEdit txttenhp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnthoathp;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnxoahp;
        private DevExpress.XtraEditors.SimpleButton btnsuahp;
        private DevExpress.XtraEditors.SimpleButton btnthemhp;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtmahp;
        private System.Windows.Forms.ComboBox cbbLoaiHocPhan;
        private DevExpress.XtraEditors.TextEdit txtTrongSoDThi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTrongSoDQT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoDQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongSoDThi;
    }
}