namespace Baocaocuoiky
{
    partial class FormGhiNhanSuCo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlTitle = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tblMain = new TableLayoutPanel();
            pnlLeft = new Panel();
            tblLeft = new TableLayoutPanel();
            panel1 = new Panel();
            tblSearch = new TableLayoutPanel();
            label4 = new Label();
            cboPhong = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            cboTrangThai = new ComboBox();
            cboMucDo = new ComboBox();
            cboThietBi = new ComboBox();
            dtpDenNgay = new DateTimePicker();
            btnTim = new FontAwesome.Sharp.IconButton();
            btnTaiLai = new FontAwesome.Sharp.IconButton();
            pnlSearch = new Panel();
            label3 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            pnlLeftHeader = new Panel();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            pnlRight = new Panel();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            label10 = new Label();
            dgvSuCo = new DataGridView();
            colMaSC = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colThietBi = new DataGridViewTextBoxColumn();
            colNgayBao = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tblMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            tblLeft.SuspendLayout();
            panel1.SuspendLayout();
            tblSearch.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            pnlLeftHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuCo).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.RoyalBlue;
            pnlTitle.Controls.Add(label1);
            pnlTitle.Controls.Add(iconPictureBox1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1848, 60);
            pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 0);
            label1.Name = "label1";
            label1.Size = new Size(829, 45);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý báo hỏng && Sửa chữa cơ sở vật chất";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.RoyalBlue;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Tools;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 60;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(60, 60);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblMain.Controls.Add(pnlLeft, 0, 0);
            tblMain.Controls.Add(pnlRight, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 60);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(16);
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1848, 812);
            tblMain.TabIndex = 1;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Controls.Add(tblLeft);
            pnlLeft.Controls.Add(pnlLeftHeader);
            pnlLeft.Dock = DockStyle.Fill;
            pnlLeft.Location = new Point(24, 24);
            pnlLeft.Margin = new Padding(8);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(1073, 764);
            pnlLeft.TabIndex = 0;
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 1;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLeft.Controls.Add(panel1, 0, 0);
            tblLeft.Controls.Add(panel2, 0, 1);
            tblLeft.Controls.Add(panel3, 0, 2);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(0, 50);
            tblLeft.Name = "tblLeft";
            tblLeft.Padding = new Padding(10);
            tblLeft.RowCount = 3;
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tblLeft.Size = new Size(1071, 712);
            tblLeft.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tblSearch);
            panel1.Controls.Add(pnlSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 213);
            panel1.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 6;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSearch.Controls.Add(label4, 0, 0);
            tblSearch.Controls.Add(cboPhong, 1, 0);
            tblSearch.Controls.Add(label7, 2, 1);
            tblSearch.Controls.Add(label5, 2, 0);
            tblSearch.Controls.Add(label6, 4, 0);
            tblSearch.Controls.Add(label8, 0, 1);
            tblSearch.Controls.Add(cboTrangThai, 3, 0);
            tblSearch.Controls.Add(cboMucDo, 1, 1);
            tblSearch.Controls.Add(cboThietBi, 5, 0);
            tblSearch.Controls.Add(dtpDenNgay, 3, 1);
            tblSearch.Controls.Add(btnTim, 2, 2);
            tblSearch.Controls.Add(btnTaiLai, 4, 2);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(0, 40);
            tblSearch.Name = "tblSearch";
            tblSearch.Padding = new Padding(8, 4, 8, 4);
            tblSearch.RowCount = 3;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tblSearch.Size = new Size(1041, 171);
            tblSearch.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.FromArgb(31, 45, 61);
            label4.Location = new Point(11, 16);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 0;
            label4.Text = "Phòng:";
            // 
            // cboPhong
            // 
            cboPhong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboPhong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPhong.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPhong.FlatStyle = FlatStyle.Flat;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(103, 12);
            cboPhong.Margin = new Padding(3, 3, 12, 3);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(231, 36);
            cboPhong.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(31, 45, 61);
            label7.Location = new Point(349, 68);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 3;
            label7.Text = "Đến ngày:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(31, 45, 61);
            label5.Location = new Point(349, 16);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 1;
            label5.Text = "Trạng thái:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.FromArgb(31, 45, 61);
            label6.Location = new Point(686, 16);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 2;
            label6.Text = "Thiết bị:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.FromArgb(31, 45, 61);
            label8.Location = new Point(11, 68);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 4;
            label8.Text = "Mức độ:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboTrangThai.FlatStyle = FlatStyle.Flat;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(461, 12);
            cboTrangThai.Margin = new Padding(3, 3, 12, 3);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(210, 36);
            cboTrangThai.TabIndex = 5;
            // 
            // cboMucDo
            // 
            cboMucDo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboMucDo.FlatStyle = FlatStyle.Flat;
            cboMucDo.FormattingEnabled = true;
            cboMucDo.Location = new Point(103, 64);
            cboMucDo.Margin = new Padding(3, 3, 12, 3);
            cboMucDo.Name = "cboMucDo";
            cboMucDo.Size = new Size(231, 36);
            cboMucDo.TabIndex = 7;
            // 
            // cboThietBi
            // 
            cboThietBi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboThietBi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboThietBi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboThietBi.FlatStyle = FlatStyle.Flat;
            cboThietBi.FormattingEnabled = true;
            cboThietBi.Location = new Point(778, 12);
            cboThietBi.Margin = new Padding(3, 3, 12, 3);
            cboThietBi.Name = "cboThietBi";
            cboThietBi.Size = new Size(243, 36);
            cboThietBi.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(461, 65);
            dtpDenNgay.Margin = new Padding(3, 3, 12, 3);
            dtpDenNgay.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(210, 34);
            dtpDenNgay.TabIndex = 8;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(21, 101, 192);
            tblSearch.SetColumnSpan(btnTim, 2);
            btnTim.Cursor = Cursors.Hand;
            btnTim.Dock = DockStyle.Fill;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnTim.IconColor = Color.White;
            btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTim.IconSize = 20;
            btnTim.Location = new Point(349, 111);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(331, 53);
            btnTim.TabIndex = 9;
            btnTim.Text = "Tìm kiếm";
            btnTim.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTim.UseVisualStyleBackColor = false;
            // 
            // btnTaiLai
            // 
            tblSearch.SetColumnSpan(btnTaiLai, 2);
            btnTaiLai.Cursor = Cursors.Hand;
            btnTaiLai.Dock = DockStyle.Fill;
            btnTaiLai.FlatAppearance.BorderColor = Color.FromArgb(157, 183, 213);
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTaiLai.ForeColor = Color.FromArgb(21, 101, 192);
            btnTaiLai.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            btnTaiLai.IconColor = Color.FromArgb(21, 101, 192);
            btnTaiLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaiLai.IconSize = 20;
            btnTaiLai.Location = new Point(686, 111);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(344, 53);
            btnTaiLai.TabIndex = 10;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiLai.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(238, 245, 252);
            pnlSearch.Controls.Add(label3);
            pnlSearch.Controls.Add(iconPictureBox3);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1041, 40);
            pnlSearch.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.ForeColor = Color.FromArgb(21, 62, 117);
            label3.Location = new Point(48, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 30);
            label3.TabIndex = 1;
            label3.Text = "TÌM KIẾM && LỌC";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.Transparent;
            iconPictureBox3.Dock = DockStyle.Left;
            iconPictureBox3.ForeColor = Color.FromArgb(21, 62, 117);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox3.IconColor = Color.FromArgb(21, 62, 117);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 40;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 40);
            iconPictureBox3.TabIndex = 0;
            iconPictureBox3.TabStop = false;
            // 
            // pnlLeftHeader
            // 
            pnlLeftHeader.BackColor = Color.FromArgb(220, 235, 250);
            pnlLeftHeader.Controls.Add(label2);
            pnlLeftHeader.Controls.Add(iconPictureBox2);
            pnlLeftHeader.Dock = DockStyle.Top;
            pnlLeftHeader.Location = new Point(0, 0);
            pnlLeftHeader.Name = "pnlLeftHeader";
            pnlLeftHeader.Size = new Size(1071, 50);
            pnlLeftHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.FromArgb(21, 62, 117);
            label2.Location = new Point(50, 0);
            label2.Name = "label2";
            label2.Size = new Size(383, 36);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ DỮ LIỆU && TRA CỨU";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(220, 235, 250);
            iconPictureBox2.Dock = DockStyle.Left;
            iconPictureBox2.ForeColor = Color.FromArgb(21, 62, 117);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconPictureBox2.IconColor = Color.FromArgb(21, 62, 117);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 50;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(50, 50);
            iconPictureBox2.TabIndex = 0;
            iconPictureBox2.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.BorderStyle = BorderStyle.FixedSingle;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(1113, 24);
            pnlRight.Margin = new Padding(8);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(711, 764);
            pnlRight.TabIndex = 1;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvSuCo);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(14, 235);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(1);
            panel2.Size = new Size(1043, 268);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(14, 511);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(1);
            panel3.Size = new Size(1043, 187);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(238, 245, 252);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(iconPictureBox4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(1, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1041, 40);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(238, 245, 252);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(iconPictureBox5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(1041, 40);
            panel5.TabIndex = 0;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.Transparent;
            iconPictureBox4.Dock = DockStyle.Left;
            iconPictureBox4.ForeColor = Color.FromArgb(21, 62, 117);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconPictureBox4.IconColor = Color.FromArgb(21, 62, 117);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 40;
            iconPictureBox4.Location = new Point(0, 0);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(48, 40);
            iconPictureBox4.TabIndex = 0;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.Dock = DockStyle.Left;
            iconPictureBox5.ForeColor = Color.FromArgb(21, 62, 117);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox5.IconColor = Color.FromArgb(21, 62, 117);
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 40;
            iconPictureBox5.Location = new Point(0, 0);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(48, 40);
            iconPictureBox5.TabIndex = 0;
            iconPictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(21, 62, 117);
            label9.Location = new Point(48, 0);
            label9.Name = "label9";
            label9.Size = new Size(214, 30);
            label9.TabIndex = 1;
            label9.Text = "DANH SÁCH SỰ CỐ";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(21, 62, 117);
            label10.Location = new Point(48, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 30);
            label10.TabIndex = 1;
            label10.Text = "label10";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvSuCo
            // 
            dgvSuCo.AllowUserToAddRows = false;
            dgvSuCo.AllowUserToDeleteRows = false;
            dgvSuCo.AllowUserToResizeRows = false;
            dgvSuCo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuCo.BackgroundColor = Color.White;
            dgvSuCo.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(227, 238, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(21, 62, 117);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(227, 238, 250);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(21, 62, 117);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSuCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuCo.ColumnHeadersHeight = 40;
            dgvSuCo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSuCo.Columns.AddRange(new DataGridViewColumn[] { colMaSC, colPhong, colThietBi, colNgayBao, colTrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(31, 45, 61);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(214, 232, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(31, 45, 61);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuCo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSuCo.Dock = DockStyle.Fill;
            dgvSuCo.EnableHeadersVisualStyles = false;
            dgvSuCo.Location = new Point(1, 41);
            dgvSuCo.MultiSelect = false;
            dgvSuCo.Name = "dgvSuCo";
            dgvSuCo.ReadOnly = true;
            dgvSuCo.RowHeadersVisible = false;
            dgvSuCo.RowHeadersWidth = 62;
            dgvSuCo.RowTemplate.Height = 38;
            dgvSuCo.RowTemplate.ReadOnly = true;
            dgvSuCo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuCo.Size = new Size(1041, 226);
            dgvSuCo.TabIndex = 1;
            // 
            // colMaSC
            // 
            colMaSC.FillWeight = 15F;
            colMaSC.HeaderText = "Mã SC";
            colMaSC.MinimumWidth = 60;
            colMaSC.Name = "colMaSC";
            colMaSC.ReadOnly = true;
            // 
            // colPhong
            // 
            colPhong.FillWeight = 15F;
            colPhong.HeaderText = "Phòng";
            colPhong.MinimumWidth = 60;
            colPhong.Name = "colPhong";
            colPhong.ReadOnly = true;
            // 
            // colThietBi
            // 
            colThietBi.FillWeight = 30F;
            colThietBi.HeaderText = "Thiết bị";
            colThietBi.MinimumWidth = 100;
            colThietBi.Name = "colThietBi";
            colThietBi.ReadOnly = true;
            // 
            // colNgayBao
            // 
            colNgayBao.FillWeight = 20F;
            colNgayBao.HeaderText = "Ngày báo";
            colNgayBao.MinimumWidth = 90;
            colNgayBao.Name = "colNgayBao";
            colNgayBao.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.FillWeight = 20F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 110;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // FormGhiNhanSuCo
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1848, 872);
            Controls.Add(tblMain);
            Controls.Add(pnlTitle);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1100, 650);
            Name = "FormGhiNhanSuCo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tblMain.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            tblLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            pnlLeftHeader.ResumeLayout(false);
            pnlLeftHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSuCo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TableLayoutPanel tblMain;
        private Panel pnlLeft;
        private Panel pnlLeftHeader;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel pnlRight;
        private TableLayoutPanel tblLeft;
        private Label label2;
        private Panel panel1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Panel pnlSearch;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TableLayoutPanel tblSearch;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private ComboBox cboPhong;
        private ComboBox cboTrangThai;
        private ComboBox cboMucDo;
        private ComboBox cboThietBi;
        private DateTimePicker dtpDenNgay;
        private FontAwesome.Sharp.IconButton btnTim;
        private FontAwesome.Sharp.IconButton btnTaiLai;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label label9;
        private Label label10;
        private DataGridView dgvSuCo;
        private DataGridViewTextBoxColumn colMaSC;
        private DataGridViewTextBoxColumn colPhong;
        private DataGridViewTextBoxColumn colThietBi;
        private DataGridViewTextBoxColumn colNgayBao;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}
