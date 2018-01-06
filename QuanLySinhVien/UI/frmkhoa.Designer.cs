namespace UI_Tier
{
    partial class frmkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnthemkhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuakhoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoakhoa = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatkhoa = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtmakhoa = new DevExpress.XtraEditors.TextEdit();
            this.txttenkhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtmailkhoa = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsdtkhoa = new DevExpress.XtraEditors.TextEdit();
            this.gridviewkhoa = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailkhoa.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtkhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewkhoa)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthemkhoa
            // 
            this.btnthemkhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemkhoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemkhoa.Appearance.Options.UseFont = true;
            this.btnthemkhoa.Appearance.Options.UseForeColor = true;
            this.btnthemkhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemkhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemkhoa.ImageOptions.Image")));
            this.btnthemkhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemkhoa.Location = new System.Drawing.Point(31, 42);
            this.btnthemkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemkhoa.Name = "btnthemkhoa";
            this.btnthemkhoa.Size = new System.Drawing.Size(128, 41);
            this.btnthemkhoa.TabIndex = 4;
            this.btnthemkhoa.Text = "Thêm";
            this.btnthemkhoa.Click += new System.EventHandler(this.btnthemkhoa_Click);
            // 
            // btnsuakhoa
            // 
            this.btnsuakhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuakhoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuakhoa.Appearance.Options.UseFont = true;
            this.btnsuakhoa.Appearance.Options.UseForeColor = true;
            this.btnsuakhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuakhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuakhoa.ImageOptions.Image")));
            this.btnsuakhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuakhoa.Location = new System.Drawing.Point(31, 94);
            this.btnsuakhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsuakhoa.Name = "btnsuakhoa";
            this.btnsuakhoa.Size = new System.Drawing.Size(128, 41);
            this.btnsuakhoa.TabIndex = 5;
            this.btnsuakhoa.Text = "Sửa ";
            this.btnsuakhoa.Click += new System.EventHandler(this.btnsuakhoa_Click);
            // 
            // btnxoakhoa
            // 
            this.btnxoakhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoakhoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoakhoa.Appearance.Options.UseFont = true;
            this.btnxoakhoa.Appearance.Options.UseForeColor = true;
            this.btnxoakhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoakhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoakhoa.ImageOptions.Image")));
            this.btnxoakhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoakhoa.Location = new System.Drawing.Point(31, 144);
            this.btnxoakhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoakhoa.Name = "btnxoakhoa";
            this.btnxoakhoa.Size = new System.Drawing.Size(128, 41);
            this.btnxoakhoa.TabIndex = 6;
            this.btnxoakhoa.Text = "Xóa";
            this.btnxoakhoa.Click += new System.EventHandler(this.btnxoakhoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatkhoa);
            this.groupBox2.Controls.Add(this.btnxoakhoa);
            this.groupBox2.Controls.Add(this.btnsuakhoa);
            this.groupBox2.Controls.Add(this.btnthemkhoa);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(681, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(191, 256);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatkhoa
            // 
            this.btnthoatkhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatkhoa.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatkhoa.Appearance.Options.UseFont = true;
            this.btnthoatkhoa.Appearance.Options.UseForeColor = true;
            this.btnthoatkhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatkhoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatkhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatkhoa.ImageOptions.Image")));
            this.btnthoatkhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatkhoa.Location = new System.Drawing.Point(31, 198);
            this.btnthoatkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoatkhoa.Name = "btnthoatkhoa";
            this.btnthoatkhoa.Size = new System.Drawing.Size(128, 41);
            this.btnthoatkhoa.TabIndex = 7;
            this.btnthoatkhoa.Text = "Đóng";
            this.btnthoatkhoa.Click += new System.EventHandler(this.btnthoatkhoa_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 29);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã khoa";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 94);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 29);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên khoa";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 144);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(139, 29);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 198);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 29);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Email";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakhoa.Location = new System.Drawing.Point(227, 54);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmakhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmakhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtmakhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtmakhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmakhoa.Properties.Mask.BeepOnError = true;
            this.txtmakhoa.Properties.Mask.EditMask = "[A-Z]{2}\\d{4}";
            this.txtmakhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmakhoa.Properties.MaxLength = 6;
            this.txtmakhoa.Size = new System.Drawing.Size(375, 22);
            this.txtmakhoa.TabIndex = 0;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenkhoa.Location = new System.Drawing.Point(227, 100);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttenkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttenkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txttenkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txttenkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txttenkhoa.Properties.Mask.EditMask = "\\w+( \\w+)*";
            this.txttenkhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txttenkhoa.Properties.MaxLength = 100;
            this.txttenkhoa.Size = new System.Drawing.Size(375, 22);
            this.txttenkhoa.TabIndex = 1;
            // 
            // txtmailkhoa
            // 
            this.txtmailkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmailkhoa.Location = new System.Drawing.Point(227, 204);
            this.txtmailkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmailkhoa.Name = "txtmailkhoa";
            this.txtmailkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmailkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmailkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtmailkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtmailkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmailkhoa.Properties.Mask.EditMask = "([a-z]|[0-9]|\\.|_)+@([a-z]|[0-9])+\\.([a-z]|[0-9])+";
            this.txtmailkhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtmailkhoa.Properties.MaxLength = 100;
            this.txtmailkhoa.Size = new System.Drawing.Size(375, 22);
            this.txtmailkhoa.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtsdtkhoa);
            this.groupBox1.Controls.Add(this.txtmailkhoa);
            this.groupBox1.Controls.Add(this.txttenkhoa);
            this.groupBox1.Controls.Add(this.txtmakhoa);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(657, 256);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtsdtkhoa
            // 
            this.txtsdtkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdtkhoa.Location = new System.Drawing.Point(227, 150);
            this.txtsdtkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdtkhoa.Name = "txtsdtkhoa";
            this.txtsdtkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtsdtkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtsdtkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtsdtkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtsdtkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtsdtkhoa.Properties.Mask.BeepOnError = true;
            this.txtsdtkhoa.Properties.Mask.EditMask = "\\(\\d{0,3}\\) \\d{8}";
            this.txtsdtkhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtsdtkhoa.Size = new System.Drawing.Size(375, 22);
            this.txtsdtkhoa.TabIndex = 2;
            // 
            // gridviewkhoa
            // 
            this.gridviewkhoa.AllowUserToAddRows = false;
            this.gridviewkhoa.AllowUserToDeleteRows = false;
            this.gridviewkhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewkhoa.BackgroundColor = System.Drawing.Color.White;
            this.gridviewkhoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridviewkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.Sdt,
            this.Email});
            this.gridviewkhoa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridviewkhoa.Location = new System.Drawing.Point(9, 25);
            this.gridviewkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridviewkhoa.MultiSelect = false;
            this.gridviewkhoa.Name = "gridviewkhoa";
            this.gridviewkhoa.ReadOnly = true;
            this.gridviewkhoa.RowHeadersVisible = false;
            this.gridviewkhoa.Size = new System.Drawing.Size(839, 289);
            this.gridviewkhoa.TabIndex = 9;
            this.gridviewkhoa.TabStop = false;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MaKhoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.TenKhoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenKhoa.HeaderText = "Tên Khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Sdt.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sdt.HeaderText = "Số Điện Thoại";
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Email.DefaultCellStyle = dataGridViewCellStyle4;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewkhoa);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 263);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(856, 327);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // frmkhoa
            // 
            this.AcceptButton = this.btnthemkhoa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.CancelButton = this.btnthoatkhoa;
            this.ClientSize = new System.Drawing.Size(884, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmkhoa";
            this.Text = "QUẢN LÍ KHOA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmkhoa_FormClosing);
            this.Load += new System.EventHandler(this.frmkhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmailkhoa.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdtkhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewkhoa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnthemkhoa;
        private DevExpress.XtraEditors.SimpleButton btnsuakhoa;
        private DevExpress.XtraEditors.SimpleButton btnxoakhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtmakhoa;
        private DevExpress.XtraEditors.TextEdit txttenkhoa;
        private DevExpress.XtraEditors.TextEdit txtmailkhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridviewkhoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnthoatkhoa;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit txtsdtkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}