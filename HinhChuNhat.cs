namespace CSharp_TinhChuViDienTich
{
    public partial class HinhChuNhat : Form
    {
        double dai;
        double rong;

        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "- Diện tích: " + (dai * rong) + Environment.NewLine + "- Chu vi: " + (dai + rong) * 2;
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            LayThongTin();
            lblKQ.Text = "Diện tích: " + TinhDienTich(dai, rong);
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            if (LayThongTinMoi())
                lblKQ.Text = "Chu vi: " + TinhChuVi(dai, rong);
            else
                lblKQ.Text = "";
        }

        private double TinhDienTich(double d, double r)
        {
            return d * r;
        }
        private double TinhChuVi(double d, double r)
        {
            return (d + r) * 2;
        }

        private void LayThongTin()
        {
            try
            {
                dai = Convert.ToDouble(txtDai.Text);
                rong = Convert.ToDouble(txtRong.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDai.Clear();
                txtRong.Clear();
                txtDai.Focus();
            }

        }

        private bool LayThongTinMoi()
        {
            try
            {
                dai = Convert.ToDouble(txtDai.Text);
                rong = Convert.ToDouble(txtRong.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDai.Clear();
                txtRong.Clear();
                txtDai.Focus();
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LayThongTinMoi())
            {
                if (rdoCV.Checked) lblKQ.Text = "Chu vi: " + TinhChuVi(dai, rong);
                if (rdoDT.Checked) lblKQ.Text = "Diện tích: " + TinhDienTich(dai, rong);
            }
            else
                lblKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtDai.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            txtRong.Text = numericUpDown2.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtDai.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtRong.Text = trackBar1.Value.ToString();
        }

        private void HinhChuNhat_Load(object sender, EventArgs e)
        {
            txtDai.Text = trackBar1.Value.ToString();
            txtRong.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LayThongTinMoi())
            {
                if (chkCV.Checked) lblKQ.Text = "Chu vi: " + TinhChuVi(dai, rong);
                if (chkDT.Checked) lblKQ.Text = "Diện tích: " + TinhDienTich(dai, rong);
                if (chkCV.Checked && chkDT.Checked) lblKQ.Text = "Chu vi: " + TinhChuVi(dai, rong) + Environment.NewLine + "Diện tích: " + TinhDienTich(dai, rong);
            }
            else
                lblKQ.Text = "";
        }
    }
}
