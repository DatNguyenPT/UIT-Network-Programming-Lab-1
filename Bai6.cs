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

namespace WinFormsApp1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            Load += Bai6_Load;
        }

        private void Bai6_Load(object sender, EventArgs e) { }

        private void multiplicationTable()
        {
            int firstNum = Int32.Parse(num1Input.Text);
            int secondNum = Int32.Parse(num2Input.Text);
            StringBuilder sb = new StringBuilder();
            int temp = secondNum - firstNum;
            for (int i = 0; i <= 10; i++)
            {
                int mul = temp * i;
                sb.Append($"{temp} x {i} = {mul} \n");
            }
            result.Text = sb.ToString();
        }

        private void cal()
        {
            int firstNum = Int32.Parse(num1Input.Text);
            int secondNum = Int32.Parse(num2Input.Text);
            StringBuilder sb = new StringBuilder();
            int temp = firstNum - secondNum;
            if (temp < 0)
            {
                MessageBox.Show("Giá trị A - B < 0 nên không thể tính giai thừa");
            }
            else
            {
                int mul = 1;
                for (int i = 1; i <= temp; i++)
                {
                    mul *= i;
                }
                sb.Append($"(A - B)! = {mul}\n");
            }
            double sum = 0;
            for (int i = 1; i <= secondNum; i++)
            {
                sum += Math.Pow(firstNum, secondNum);
            }
            sum = (int)sum;
            sb.Append($"Tổng S = {sum}\n");
            result.Text = sb.ToString();
        }
        private void cal_click(object sender, EventArgs e)
        {
            switch (option.SelectedItem.ToString())
            {
                case "Bảng cửu chương":
                    multiplicationTable();
                    break;
                case "Tính toán giá trị":
                    cal();
                    break;
            }
        }

        private void deleteNum(object sender, EventArgs e)
        {
            num1Input.Text = "";
            num2Input.Text = "";
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
