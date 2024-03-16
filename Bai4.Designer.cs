namespace WinFormsApp1
{
    partial class Bai4
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
            word = new Label();
            input = new TextBox();
            result = new Label();
            resultbox = new Label();
            read = new Button();
            delete = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // word
            // 
            word.AutoSize = true;
            word.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            word.Location = new Point(12, 62);
            word.Name = "word";
            word.Size = new Size(204, 35);
            word.TabIndex = 0;
            word.Text = "Nhập số cần đọc";
            // 
            // input
            // 
            input.Location = new Point(214, 71);
            input.Name = "input";
            input.Size = new Size(288, 27);
            input.TabIndex = 1;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            result.Location = new Point(12, 156);
            result.Name = "result";
            result.Size = new Size(100, 35);
            result.TabIndex = 2;
            result.Text = "Kết quả";
            // 
            // resultbox
            // 
            resultbox.BorderStyle = BorderStyle.FixedSingle;
            resultbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultbox.Location = new Point(214, 154);
            resultbox.Name = "resultbox";
            resultbox.Size = new Size(558, 37);
            resultbox.TabIndex = 3;
            // 
            // read
            // 
            read.Location = new Point(66, 322);
            read.Name = "read";
            read.Size = new Size(128, 57);
            read.TabIndex = 4;
            read.Text = "Đọc";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // delete
            // 
            delete.Location = new Point(342, 322);
            delete.Name = "delete";
            delete.Size = new Size(117, 57);
            delete.TabIndex = 5;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += deleteNum;
            // 
            // exit
            // 
            exit.Location = new Point(619, 322);
            exit.Name = "exit";
            exit.Size = new Size(115, 57);
            exit.TabIndex = 6;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_form;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(read);
            Controls.Add(resultbox);
            Controls.Add(result);
            Controls.Add(input);
            Controls.Add(word);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label word;
        private TextBox input;
        private Label result;
        private Label resultbox;
        private Button read;
        private Button delete;
        private Button exit;
    }
}