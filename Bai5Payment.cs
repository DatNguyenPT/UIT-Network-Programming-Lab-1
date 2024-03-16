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
    public partial class Bai5Payment : Form
    {
        public Bai5Payment()
        {
            InitializeComponent();
            Load += Bai5Payment_Load;
        }

        private void Bai5Payment_Load(object sender, EventArgs e) { }
        private void DisplayTicketInfo(List<Tuple<int, int>> list, Dictionary<string, double> filmPrices, Dictionary<string, double> seatPrices, string filmName)
        {
            string result = $"Họ tên: {nameInput.Text}\n" +
                $"Đã mua {list.Count} vé\n";
            List<string> seatPosition = new List<string>();
            foreach (var seat in list)
            {
                string type = "";
                switch (seat.Item1)
                {
                    case 0:
                        type = "A";
                        break;
                    case 1:
                        type = "B";
                        break;
                    case 2:
                        type = "C";
                        break;
                }
                seatPosition.Add(type + (seat.Item2 + 1)); // Start with index 0
            }
            result += $"Các vé lần lượt là: {string.Join(", ", seatPosition)}\n";

            double total = 0;
            foreach (var seat in seatPosition)
            {
                total += filmPrices[filmName] * seatPrices[seat];
            }
            result += $"Tổng tiền: {total}";
            ticketInfo.Text = result;
        }

        // Event handler for Finish button click
        public event EventHandler PaymentFormClosed;
        public int count = 0;
        private void FinishButton_Click(object sender, EventArgs e)
        {
            ++count;
            Bai5 bai5 = (Bai5)this.Owner; // Access to current Bai5 instance
            if (bai5 != null)
            {
                List<Tuple<int, int>> selectedSeats = bai5.buyTickets();
                Dictionary<string, double> filmPrices = bai5.filmPrices;
                Dictionary<string, double> seatPrices = bai5.seatPrices;
                string filmName = this.filmName;
                DisplayTicketInfo(selectedSeats, filmPrices, seatPrices, filmName);
                bai5.disableCheckedSeats();
                bai5.updateSeatState();
                finish.Text = "Kết thúc";
                if (count == 2)
                {
                    this.Close();
                }

            }
        }

        private void Bai5Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            PaymentFormClosed?.Invoke(this, EventArgs.Empty);
        }

        public string filmName { get; set; }
    }
}
