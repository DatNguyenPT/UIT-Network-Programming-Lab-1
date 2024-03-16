using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            Load += new EventHandler(Bai4_Load);
        }

        private void Bai4_Load(object sender, EventArgs e) { }

        private string[] units = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private string[] digits = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

        private string ReadThreeDigits(int num)
        {
            StringBuilder sb = new StringBuilder();

            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int ones = num % 10;

            if (hundreds > 0)
                sb.Append(digits[hundreds] + " trăm ");

            if (tens == 0)
            {
                if (ones > 0)
                    sb.Append(digits[ones]);
            }
            else if (tens == 1)
            {
                sb.Append("mười ");
                if (ones > 0)
                    sb.Append(digits[ones]);
            }
            else
            {
                sb.Append(units[tens]);
                if (ones > 0)
                    sb.Append(" " + digits[ones]);
            }

            return sb.ToString();
        }

        private void read_Click(object sender, EventArgs e)
        {
            string inputNumber = input.Text;
            int length = inputNumber.Length;
            StringBuilder result = new StringBuilder();
            int groupCount = (length + 2) / 3;
            int[] groups = new int[groupCount];
            for (int i = 0; i < groupCount; i++)
            {
                groups[i] = int.Parse(inputNumber.Substring(Math.Max(0, length - (i + 1) * 3), Math.Min(3, length - i * 3)));
            }
            for (int i = groupCount - 1; i >= 0; i--)
            {
                string groupText = ReadThreeDigits(groups[i]);
                if (groupText != "")
                {
                    result.Append(groupText);
                    switch (i)
                    {
                        case 1:
                            result.Append(" nghìn ");
                            break;
                        case 2:
                            result.Append(" triệu ");
                            break;
                        case 3:
                            result.Append(" tỷ ");
                            break;
                    }
                }
            }

            resultbox.Text = result.ToString().Trim();
        }
        private void deleteNum(object sender, EventArgs e)
        {
            input.Text = "";
            resultbox.Text = "";
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
