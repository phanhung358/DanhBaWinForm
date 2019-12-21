namespace DanhBa
{
    partial class frmDanhBa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhBa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dgvNhomDB = new System.Windows.Forms.DataGridView();
            this.tennhomDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsNhomDB = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDanhBa = new System.Windows.Forms.DataGridView();
            this.bdsDanhBa = new System.Windows.Forms.BindingSource(this.components);
            this.tenDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTenGoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhomDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhBa)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.btnThemLienLac,
            this.btnXoaLienLac,
            this.txtTimKiem,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1043, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(115, 24);
            this.btnThemNhom.Text = "Thêm Nhóm";
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(104, 24);
            this.btnXoaNhom.Text = "Xóa Nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.BtnXoaNhom_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLienLac.Image")));
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(127, 28);
            this.btnThemLienLac.Text = "Thêm Liên Lạc";
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLienLac.Image")));
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(116, 24);
            this.btnXoaLienLac.Text = "Xóa Liên Lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.BtnXoaLienLac_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 27);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.TxtTimKiem_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 28);
            this.toolStripLabel1.Text = "Tìm Kiếm";
            // 
            // dgvNhomDB
            // 
            this.dgvNhomDB.AllowUserToAddRows = false;
            this.dgvNhomDB.AllowUserToDeleteRows = false;
            this.dgvNhomDB.AllowUserToResizeRows = false;
            this.dgvNhomDB.AutoGenerateColumns = false;
            this.dgvNhomDB.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvNhomDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tennhomDB});
            this.dgvNhomDB.DataSource = this.bdsNhomDB;
            this.dgvNhomDB.GridColor = System.Drawing.SystemColors.Info;
            this.dgvNhomDB.Location = new System.Drawing.Point(12, 38);
            this.dgvNhomDB.Name = "dgvNhomDB";
            this.dgvNhomDB.ReadOnly = true;
            this.dgvNhomDB.RowHeadersWidth = 51;
            this.dgvNhomDB.RowTemplate.Height = 24;
            this.dgvNhomDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomDB.Size = new System.Drawing.Size(346, 622);
            this.dgvNhomDB.TabIndex = 2;
            this.dgvNhomDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhomDB_CellClick);
            // 
            // tennhomDB
            // 
            this.tennhomDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tennhomDB.DataPropertyName = "tennhomDB";
            this.tennhomDB.HeaderText = "Tên Nhóm";
            this.tennhomDB.MinimumWidth = 6;
            this.tennhomDB.Name = "tennhomDB";
            this.tennhomDB.ReadOnly = true;
            // 
            // dgvDanhBa
            // 
            this.dgvDanhBa.AllowUserToAddRows = false;
            this.dgvDanhBa.AllowUserToDeleteRows = false;
            this.dgvDanhBa.AutoGenerateColumns = false;
            this.dgvDanhBa.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDB,
            this.email,
            this.sdt});
            this.dgvDanhBa.DataSource = this.bdsDanhBa;
            this.dgvDanhBa.GridColor = System.Drawing.SystemColors.Info;
            this.dgvDanhBa.Location = new System.Drawing.Point(367, 39);
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.ReadOnly = true;
            this.dgvDanhBa.RowHeadersWidth = 51;
            this.dgvDanhBa.RowTemplate.Height = 24;
            this.dgvDanhBa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhBa.Size = new System.Drawing.Size(664, 353);
            this.dgvDanhBa.TabIndex = 3;
            this.dgvDanhBa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDanhBa_CellClick);
            // 
            // tenDB
            // 
            this.tenDB.DataPropertyName = "tenDB";
            this.tenDB.HeaderText = "Tên Danh Bạ";
            this.tenDB.MinimumWidth = 6;
            this.tenDB.Name = "tenDB";
            this.tenDB.ReadOnly = true;
            this.tenDB.Width = 121;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 185;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // lblTenGoi
            // 
            this.lblTenGoi.AutoSize = true;
            this.lblTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenGoi.ForeColor = System.Drawing.Color.Red;
            this.lblTenGoi.Location = new System.Drawing.Point(375, 420);
            this.lblTenGoi.Name = "lblTenGoi";
            this.lblTenGoi.Size = new System.Drawing.Size(156, 39);
            this.lblTenGoi.TabIndex = 4;
            this.lblTenGoi.Text = "[Tên Gọi]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(377, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(377, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(377, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Location = new System.Drawing.Point(579, 496);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(76, 25);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(579, 557);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(137, 25);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(579, 618);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // frmDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 668);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenGoi);
            this.Controls.Add(this.dgvDanhBa);
            this.Controls.Add(this.dgvNhomDB);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Bạ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhomDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhBa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dgvNhomDB;
        private System.Windows.Forms.DataGridView dgvDanhBa;
        private System.Windows.Forms.BindingSource bdsNhomDB;
        private System.Windows.Forms.BindingSource bdsDanhBa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhomDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Label lblTenGoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
    }
}

