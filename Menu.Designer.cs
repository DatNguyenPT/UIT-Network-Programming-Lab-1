namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_bai1 = new Button();
            btn_bai2 = new Button();
            btn_bai3 = new Button();
            btn_bai4 = new Button();
            btn_bai5 = new Button();
            btn_bai6 = new Button();
            btn_bai7 = new Button();
            btn_bai8 = new Button();
            btn_bai9 = new Button();
            SuspendLayout();
            // 
            // btn_bai1
            // 
            btn_bai1.Location = new Point(102, 50);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(181, 44);
            btn_bai1.TabIndex = 0;
            btn_bai1.Text = "Bài 1";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += bai1_click;
            // 
            // btn_bai2
            // 
            btn_bai2.Location = new Point(344, 50);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(181, 44);
            btn_bai2.TabIndex = 1;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += bai2_click;
            // 
            // btn_bai3
            // 
            btn_bai3.Location = new Point(102, 123);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(181, 44);
            btn_bai3.TabIndex = 2;
            btn_bai3.Text = "Bài 3";
            btn_bai3.UseVisualStyleBackColor = true;
            btn_bai3.Click += bai3_click;
            // 
            // btn_bai4
            // 
            btn_bai4.Location = new Point(344, 123);
            btn_bai4.Name = "btn_bai4";
            btn_bai4.Size = new Size(181, 44);
            btn_bai4.TabIndex = 3;
            btn_bai4.Text = "Bài 4";
            btn_bai4.UseVisualStyleBackColor = true;
            btn_bai4.Click += bai4_click;
            // 
            // btn_bai5
            // 
            btn_bai5.Location = new Point(102, 192);
            btn_bai5.Name = "btn_bai5";
            btn_bai5.Size = new Size(181, 44);
            btn_bai5.TabIndex = 4;
            btn_bai5.Text = "Bài 5";
            btn_bai5.UseVisualStyleBackColor = true;
            btn_bai5.Click += bai5_click;
            // 
            // btn_bai6
            // 
            btn_bai6.Location = new Point(344, 192);
            btn_bai6.Name = "btn_bai6";
            btn_bai6.Size = new Size(181, 44);
            btn_bai6.TabIndex = 5;
            btn_bai6.Text = "Bài 6";
            btn_bai6.UseVisualStyleBackColor = true;
            btn_bai6.Click += bai6_click;
            // 
            // btn_bai7
            // 
            btn_bai7.Location = new Point(102, 265);
            btn_bai7.Name = "btn_bai7";
            btn_bai7.Size = new Size(181, 44);
            btn_bai7.TabIndex = 6;
            btn_bai7.Text = "Bài 7";
            btn_bai7.UseVisualStyleBackColor = true;
            btn_bai7.Click += bai7_click;
            // 
            // btn_bai8
            // 
            btn_bai8.Location = new Point(344, 265);
            btn_bai8.Name = "btn_bai8";
            btn_bai8.Size = new Size(181, 44);
            btn_bai8.TabIndex = 7;
            btn_bai8.Text = "Bài 8";
            btn_bai8.UseVisualStyleBackColor = true;
            btn_bai8.Click += bai8_click;
            // 
            // btn_bai9
            // 
            btn_bai9.Location = new Point(219, 338);
            btn_bai9.Name = "btn_bai9";
            btn_bai9.Size = new Size(181, 44);
            btn_bai9.TabIndex = 8;
            btn_bai9.Text = "Bài 9";
            btn_bai9.UseVisualStyleBackColor = true;
            /*btn_bai9.Click += bai9_click;*/
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bai9);
            Controls.Add(btn_bai8);
            Controls.Add(btn_bai7);
            Controls.Add(btn_bai6);
            Controls.Add(btn_bai5);
            Controls.Add(btn_bai4);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai2);
            Controls.Add(btn_bai1);
            Name = "Menu";
            Text = "Lab1";
            ResumeLayout(false);
        }

        private void Btn_bai1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btn_bai1;
        private Button btn_bai2;
        private Button btn_bai3;
        private Button btn_bai4;
        private Button btn_bai5;
        private Button btn_bai6;
        private Button btn_bai7;
        private Button btn_bai8;
        private Button btn_bai9;

        private void bai1_click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void bai2_click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }
        private void bai3_click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }
        private void bai4_click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();
        }
        private void bai5_click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.Show();
        }
        private void bai6_click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.Show();
        }
        private void bai7_click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.Show();
        }
        private void bai8_click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            bai8.Show();
        }
        /*private void bai9_click(object sender, EventArgs e)
        {
            Bai9 bai7 = new Bai9();
            bai9.Show();
        }*/
    }
}