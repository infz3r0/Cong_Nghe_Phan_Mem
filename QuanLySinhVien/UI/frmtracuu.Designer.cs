namespace UI_Tier
{
    partial class frmtracuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtracuu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridviewtracuu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            this.btnthoatracuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btntracuu = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewtracuu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewtracuu
            // 
            this.gridviewtracuu.AllowUserToAddRows = false;
            this.gridviewtracuu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridviewtracuu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewtracuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewtracuu.BackgroundColor = System.Drawing.Color.White;
            this.gridviewtracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewtracuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masv,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.malop});
            this.gridviewtracuu.Location = new System.Drawing.Point(8, 28);
            this.gridviewtracuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridviewtracuu.Name = "gridviewtracuu";
            this.gridviewtracuu.ReadOnly = true;
            this.gridviewtracuu.RowHeadersVisible = false;
            this.gridviewtracuu.Size = new System.Drawing.Size(1027, 358);
            this.gridviewtracuu.TabIndex = 9;
            this.gridviewtracuu.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewtracuu);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1042, 399);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.btnthoatracuu);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.btntracuu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1042, 106);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(261, 48);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtInput.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Properties.Appearance.Options.UseBackColor = true;
            this.txtInput.Properties.Appearance.Options.UseForeColor = true;
            this.txtInput.Size = new System.Drawing.Size(405, 22);
            this.txtInput.TabIndex = 3;
            // 
            // btnthoatracuu
            // 
            this.btnthoatracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatracuu.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatracuu.Appearance.Options.UseFont = true;
            this.btnthoatracuu.Appearance.Options.UseForeColor = true;
            this.btnthoatracuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatracuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatracuu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatracuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatracuu.ImageOptions.Image")));
            this.btnthoatracuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatracuu.Location = new System.Drawing.Point(881, 38);
            this.btnthoatracuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatracuu.Name = "btnthoatracuu";
            this.btnthoatracuu.Size = new System.Drawing.Size(112, 41);
            this.btnthoatracuu.TabIndex = 2;
            this.btnthoatracuu.Text = "Đóng";
            this.btnthoatracuu.Click += new System.EventHandler(this.btnthoatracuu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 29);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhập mssv hoặc tên";
            // 
            // btntracuu
            // 
            this.btntracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntracuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btntracuu.Appearance.Options.UseFont = true;
            this.btntracuu.Appearance.Options.UseForeColor = true;
            this.btntracuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntracuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntracuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntracuu.ImageOptions.Image")));
            this.btntracuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btntracuu.Location = new System.Drawing.Point(722, 38);
            this.btntracuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(112, 41);
            this.btntracuu.TabIndex = 1;
            this.btntracuu.Text = "Tìm";
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // masv
            // 
            this.masv.DataPropertyName = "MaSV";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.masv.DefaultCellStyle = dataGridViewCellStyle2;
            this.masv.HeaderText = "Mã SV";
            this.masv.Name = "masv";
            this.masv.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HoTen";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.hoten.DefaultCellStyle = dataGridViewCellStyle3;
            this.hoten.HeaderText = "Họ & Tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ngaysinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.gioitinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.sdt.DefaultCellStyle = dataGridViewCellStyle6;
            this.sdt.HeaderText = "Sđt";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "MaLop";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.malop.DefaultCellStyle = dataGridViewCellStyle7;
            this.malop.HeaderText = "Mã Lớp";
            this.malop.Name = "malop";
            this.malop.ReadOnly = true;
            // 
            // frmtracuu
            // 
            this.AcceptButton = this.btntracuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoatracuu;
            this.ClientSize = new System.Drawing.Size(1064, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmtracuu";
            this.Text = "TRA CỨU THÔNG TIN SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmtracuu_FormClosing);
            this.Load += new System.EventHandler(this.frmtracuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewtracuu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewtracuu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btntracuu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnthoatracuu;
        private DevExpress.XtraEditors.TextEdit txtInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
    }
}