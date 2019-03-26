namespace quanlynhasach.HeThongGiaoDien
{
    partial class frmdanhsachsach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdanhsachsach));
            this.txtthongtinsach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radtensach = new System.Windows.Forms.RadioButton();
            this.radiotacgia = new System.Windows.Forms.RadioButton();
            this.cbTimTheLoai = new System.Windows.Forms.ComboBox();
            this.radtatca = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvsach = new System.Windows.Forms.DataGridView();
            this.colmasach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsoluongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmatheloai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchon = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtthongtinsach
            // 
            this.txtthongtinsach.Location = new System.Drawing.Point(124, 18);
            this.txtthongtinsach.Name = "txtthongtinsach";
            this.txtthongtinsach.Size = new System.Drawing.Size(176, 20);
            this.txtthongtinsach.TabIndex = 1;
            this.txtthongtinsach.TextChanged += new System.EventHandler(this.txtthongtinsach_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin liệt kê sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radtensach);
            this.groupBox2.Controls.Add(this.radiotacgia);
            this.groupBox2.Controls.Add(this.cbTimTheLoai);
            this.groupBox2.Controls.Add(this.radtatca);
            this.groupBox2.Controls.Add(this.txtthongtinsach);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Sách theo thông tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thể loại:";
            // 
            // radtensach
            // 
            this.radtensach.AutoSize = true;
            this.radtensach.Location = new System.Drawing.Point(586, 20);
            this.radtensach.Name = "radtensach";
            this.radtensach.Size = new System.Drawing.Size(70, 17);
            this.radtensach.TabIndex = 5;
            this.radtensach.TabStop = true;
            this.radtensach.Text = "Tên sách";
            this.radtensach.UseVisualStyleBackColor = true;
            this.radtensach.CheckedChanged += new System.EventHandler(this.radtensach_CheckedChanged);
            // 
            // radiotacgia
            // 
            this.radiotacgia.AutoSize = true;
            this.radiotacgia.Location = new System.Drawing.Point(525, 20);
            this.radiotacgia.Name = "radiotacgia";
            this.radiotacgia.Size = new System.Drawing.Size(61, 17);
            this.radiotacgia.TabIndex = 5;
            this.radiotacgia.TabStop = true;
            this.radiotacgia.Text = "Tác giả";
            this.radiotacgia.UseVisualStyleBackColor = true;
            this.radiotacgia.CheckedChanged += new System.EventHandler(this.radiotacgia_CheckedChanged);
            // 
            // cbTimTheLoai
            // 
            this.cbTimTheLoai.FormattingEnabled = true;
            this.cbTimTheLoai.Location = new System.Drawing.Point(360, 18);
            this.cbTimTheLoai.Name = "cbTimTheLoai";
            this.cbTimTheLoai.Size = new System.Drawing.Size(97, 21);
            this.cbTimTheLoai.TabIndex = 12;
            this.cbTimTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTimTheLoai_SelectedIndexChanged);
            // 
            // radtatca
            // 
            this.radtatca.AutoSize = true;
            this.radtatca.Location = new System.Drawing.Point(463, 19);
            this.radtatca.Name = "radtatca";
            this.radtatca.Size = new System.Drawing.Size(56, 17);
            this.radtatca.TabIndex = 3;
            this.radtatca.TabStop = true;
            this.radtatca.Text = "Tất cả";
            this.radtatca.UseVisualStyleBackColor = true;
            this.radtatca.CheckedChanged += new System.EventHandler(this.radtatca_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvsach);
            this.groupBox1.Location = new System.Drawing.Point(14, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 181);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết về cuốn sách";
            // 
            // dgvsach
            // 
            this.dgvsach.AllowUserToAddRows = false;
            this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colmasach,
            this.coltensach,
            this.colgiaban,
            this.colsoluongton,
            this.coltacgia,
            this.colmatheloai});
            this.dgvsach.Location = new System.Drawing.Point(7, 20);
            this.dgvsach.MultiSelect = false;
            this.dgvsach.Name = "dgvsach";
            this.dgvsach.ReadOnly = true;
            this.dgvsach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsach.Size = new System.Drawing.Size(652, 150);
            this.dgvsach.TabIndex = 3;
            this.dgvsach.SelectionChanged += new System.EventHandler(this.dgvsach_SelectionChanged);
            // 
            // colmasach
            // 
            this.colmasach.DataPropertyName = "MaSach";
            this.colmasach.HeaderText = "Mã sách";
            this.colmasach.Name = "colmasach";
            this.colmasach.ReadOnly = true;
            // 
            // coltensach
            // 
            this.coltensach.DataPropertyName = "TenSach";
            this.coltensach.HeaderText = "Tên sách";
            this.coltensach.Name = "coltensach";
            this.coltensach.ReadOnly = true;
            // 
            // colgiaban
            // 
            this.colgiaban.DataPropertyName = "GiaBan";
            this.colgiaban.HeaderText = "Giá bán";
            this.colgiaban.Name = "colgiaban";
            this.colgiaban.ReadOnly = true;
            // 
            // colsoluongton
            // 
            this.colsoluongton.DataPropertyName = "SoLuongTon";
            this.colsoluongton.HeaderText = "Số lượng tồn";
            this.colsoluongton.Name = "colsoluongton";
            this.colsoluongton.ReadOnly = true;
            // 
            // coltacgia
            // 
            this.coltacgia.DataPropertyName = "TacGia";
            this.coltacgia.HeaderText = "Tác giả";
            this.coltacgia.Name = "coltacgia";
            this.coltacgia.ReadOnly = true;
            // 
            // colmatheloai
            // 
            this.colmatheloai.DataPropertyName = "MaTheLoai";
            this.colmatheloai.HeaderText = "Thể loại";
            this.colmatheloai.Name = "colmatheloai";
            this.colmatheloai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(221, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "DANH SÁCH SÁCH";
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(578, 293);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchon
            // 
            this.btnchon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchon.BackgroundImage")));
            this.btnchon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnchon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchon.ForeColor = System.Drawing.Color.White;
            this.btnchon.Location = new System.Drawing.Point(498, 293);
            this.btnchon.Name = "btnchon";
            this.btnchon.Size = new System.Drawing.Size(75, 23);
            this.btnchon.TabIndex = 11;
            this.btnchon.Text = "Chọn";
            this.btnchon.UseVisualStyleBackColor = true;
            this.btnchon.Click += new System.EventHandler(this.btnchon_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_12;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Location = new System.Drawing.Point(675, 1);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(19, 334);
            this.pictureBox14.TabIndex = 22;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_20;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 336);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_01;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(98, 18);
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_06;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(675, -1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(19, 51);
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_03;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(1, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(693, 18);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_21;
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Location = new System.Drawing.Point(675, 278);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(19, 56);
            this.pictureBox15.TabIndex = 28;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_22;
            this.pictureBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox16.Location = new System.Drawing.Point(0, 290);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(16, 45);
            this.pictureBox16.TabIndex = 29;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::quanlynhasach.Properties.Resources.nen23psd_26;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 316);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(694, 19);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // frmdanhsachsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 335);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnchon);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmdanhsachsach";
            this.Text = "Danh sách Sách";
            this.Load += new System.EventHandler(this.frmdanhsachsach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtthongtinsach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiotacgia;
        private System.Windows.Forms.RadioButton radtatca;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchon;
        private System.Windows.Forms.RadioButton radtensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmasach;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsoluongton;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltacgia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colmatheloai;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTimTheLoai;

    }
}