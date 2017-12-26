namespace UI_Tier
{
    partial class frmbancansu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbancansu));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridviewbcs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbchucvubancansu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbhotenbancansu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbmssvbancansu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatbcs = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoabcs = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuabcs = new DevExpress.XtraEditors.SimpleButton();
            this.btnthembcs = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewbcs)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbchucvubancansu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbhotenbancansu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmssvbancansu.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // gridviewbcs
            // 
            this.gridviewbcs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewbcs.BackgroundColor = System.Drawing.Color.White;
            this.gridviewbcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridviewbcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewbcs.Location = new System.Drawing.Point(7, 20);
            this.gridviewbcs.Name = "gridviewbcs";
            this.gridviewbcs.Size = new System.Drawing.Size(629, 235);
            this.gridviewbcs.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbchucvubancansu);
            this.groupBox1.Controls.Add(this.cbbhotenbancansu);
            this.groupBox1.Controls.Add(this.cbbmssvbancansu);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 208);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbchucvubancansu
            // 
            this.cbbchucvubancansu.Location = new System.Drawing.Point(144, 130);
            this.cbbchucvubancansu.Name = "cbbchucvubancansu";
            this.cbbchucvubancansu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbchucvubancansu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbchucvubancansu.Properties.Appearance.Options.UseBackColor = true;
            this.cbbchucvubancansu.Properties.Appearance.Options.UseForeColor = true;
            this.cbbchucvubancansu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbchucvubancansu.Size = new System.Drawing.Size(275, 20);
            this.cbbchucvubancansu.TabIndex = 2;
            // 
            // cbbhotenbancansu
            // 
            this.cbbhotenbancansu.Location = new System.Drawing.Point(144, 89);
            this.cbbhotenbancansu.Name = "cbbhotenbancansu";
            this.cbbhotenbancansu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbhotenbancansu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbhotenbancansu.Properties.Appearance.Options.UseBackColor = true;
            this.cbbhotenbancansu.Properties.Appearance.Options.UseForeColor = true;
            this.cbbhotenbancansu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbhotenbancansu.Size = new System.Drawing.Size(275, 20);
            this.cbbhotenbancansu.TabIndex = 1;
            // 
            // cbbmssvbancansu
            // 
            this.cbbmssvbancansu.Location = new System.Drawing.Point(144, 52);
            this.cbbmssvbancansu.Name = "cbbmssvbancansu";
            this.cbbmssvbancansu.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbmssvbancansu.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbmssvbancansu.Properties.Appearance.Options.UseBackColor = true;
            this.cbbmssvbancansu.Properties.Appearance.Options.UseForeColor = true;
            this.cbbmssvbancansu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbmssvbancansu.Size = new System.Drawing.Size(275, 20);
            this.cbbmssvbancansu.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 127);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 23);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Chức vụ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Họ tên";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mssv";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewbcs);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 266);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatbcs);
            this.groupBox2.Controls.Add(this.btnxoabcs);
            this.groupBox2.Controls.Add(this.btnsuabcs);
            this.groupBox2.Controls.Add(this.btnthembcs);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(511, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 208);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatbcs
            // 
            this.btnthoatbcs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatbcs.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatbcs.Appearance.Options.UseFont = true;
            this.btnthoatbcs.Appearance.Options.UseForeColor = true;
            this.btnthoatbcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatbcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatbcs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatbcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatbcs.ImageOptions.Image")));
            this.btnthoatbcs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatbcs.Location = new System.Drawing.Point(23, 161);
            this.btnthoatbcs.Name = "btnthoatbcs";
            this.btnthoatbcs.Size = new System.Drawing.Size(96, 33);
            this.btnthoatbcs.TabIndex = 3;
            this.btnthoatbcs.Text = "Đóng";
            this.btnthoatbcs.Click += new System.EventHandler(this.btnthoatbcs_Click);
            // 
            // btnxoabcs
            // 
            this.btnxoabcs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoabcs.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoabcs.Appearance.Options.UseFont = true;
            this.btnxoabcs.Appearance.Options.UseForeColor = true;
            this.btnxoabcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoabcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoabcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoabcs.ImageOptions.Image")));
            this.btnxoabcs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoabcs.Location = new System.Drawing.Point(23, 117);
            this.btnxoabcs.Name = "btnxoabcs";
            this.btnxoabcs.Size = new System.Drawing.Size(96, 33);
            this.btnxoabcs.TabIndex = 2;
            this.btnxoabcs.Text = "Xóa";
            // 
            // btnsuabcs
            // 
            this.btnsuabcs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuabcs.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuabcs.Appearance.Options.UseFont = true;
            this.btnsuabcs.Appearance.Options.UseForeColor = true;
            this.btnsuabcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuabcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuabcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuabcs.ImageOptions.Image")));
            this.btnsuabcs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuabcs.Location = new System.Drawing.Point(23, 76);
            this.btnsuabcs.Name = "btnsuabcs";
            this.btnsuabcs.Size = new System.Drawing.Size(96, 33);
            this.btnsuabcs.TabIndex = 1;
            this.btnsuabcs.Text = "Sửa ";
            // 
            // btnthembcs
            // 
            this.btnthembcs.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthembcs.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthembcs.Appearance.Options.UseFont = true;
            this.btnthembcs.Appearance.Options.UseForeColor = true;
            this.btnthembcs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthembcs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthembcs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthembcs.ImageOptions.Image")));
            this.btnthembcs.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthembcs.Location = new System.Drawing.Point(23, 32);
            this.btnthembcs.Name = "btnthembcs";
            this.btnthembcs.Size = new System.Drawing.Size(96, 33);
            this.btnthembcs.TabIndex = 0;
            this.btnthembcs.Text = "Thêm";
            // 
            // frmbancansu
            // 
            this.AcceptButton = this.btnthembcs;
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoatbcs;
            this.ClientSize = new System.Drawing.Size(665, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmbancansu";
            this.Text = "BAN CÁN SỰ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmbancansu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewbcs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbchucvubancansu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbhotenbancansu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbmssvbancansu.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridView gridviewbcs;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnthoatbcs;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnxoabcs;
        private DevExpress.XtraEditors.SimpleButton btnsuabcs;
        private DevExpress.XtraEditors.SimpleButton btnthembcs;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ComboBoxEdit cbbchucvubancansu;
        private DevExpress.XtraEditors.ComboBoxEdit cbbhotenbancansu;
        private DevExpress.XtraEditors.ComboBoxEdit cbbmssvbancansu;
    }
}