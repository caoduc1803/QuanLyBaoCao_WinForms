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
            pnlTitle = new Panel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            tblMain = new TableLayoutPanel();
            pnlLeft = new Panel();
            tblLeft = new TableLayoutPanel();
            panel1 = new Panel();
            label3 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            pnlLeftHeader = new Panel();
            label2 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            pnlRight = new Panel();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tblMain.SuspendLayout();
            pnlLeft.SuspendLayout();
            tblLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            pnlLeftHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
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
            pnlTitle.Size = new Size(1378, 60);
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
            label1.Size = new Size(836, 45);
            label1.TabIndex = 0;
            label1.Text = "Hệ thống quản lý báo hỏng và Sửa chữa cơ sở vật chất";
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
            tblMain.Size = new Size(1378, 684);
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
            pnlLeft.Size = new Size(791, 636);
            pnlLeft.TabIndex = 0;
            // 
            // tblLeft
            // 
            tblLeft.ColumnCount = 1;
            tblLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLeft.Controls.Add(panel1, 0, 0);
            tblLeft.Dock = DockStyle.Fill;
            tblLeft.Location = new Point(0, 50);
            tblLeft.Name = "tblLeft";
            tblLeft.Padding = new Padding(10);
            tblLeft.RowCount = 3;
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tblLeft.Size = new Size(789, 584);
            tblLeft.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 213, 242);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconPictureBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 172);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(238, 245, 252);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(48, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 0;
            label3.Text = "TÌM KIẾM VÀ LỌC";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(187, 213, 242);
            iconPictureBox3.Dock = DockStyle.Left;
            iconPictureBox3.ForeColor = Color.FromArgb(21, 62, 117);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox3.IconColor = Color.FromArgb(21, 62, 117);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 48;
            iconPictureBox3.Location = new Point(0, 0);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(48, 172);
            iconPictureBox3.TabIndex = 1;
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
            pnlLeftHeader.Size = new Size(789, 50);
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
            label2.Size = new Size(395, 36);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ DỮ LIỆU VÀ TRA CỨU";
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
            pnlRight.Location = new Point(831, 24);
            pnlRight.Margin = new Padding(8);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(523, 636);
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
            // FormGhiNhanSuCo
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1378, 744);
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
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            pnlLeftHeader.ResumeLayout(false);
            pnlLeftHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
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
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
    }
}
