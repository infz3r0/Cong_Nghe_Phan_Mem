using System;

namespace UI_Tier
{
    partial class frmdangkymonhoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangkymonhoc));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GridViewmonhoc = new System.Windows.Forms.DataGridView();
            this.chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mahp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malophp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimmon = new System.Windows.Forms.TextBox();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridViewdanhsach = new System.Windows.Forms.DataGridView();
            this.btnloc = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewmonhoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc theo môn học";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.GridViewmonhoc);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 75);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(845, 250);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // GridViewmonhoc
            // 
            this.GridViewmonhoc.AllowUserToAddRows = false;
            this.GridViewmonhoc.AllowUserToDeleteRows = false;
            this.GridViewmonhoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewmonhoc.BackgroundColor = System.Drawing.Color.White;
            this.GridViewmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chon,
            this.mahp,
            this.tenhp,
            this.malophp,
            this.sotinchi,
            this.soluongsv});
            this.GridViewmonhoc.Location = new System.Drawing.Point(22, 34);
            this.GridViewmonhoc.Name = "GridViewmonhoc";
            this.GridViewmonhoc.RowHeadersVisible = false;
            this.GridViewmonhoc.RowTemplate.Height = 24;
            this.GridViewmonhoc.Size = new System.Drawing.Size(806, 201);
            this.GridViewmonhoc.TabIndex = 0;
            // 
            // chon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = false;
            this.chon.DefaultCellStyle = dataGridViewCellStyle1;
            this.chon.HeaderText = "Chọn";
            this.chon.Name = "chon";
            // 
            // mahp
            // 
            this.mahp.DataPropertyName = "MaHP";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.mahp.DefaultCellStyle = dataGridViewCellStyle2;
            this.mahp.HeaderText = "Mã Học Phần";
            this.mahp.Name = "mahp";
            // 
            // tenhp
            // 
            this.tenhp.DataPropertyName = "TenHP";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.tenhp.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenhp.HeaderText = "Tên Học Phần";
            this.tenhp.Name = "tenhp";
            // 
            // malophp
            // 
            this.malophp.DataPropertyName = "MaLopHP";
            this.malophp.HeaderText = "Mã Lớp HP";
            this.malophp.Name = "malophp";
            // 
            // sotinchi
            // 
            this.sotinchi.DataPropertyName = "SoTinChi";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.sotinchi.DefaultCellStyle = dataGridViewCellStyle4;
            this.sotinchi.HeaderText = "Số Tín Chỉ";
            this.sotinchi.Name = "sotinchi";
            // 
            // soluongsv
            // 
            this.soluongsv.DataPropertyName = "SoLuongSV";
            this.soluongsv.HeaderText = "Số Lượng SV";
            this.soluongsv.Name = "soluongsv";
            // 
            // txttimmon
            // 
            this.txttimmon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimmon.Location = new System.Drawing.Point(247, 26);
            this.txttimmon.Name = "txttimmon";
            this.txttimmon.Size = new System.Drawing.Size(232, 29);
            this.txttimmon.TabIndex = 31;
            // 
            // btnok
            // 
            this.btnok.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Appearance.Options.UseFont = true;
            this.btnok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnok.ImageOptions.Image")));
            this.btnok.Location = new System.Drawing.Point(887, 113);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(99, 44);
            this.btnok.TabIndex = 33;
            this.btnok.Text = "OK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // txtmssv
            // 
            this.txtmssv.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmssv.Location = new System.Drawing.Point(190, 359);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(273, 29);
            this.txtmssv.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btndong);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(492, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(494, 87);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btndong
            // 
            this.btndong.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndong.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btndong.Appearance.Options.UseFont = true;
            this.btndong.Appearance.Options.UseForeColor = true;
            this.btndong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btndong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndong.Location = new System.Drawing.Point(355, 28);
            this.btndong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(112, 41);
            this.btndong.TabIndex = 2;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.Appearance.Options.UseForeColor = true;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoa.Location = new System.Drawing.Point(222, 28);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(112, 41);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            // 
            // btnluu
            // 
            this.btnluu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnluu.Appearance.Options.UseFont = true;
            this.btnluu.Appearance.Options.UseForeColor = true;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnluu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.ImageOptions.Image")));
            this.btnluu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnluu.Location = new System.Drawing.Point(89, 28);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 41);
            this.btnluu.TabIndex = 0;
            this.btnluu.Text = "Lưu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.GridViewdanhsach);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 428);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(969, 269);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học";
            // 
            // GridViewdanhsach
            // 
            this.GridViewdanhsach.BackgroundColor = System.Drawing.Color.White;
            this.GridViewdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewdanhsach.Location = new System.Drawing.Point(22, 34);
            this.GridViewdanhsach.Name = "GridViewdanhsach";
            this.GridViewdanhsach.RowTemplate.Height = 24;
            this.GridViewdanhsach.Size = new System.Drawing.Size(929, 209);
            this.GridViewdanhsach.TabIndex = 0;
            // 
            // btnloc
            // 
            this.btnloc.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Appearance.Options.UseFont = true;
            this.btnloc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.ImageOptions.Image")));
            this.btnloc.Location = new System.Drawing.Point(508, 18);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(106, 41);
            this.btnloc.TabIndex = 32;
            this.btnloc.Text = "Lọc";
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click_1);
            // 
            // frmdangkymonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 711);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txttimmon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "frmdangkymonhoc";
            this.Text = "frmdangkymonhoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangkymonhoc_FormClosing);
            this.Load += new System.EventHandler(this.frmdangkymonhoc_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewmonhoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private EventHandler btnloc_Click;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttimmon;
        private System.Windows.Forms.DataGridView GridViewmonhoc;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridViewdanhsach;
        private DevExpress.XtraEditors.SimpleButton btnloc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhp;
        private System.Windows.Forms.DataGridViewTextBoxColumn malophp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongsv;
    }
}