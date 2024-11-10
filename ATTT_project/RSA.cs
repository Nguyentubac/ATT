using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATTT_project
{
    public partial class RSA : Form
    {
        public int e;
        public int n;

        public RSA()
        {
            InitializeComponent();
            txt_d.Enabled = false;
            txt_e.Enabled = false;
            txt_n.Enabled = false;
            txt_p.Enabled = false;
            txt_q.Enabled = false;
            comboBox1.Items.Add("Mã hoá");
            comboBox1.Items.Add("Giải mã");
            comboBox1.Text = "--Chọn--";
        }
        static int[] ConvertToBitArray(int number)
        {
            // Tính số lượng bit cần thiết
            int length = (int)Math.Floor(Math.Log(number, 2)) + 1;
            int[] bits = new int[length];
            for (int i = length - 1; i >= 0; i--)
            {
                bits[i] = number % 2;
                number /= 2;
            }
            Array.Reverse(bits);
            return bits;
        }
        public static int ModwithEXP(int p, int e, int n)
        {
            int ll = ConvertToBitArray(e).Length; // --> 4 bits
            //int ll = 3; // --> 4 bits
            long[] result = new long[ll];
            result[0] = p % n;
            for (int i = 1; i < ll; i++)
            {
                result[i] = (result[i - 1] * result[i - 1]) % n;
            }
            return 0;
        }
        static bool IsPrime(int s)
        {
            if (s == 2) return true;
            if (s < 2) return false;
             // 2 là số nguyên tố
            if (s % 2 == 0) return false; // Các số chẵn lớn hơn 2 không phải là số nguyên tố

            for (int i = 3; i <= Math.Sqrt(s); i += 2)
            {
                if (s % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int UCLN(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x; // 
        }
        static int[] Change(int[] x, string plaintext)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = (int)plaintext[i];
            }
            return x;
        }
        static string Change__(int[] x, string plaintext)
        {
            for (int i = 0; i < x.Length; i++)
            {
                plaintext += (char)x[i];
            }
            return plaintext;
        }

        public static int ModInverse(int a, int n)
        {
            int t1 = 0, t2 = 1, r1 = n, r2 = a;

            while (r2 > 0)
            {
                int q = r1 / r2;
                int r = r1 - q * r2;
                r1 = r2;
                r2 = r;

                int t = t1 - q * t2;
                t1 = t2;
                t2 = t;
            }

            if (r1 == 1) // UCLN(a,n)=1
            {
                return t1 < 0 ? t1 + n : t1;
            }
            else
            {
                throw new InvalidOperationException("Nghịch đảo module không tồn tại.");
            }
        }
        long dequi(int a,int[] bits, int n )
        {   

            int ll =  bits.Length;
            int [] result = new int[ll];
            result[0] = a % n;
            for (int i = 1; i < ll; i++)
            {
                result[i] = (result[i - 1] * result[i - 1]) % n;

            }
            long kq = 1;
            for (int i = 0; i < ll; i++)
            {
                if (bits[i] == 1)
                    kq *= result[i] % n;
            }
            kq = kq % n;
            return kq;
        }
        private void MaHoa()
        {   
            string plantext = txtplaintext.Text;
            int len = plantext.Length;
            int[] plantext_int = new int[len];
            int[] ciphertext_int = new int[len];
            string cipher_text = "";

            if (string.IsNullOrEmpty(txtplaintext.Text))
            {
                MessageBox.Show("Hãy nhập văn bản để mã hoá");
            }
            Change(plantext_int, plantext);
            int p = 0;
            int q = 0;
            if (txt_p.Text.Trim() == string.Empty)
            { 
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(txt_p.Text, out p))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }

            if (txt_q.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(txt_q.Text, out q))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }
            if (txt_e.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(txt_e.Text, out e))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }

            // thêm check số
            //e = int.Parse(txt_e.Text);
            n = 0;
            int fi = 0;
            //int d = 0;

            if (IsPrime(p) && IsPrime(q))
            {
                fi = (p - 1) * (q - 1);
                n = p * q;

                if ((1 < e && e < fi) && (UCLN(e, fi) == 1))
                {
                    //d = ModInverse(e, fi);
                    for(int i = 0; i<len; i++)
                    {
                        ciphertext_int[i] = (int) dequi(plantext_int[i], ConvertToBitArray(e),n);
                        //ciphertext_int[i] = (char) dequi(plantext_int[i], ConvertToBitArray(e),n);
                        cipher_text += ciphertext_int[i] + " ";
                    }

                    MessageBox.Show(string.Format("d : {0}", ModInverse(e,fi).ToString()));
                    txtplaintext.Clear();
                    txtplaintext.Text = cipher_text;
                    txt_p.Clear();
                    txt_q.Clear();
                    txt_e.Clear();
                    txt_n.Text = n.ToString();
                    txt_d.Text = ModInverse(e, fi).ToString();
                }
                else
                {
                    MessageBox.Show("e bạn chọn không thoả mãn đk (1 < e && e < fi) && (UCLN(e, fi) == 1)");
                }
            }
            else
            {
                MessageBox.Show("p và q phải là 2 số nguyên tố");
            }
            
        }

        private void GiaiMa()
        {
            int d =0;
            if (txt_n.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(txt_n.Text, out n))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }

            if (txt_d.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(txt_d.Text, out d))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }

            string cipher_text = txtplaintext.Text;

            if (cipher_text.Length > 0)
            {
                string[] stringArray = cipher_text.Trim().Split(' ');

                int[] intArray = stringArray.Select(int.Parse).ToArray();
                int len = intArray.Length;
                int[] plaintext_int = new int[len];
                string plaintext = "";
                //e = int.Parse(txt_e.Text);
                int[] bits = ConvertToBitArray(d);
                for (int i = 0; i < len; i++)
                {   
                    plaintext_int[i] = (int)dequi(intArray[i],bits,n);  
                }
                plaintext = Change__(plaintext_int, plaintext);
                txtplaintext.Clear();
                txtplaintext.Text = plaintext;
            }
            else
            {
                MessageBox.Show("Hãy nhập chuỗi để giải hoá");
            }
            
        }

        private void RSA_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txt_q.Enabled = true;
                    txt_e.Enabled = true;
                    txt_p.Enabled = true;
                    txt_d.Enabled = false;
                    txt_n.Enabled = false;
                    break;
                case 1:
                    
                    txt_d.Enabled = true;
                    txt_n.Enabled = true;

                    txt_q.Enabled = false;
                    txt_e.Enabled = false;
                    txt_p.Enabled = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    MaHoa();
                    break;
                case 1:
                    GiaiMa();
                    break;

            }
        }
    }
}
