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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            Load += new EventHandler(Bai2_Load);
        }

        private void findValue(object sender, EventArgs e)
        {
            float s1, s2, s3;
            if (float.TryParse(inputNum1.Text, out s1) && float.TryParse(inputNum2.Text, out s2) && float.TryParse(inputNum3.Text, out s3))
            {
                float max = Math.Max((Math.Max(s1, s2)), (Math.Max(s2, s3)));
                float min = Math.Min((Math.Min(s1, s2)), (Math.Min(s2, s3)));
                maxResult.Text = string.Format("{0:F1}", max);
                minResult.Text = string.Format("{0:F1}", min);
            }
        }

        private void clear(object sender, EventArgs e)
        {
            inputNum1.Text = String.Empty;
            inputNum2.Text = String.Empty;
            inputNum3.Text = String.Empty;
        }

        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
