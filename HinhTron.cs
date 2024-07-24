using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhChuViDienTich
{
    public partial class HinhTron : Form
    {
        double r;
        double pi = 3.14;
        public HinhTron()
        {
            InitializeComponent();
        }
        private bool LayThongTin()
        {
            try
            {
                r = Convert.ToDouble(txtR.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtR.Clear();
                txtR.Focus();
                return false;
            }
        }
        private double TinhDienTich(double r, double pi)
        {
            return r * r * pi;
        }
        private double TinhChuVi(double r, double pi)
        {
            return 2 * r * pi;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "- Diện tích: " + TinhDienTich(r, pi) + Environment.NewLine + "- Chu vi: " + TinhChuVi(r, pi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LayThongTin())
            {
                if (rdoCV.Checked) lblKQ.Text = "- Chu vi: " + TinhChuVi(r, pi);
                if (rdoDT.Checked) lblKQ.Text = "- Diện tích: " + TinhDienTich(r, pi);
            }
            else
                lblKQ.Text = "";
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            if (LayThongTin()) lblKQ.Text = "- Diện tích: " + TinhDienTich(r, pi);
            else lblKQ.Text = "";
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            if (LayThongTin()) lblKQ.Text = "- Chu vi: " + TinhChuVi(r, pi);
            else lblKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LayThongTin())
            {
                if (chkCV.Checked) lblKQ.Text = "- Chu vi: " + TinhChuVi(r, pi);
                if (chkDT.Checked) lblKQ.Text = "- Diện tích: " + TinhDienTich(r, pi);
                if (chkDT.Checked && chkCV.Checked) lblKQ.Text = "- Diện tích: " + TinhDienTich(r, pi) + Environment.NewLine + "- Chu vi: " + TinhChuVi(r, pi);                              
            }
            else
                lblKQ.Text = "";
        }
    }
}
