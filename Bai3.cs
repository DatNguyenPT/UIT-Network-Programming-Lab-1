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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            Load += new EventHandler(Bai3_Load);
        }

        private void Bai3_Load(object sender, EventArgs e) { }

        private void numRead(object sender, EventArgs e) {
            if (input.Text.Length == 1)
            {
                char character = input.Text[0];
                if (character < 48 || character > 57)
                {
                    MessageBox.Show("Giá trị không hợp lệ");
                    resultbox.Text = string.Empty;

                }
                else
                {
                    int temp;
                    int.TryParse(input.Text, out temp);
                    if (temp >= 0 && temp <= 9)
                    {
                        switch (temp)
                        {
                            case 0:
                                resultbox.Text = "Không";
                                break;
                            case 1:
                                resultbox.Text = "Một";
                                break;
                            case 2:
                                resultbox.Text = "Hai";
                                break;
                            case 3:
                                resultbox.Text = "Ba";
                                break;
                            case 4:
                                resultbox.Text = "Bốn";
                                break;
                            case 5:
                                resultbox.Text = "Năm";
                                break;
                            case 6:
                                resultbox.Text = "Sáu";
                                break;
                            case 7:
                                resultbox.Text = "Bảy";
                                break;
                            case 8:
                                resultbox.Text = "Tám";
                                break;
                            case 9:
                                resultbox.Text = "Chín";
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ");
            }

        }
            
        private void numDel(object sender, EventArgs e)
        {
            input.Text = string.Empty;
        }

        private void exitForm(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
