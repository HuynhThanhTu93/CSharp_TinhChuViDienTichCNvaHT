namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDai = new TextBox();
            txtRong = new TextBox();
            label4 = new Label();
            lblKQ = new Label();
            btnTinh = new Button();
            btnThoat = new Button();
            btnDienTich = new Button();
            btnChuVi = new Button();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            rdoCV = new RadioButton();
            rdoDT = new RadioButton();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            trackBar1 = new TrackBar();
            numericUpDown2 = new NumericUpDown();
            trackBar2 = new TrackBar();
            groupBox2 = new GroupBox();
            chkCV = new CheckBox();
            chkDT = new CheckBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(789, 33);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F);
            label2.Location = new Point(22, 82);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 1;
            label2.Text = "Chiều dài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(22, 142);
            label3.Name = "label3";
            label3.Size = new Size(144, 33);
            label3.TabIndex = 2;
            label3.Text = "Chiều rộng";
            // 
            // txtDai
            // 
            txtDai.Location = new Point(186, 79);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(219, 40);
            txtDai.TabIndex = 1;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(186, 139);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(219, 40);
            txtRong.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 2;
            label4.Text = "Kết quả";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Tahoma", 20F);
            lblKQ.Location = new Point(186, 202);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 4;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(22, 267);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(144, 56);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(672, 344);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 56);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(22, 344);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(168, 56);
            btnDienTich.TabIndex = 6;
            btnDienTich.Text = "DIỆN TÍCH";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(208, 344);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(144, 56);
            btnChuVi.TabIndex = 6;
            btnChuVi.Text = "CHU VI";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoCV);
            groupBox1.Controls.Add(rdoDT);
            groupBox1.Location = new Point(404, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 140);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // rdoCV
            // 
            rdoCV.AutoSize = true;
            rdoCV.Location = new Point(6, 82);
            rdoCV.Name = "rdoCV";
            rdoCV.Size = new Size(106, 37);
            rdoCV.TabIndex = 1;
            rdoCV.TabStop = true;
            rdoCV.Text = "Chu vi";
            rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoDT
            // 
            rdoDT.AutoSize = true;
            rdoDT.Location = new Point(6, 39);
            rdoDT.Name = "rdoDT";
            rdoDT.Size = new Size(136, 37);
            rdoDT.TabIndex = 0;
            rdoDT.TabStop = true;
            rdoDT.Text = "Diện tích";
            rdoDT.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(358, 344);
            button1.Name = "button1";
            button1.Size = new Size(134, 56);
            button1.TabIndex = 8;
            button1.Text = "TÍNH 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(424, 79);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 40);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(559, 74);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(234, 45);
            trackBar1.TabIndex = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(424, 140);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(353, 40);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(559, 135);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(234, 45);
            trackBar2.TabIndex = 10;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkCV);
            groupBox2.Controls.Add(chkDT);
            groupBox2.Location = new Point(577, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(155, 138);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // chkCV
            // 
            chkCV.AutoSize = true;
            chkCV.Location = new Point(6, 82);
            chkCV.Name = "chkCV";
            chkCV.Size = new Size(107, 37);
            chkCV.TabIndex = 1;
            chkCV.Text = "Chu vi";
            chkCV.UseVisualStyleBackColor = true;
            // 
            // chkDT
            // 
            chkDT.AutoSize = true;
            chkDT.Location = new Point(6, 39);
            chkDT.Name = "chkDT";
            chkDT.Size = new Size(137, 37);
            chkDT.TabIndex = 0;
            chkDT.Text = "Diện tích";
            chkDT.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Location = new Point(498, 344);
            button2.Name = "button2";
            button2.Size = new Size(134, 56);
            button2.TabIndex = 8;
            button2.Text = "TÍNH 2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 427);
            Controls.Add(groupBox2);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(lblKQ);
            Controls.Add(txtRong);
            Controls.Add(txtDai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhChuNhat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HÌNH CHỮ NHẬT";
            Load += HinhChuNhat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDai;
        private TextBox txtRong;
        private Label label4;
        private Label lblKQ;
        private Button btnTinh;
        private Button btnThoat;
        private Button btnDienTich;
        private Button btnChuVi;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox1;
        private RadioButton rdoCV;
        private RadioButton rdoDT;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private TrackBar trackBar1;
        private NumericUpDown numericUpDown2;
        private TrackBar trackBar2;
        private GroupBox groupBox2;
        private CheckBox chkCV;
        private CheckBox chkDT;
        private Button button2;
    }
}
