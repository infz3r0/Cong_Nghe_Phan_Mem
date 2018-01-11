namespace UI_Tier
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbGID = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSystem = new DevExpress.XtraEditors.SimpleButton();
            this.btnWrite = new DevExpress.XtraEditors.SimpleButton();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefault = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.clbPhanQuyen = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOKPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoatPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clbPhanQuyen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbGID);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(556, 165);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbGID
            // 
            this.cbbGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGID.FormattingEnabled = true;
            this.cbbGID.Location = new System.Drawing.Point(224, 58);
            this.cbbGID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbGID.Name = "cbbGID";
            this.cbbGID.Size = new System.Drawing.Size(258, 31);
            this.cbbGID.TabIndex = 0;
            this.cbbGID.TabStop = false;
            this.cbbGID.SelectionChangeCommitted += new System.EventHandler(this.cbbGID_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 203);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 29);
            this.labelControl1.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(103, 58);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 29);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Nhóm";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnSystem);
            this.groupBox3.Controls.Add(this.btnWrite);
            this.groupBox3.Controls.Add(this.btnRead);
            this.groupBox3.Controls.Add(this.btnDefault);
            this.groupBox3.Controls.Add(this.btnSelectAll);
            this.groupBox3.Controls.Add(this.clbPhanQuyen);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(14, 187);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(716, 432);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // btnSystem
            // 
            this.btnSystem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSystem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSystem.Appearance.Options.UseFont = true;
            this.btnSystem.Appearance.Options.UseForeColor = true;
            this.btnSystem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSystem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSystem.Location = new System.Drawing.Point(500, 31);
            this.btnSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(112, 41);
            this.btnSystem.TabIndex = 3;
            this.btnSystem.Text = "Hệ thống";
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWrite.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Appearance.Options.UseFont = true;
            this.btnWrite.Appearance.Options.UseForeColor = true;
            this.btnWrite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWrite.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnWrite.Location = new System.Drawing.Point(381, 31);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(112, 41);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Chỉnh sửa";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRead.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRead.Appearance.Options.UseFont = true;
            this.btnRead.Appearance.Options.UseForeColor = true;
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnRead.Location = new System.Drawing.Point(262, 31);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(112, 41);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Xem";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDefault.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Appearance.Options.UseFont = true;
            this.btnDefault.Appearance.Options.UseForeColor = true;
            this.btnDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefault.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDefault.Location = new System.Drawing.Point(143, 31);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(112, 41);
            this.btnDefault.TabIndex = 3;
            this.btnDefault.Text = "Mặc định";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSelectAll.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Appearance.Options.UseFont = true;
            this.btnSelectAll.Appearance.Options.UseForeColor = true;
            this.btnSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSelectAll.Location = new System.Drawing.Point(24, 31);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(112, 41);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "Chọn tất cả";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // clbPhanQuyen
            // 
            this.clbPhanQuyen.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(105)))), ((int)(((byte)(155)))));
            this.clbPhanQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.clbPhanQuyen.Appearance.Options.UseBackColor = true;
            this.clbPhanQuyen.Appearance.Options.UseFont = true;
            this.clbPhanQuyen.CheckOnClick = true;
            this.clbPhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbPhanQuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbPhanQuyen.Location = new System.Drawing.Point(3, 78);
            this.clbPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbPhanQuyen.MultiColumn = true;
            this.clbPhanQuyen.Name = "clbPhanQuyen";
            this.clbPhanQuyen.Size = new System.Drawing.Size(710, 350);
            this.clbPhanQuyen.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOKPhanQuyen);
            this.groupBox2.Controls.Add(this.btnThoatPhanQuyen);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(577, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(153, 165);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnOKPhanQuyen
            // 
            this.btnOKPhanQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOKPhanQuyen.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOKPhanQuyen.Appearance.Options.UseFont = true;
            this.btnOKPhanQuyen.Appearance.Options.UseForeColor = true;
            this.btnOKPhanQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOKPhanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOKPhanQuyen.ImageOptions.Image")));
            this.btnOKPhanQuyen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOKPhanQuyen.Location = new System.Drawing.Point(17, 47);
            this.btnOKPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOKPhanQuyen.Name = "btnOKPhanQuyen";
            this.btnOKPhanQuyen.Size = new System.Drawing.Size(112, 41);
            this.btnOKPhanQuyen.TabIndex = 2;
            this.btnOKPhanQuyen.Text = "OK";
            this.btnOKPhanQuyen.Click += new System.EventHandler(this.btnOKPhanQuyen_Click);
            // 
            // btnThoatPhanQuyen
            // 
            this.btnThoatPhanQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatPhanQuyen.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoatPhanQuyen.Appearance.Options.UseFont = true;
            this.btnThoatPhanQuyen.Appearance.Options.UseForeColor = true;
            this.btnThoatPhanQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoatPhanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoatPhanQuyen.ImageOptions.Image")));
            this.btnThoatPhanQuyen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThoatPhanQuyen.Location = new System.Drawing.Point(17, 97);
            this.btnThoatPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoatPhanQuyen.Name = "btnThoatPhanQuyen";
            this.btnThoatPhanQuyen.Size = new System.Drawing.Size(112, 41);
            this.btnThoatPhanQuyen.TabIndex = 3;
            this.btnThoatPhanQuyen.Text = "Đóng";
            this.btnThoatPhanQuyen.Click += new System.EventHandler(this.btnThoatPhanQuyen_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN QUYỀN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanQuyen_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clbPhanQuyen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbGID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnOKPhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btnThoatPhanQuyen;
        private DevExpress.XtraEditors.CheckedListBoxControl clbPhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btnSystem;
        private DevExpress.XtraEditors.SimpleButton btnWrite;
        private DevExpress.XtraEditors.SimpleButton btnRead;
        private DevExpress.XtraEditors.SimpleButton btnDefault;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
    }
}