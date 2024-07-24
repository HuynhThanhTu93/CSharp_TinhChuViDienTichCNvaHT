namespace CSharp_TinhChuViDienTich
{
    partial class HinhTron
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
            btnChuVi = new Button();
            btnDienTich = new Button();
            btnThoat = new Button();
            btnTinh = new Button();
            lblKQ = new Label();
            txtRong = new TextBox();
            txtR = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            groupBox1 = new GroupBox();
            chkCV = new CheckBox();
            chkDT = new CheckBox();
            rdoCV = new RadioButton();
            rdoDT = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChuVi
            // 
            btnChuVi.Location = new Point(180, 377);
            btnChuVi.Name = "btnChuVi";
            btnChuVi.Size = new Size(130, 56);
            btnChuVi.TabIndex = 17;
            btnChuVi.Text = "CHU VI";
            btnChuVi.UseVisualStyleBackColor = true;
            btnChuVi.Click += btnChuVi_Click;
            // 
            // btnDienTich
            // 
            btnDienTich.Location = new Point(12, 377);
            btnDienTich.Name = "btnDienTich";
            btnDienTich.Size = new Size(157, 56);
            btnDienTich.TabIndex = 18;
            btnDienTich.Text = "DIỆN TÍCH";
            btnDienTich.UseVisualStyleBackColor = true;
            btnDienTich.Click += btnDienTich_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(628, 377);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(132, 56);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(12, 296);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(144, 56);
            btnTinh.TabIndex = 16;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Tahoma", 20F);
            lblKQ.Location = new Point(120, 231);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(0, 33);
            lblKQ.TabIndex = 14;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(180, 164);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(88, 40);
            txtRong.TabIndex = 12;
            txtRong.Text = "3.14";
            // 
            // txtR
            // 
            txtR.Location = new Point(180, 104);
            txtR.Name = "txtR";
            txtR.Size = new Size(88, 40);
            txtR.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 20F);
            label4.Location = new Point(18, 231);
            label4.Name = "label4";
            label4.Size = new Size(106, 33);
            label4.TabIndex = 10;
            label4.Text = "Kết quả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F);
            label3.Location = new Point(18, 171);
            label3.Name = "label3";
            label3.Size = new Size(74, 33);
            label3.TabIndex = 11;
            label3.Text = "Số Pi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 20F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(147, 33);
            label2.TabIndex = 9;
            label2.Text = "Bán kính(r)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F, FontStyle.Bold);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(723, 33);
            label1.TabIndex = 8;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH HÌNH TRÒN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkCV);
            groupBox1.Controls.Add(chkDT);
            groupBox1.Controls.Add(rdoCV);
            groupBox1.Controls.Add(rdoDT);
            groupBox1.Location = new Point(346, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 140);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn Chức Năng";
            // 
            // chkCV
            // 
            chkCV.AutoSize = true;
            chkCV.Location = new Point(148, 82);
            chkCV.Name = "chkCV";
            chkCV.Size = new Size(107, 37);
            chkCV.TabIndex = 3;
            chkCV.Text = "Chu vi";
            chkCV.UseVisualStyleBackColor = true;
            // 
            // chkDT
            // 
            chkDT.AutoSize = true;
            chkDT.Location = new Point(148, 39);
            chkDT.Name = "chkDT";
            chkDT.Size = new Size(137, 37);
            chkDT.TabIndex = 2;
            chkDT.Text = "Diện tích";
            chkDT.UseVisualStyleBackColor = true;
            // 
            // rdoCV
            // 
            rdoCV.AutoSize = true;
            rdoCV.Location = new Point(6, 82);
            rdoCV.Name = "rdoCV";
            rdoCV.Size = new Size(106, 37);
            rdoCV.TabIndex = 1;
            rdoCV.Text = "Chu vi";
            rdoCV.UseVisualStyleBackColor = true;
            // 
            // rdoDT
            // 
            rdoDT.AutoSize = true;
            rdoDT.Checked = true;
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
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Location = new Point(316, 377);
            button1.Name = "button1";
            button1.Size = new Size(144, 56);
            button1.TabIndex = 20;
            button1.Text = "TÍNH 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 255);
            button2.Location = new Point(466, 377);
            button2.Name = "button2";
            button2.Size = new Size(144, 56);
            button2.TabIndex = 20;
            button2.Text = "TÍNH 2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // HinhTron
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 515);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnChuVi);
            Controls.Add(btnDienTich);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(lblKQ);
            Controls.Add(txtRong);
            Controls.Add(txtR);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhTron";
            Text = "HinhTron";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChuVi;
        private Button btnDienTich;
        private Button btnThoat;
        private Button btnTinh;
        private Label lblKQ;
        private TextBox txtRong;
        private TextBox txtR;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private GroupBox groupBox1;
        private RadioButton rdoCV;
        private RadioButton rdoDT;
        private Button button1;
        private CheckBox chkCV;
        private CheckBox chkDT;
        private Button button2;
    }
}