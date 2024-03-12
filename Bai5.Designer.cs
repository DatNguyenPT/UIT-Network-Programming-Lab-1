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
            labelX = 264;
            labelY = 0;
            
            SuspendLayout();
            // 
            // filmList
            // 
            List<String> films = new List<string>
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
            List<String> sectionOrder = new List<string> { "1", "2", "3" };
            section.DataSource = sectionOrder;
            section.DropDownStyle = ComboBoxStyle.DropDownList;
            section.FormattingEnabled = true;
            section.Location = new Point(613, 67);
            section.Name = "section";
            section.Size = new Size(151, 28);
            section.TabIndex = 1;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        int labelX;
        int labelY;
        private CheckBox[,] seatStatus;
        private void createSeats()
        {
            seatStatus = new CheckBox[seatRows, seatCols];
            int seatWidth = 40;
            int seatHeight = 40;
            int gap = 10; 
            int startX = (this.ClientSize.Width - (seatCols * (seatWidth + gap) - gap)) / 2;
            int startY = 240; 
            string[] alphabet = { "A", "B", "C"};
            for (int i = 0; i < seatRows; i++)
            {
                int y = startY + (seatHeight + gap) * i;
                Label label = new Label();
                label.Text = alphabet[i];
                label.AutoSize = true;
                label.Location = new Point(startX - 30, y + seatHeight / 2 - label.Height / 2);
                this.Controls.Add(label);
                for (int j = 0; j < seatCols; j++)
                {
                    int x = startX + (seatWidth + gap) * j;

                    CheckBox seat = new CheckBox();
                    seat.Size = new System.Drawing.Size(seatWidth, seatHeight);
                    seat.Location = new Point(x, y);
                    seat.Enabled = true;
                    seat.Checked = false;
                    this.Controls.Add(seat);
                    seatStatus[i, j] = seat;
                }
            }
        }
    }
}