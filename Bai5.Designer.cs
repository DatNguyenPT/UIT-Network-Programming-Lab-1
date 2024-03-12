namespace WinFormsApp1
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai5));
            filmList = new ComboBox();
            section = new ComboBox();
            pay = new Button();
            reset = new Button();
            exit = new Button();
            renew = new Button();
            SuspendLayout();
            // 
            // filmList
            // 
            List<string> films = new List<string>()
            {
                "Đào, phở và Piano",
                "Mai",
                "Gặp lại chị bầu",
                "Tarot"
            };
            filmList.DataSource = films;
            filmList.DropDownStyle = ComboBoxStyle.DropDownList;
            filmList.FormattingEnabled = true;
            filmList.Location = new Point(264, 67);
            filmList.Name = "filmList";
            filmList.Size = new Size(246, 28);
            filmList.TabIndex = 0;
            // 
            // section
            // 
            List<String> sectionOrder = new List<string>() { "1", "2", "3" };
            section.DataSource = sectionOrder;
            section.DropDownStyle = ComboBoxStyle.DropDownList;
            section.FormattingEnabled = true;
            section.Location = new Point(613, 67);
            section.Name = "section";
            section.Size = new Size(151, 28);
            section.TabIndex = 1;
            // 
            // pay
            // 
            pay.Location = new Point(613, 139);
            pay.Name = "pay";
            pay.Size = new Size(151, 41);
            pay.TabIndex = 2;
            pay.Text = "Thanh Toán";
            pay.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            reset.Location = new Point(613, 205);
            reset.Name = "reset";
            reset.Size = new Size(151, 42);
            reset.TabIndex = 3;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.Location = new Point(613, 277);
            exit.Name = "exit";
            exit.Size = new Size(151, 40);
            exit.TabIndex = 4;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            // 
            // renew
            // 
            renew.Location = new Point(613, 348);
            renew.Name = "renew";
            renew.Size = new Size(151, 40);
            renew.TabIndex = 5;
            renew.Text = "Làm Mới";
            renew.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(renew);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(pay);
            Controls.Add(section);
            Controls.Add(filmList);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox filmList;
        private ComboBox section;
        private int seatRows = 3;
        private int seatCols = 5;
        int seatWidth = 40;
        int seatHeight = 40;
        int labelX;
        int labelY;
        public CheckBox[,] seatStatus;
        int gap = 10;
        int startX;
        int startY;
        private void createSeats(CheckBox[,] seatArray)
        {
            if (seatArray.GetLength(0) != seatRows || seatArray.GetLength(1) != seatCols)
            {
                seatRows = seatArray.GetLength(0);
                seatCols = seatArray.GetLength(1);
                seatStatus = seatArray;
            }

            int startXTemp = (this.ClientSize.Width - (seatCols * (seatWidth + gap) - gap)) / 2;
            int startYTemp = 240;
            startX = startXTemp;
            startY = startYTemp;
            string[] alphabet = { "A", "B", "C" };
            for (int i = 0; i < seatRows; i++)
            {
                int y = startYTemp + (seatHeight + gap) * i;
                Label label = new Label();
                label.Text = alphabet[i];
                label.AutoSize = true;
                label.Location = new Point(startX - 30, y + seatHeight / 2 - label.Height / 2);
                this.Controls.Add(label);
                for (int j = 0; j < seatCols; j++)
                {
                    int x = startXTemp + (seatWidth + gap) * j;
                    CheckBox seat = seatArray[i, j];
                    seat.Size = new Size(seatWidth, seatHeight);
                    seat.Location = new Point(x, y);
                    seat.Enabled = true;
                    seat.Checked = false;
                    this.Controls.Add(seat);
                }
            }
        }
        private bool[,] saveSeatState()
        {
            bool[,] currentSeatState = new bool[seatRows, seatCols];
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox currentSeat = (CheckBox)control;
                    if (currentSeat.Parent == this)
                    {
                        int i = (currentSeat.Top - startY) / (seatHeight + gap);
                        int j = (currentSeat.Left - startX) / (seatWidth + gap);
                        currentSeatState[i, j] = currentSeat.Checked;
                    }
                }
            }
            return currentSeatState;
        }

        private Button pay;
        private Button reset;
        private Button exit;
        private Button renew;
    }
}