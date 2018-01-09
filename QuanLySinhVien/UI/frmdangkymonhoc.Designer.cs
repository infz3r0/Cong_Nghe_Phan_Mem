using System;

namespace UI_Tier
{
    partial class frmdangkymonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangkymonhoc));
            this.label1 = new System.Windows.Forms.Label();
            this.txttimmon = new DevExpress.XtraEditors.TextEdit();
            this.btnloc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxmonhoc = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Griddanhsachdachon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmssv = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatdk = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoadk = new DevExpress.XtraEditors.SimpleButton();
            this.btnluudk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txttimmon.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Griddanhsachdachon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmssv.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc theo môn học";
            // 
            // txttimmon
            // 
            this.txttimmon.Location = new System.Drawing.Point(231, 22);
            this.txttimmon.Name = "txttimmon";
            this.txttimmon.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txttimmon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimmon.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txttimmon.Properties.Appearance.Options.UseBackColor = true;
            this.txttimmon.Properties.Appearance.Options.UseFont = true;
            this.txttimmon.Properties.Appearance.Options.UseForeColor = true;
            this.txttimmon.Size = new System.Drawing.Size(235, 30);
            this.txttimmon.TabIndex = 1;
            // 
            // btnloc
            // 
            this.btnloc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.ForeColor = System.Drawing.Color.Black;
            this.btnloc.Location = new System.Drawing.Point(485, 20);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(94, 38);
            this.btnloc.TabIndex = 2;
            this.btnloc.Text = "Lọc >>";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkedListBoxmonhoc);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 75);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(983, 250);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // checkedListBoxmonhoc
            // 
            this.checkedListBoxmonhoc.FormattingEnabled = true;
            this.checkedListBoxmonhoc.Location = new System.Drawing.Point(23, 43);
            this.checkedListBoxmonhoc.Name = "checkedListBoxmonhoc";
            this.checkedListBoxmonhoc.Size = new System.Drawing.Size(947, 179);
            this.checkedListBoxmonhoc.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Griddanhsachdachon);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 428);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(983, 277);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học đã chọn";
            // 
            // Griddanhsachdachon
            // 
            this.Griddanhsachdachon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Griddanhsachdachon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Griddanhsachdachon.Location = new System.Drawing.Point(23, 47);
            this.Griddanhsachdachon.Name = "Griddanhsachdachon";
            this.Griddanhsachdachon.RowTemplate.Height = 24;
            this.Griddanhsachdachon.Size = new System.Drawing.Size(947, 208);
            this.Griddanhsachdachon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã sinh viên";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(184, 363);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtmssv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmssv.Properties.Appearance.Options.UseBackColor = true;
            this.txtmssv.Properties.Appearance.Options.UseFont = true;
            this.txtmssv.Size = new System.Drawing.Size(235, 30);
            this.txtmssv.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnthoatdk);
            this.groupBox2.Controls.Add(this.btnxoadk);
            this.groupBox2.Controls.Add(this.btnluudk);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(481, 342);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(519, 87);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatdk
            // 
            this.btnthoatdk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatdk.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatdk.Appearance.Options.UseFont = true;
            this.btnthoatdk.Appearance.Options.UseForeColor = true;
            this.btnthoatdk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatdk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatdk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatdk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatdk.ImageOptions.Image")));
            this.btnthoatdk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatdk.Location = new System.Drawing.Point(378, 28);
            this.btnthoatdk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoatdk.Name = "btnthoatdk";
            this.btnthoatdk.Size = new System.Drawing.Size(112, 41);
            this.btnthoatdk.TabIndex = 3;
            this.btnthoatdk.Text = "Đóng";
            this.btnthoatdk.Click += new System.EventHandler(this.btnthoatdk_Click);
            // 
            // btnxoadk
            // 
            this.btnxoadk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoadk.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnxoadk.Appearance.Options.UseFont = true;
            this.btnxoadk.Appearance.Options.UseForeColor = true;
            this.btnxoadk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnxoadk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoadk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoadk.ImageOptions.Image")));
            this.btnxoadk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoadk.Location = new System.Drawing.Point(232, 28);
            this.btnxoadk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoadk.Name = "btnxoadk";
            this.btnxoadk.Size = new System.Drawing.Size(112, 41);
            this.btnxoadk.TabIndex = 2;
            this.btnxoadk.Text = "Xóa";
            // 
            // btnluudk
            // 
            this.btnluudk.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluudk.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnluudk.Appearance.Options.UseFont = true;
            this.btnluudk.Appearance.Options.UseForeColor = true;
            this.btnluudk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnluudk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnluudk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnluudk.ImageOptions.Image")));
            this.btnluudk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnluudk.Location = new System.Drawing.Point(89, 28);
            this.btnluudk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnluudk.Name = "btnluudk";
            this.btnluudk.Size = new System.Drawing.Size(112, 41);
            this.btnluudk.TabIndex = 0;
            this.btnluudk.Text = "Lưu";
            // 
            // frmdangkymonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.txttimmon);
            this.Controls.Add(this.label1);
            this.Name = "frmdangkymonhoc";
            this.Text = "frmdangkymonhoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangkymonhoc_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txttimmon.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Griddanhsachdachon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmssv.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnloc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txttimmon;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Griddanhsachdachon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtmssv;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnthoatdk;
        private DevExpress.XtraEditors.SimpleButton btnxoadk;
        private DevExpress.XtraEditors.SimpleButton btnluudk;
        private System.Windows.Forms.CheckedListBox checkedListBoxmonhoc;
    }
}