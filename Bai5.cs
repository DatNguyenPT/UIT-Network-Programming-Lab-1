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
        public Dictionary<string, double> seatPrices;
        public Dictionary<string, double> filmPrices;
        public CheckBox[,] seatStatusList;
        public Dictionary<Tuple<string, string>, CheckBox[,]> filmWithSeatState;
        public Bai5()
        {
            seatPrices = new Dictionary<string, double>();
            filmPrices = new Dictionary<string, double>();
            seatStatusList = new CheckBox[seatRows, seatCols];
            filmWithSeatState = new Dictionary<Tuple<string, string>, CheckBox[,]>();
            InitializeComponent();
            Load += Bai5_Load;
            createSeats();
            seatStatusList = seatStatus;
        }

        private void Bai5_Load(object sender, EventArgs e) {
            // Set seat prices
            seatPrices.Clear();
            seatPrices.Add("A1", 0.25);
            seatPrices.Add("A5", 0.25);
            seatPrices.Add("C1", 0.25);
            seatPrices.Add("C5", 0.25);
            seatPrices.Add("A2", 1);
            seatPrices.Add("A3", 1);
            seatPrices.Add("A4", 1);
            seatPrices.Add("C2", 1);
            seatPrices.Add("C3", 1);
            seatPrices.Add("C4", 1);
            seatPrices.Add("B1", 2);
            seatPrices.Add("B2", 2);
            seatPrices.Add("B3", 2);
            seatPrices.Add("B4", 2);
            seatPrices.Add("B5", 2);

            // Set film prices
            filmPrices.Clear();
            filmPrices.Add("Đào, phở và Piano", 45000);
            filmPrices.Add("Mai", 100000);
            filmPrices.Add("Gặp lại chị bầu", 70000);
            filmPrices.Add("Tarot", 90000);

            // Set film default seat state
            filmWithSeatState.Clear();
            for (int i = 1; i <= 3; i++)
            {
                filmWithSeatState.Add(Tuple.Create("Đào, phở và Piano", i.ToString()), seatStatusList);
            }
            for (int i = 2; i <= 3; i++)
            {
                filmWithSeatState.Add(Tuple.Create("Mai", i.ToString()), seatStatusList);
            }
            filmWithSeatState.Add(Tuple.Create("Gặp lại chị bầu", "1"), seatStatusList);
            filmWithSeatState.Add(Tuple.Create("Tarot", "3"), seatStatusList);
        }

        private void saveSeatState()
        {
            CheckBox[,] currentSeatState = new CheckBox[seatRows, seatCols];
            for (int i = 0; i < seatRows; i++)
            {
                for (int j = 0; j < seatCols; j++)
                {
                    currentSeatState[i, j] = 
                }
            }
        }

        private void updateSeatState()
        {
            Tuple<string, string> temp = Tuple.Create(filmList.SelectedText, section.SelectedText);
            CheckBox[,] newStatus = filmWithSeatState[temp];
            // Not Finished
        }

    }
}
