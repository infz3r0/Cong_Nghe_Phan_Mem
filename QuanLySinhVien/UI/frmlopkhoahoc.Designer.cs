namespace UI_Tier
{
    partial class frmlopkhoahoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlopkhoahoc));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridviewlopkh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTenKhoaLopKH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtmalopkhoahoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnthoatlopkh = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoalopkh = new DevExpress.XtraEditors.SimpleButton();
            this.btnsualopkh = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemlopkh = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager2 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewlopkh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenKhoaLopKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalopkhoahoc.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewlopkh);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 274);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridviewlopkh
            // 
            this.gridviewlopkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewlopkh.BackgroundColor = System.Drawing.Color.White;
            this.gridviewlopkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewlopkh.Location = new System.Drawing.Point(7, 25);
            this.gridviewlopkh.Name = "gridviewlopkh";
            this.gridviewlopkh.Size = new System.Drawing.Size(544, 235);
            this.gridviewlopkh.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.groupBox1.Controls.Add(this.cbbTenKhoaLopKH);
            this.groupBox1.Controls.Add(this.txtmalopkhoahoc);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 215);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbTenKhoaLopKH
            // 
            this.cbbTenKhoaLopKH.Location = new System.Drawing.Point(156, 117);
            this.cbbTenKhoaLopKH.Name = "cbbTenKhoaLopKH";
            this.cbbTenKhoaLopKH.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbTenKhoaLopKH.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbTenKhoaLopKH.Properties.Appearance.Options.UseBackColor = true;
            this.cbbTenKhoaLopKH.Properties.Appearance.Options.UseForeColor = true;
            this.cbbTenKhoaLopKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTenKhoaLopKH.Size = new System.Drawing.Size(220, 20);
            this.cbbTenKhoaLopKH.TabIndex = 1;
            // 
            // txtmalopkhoahoc
            // 
            this.txtmalopkhoahoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmalopkhoahoc.Location = new System.Drawing.Point(156, 54);
            this.txtmalopkhoahoc.Name = "txtmalopkhoahoc";
            this.txtmalopkhoahoc.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmalopkhoahoc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmalopkhoahoc.Properties.Appearance.Options.UseBackColor = true;
            this.txtmalopkhoahoc.Properties.Appearance.Options.UseForeColor = true;
            this.txtmalopkhoahoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmalopkhoahoc.Size = new System.Drawing.Size(220, 20);
            this.txtmalopkhoahoc.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 117);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 23);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Tên khoa";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã lớp";
            // 
            // btnthoatlopkh
            // 
            this.btnthoatlopkh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatlopkh.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatlopkh.Appearance.Options.UseFont = true;
            this.btnthoatlopkh.Appearance.Options.UseForeColor = true;
            this.btnthoatlopkh.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.btnthoatlopkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatlopkh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthoatlopkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatlopkh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatlopkh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatlopkh.ImageOptions.Image")));
            this.btnthoatlopkh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatlopkh.Location = new System.Drawing.Point(23, 161);
            this.btnthoatlopkh.Name = "btnthoatlopkh";
            this.btnthoatlopkh.Size = new System.Drawing.Size(97, 36);
            this.btnthoatlopkh.TabIndex = 24;
            this.btnthoatlopkh.Text = "Đóng";
            this.btnthoatlopkh.Click += new System.EventHandler(this.btnthoatlopkh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatlopkh);
            this.groupBox2.Controls.Add(this.btnxoalopkh);
            this.groupBox2.Controls.Add(this.btnsualopkh);
            this.groupBox2.Controls.Add(this.btnthemlopkh);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 215);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnxoalopkh
            // 
            this.btnxoalopkh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoalopkh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoalopkh.Appearance.Options.UseFont = true;
            this.btnxoalopkh.Appearance.Options.UseForeColor = true;
            this.btnxoalopkh.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnxoalopkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoalopkh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnxoalopkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoalopkh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoalopkh.ImageOptions.Image")));
            this.btnxoalopkh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoalopkh.Location = new System.Drawing.Point(24, 113);
            this.btnxoalopkh.Name = "btnxoalopkh";
            this.btnxoalopkh.Size = new System.Drawing.Size(96, 36);
            this.btnxoalopkh.TabIndex = 2;
            this.btnxoalopkh.Text = "Xóa";
            // 
            // btnsualopkh
            // 
            this.btnsualopkh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsualopkh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsualopkh.Appearance.Options.UseFont = true;
            this.btnsualopkh.Appearance.Options.UseForeColor = true;
            this.btnsualopkh.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.btnsualopkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsualopkh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnsualopkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsualopkh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsualopkh.ImageOptions.Image")));
            this.btnsualopkh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsualopkh.Location = new System.Drawing.Point(23, 69);
            this.btnsualopkh.Name = "btnsualopkh";
            this.btnsualopkh.Size = new System.Drawing.Size(97, 31);
            this.btnsualopkh.TabIndex = 1;
            this.btnsualopkh.Text = "Sửa ";
            // 
            // btnthemlopkh
            // 
            this.btnthemlopkh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemlopkh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemlopkh.Appearance.Options.UseFont = true;
            this.btnthemlopkh.Appearance.Options.UseForeColor = true;
            this.btnthemlopkh.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnthemlopkh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemlopkh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthemlopkh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemlopkh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemlopkh.ImageOptions.Image")));
            this.btnthemlopkh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemlopkh.Location = new System.Drawing.Point(23, 25);
            this.btnthemlopkh.Name = "btnthemlopkh";
            this.btnthemlopkh.Size = new System.Drawing.Size(96, 32);
            this.btnthemlopkh.TabIndex = 0;
            this.btnthemlopkh.Text = "Thêm";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // frmlopkhoahoc
            // 
            this.AcceptButton = this.btnthemlopkh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.CancelButton = this.btnthoatlopkh;
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.Name = "frmlopkhoahoc";
            this.Text = "LỚP KHÓA HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmlopkhoahoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewlopkh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTenKhoaLopKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmalopkhoahoc.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridviewlopkh;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtmalopkhoahoc;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private DevExpress.XtraEditors.SimpleButton btnthoatlopkh;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnxoalopkh;
        private DevExpress.XtraEditors.SimpleButton btnsualopkh;
        private DevExpress.XtraEditors.SimpleButton btnthemlopkh;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTenKhoaLopKH;
    }
}