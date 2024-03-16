using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
            Load += Bai8_Load;
        }

        private void Bai8_Load(object sender, EventArgs e) { }

        private bool IsDouble(string s)
        {
            return double.TryParse(s, out _);
        }

        private string checkResult()
        {
            string[] inputArray = input.Text.Split(",", StringSplitOptions.RemoveEmptyEntries);
            if (inputArray.Length == 0 || inputArray.Length == 1)
            {
                MessageBox.Show("Input của bạn không theo format hợp lệ");
            }
            else
            {
                string name = inputArray[0];
                foreach (char c in name)
                {
                    if (!char.IsLetter(c))
                    {
                        MessageBox.Show("Input của bạn không theo format hợp lệ");
                        break;
                    }
                }
                List<double> score = new List<double>();
                for (int i = 1; i < inputArray.Length; i++)
                {
                    if (!IsDouble(inputArray[i]))
                    {
                        MessageBox.Show("Input của bạn không theo format hợp lệ");
                        break;
                    }
                    else
                    {
                        score.Add(double.Parse(inputArray[i]));
                    }
                }
                StringBuilder sb = new StringBuilder();
                sb.Append($"Họ và tên: {name}\n");
                for (int i = 0; i < score.Count; i++)
                {
                    if (i < score.Count - 1)
                        sb.Append($"Môn {i+1}: {score[i]} điểm -  ");
                    else
                        sb.Append($"Môn {i + 1}: {score[i]} điểm");
                    if (i == score.Count - 1)
                    {
                        sb.Append("\n");
                    }
                }
                sb.Append($"Trung bình cộng: {score.Average()}\n");
                sb.Append($"Điểm cao nhất: {score.Max()}\n");
                sb.Append($"Điểm thấp nhất: {score.Min()}\n");
                List<double> pass = new List<double>();
                List<double> notPass = new List<double>();
                for (int i = 0; i < score.Count; i++)
                {
                    if (score[i] >= 5)
                        pass.Add(score[i]);
                    else
                        notPass.Add(score[i]);
                }
                sb.Append($"Có {pass.Count} môn đậu và {notPass.Count} môn không đậu\n");
                string rank = "";
                if (score.Average() >= 8)
                {
                    bool rankCheck = true;
                    for (int i = 0; i < score.Count; i++)
                    {
                        if (score[i] < 6.5)
                        {
                            rankCheck = false;
                            break;
                        }
                    }
                    if (rankCheck)
                    {
                        rank = "Giỏi";
                        sb.Append($"Xếp loại: {rank}\n");
                        return sb.ToString();
                    }
                }
                else if (score.Average() >= 6.5)
                {
                    bool rankCheck = true;
                    for (int i = 0; i < score.Count; i++)
                    {
                        if (score[i] < 5)
                        {
                            rankCheck = false;
                            break;
                        }
                    }
                    if (rankCheck)
                    {
                        rank = "Khá";
                        sb.Append($"Xếp loại: {rank}\n");
                        return sb.ToString();
                    }
                }
                else if (score.Average() >= 5)
                {
                    bool rankCheck = true;
                    for (int i = 0; i < score.Count; i++)
                    {
                        if (score[i] < 3.5)
                        {
                            rankCheck = false;
                            break;
                        }
                    }
                    if (rankCheck)
                    {
                        rank = "Trung bình";
                        sb.Append($"Xếp loại: {rank}\n");
                        return sb.ToString();
                    }
                }
                else if (score.Average() >= 3.5)
                {
                    bool rankCheck = true;
                    for (int i = 0; i < score.Count; i++)
                    {
                        if (score[i] < 2)
                        {
                            rankCheck = false;
                            break;
                        }
                    }
                    if (rankCheck)
                    {
                        rank = "Yếu";
                        sb.Append($"Xếp loại: {rank}\n");
                        return sb.ToString();
                    }
                }
                else
                {
                    rank = "Kém";
                    sb.Append($"Xếp loại: {rank}\n");
                    return sb.ToString();
                }
            }
            return "";
        }

        private void check_click(object sender, EventArgs e)
        {
            result.Text = checkResult();
        }

        private void delete_click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
