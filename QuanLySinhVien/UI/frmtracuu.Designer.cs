namespace UI_Tier
{
    partial class frmtracuu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtracuu));
            this.gridviewtracuu = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoatracuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btntracuu = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtInput = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewtracuu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewtracuu
            // 
            this.gridviewtracuu.AllowUserToAddRows = false;
            this.gridviewtracuu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridviewtracuu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewtracuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridviewtracuu.BackgroundColor = System.Drawing.Color.White;
            this.gridviewtracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewtracuu.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewtracuu.Location = new System.Drawing.Point(7, 23);
            this.gridviewtracuu.Name = "gridviewtracuu";
            this.gridviewtracuu.ReadOnly = true;
            this.gridviewtracuu.RowHeadersVisible = false;
            this.gridviewtracuu.Size = new System.Drawing.Size(880, 291);
            this.gridviewtracuu.TabIndex = 9;
            this.gridviewtracuu.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.gridviewtracuu);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 324);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.btnthoatracuu);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.btntracuu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 86);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnthoatracuu
            // 
            this.btnthoatracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatracuu.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btnthoatracuu.Appearance.Options.UseFont = true;
            this.btnthoatracuu.Appearance.Options.UseForeColor = true;
            this.btnthoatracuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnthoatracuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoatracuu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoatracuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoatracuu.ImageOptions.Image")));
            this.btnthoatracuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoatracuu.Location = new System.Drawing.Point(755, 31);
            this.btnthoatracuu.Name = "btnthoatracuu";
            this.btnthoatracuu.Size = new System.Drawing.Size(96, 33);
            this.btnthoatracuu.TabIndex = 2;
            this.btnthoatracuu.Text = "Đóng";
            this.btnthoatracuu.Click += new System.EventHandler(this.btnthoatracuu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Nhập mssv hoặc tên";
            // 
            // btntracuu
            // 
            this.btntracuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntracuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btntracuu.Appearance.Options.UseFont = true;
            this.btntracuu.Appearance.Options.UseForeColor = true;
            this.btntracuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntracuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntracuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntracuu.ImageOptions.Image")));
            this.btntracuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btntracuu.Location = new System.Drawing.Point(619, 31);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(96, 33);
            this.btntracuu.TabIndex = 1;
            this.btntracuu.Text = "Tìm";
            this.btntracuu.Click += new System.EventHandler(this.btntracuu_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(224, 39);
            this.txtInput.Name = "txtInput";
            this.txtInput.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtInput.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Properties.Appearance.Options.UseBackColor = true;
            this.txtInput.Properties.Appearance.Options.UseForeColor = true;
            this.txtInput.Size = new System.Drawing.Size(347, 20);
            this.txtInput.TabIndex = 3;
            // 
            // frmtracuu
            // 
            this.AcceptButton = this.btntracuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoatracuu;
            this.ClientSize = new System.Drawing.Size(912, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmtracuu";
            this.Text = "TRA CỨU THÔNG TIN SINH VIÊN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmtracuu_FormClosing);
            this.Load += new System.EventHandler(this.frmtracuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewtracuu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewtracuu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btntracuu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnthoatracuu;
        private DevExpress.XtraEditors.TextEdit txtInput;
    }
}