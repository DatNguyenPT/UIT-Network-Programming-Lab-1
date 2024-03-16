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
    public partial class Bai9 : Form
    {
        List<string> foods;
        public Bai9()
        {
            InitializeComponent();
            foods = new List<string>()
            {
                "Hủ tiếu",
                "Bún bò",
                "Cơm tấm",
                "Bún riêu"
            };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < foods.Count; i++)
            {
                sb.Append(foods[i] + "\n");
            }
            foodBoard.Text = sb.ToString(); 
            Load += Bai9_Load;            
        }

        private void Bai9_Load(object sender, EventArgs e) { }

        private void addFood(object  sender, EventArgs e) { 
            if (!input.Text.ToString().Equals(""))
            {
                foods.Add(input.Text.ToString());
                foodBoard.Text += input.Text.ToString() + "\n";
            }
            else
            {
                MessageBox.Show("Chưa nhập món ăn");
            }
        }

        private void findFood(object sender, EventArgs e)
        {
            if (!foodBoard.Text.Equals(""))
            {
                result.Text = "Hôm nay ăn: \n";
                Random random = new Random();
                int randomIndex = random.Next(0, foods.Count);
                string foodResult = foods[randomIndex];
                result.Text += foodResult;
            }
            else
            {
                MessageBox.Show("Bảng thức ăn rỗng");
            }
        }

        private void deleteFoods(object sender, EventArgs e)
        {
            foodBoard.Text = "";
            input.Text = "";
            foods.Clear();
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
