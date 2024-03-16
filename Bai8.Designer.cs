namespace WinFormsApp1
{
    partial class Bai8
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
            request = new Label();
            input = new TextBox();
            check = new Button();
            delete = new Button();
            exit = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // request
            // 
            request.Location = new Point(225, 42);
            request.Name = "request";
            request.Size = new Size(363, 25);
            request.TabIndex = 0;
            request.Text = "Yêu cầu nhập đúng format (Tên, điểm 1, điểm 2,...)";
            // 
            // input
            // 
            input.Location = new Point(225, 89);
            input.Name = "input";
            input.Size = new Size(324, 27);
            input.TabIndex = 1;
            // 
            // check
            // 
            check.Location = new Point(76, 133);
            check.Name = "check";
            check.Size = new Size(94, 29);
            check.TabIndex = 2;
            check.Text = "Kiểm tra";
            check.UseVisualStyleBackColor = true;
            check.Click += check_click;
            // 
            // delete
            // 
            delete.Location = new Point(337, 133);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 3;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_click;
            // 
            // exit
            // 
            exit.Location = new Point(577, 133);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 4;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_form;
            // 
            // result
            // 
            result.Location = new Point(12, 165);
            result.Name = "result";
            result.Size = new Size(776, 276);
            result.TabIndex = 5;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(check);
            Controls.Add(input);
            Controls.Add(request);
            Name = "Bai8";
            Text = "Bai8";
            Load += Bai8_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label request;
        private TextBox input;
        private Button check;
        private Button delete;
        private Button exit;
        private Label result;
    }
}