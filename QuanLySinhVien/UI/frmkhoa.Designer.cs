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
            this.btnthemkhoa.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnthemkhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemkhoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthemkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemkhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemkhoa.ImageOptions.Image")));
            this.btnthemkhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemkhoa.Location = new System.Drawing.Point(23, 25);
            this.btnthemkhoa.Name = "btnthemkhoa";
            this.btnthemkhoa.Size = new System.Drawing.Size(96, 32);
            this.btnthemkhoa.TabIndex = 0;
            this.btnthemkhoa.Text = "Thêm";
            // 
            // btnsuakhoa
            // 
            this.btnsuakhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuakhoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuakhoa.Appearance.Options.UseFont = true;
            this.btnsuakhoa.Appearance.Options.UseForeColor = true;
            this.btnsuakhoa.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnsuakhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuakhoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnsuakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuakhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuakhoa.ImageOptions.Image")));
            this.btnsuakhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuakhoa.Location = new System.Drawing.Point(23, 63);
            this.btnsuakhoa.Name = "btnsuakhoa";
            this.btnsuakhoa.Size = new System.Drawing.Size(96, 37);
            this.btnsuakhoa.TabIndex = 1;
            this.btnsuakhoa.Text = "Sửa ";
            // 
            // btnxoakhoa
            // 
            this.btnxoakhoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoakhoa.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoakhoa.Appearance.Options.UseFont = true;
            this.btnxoakhoa.Appearance.Options.UseForeColor = true;
            this.btnxoakhoa.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnxoakhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoakhoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnxoakhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoakhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoakhoa.ImageOptions.Image")));
            this.btnxoakhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoakhoa.Location = new System.Drawing.Point(23, 111);
            this.btnxoakhoa.Name = "btnxoakhoa";
            this.btnxoakhoa.Size = new System.Drawing.Size(96, 36);
            this.btnxoakhoa.TabIndex = 2;
            this.btnxoakhoa.Text = "Xóa";
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
            this.groupBox2.Location = new System.Drawing.Point(511, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 208);
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
            this.btnthoatkhoa.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnthoatkhoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatkhoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthoatkhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatkhoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatkhoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatkhoa.ImageOptions.Image")));
            this.btnthoatkhoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatkhoa.Location = new System.Drawing.Point(23, 161);
            this.btnthoatkhoa.Name = "btnthoatkhoa";
            this.btnthoatkhoa.Size = new System.Drawing.Size(96, 36);
            this.btnthoatkhoa.TabIndex = 24;
            this.btnthoatkhoa.Text = "Đóng";
            this.btnthoatkhoa.Click += new System.EventHandler(this.btnthoatkhoa_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã khoa";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên khoa";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(110, 23);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số điện thoại";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 23);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Email";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakhoa.Location = new System.Drawing.Point(170, 37);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmakhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmakhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtmakhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtmakhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmakhoa.Size = new System.Drawing.Size(281, 20);
            this.txtmakhoa.TabIndex = 0;
            this.txtmakhoa.TextChanged += new System.EventHandler(this.txtmakhoa_TextChanged);
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenkhoa.Location = new System.Drawing.Point(170, 77);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttenkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttenkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txttenkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txttenkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txttenkhoa.Size = new System.Drawing.Size(281, 20);
            this.txttenkhoa.TabIndex = 1;
            // 
            // txtmailkhoa
            // 
            this.txtmailkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmailkhoa.Location = new System.Drawing.Point(170, 158);
            this.txtmailkhoa.Name = "txtmailkhoa";
            this.txtmailkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmailkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmailkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtmailkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtmailkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmailkhoa.Size = new System.Drawing.Size(281, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 208);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtsdtkhoa
            // 
            this.txtsdtkhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdtkhoa.Location = new System.Drawing.Point(170, 114);
            this.txtsdtkhoa.Name = "txtsdtkhoa";
            this.txtsdtkhoa.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtsdtkhoa.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtsdtkhoa.Properties.Appearance.Options.UseBackColor = true;
            this.txtsdtkhoa.Properties.Appearance.Options.UseForeColor = true;
            this.txtsdtkhoa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtsdtkhoa.Size = new System.Drawing.Size(281, 20);
            this.txtsdtkhoa.TabIndex = 2;
            // 
            // gridviewkhoa
            // 
            this.gridviewkhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewkhoa.BackgroundColor = System.Drawing.Color.White;
            this.gridviewkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewkhoa.Location = new System.Drawing.Point(7, 20);
            this.gridviewkhoa.Name = "gridviewkhoa";
            this.gridviewkhoa.Size = new System.Drawing.Size(629, 235);
            this.gridviewkhoa.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewkhoa);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 266);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.CancelButton = this.btnthoatkhoa;
            this.ClientSize = new System.Drawing.Size(663, 489);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmkhoa";
            this.Text = "QUẢN LÍ KHOA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmkhoa_FormClosing);
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
    }
}