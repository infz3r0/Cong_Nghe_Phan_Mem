namespace UI_Tier
{
    partial class frmlophp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlophp));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridLopHP = new System.Windows.Forms.DataGridView();
            this.MaLopHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopTruong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatlophp = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoalophp = new DevExpress.XtraEditors.SimpleButton();
            this.btnsualophp = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemlophp = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLopTruong = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbbMaHPLopHP = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSLSVLopHP = new DevExpress.XtraEditors.TextEdit();
            this.txtmalophp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLSVLopHP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalophp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridLopHP);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 282);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(892, 330);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridLopHP
            // 
            this.gridLopHP.AllowUserToAddRows = false;
            this.gridLopHP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridLopHP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLopHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLopHP.BackgroundColor = System.Drawing.Color.White;
            this.gridLopHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLopHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopHP,
            this.SoLuongSV,
            this.MAHP,
            this.TenHP,
            this.LopTruong});
            this.gridLopHP.Location = new System.Drawing.Point(8, 31);
            this.gridLopHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridLopHP.MultiSelect = false;
            this.gridLopHP.Name = "gridLopHP";
            this.gridLopHP.ReadOnly = true;
            this.gridLopHP.RowHeadersVisible = false;
            this.gridLopHP.Size = new System.Drawing.Size(877, 289);
            this.gridLopHP.TabIndex = 9;
            this.gridLopHP.TabStop = false;
            // 
            // MaLopHP
            // 
            this.MaLopHP.DataPropertyName = "MaLopHP";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.MaLopHP.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaLopHP.HeaderText = "Mã lớp học phần";
            this.MaLopHP.Name = "MaLopHP";
            this.MaLopHP.ReadOnly = true;
            // 
            // SoLuongSV
            // 
            this.SoLuongSV.DataPropertyName = "SoLuongSV";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.SoLuongSV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoLuongSV.HeaderText = "Số lượng sinh viên";
            this.SoLuongSV.Name = "SoLuongSV";
            this.SoLuongSV.ReadOnly = true;
            // 
            // MAHP
            // 
            this.MAHP.DataPropertyName = "MaHP";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.MAHP.DefaultCellStyle = dataGridViewCellStyle4;
            this.MAHP.HeaderText = "Mã học phần";
            this.MAHP.Name = "MAHP";
            this.MAHP.ReadOnly = true;
            // 
            // TenHP
            // 
            this.TenHP.DataPropertyName = "TenHP";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.TenHP.DefaultCellStyle = dataGridViewCellStyle5;
            this.TenHP.HeaderText = "Tên học phần";
            this.TenHP.Name = "TenHP";
            this.TenHP.ReadOnly = true;
            // 
            // LopTruong
            // 
            this.LopTruong.DataPropertyName = "LopTruong";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.LopTruong.DefaultCellStyle = dataGridViewCellStyle6;
            this.LopTruong.HeaderText = "Lớp trưởng";
            this.LopTruong.Name = "LopTruong";
            this.LopTruong.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatlophp);
            this.groupBox2.Controls.Add(this.btnxoalophp);
            this.groupBox2.Controls.Add(this.btnsualophp);
            this.groupBox2.Controls.Add(this.btnthemlophp);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(714, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(192, 260);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatlophp
            // 
            this.btnthoatlophp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatlophp.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatlophp.Appearance.Options.UseFont = true;
            this.btnthoatlophp.Appearance.Options.UseForeColor = true;
            this.btnthoatlophp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatlophp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatlophp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatlophp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatlophp.ImageOptions.Image")));
            this.btnthoatlophp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatlophp.Location = new System.Drawing.Point(50, 197);
            this.btnthoatlophp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatlophp.Name = "btnthoatlophp";
            this.btnthoatlophp.Size = new System.Drawing.Size(112, 41);
            this.btnthoatlophp.TabIndex = 3;
            this.btnthoatlophp.Text = "Đóng";
            this.btnthoatlophp.Click += new System.EventHandler(this.btnthoatlophp_Click);
            // 
            // btnxoalophp
            // 
            this.btnxoalophp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoalophp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoalophp.Appearance.Options.UseFont = true;
            this.btnxoalophp.Appearance.Options.UseForeColor = true;
            this.btnxoalophp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoalophp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoalophp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoalophp.ImageOptions.Image")));
            this.btnxoalophp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoalophp.Location = new System.Drawing.Point(50, 139);
            this.btnxoalophp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoalophp.Name = "btnxoalophp";
            this.btnxoalophp.Size = new System.Drawing.Size(112, 41);
            this.btnxoalophp.TabIndex = 2;
            this.btnxoalophp.Text = "Xóa";
            this.btnxoalophp.Click += new System.EventHandler(this.btnxoalophp_Click);
            // 
            // btnsualophp
            // 
            this.btnsualophp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsualophp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsualophp.Appearance.Options.UseFont = true;
            this.btnsualophp.Appearance.Options.UseForeColor = true;
            this.btnsualophp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsualophp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsualophp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsualophp.ImageOptions.Image")));
            this.btnsualophp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsualophp.Location = new System.Drawing.Point(50, 85);
            this.btnsualophp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsualophp.Name = "btnsualophp";
            this.btnsualophp.Size = new System.Drawing.Size(112, 41);
            this.btnsualophp.TabIndex = 1;
            this.btnsualophp.Text = "Sửa ";
            this.btnsualophp.Click += new System.EventHandler(this.btnsualophp_Click);
            // 
            // btnthemlophp
            // 
            this.btnthemlophp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemlophp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemlophp.Appearance.Options.UseFont = true;
            this.btnthemlophp.Appearance.Options.UseForeColor = true;
            this.btnthemlophp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemlophp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemlophp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemlophp.ImageOptions.Image")));
            this.btnthemlophp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemlophp.Location = new System.Drawing.Point(50, 31);
            this.btnthemlophp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthemlophp.Name = "btnthemlophp";
            this.btnthemlophp.Size = new System.Drawing.Size(112, 41);
            this.btnthemlophp.TabIndex = 0;
            this.btnthemlophp.Text = "Thêm";
            this.btnthemlophp.Click += new System.EventHandler(this.btnthemlophp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbLopTruong);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.cbbMaHPLopHP);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtSLSVLopHP);
            this.groupBox1.Controls.Add(this.txtmalophp);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 260);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbLopTruong
            // 
            this.cbbLopTruong.FormattingEnabled = true;
            this.cbbLopTruong.Location = new System.Drawing.Point(224, 204);
            this.cbbLopTruong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbLopTruong.Name = "cbbLopTruong";
            this.cbbLopTruong.Size = new System.Drawing.Size(364, 31);
            this.cbbLopTruong.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(23, 204);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 29);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Lớp trưởng";
            // 
            // cbbMaHPLopHP
            // 
            this.cbbMaHPLopHP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbMaHPLopHP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbbMaHPLopHP.FormattingEnabled = true;
            this.cbbMaHPLopHP.Location = new System.Drawing.Point(224, 153);
            this.cbbMaHPLopHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMaHPLopHP.Name = "cbbMaHPLopHP";
            this.cbbMaHPLopHP.Size = new System.Drawing.Size(364, 31);
            this.cbbMaHPLopHP.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 153);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 29);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên học phần";
            // 
            // txtSLSVLopHP
            // 
            this.txtSLSVLopHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLSVLopHP.Location = new System.Drawing.Point(224, 101);
            this.txtSLSVLopHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSLSVLopHP.Name = "txtSLSVLopHP";
            this.txtSLSVLopHP.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtSLSVLopHP.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtSLSVLopHP.Properties.Appearance.Options.UseBackColor = true;
            this.txtSLSVLopHP.Properties.Appearance.Options.UseForeColor = true;
            this.txtSLSVLopHP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtSLSVLopHP.Properties.ReadOnly = true;
            this.txtSLSVLopHP.Size = new System.Drawing.Size(365, 22);
            this.txtSLSVLopHP.TabIndex = 1;
            this.txtSLSVLopHP.TabStop = false;
            // 
            // txtmalophp
            // 
            this.txtmalophp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmalophp.Location = new System.Drawing.Point(224, 48);
            this.txtmalophp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmalophp.Name = "txtmalophp";
            this.txtmalophp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmalophp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmalophp.Properties.Appearance.Options.UseBackColor = true;
            this.txtmalophp.Properties.Appearance.Options.UseForeColor = true;
            this.txtmalophp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmalophp.Properties.Mask.EditMask = "\\d{1,4}";
            this.txtmalophp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmalophp.Properties.MaxLength = 10;
            this.txtmalophp.Size = new System.Drawing.Size(365, 22);
            this.txtmalophp.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 101);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(125, 29);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Số lượng sv";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 29);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã lớp";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // frmlophp
            // 
            this.AcceptButton = this.btnthemlophp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoatlophp;
            this.ClientSize = new System.Drawing.Size(917, 624);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmlophp";
            this.Text = "LỚP HỌC PHẦN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlophp_FormClosing);
            this.Load += new System.EventHandler(this.frmlophp_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLopHP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLSVLopHP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalophp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridLopHP;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtSLSVLopHP;
        private DevExpress.XtraEditors.TextEdit txtmalophp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnthoatlophp;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnxoalophp;
        private DevExpress.XtraEditors.SimpleButton btnsualophp;
        private DevExpress.XtraEditors.SimpleButton btnthemlophp;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbbMaHPLopHP;
        private System.Windows.Forms.ComboBox cbbLopTruong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopTruong;
    }
}