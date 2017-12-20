namespace UI_Tier
{
    partial class frmthongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongke));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridviewsv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbmaloptk = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbtenkhoatk = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoattk = new DevExpress.XtraEditors.SimpleButton();
            this.btnthongke = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmaloptk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtenkhoatk.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewsv);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(784, 327);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridviewsv
            // 
            this.gridviewsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewsv.BackgroundColor = System.Drawing.Color.White;
            this.gridviewsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewsv.Location = new System.Drawing.Point(10, 27);
            this.gridviewsv.Name = "gridviewsv";
            this.gridviewsv.Size = new System.Drawing.Size(768, 284);
            this.gridviewsv.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cbbmaloptk);
            this.groupBox2.Controls.Add(this.cbbtenkhoatk);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 125);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều kiện thống kê";
            // 
            // cbbmaloptk
            // 
            this.cbbmaloptk.Location = new System.Drawing.Point(184, 78);
            this.cbbmaloptk.Name = "cbbmaloptk";
            this.cbbmaloptk.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbmaloptk.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbmaloptk.Properties.Appearance.Options.UseBackColor = true;
            this.cbbmaloptk.Properties.Appearance.Options.UseForeColor = true;
            this.cbbmaloptk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbmaloptk.Size = new System.Drawing.Size(248, 20);
            this.cbbmaloptk.TabIndex = 1;
            // 
            // cbbtenkhoatk
            // 
            this.cbbtenkhoatk.EditValue = "";
            this.cbbtenkhoatk.Location = new System.Drawing.Point(184, 37);
            this.cbbtenkhoatk.Name = "cbbtenkhoatk";
            this.cbbtenkhoatk.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbtenkhoatk.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbtenkhoatk.Properties.Appearance.Options.UseBackColor = true;
            this.cbbtenkhoatk.Properties.Appearance.Options.UseForeColor = true;
            this.cbbtenkhoatk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbtenkhoatk.Size = new System.Drawing.Size(248, 20);
            this.cbbtenkhoatk.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 23);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Mã lớp";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 23);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Tên khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnthoattk);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(536, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 125);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnthoattk
            // 
            this.btnthoattk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoattk.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoattk.Appearance.Options.UseFont = true;
            this.btnthoattk.Appearance.Options.UseForeColor = true;
            this.btnthoattk.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.btnthoattk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoattk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthoattk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoattk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoattk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoattk.ImageOptions.Image")));
            this.btnthoattk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoattk.Location = new System.Drawing.Point(80, 70);
            this.btnthoattk.Name = "btnthoattk";
            this.btnthoattk.Size = new System.Drawing.Size(109, 41);
            this.btnthoattk.TabIndex = 2;
            this.btnthoattk.Text = "Thoát";
            this.btnthoattk.Click += new System.EventHandler(this.btnthoattk_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthongke.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthongke.Appearance.Options.UseFont = true;
            this.btnthongke.Appearance.Options.UseForeColor = true;
            this.btnthongke.BackgroundImage = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnthongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthongke.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthongke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.ImageOptions.Image")));
            this.btnthongke.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthongke.Location = new System.Drawing.Point(80, 23);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(109, 41);
            this.btnthongke.TabIndex = 0;
            this.btnthongke.Text = "Thống kê";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // frmthongke
            // 
            this.AcceptButton = this.btnthongke;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::UI_Tier.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.CancelButton = this.btnthoattk;
            this.ClientSize = new System.Drawing.Size(808, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmthongke";
            this.Text = "THỐNG KÊ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmthongke_FormClosing);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewsv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmaloptk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbtenkhoatk.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridviewsv;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit cbbmaloptk;
        private DevExpress.XtraEditors.ComboBoxEdit cbbtenkhoatk;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnthoattk;
        private DevExpress.XtraEditors.SimpleButton btnthongke;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}