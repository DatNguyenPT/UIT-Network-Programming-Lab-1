namespace WinFormsApp1
{
    partial class Bai1
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
            num1 = new Label();
            num2 = new Label();
            input1 = new TextBox();
            input2 = new TextBox();
            result = new Label();
            calculate = new Button();
            exit = new Button();
            resultBox = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(121, 87);
            num1.Name = "num1";
            num1.Size = new Size(64, 20);
            num1.TabIndex = 0;
            num1.Text = "Số thứ 1";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(121, 166);
            num2.Name = "num2";
            num2.Size = new Size(64, 20);
            num2.TabIndex = 1;
            num2.Text = "Số thứ 2";
            // 
            // input1
            // 
            input1.Location = new Point(326, 80);
            input1.Name = "input1";
            input1.Size = new Size(125, 27);
            input1.TabIndex = 2;
            // 
            // input2
            // 
            input2.Location = new Point(326, 166);
            input2.Name = "input2";
            input2.Size = new Size(125, 27);
            input2.TabIndex = 3;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(121, 246);
            result.Name = "result";
            result.Size = new Size(60, 20);
            result.TabIndex = 5;
            result.Text = "Kết quả";
            // 
            // calculate
            // 
            calculate.Location = new Point(334, 340);
            calculate.Name = "calculate";
            calculate.Size = new Size(94, 29);
            calculate.TabIndex = 6;
            calculate.Text = "Tính";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += twoSum;
            // 
            // exit
            // 
            exit.Location = new Point(472, 340);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 7;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exitForm;
            // 
            // resultBox
            // 
            resultBox.AutoSize = true;
            resultBox.Location = new Point(334, 246);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(50, 20);
            resultBox.TabIndex = 8;
            resultBox.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultBox);
            Controls.Add(exit);
            Controls.Add(calculate);
            Controls.Add(result);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1;
        private Label num2;
        private TextBox input1;
        private TextBox input2;
        private Label result;
        private Button calculate;
        private Button exit;
        private Label resultBox;
    }
}