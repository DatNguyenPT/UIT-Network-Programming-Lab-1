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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            Load += new EventHandler(Bai1_Load);
        }

        private void twoSum(object sender, EventArgs e)
        {
            string n1 = input1.Text;
            string n2 = input2.Text;
            int s1;
            int s2;
            if (int.TryParse(n1, out s1))
            {
                if (int.TryParse(n2 , out s2))
                {
                    resultBox.Text = (s1 + s2).ToString();
                }
                else
                {
                    MessageBox.Show("Số thứ 2 không phải số nguyên");
                }
            }
            else
            {
                MessageBox.Show("Số thứ 1 không phải số nguyên");
            }
        }

        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
