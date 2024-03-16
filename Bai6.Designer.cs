namespace WinFormsApp1
{
    partial class Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai6));
            num1 = new Label();
            num2 = new Label();
            num1Input = new TextBox();
            num2Input = new TextBox();
            option = new ComboBox();
            result = new Label();
            calculate = new Button();
            delete = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(48, 75);
            num1.Name = "num1";
            num1.Size = new Size(38, 20);
            num1.TabIndex = 0;
            num1.Text = "Số a";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(503, 75);
            num2.Name = "num2";
            num2.Size = new Size(39, 20);
            num2.TabIndex = 1;
            num2.Text = "Số b";
            // 
            // num1Input
            // 
            num1Input.Location = new Point(126, 68);
            num1Input.Name = "num1Input";
            num1Input.Size = new Size(125, 27);
            num1Input.TabIndex = 2;
            // 
            // num2Input
            // 
            num2Input.Location = new Point(598, 72);
            num2Input.Name = "num2Input";
            num2Input.Size = new Size(125, 27);
            num2Input.TabIndex = 3;
            // 
            // option
            // 
            List<string> optionList = new List<string>
            {
                "Bảng cửu chương",
                "Tính toán giá trị"
            };
            option.DataSource = optionList;
            option.FormattingEnabled = true;
            option.Location = new Point(311, 116);
            option.Name = "option";
            option.Size = new Size(151, 28);
            option.TabIndex = 4;
            // 
            // result
            // 
            result.Location = new Point(29, 188);
            result.Name = "result";
            result.Size = new Size(717, 253);
            result.TabIndex = 5;
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            calculate.Location = new Point(126, 156);
            calculate.Name = "calculate";
            calculate.Size = new Size(94, 29);
            calculate.TabIndex = 6;
            calculate.Text = "Tính toán giá trị";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += cal_click;
            // 
            // delete
            // 
            delete.Location = new Point(340, 156);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 7;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += deleteNum;
            // 
            // exit
            // 
            exit.Location = new Point(557, 156);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 8;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_form;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(calculate);
            Controls.Add(result);
            Controls.Add(option);
            Controls.Add(num2Input);
            Controls.Add(num1Input);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1;
        private Label num2;
        private TextBox num1Input;
        private TextBox num2Input;
        private ComboBox option;
        private Label result;
        private Button calculate;
        private Button delete;
        private Button exit;
    }
}