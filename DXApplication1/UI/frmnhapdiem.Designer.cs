﻿namespace DXApplication1
{
    partial class frmnhapdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnhapdiem));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatnhapdiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnsuadiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnthemdiem = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridviewnhapdiem = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdiemthinhap = new System.Windows.Forms.MaskedTextBox();
            this.txtdiemqtnhap = new System.Windows.Forms.MaskedTextBox();
            this.txtmssvnhapdiem = new System.Windows.Forms.MaskedTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewnhapdiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatnhapdiem);
            this.groupBox2.Controls.Add(this.btnsuadiem);
            this.groupBox2.Controls.Add(this.btnthemdiem);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(433, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 208);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatnhapdiem
            // 
            this.btnthoatnhapdiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatnhapdiem.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatnhapdiem.Appearance.Options.UseFont = true;
            this.btnthoatnhapdiem.Appearance.Options.UseForeColor = true;
            this.btnthoatnhapdiem.BackgroundImage = global::DXApplication1.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.btnthoatnhapdiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatnhapdiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthoatnhapdiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatnhapdiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatnhapdiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatnhapdiem.ImageOptions.Image")));
            this.btnthoatnhapdiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatnhapdiem.Location = new System.Drawing.Point(22, 161);
            this.btnthoatnhapdiem.Name = "btnthoatnhapdiem";
            this.btnthoatnhapdiem.Size = new System.Drawing.Size(99, 41);
            this.btnthoatnhapdiem.TabIndex = 24;
            this.btnthoatnhapdiem.Text = "Thoát";
            this.btnthoatnhapdiem.Click += new System.EventHandler(this.btnthoatnhapdiem_Click);
            // 
            // btnsuadiem
            // 
            this.btnsuadiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuadiem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnsuadiem.Appearance.Options.UseFont = true;
            this.btnsuadiem.Appearance.Options.UseForeColor = true;
            this.btnsuadiem.BackgroundImage = global::DXApplication1.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.btnsuadiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsuadiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnsuadiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuadiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsuadiem.ImageOptions.Image")));
            this.btnsuadiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnsuadiem.Location = new System.Drawing.Point(23, 92);
            this.btnsuadiem.Name = "btnsuadiem";
            this.btnsuadiem.Size = new System.Drawing.Size(100, 41);
            this.btnsuadiem.TabIndex = 1;
            this.btnsuadiem.Text = "Sửa ";
            // 
            // btnthemdiem
            // 
            this.btnthemdiem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemdiem.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnthemdiem.Appearance.Options.UseFont = true;
            this.btnthemdiem.Appearance.Options.UseForeColor = true;
            this.btnthemdiem.BackgroundImage = global::DXApplication1.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ1;
            this.btnthemdiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthemdiem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnthemdiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthemdiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthemdiem.ImageOptions.Image")));
            this.btnthemdiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthemdiem.Location = new System.Drawing.Point(23, 23);
            this.btnthemdiem.Name = "btnthemdiem";
            this.btnthemdiem.Size = new System.Drawing.Size(99, 41);
            this.btnthemdiem.TabIndex = 0;
            this.btnthemdiem.Text = "Thêm";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Blueprint";
            // 
            // gridviewnhapdiem
            // 
            this.gridviewnhapdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewnhapdiem.BackgroundColor = System.Drawing.Color.White;
            this.gridviewnhapdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewnhapdiem.Location = new System.Drawing.Point(6, 25);
            this.gridviewnhapdiem.Name = "gridviewnhapdiem";
            this.gridviewnhapdiem.Size = new System.Drawing.Size(548, 220);
            this.gridviewnhapdiem.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewnhapdiem);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 258);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImage = global::DXApplication1.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.groupBox1.Controls.Add(this.txtdiemthinhap);
            this.groupBox1.Controls.Add(this.txtdiemqtnhap);
            this.groupBox1.Controls.Add(this.txtmssvnhapdiem);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 208);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtdiemthinhap
            // 
            this.txtdiemthinhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiemthinhap.ForeColor = System.Drawing.Color.Black;
            this.txtdiemthinhap.Location = new System.Drawing.Point(156, 165);
            this.txtdiemthinhap.Mask = "00000";
            this.txtdiemthinhap.Name = "txtdiemthinhap";
            this.txtdiemthinhap.PromptChar = ' ';
            this.txtdiemthinhap.Size = new System.Drawing.Size(220, 19);
            this.txtdiemthinhap.TabIndex = 7;
            this.txtdiemthinhap.ValidatingType = typeof(int);
            // 
            // txtdiemqtnhap
            // 
            this.txtdiemqtnhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdiemqtnhap.ForeColor = System.Drawing.Color.Black;
            this.txtdiemqtnhap.Location = new System.Drawing.Point(156, 104);
            this.txtdiemqtnhap.Mask = "00000";
            this.txtdiemqtnhap.Name = "txtdiemqtnhap";
            this.txtdiemqtnhap.PromptChar = ' ';
            this.txtdiemqtnhap.Size = new System.Drawing.Size(220, 19);
            this.txtdiemqtnhap.TabIndex = 6;
            this.txtdiemqtnhap.ValidatingType = typeof(int);
            // 
            // txtmssvnhapdiem
            // 
            this.txtmssvnhapdiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmssvnhapdiem.ForeColor = System.Drawing.Color.Black;
            this.txtmssvnhapdiem.Location = new System.Drawing.Point(156, 41);
            this.txtmssvnhapdiem.Mask = "0000000000";
            this.txtmssvnhapdiem.Name = "txtmssvnhapdiem";
            this.txtmssvnhapdiem.PromptChar = ' ';
            this.txtmssvnhapdiem.Size = new System.Drawing.Size(220, 19);
            this.txtmssvnhapdiem.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 23);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Điểm thi";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 23);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Điểm quá trình";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(20, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mssv";
            // 
            // frmnhapdiem
            // 
            this.AcceptButton = this.btnthemdiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::DXApplication1.Properties.Resources.AAIA_wDGAAAAAQAAAAAAAAs5AAAAJDU2ODE4YTAwLTVkM2YtNGYzOS04MzcyLTg3NTI2NmM1ZDEwZQ;
            this.CancelButton = this.btnthoatnhapdiem;
            this.ClientSize = new System.Drawing.Size(592, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmnhapdiem";
            this.Text = "NHẬP ĐIỂM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmnhapdiem_FormClosing);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewnhapdiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoatnhapdiem;
        private DevExpress.XtraEditors.SimpleButton btnsuadiem;
        private DevExpress.XtraEditors.SimpleButton btnthemdiem;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.DataGridView gridviewnhapdiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtmssvnhapdiem;
        private System.Windows.Forms.MaskedTextBox txtdiemthinhap;
        private System.Windows.Forms.MaskedTextBox txtdiemqtnhap;
    }
}