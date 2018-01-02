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
            this.cbbGIDPhanQuyen = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaQuyen = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoatPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnOKPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            this.gridPhanQuyen = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuyen.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbGIDPhanQuyen);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtMaQuyen);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 134);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cbbGIDPhanQuyen
            // 
            this.cbbGIDPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGIDPhanQuyen.FormattingEnabled = true;
            this.cbbGIDPhanQuyen.Location = new System.Drawing.Point(217, 37);
            this.cbbGIDPhanQuyen.Name = "cbbGIDPhanQuyen";
            this.cbbGIDPhanQuyen.Size = new System.Drawing.Size(222, 26);
            this.cbbGIDPhanQuyen.TabIndex = 8;
            this.cbbGIDPhanQuyen.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 165);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 23);
            this.labelControl1.TabIndex = 6;
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaQuyen.EditValue = "";
            this.txtMaQuyen.Location = new System.Drawing.Point(217, 81);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaQuyen.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtMaQuyen.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaQuyen.Properties.Appearance.Options.UseForeColor = true;
            this.txtMaQuyen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtMaQuyen.Properties.Mask.EditMask = "\\w+";
            this.txtMaQuyen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMaQuyen.Size = new System.Drawing.Size(220, 20);
            this.txtMaQuyen.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 23);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Nhóm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Mã quyền";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridPhanQuyen);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 263);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnOKPhanQuyen);
            this.groupBox2.Controls.Add(this.btnThoatPhanQuyen);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(495, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 134);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThoatPhanQuyen
            // 
            this.btnThoatPhanQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoatPhanQuyen.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoatPhanQuyen.Appearance.Options.UseFont = true;
            this.btnThoatPhanQuyen.Appearance.Options.UseForeColor = true;
            this.btnThoatPhanQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThoatPhanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatPhanQuyen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatlophp.ImageOptions.Image")));
            this.btnThoatPhanQuyen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThoatPhanQuyen.Location = new System.Drawing.Point(15, 79);
            this.btnThoatPhanQuyen.Name = "btnThoatPhanQuyen";
            this.btnThoatPhanQuyen.Size = new System.Drawing.Size(96, 33);
            this.btnThoatPhanQuyen.TabIndex = 3;
            this.btnThoatPhanQuyen.Text = "Đóng";
            // 
            // btnOKPhanQuyen
            // 
            this.btnOKPhanQuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOKPhanQuyen.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnOKPhanQuyen.Appearance.Options.UseFont = true;
            this.btnOKPhanQuyen.Appearance.Options.UseForeColor = true;
            this.btnOKPhanQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOKPhanQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKPhanQuyen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOKPhanQuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnOKPhanQuyen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOKPhanQuyen.Location = new System.Drawing.Point(15, 38);
            this.btnOKPhanQuyen.Name = "btnOKPhanQuyen";
            this.btnOKPhanQuyen.Size = new System.Drawing.Size(96, 33);
            this.btnOKPhanQuyen.TabIndex = 4;
            this.btnOKPhanQuyen.Text = "OK";
            // 
            // gridPhanQuyen
            // 
            this.gridPhanQuyen.BackgroundColor = System.Drawing.Color.White;
            this.gridPhanQuyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhanQuyen.Location = new System.Drawing.Point(6, 25);
            this.gridPhanQuyen.Name = "gridPhanQuyen";
            this.gridPhanQuyen.Size = new System.Drawing.Size(602, 232);
            this.gridPhanQuyen.TabIndex = 0;
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhanQuyen";
            this.Text = "PHÂN QUYỀN";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuyen.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbGIDPhanQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridPhanQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnOKPhanQuyen;
        private DevExpress.XtraEditors.SimpleButton btnThoatPhanQuyen;
    }
}