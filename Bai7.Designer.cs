namespace WinFormsApp1
{
    partial class Bai7
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
            welcomeWord = new Label();
            input = new TextBox();
            result = new Label();
            check = new Button();
            SuspendLayout();
            // 
            // welcomeWord
            // 
            welcomeWord.Location = new Point(281, 55);
            welcomeWord.Name = "welcomeWord";
            welcomeWord.Size = new Size(229, 25);
            welcomeWord.TabIndex = 0;
            welcomeWord.Text = "Nhập ngày/tháng sinh của bạn";
            // 
            // input
            // 
            input.Location = new Point(296, 118);
            input.Name = "input";
            input.Size = new Size(179, 27);
            input.TabIndex = 1;
            // 
            // result
            // 
            result.Location = new Point(143, 228);
            result.Name = "result";
            result.Size = new Size(484, 202);
            result.TabIndex = 2;
            result.Text = "";
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // check
            // 
            check.Location = new Point(307, 185);
            check.Name = "check";
            check.Size = new Size(145, 40);
            check.TabIndex = 3;
            check.Text = "Kiểm tra";
            check.UseVisualStyleBackColor = true;
            check.Click += Check_Click;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(check);
            Controls.Add(result);
            Controls.Add(input);
            Controls.Add(welcomeWord);
            Name = "Bai7";
            Text = "Bai7";
            Load += Bai7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeWord;
        private TextBox input;
        private Label result;
        private Button check;
    }
}