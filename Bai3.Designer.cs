namespace WinFormsApp1
{
    partial class Bai3
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
            welcome = new Label();
            input = new TextBox();
            result = new Label();
            resultbox = new Label();
            read = new Button();
            delete = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Location = new Point(25, 75);
            welcome.Name = "welcome";
            welcome.Size = new Size(215, 20);
            welcome.TabIndex = 0;
            welcome.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // input
            // 
            input.Location = new Point(261, 68);
            input.Name = "input";
            input.Size = new Size(264, 27);
            input.TabIndex = 1;
            // 
            // result
            // 
            result.Location = new Point(25, 220);
            result.Name = "result";
            result.Size = new Size(120, 54);
            result.TabIndex = 2;
            result.Text = "Kết quả";
            // 
            // resultbox
            // 
            resultbox.BorderStyle = BorderStyle.FixedSingle;
            resultbox.Location = new Point(25, 274);
            resultbox.Name = "resultbox";
            resultbox.Size = new Size(228, 45);
            resultbox.TabIndex = 3;
            // 
            // read
            // 
            read.AutoSize = true;
            read.Location = new Point(609, 75);
            read.Name = "read";
            read.Size = new Size(94, 30);
            read.TabIndex = 4;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += numRead;
            // 
            // delete
            // 
            delete.Location = new Point(609, 162);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 5;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += numDel;
            // 
            // exit
            // 
            exit.Location = new Point(609, 245);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 6;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exitForm;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultbox);
            Controls.Add(result);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(read);
            Controls.Add(input);
            Controls.Add(welcome);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome;
        private TextBox input;
        private Label result;
        private Label resultbox;
        private Button read;
        private Button delete;
        private Button exit;
    }
}