namespace UI_Tier
{
    partial class frmmonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmonhoc));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridviewhp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbloaihp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtmahp = new DevExpress.XtraEditors.TextEdit();
            this.txtstchp = new DevExpress.XtraEditors.TextEdit();
            this.txttenhp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnthoathp = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnxoahp = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuahp = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemhp = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewhp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbloaihp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstchp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenhp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewhp);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 258);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // gridviewhp
            // 
            this.gridviewhp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewhp.BackgroundColor = System.Drawing.Color.White;
            this.gridviewhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewhp.Location = new System.Drawing.Point(6, 25);
            this.gridviewhp.Name = "gridviewhp";
            this.gridviewhp.Size = new System.Drawing.Size(660, 220);
            this.gridviewhp.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbbloaihp);
            this.groupBox1.Controls.Add(this.txtmahp);
            this.groupBox1.Controls.Add(this.txtstchp);
            this.groupBox1.Controls.Add(this.txttenhp);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 208);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbbloaihp
            // 
            this.cbbloaihp.Location = new System.Drawing.Point(188, 163);
            this.cbbloaihp.Name = "cbbloaihp";
            this.cbbloaihp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbbloaihp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbbloaihp.Properties.Appearance.Options.UseBackColor = true;
            this.cbbloaihp.Properties.Appearance.Options.UseForeColor = true;
            this.cbbloaihp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbloaihp.Size = new System.Drawing.Size(297, 20);
            this.cbbloaihp.TabIndex = 3;
            // 
            // txtmahp
            // 
            this.txtmahp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmahp.Location = new System.Drawing.Point(188, 42);
            this.txtmahp.Name = "txtmahp";
            this.txtmahp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmahp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtmahp.Properties.Appearance.Options.UseBackColor = true;
            this.txtmahp.Properties.Appearance.Options.UseForeColor = true;
            this.txtmahp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtmahp.Size = new System.Drawing.Size(297, 20);
            this.txtmahp.TabIndex = 0;
            // 
            // txtstchp
            // 
            this.txtstchp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstchp.Location = new System.Drawing.Point(188, 120);
            this.txtstchp.Name = "txtstchp";
            this.txtstchp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtstchp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtstchp.Properties.Appearance.Options.UseBackColor = true;
            this.txtstchp.Properties.Appearance.Options.UseForeColor = true;
            this.txtstchp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txtstchp.Size = new System.Drawing.Size(297, 20);
            this.txtstchp.TabIndex = 2;
            // 
            // txttenhp
            // 
            this.txttenhp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenhp.Location = new System.Drawing.Point(188, 80);
            this.txttenhp.Name = "txttenhp";
            this.txttenhp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttenhp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttenhp.Properties.Appearance.Options.UseBackColor = true;
            this.txttenhp.Properties.Appearance.Options.UseForeColor = true;
            this.txttenhp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.txttenhp.Size = new System.Drawing.Size(297, 20);
            this.txttenhp.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(118, 23);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Loại học phần";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 23);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Số tín chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(117, 23);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên học phần";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã học phần";
            // 
            // btnthoathp
            // 
            this.btnthoathp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoathp.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoathp.Appearance.Options.UseFont = true;
            this.btnthoathp.Appearance.Options.UseForeColor = true;
            this.btnthoathp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoathp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoathp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoathp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoathp.ImageOptions.Image")));
            this.btnthoathp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoathp.Location = new System.Drawing.Point(22, 161);
            this.btnthoathp.Name = "btnthoathp";
            this.btnthoathp.Size = new System.Drawing.Size(96, 33);
            this.btnthoathp.TabIndex = 3;
            this.btnthoathp.Text = "Đóng";
            this.btnthoathp.Click += new System.EventHandler(this.btnthoathp_Click);
            // 
            // btnxoahp
            // 
            this.btnxoahp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoahp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoahp.Appearance.Options.UseFont = true;
            this.btnxoahp.Appearance.Options.UseForeColor = true;
            this.btnxoahp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoahp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoahp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoahp.ImageOptions.Image")));
            this.btnxoahp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoahp.Location = new System.Drawing.Point(23, 116);
            this.btnxoahp.Name = "btnxoahp";
            this.btnxoahp.Size = new System.Drawing.Size(96, 33);
            this.btnxoahp.TabIndex = 2;
            this.btnxoahp.Text = "Xóa";
            // 
            // btnsuahp
            // 
            this.btnsuahp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuahp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuahp.Appearance.Options.UseFont = true;
            this.btnsuahp.Appearance.Options.UseForeColor = true;
            this.btnsuahp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuahp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuahp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuahp.ImageOptions.Image")));
            this.btnsuahp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuahp.Location = new System.Drawing.Point(23, 70);
            this.btnsuahp.Name = "btnsuahp";
            this.btnsuahp.Size = new System.Drawing.Size(96, 33);
            this.btnsuahp.TabIndex = 1;
            this.btnsuahp.Text = "Sửa ";
            // 
            // btnthemhp
            // 
            this.btnthemhp.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemhp.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemhp.Appearance.Options.UseFont = true;
            this.btnthemhp.Appearance.Options.UseForeColor = true;
            this.btnthemhp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemhp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemhp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemhp.ImageOptions.Image")));
            this.btnthemhp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemhp.Location = new System.Drawing.Point(23, 23);
            this.btnthemhp.Name = "btnthemhp";
            this.btnthemhp.Size = new System.Drawing.Size(96, 33);
            this.btnthemhp.TabIndex = 0;
            this.btnthemhp.Text = "Thêm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoathp);
            this.groupBox2.Controls.Add(this.btnxoahp);
            this.groupBox2.Controls.Add(this.btnsuahp);
            this.groupBox2.Controls.Add(this.btnthemhp);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(548, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 208);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // frmmonhoc
            // 
            this.AcceptButton = this.btnthemhp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoathp;
            this.ClientSize = new System.Drawing.Size(700, 486);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmonhoc";
            this.Text = "QUẢN LÍ MÔN HỌC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmonhoc_FormClosing);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewhp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbloaihp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmahp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstchp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenhp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridviewhp;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtstchp;
        private DevExpress.XtraEditors.TextEdit txttenhp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnthoathp;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnxoahp;
        private DevExpress.XtraEditors.SimpleButton btnsuahp;
        private DevExpress.XtraEditors.SimpleButton btnthemhp;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit txtmahp;
        private DevExpress.XtraEditors.ComboBoxEdit cbbloaihp;
    }
}