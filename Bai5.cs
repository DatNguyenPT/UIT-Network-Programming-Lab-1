using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class Bai5 : Form
    {
        public Dictionary<string, double> seatPrices { get; }
        public Dictionary<string, double> filmPrices { get; }
        public System.Windows.Forms.CheckBox[,] seatStatusList;
        public Dictionary<Tuple<string, string>, System.Windows.Forms.CheckBox[,]> filmWithSeatState { get; }
        public Bai5()
        {
            System.Windows.Forms.CheckBox[,] mySeatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            for (int i = 0; i < seatRows; i++)
            {
                for (int j = 0; j < seatCols; j++)
                {
                    mySeatArray[i, j] = new System.Windows.Forms.CheckBox();
                }
            }
            Bai5Payment bai5Payment = new Bai5Payment();
            bai5Payment.PaymentFormClosed += Bai5Payment_FormClosed;
            seatPrices = new Dictionary<string, double>();
            filmPrices = new Dictionary<string, double>();
            seatStatusList = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            filmWithSeatState = new Dictionary<Tuple<string, string>, System.Windows.Forms.CheckBox[,]>();
            InitializeComponent();
            Load += Bai5_Load;
            createSeats(mySeatArray);

        }

        private void Bai5_Load(object sender, EventArgs e)
        {
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
                System.Windows.Forms.CheckBox[,] seatArray1 = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                InitializeSeatArray(seatArray1); // Initialize checkboxes
                filmWithSeatState.Add(Tuple.Create("Đào, phở và Piano", i.ToString()), seatArray1);
            }
            for (int i = 2; i <= 3; i++)
            {
                System.Windows.Forms.CheckBox[,] seatArray2 = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                InitializeSeatArray(seatArray2); // Initialize checkboxes
                filmWithSeatState.Add(Tuple.Create("Mai", i.ToString()), seatArray2);
            }
            System.Windows.Forms.CheckBox[,] seatArray3 = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            InitializeSeatArray(seatArray3); // Initialize checkboxes
            filmWithSeatState.Add(Tuple.Create("Gặp lại chị bầu", "1"), seatArray3);

            System.Windows.Forms.CheckBox[,] seatArray4 = new System.Windows.Forms.CheckBox[seatRows, seatCols];
            InitializeSeatArray(seatArray4); // Initialize checkboxes
            filmWithSeatState.Add(Tuple.Create("Tarot", "3"), seatArray4);
        }

        private void InitializeSeatArray(System.Windows.Forms.CheckBox[,] seatArray)
        {
            for (int i = 0; i < seatRows; i++)
            {
                for (int j = 0; j < seatCols; j++)
                {
                    seatArray[i, j] = new System.Windows.Forms.CheckBox();
                }
            }
        }

        public List<Tuple<int, int>> buyTickets()
        {
            return tickets();
        }
        private void Bai5Payment_FormClosed(object sender, EventArgs e) { }
        // Only called when finish payment
        public void updateSeatState()
        {
            Tuple<string, string> temp = Tuple.Create(filmList.SelectedItem.ToString(), section.SelectedItem.ToString());
            bool[,] newStatus = saveSeatState();
            if (filmWithSeatState.ContainsKey(temp))
            {
                System.Windows.Forms.CheckBox[,] currentStatus = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                currentStatus = filmWithSeatState[temp];
                for (int i = 0; i < seatRows; i++)
                {
                    for (int j = 0; j < seatCols; j++)
                    {
                        currentStatus[i, j].Checked = newStatus[i, j];
                        currentStatus[i, j].Enabled = !newStatus[i, j];
                    }
                }
                filmWithSeatState[temp] = currentStatus;
            }
        }

        public void disableCheckedSeats()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox currentSeat = (System.Windows.Forms.CheckBox)control;
                    if (currentSeat.Checked)
                    {
                        currentSeat.Enabled = false;
                    }
                }
            }
        }

        public void limitTheatre(Object sender, EventArgs e)
        {
            string film = filmList.SelectedItem.ToString();
            List<string> sectionLimit = new List<string>();
            switch (film)
            {
                case "Đào, phở và Piano":
                    sectionLimit.Clear();
                    sectionLimit = new List<string>() { "1", "2", "3" };
                    section.DataSource = sectionLimit;
                    break;
                case "Mai":
                    sectionLimit.Clear();
                    sectionLimit = new List<string>() { "2", "3" };
                    section.DataSource = sectionLimit;
                    break;
                case "Gặp lại chị bầu":
                    sectionLimit.Clear();
                    sectionLimit = new List<string>() { "1" };
                    section.DataSource = sectionLimit;
                    break;
                case "Tarot":
                    sectionLimit.Clear();
                    sectionLimit = new List<string>() { "3" };
                    section.DataSource = sectionLimit;
                    break;
            }
        }



        private void ClearSeatCheckboxes()
        {
            List<Control> controlsToRemove = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                this.Controls.Remove(control);
            }
        }




        private void theatreAccess_Click(object sender, EventArgs e)
        {
            string selectedFilm = filmList.SelectedItem?.ToString();
            string selectedSection = section.SelectedItem?.ToString();

            if (selectedFilm != null && selectedSection != null)
            {
                Tuple<string, string> temp = Tuple.Create(selectedFilm, selectedSection);

                if (filmWithSeatState.ContainsKey(temp))
                {
                    ClearSeatCheckboxes();
                    System.Windows.Forms.CheckBox[,] seatArray = new System.Windows.Forms.CheckBox[seatRows, seatCols];
                    seatArray = filmWithSeatState[temp];
                    createSeats(seatArray);
                }
                else
                {
                    MessageBox.Show("No seat information found for the selected film and section.");
                }
            }
            else
            {
                MessageBox.Show("Please select both film and section.");
            }
        }



        public string getFilmName()
        {
            return filmList.SelectedItem?.ToString();
        }

        public string getSection()
        {
            return section.SelectedItem?.ToString();
        }

        public int getSeatRows()
        {
            return this.seatRows;
        }

        public int getSeatCols()
        {
            return this.seatCols;
        }

        private void exit_form(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_click(object sender, EventArgs e)
        {
            foreach (var key in filmWithSeatState.Keys)
            {
                foreach(var state in filmWithSeatState[key])
                {
                    state.Checked = false;
                    state.Enabled = true;
                }
            }
        }

    }
}
