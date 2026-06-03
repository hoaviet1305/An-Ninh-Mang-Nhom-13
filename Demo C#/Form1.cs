
using System;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSA_Demo
{
    public partial class Form1 : Form
    {
        BigInteger p, q, n, phi, eKey, d;
        private string currentFilePath = "";
        private string loadedHashType = "";

        public Form1()
        {
            InitializeComponent();
            cbHash.Items.AddRange(new string[] { "MD5", "SHA1", "SHA256" });
        }

        bool IsPrime(BigInteger n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt((double)n); i++)
                if (n % i == 0) return false;
            return true;
        }

        BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;
            return x1;
        }

        string HashFile(byte[] fileBytes, string type)
        {
            if (type == "MD5")
                return Convert.ToBase64String(MD5.Create().ComputeHash(fileBytes));

            if (type == "SHA1")
                return Convert.ToBase64String(SHA1.Create().ComputeHash(fileBytes));

            return Convert.ToBase64String(SHA256.Create().ComputeHash(fileBytes));
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            p = 61;
            q = 53;

            if (!IsPrime(p) || !IsPrime(q))
            {
                MessageBox.Show("p hoặc q không phải số nguyên tố!");
                return;
            }

            n = p * q;
            phi = (p - 1) * (q - 1);

            eKey = 17;
            d = ModInverse(eKey, phi);

            txtP.Text = p.ToString();
            txtQ.Text = q.ToString();
            txtE.Text = eKey.ToString();
            txtN.Text = n.ToString();
            txtD.Text = d.ToString();

            MessageBox.Show("Tạo khóa thành công!");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All Files|*.*";

            if (o.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = o.FileName;
                txtInput.Text = Path.GetFileName(o.FileName);
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtP.Text) || string.IsNullOrWhiteSpace(txtD.Text))
            {
                MessageBox.Show("Thiếu khóa!");
                return;
            }

            if (cbHash.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn thuật toán băm!");
                return;
            }

            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("Chưa chọn file!");
                return;
            }

            byte[] fileBytes = File.ReadAllBytes(currentFilePath);

            string hash = HashFile(fileBytes, cbHash.Text);

            BigInteger m = new BigInteger(Encoding.UTF8.GetBytes(hash));
            BigInteger sign = BigInteger.ModPow(m, d, n);

            txtSign.Text = sign.ToString();

            MessageBox.Show("Ký file thành công!");
        }

        private void btnSaveSign_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Signature File|*.sig";

            if (s.ShowDialog() == DialogResult.OK)
            {
                string data = cbHash.Text + Environment.NewLine + txtSign.Text;
                File.WriteAllText(s.FileName, data);
                MessageBox.Show("Đã lưu chữ ký!");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            txtCheckContent.Text = txtInput.Text;
            txtCheckSign.Text = txtSign.Text;
        }

        private void btnOpenVerifyFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All Files|*.*";

            if (o.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = o.FileName;
                txtCheckContent.Text = Path.GetFileName(o.FileName);
            }
        }

        private void btnOpenSign_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            if (o.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(o.FileName);

                loadedHashType = lines[0];
                txtCheckSign.Text = lines[1];
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] fileBytes = File.ReadAllBytes(currentFilePath);

                string hash = HashFile(fileBytes, loadedHashType);

                BigInteger sign = BigInteger.Parse(txtCheckSign.Text);

                BigInteger m = BigInteger.ModPow(sign, eKey, n);

                string result = Encoding.UTF8.GetString(m.ToByteArray());

                if (result == hash)
                    MessageBox.Show("Chữ ký hợp lệ!");
                else
                    MessageBox.Show("File hoặc chữ ký đã bị thay đổi!");
            }
            catch
            {
                MessageBox.Show("Lỗi kiểm tra chữ ký!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtCheckSign.Text += "1";
        }
    }
}
