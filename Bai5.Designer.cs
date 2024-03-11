namespace WinFormsApp1
{
    partial class Bai5
    {
        private int row = 3;
        private int col = 5;

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            filmList = new ComboBox();
            theatreNumber = new ComboBox();
            payment = new Button();
            reset = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // filmList
            // 
            filmList.FormattingEnabled = true;
            filmList.Items.AddRange(new object[] { "Đào, phở và Piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            filmList.Location = new Point(184, 93);
            filmList.Name = "filmList";
            filmList.Size = new Size(350, 28);
            filmList.TabIndex = 0;
            filmList.Text = "Chọn Phim";
            createSeats();
            // 
            // theatreNumber
            // 
            theatreNumber.FormattingEnabled = true;
            theatreNumber.Items.AddRange(new object[] { "1", "2", "3" });
            theatreNumber.Location = new Point(609, 93);
            theatreNumber.Name = "theatreNumber";
            theatreNumber.Size = new Size(151, 28);
            theatreNumber.TabIndex = 1;
            theatreNumber.Text = "Chọn phòng chiếu";
            // 
            // payment button
            // 
            payment.Location = new Point(609, 160);
            payment.Name = "button1";
            payment.Size = new Size(151, 41);
            payment.TabIndex = 2;
            payment.Text = "Thanh toán";
            payment.UseVisualStyleBackColor = true;
            // 
            // reset button
            // 
            reset.Location = new Point(609, 218);
            reset.Name = "button2";
            reset.Size = new Size(151, 44);
            reset.TabIndex = 3;
            reset.Text = "Reset ghế ngồi";
            reset.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            exit.Location = new Point(609, 279);
            exit.Name = "button3";
            exit.Size = new Size(151, 40);
            exit.TabIndex = 4;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(payment);
            Controls.Add(theatreNumber);
            Controls.Add(filmList);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            ResumeLayout(false);
        }

        private ComboBox filmList;
        private bool[,] seatStatus;
        private ComboBox theatreNumber;
        private Button payment;
        private Button reset;
        private Button exit;
        private List<List<CheckBox>> seats = new List<List<CheckBox>>();
        public Dictionary<Tuple<string, string>, bool[,]> seatDatabase = new Dictionary<Tuple<string, string>, bool[,]>();
        private void createSeats()
        {
            string selectedFilm = filmList.SelectedItem.ToString();
            string selectedTheatre = theatreNumber.SelectedItem.ToString();
            seatStatus = new bool[row, col];
            int seatWidth = 40;
            int seatHeight = 40;
            int gapX = 50;
            for (int i = 0; i < row; i++)
            {
                List<CheckBox> row = new List<CheckBox>();

                for (int j = 0; j < col; j++)
                {
                    CheckBox seat = new CheckBox();
                    seat.Enabled = true;
                    row.Add(seat);
                    int x = 100 + j * (seatWidth + gapX);
                    int y = 200 + i * seatHeight;
                    seat.Location = new Point(x, y);
                    seat.Size = new Size(seatWidth, seatHeight);
                    this.Controls.Add(seat);
                    seatStatus[i, j] = seat.Checked;
                }
                seats.Add(row);
                seatDatabase.Add(Tuple.Create(selectedFilm, selectedTheatre), seatStatus);
            }
        }



    }
}
