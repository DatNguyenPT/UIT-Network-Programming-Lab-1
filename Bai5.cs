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
    public partial class Bai5 : Form
    {
        Dictionary<string, long> filmPrice;
        Dictionary<Tuple<string, int>, bool[,]> theatre;
        public Bai5()
        {
            InitializeComponent();
            Load += Bai5_Load;
            filmPrice = new Dictionary<string, long>();
            theatre = new Dictionary<Tuple<string, int>, bool[,]>();
        }
        private void Bai5_Load(object sender, EventArgs e) {
            filmInfo();
        }
        private void filmInfo()
        {
            filmPrice.Add("Đào, phở và Piano", 45000);
            filmPrice.Add("Mai", 100000);
            filmPrice.Add("Gặp lại chị bầu", 70000);
            filmPrice.Add("Tarot", 90000);

            for (int i = 1; i <= 3; i++)
            {
                bool[,] seatState1;
                if (seatDatabase.TryGetValue(Tuple.Create("Đào, phở và Piano", i.ToString()), out seatState1))
                {
                    theatre.Add(Tuple.Create("Đào, phở và Piano", i), seatState1);
                }
            }

            for (int i = 2; i <= 3; i++)
            {
                bool[,] seatState2;
                if (seatDatabase.TryGetValue(Tuple.Create("Mai", i.ToString()), out seatState2))
                {
                    theatre.Add(Tuple.Create("Mai", i), seatState2);
                }
            }

            bool[,] seatState3;
            if (seatDatabase.TryGetValue(Tuple.Create("Gặp lại chị bầu", "1"), out seatState3))
            {
                theatre.Add(Tuple.Create("Gặp lại chị bầu", 1), seatState3);
            }

            bool[,] seatState4;
            if (seatDatabase.TryGetValue(Tuple.Create("Tarot", "3"), out seatState4))
            {
                theatre.Add(Tuple.Create("Tarot", 3), seatState4);
            }
        }

    }
}
