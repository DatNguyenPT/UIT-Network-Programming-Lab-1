namespace WinFormsApp1
{
    partial class Bai2
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
            num3 = new Label();
            inputNum1 = new TextBox();
            inputNum2 = new TextBox();
            inputNum3 = new TextBox();
            btn_find = new Button();
            btn_delete = new Button();
            btn_exit = new Button();
            maxNum = new Label();
            maxResult = new Label();
            minNum = new Label();
            minResult = new Label();
            SuspendLayout();
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Location = new Point(12, 64);
            num1.Name = "num1";
            num1.Size = new Size(64, 20);
            num1.TabIndex = 0;
            num1.Text = "Số thứ 1";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Location = new Point(253, 68);
            num2.Name = "num2";
            num2.Size = new Size(64, 20);
            num2.TabIndex = 1;
            num2.Text = "Số thứ 2";
            // 
            // num3
            // 
            num3.AutoSize = true;
            num3.Location = new Point(512, 71);
            num3.Name = "num3";
            num3.Size = new Size(64, 20);
            num3.TabIndex = 2;
            num3.Text = "Số thứ 3";
            // 
            // inputNum1
            // 
            inputNum1.Location = new Point(82, 61);
            inputNum1.Name = "inputNum1";
            inputNum1.Size = new Size(125, 27);
            inputNum1.TabIndex = 3;
            // 
            // inputNum2
            // 
            inputNum2.Location = new Point(337, 64);
            inputNum2.Name = "inputNum2";
            inputNum2.Size = new Size(125, 27);
            inputNum2.TabIndex = 4;
            // 
            // inputNum3
            // 
            inputNum3.Location = new Point(608, 66);
            inputNum3.Name = "inputNum3";
            inputNum3.Size = new Size(125, 27);
            inputNum3.TabIndex = 5;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(74, 203);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(133, 39);
            btn_find.TabIndex = 6;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += findValue;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(329, 203);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(133, 37);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += clear;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(600, 203);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(133, 37);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += exitForm;
            // 
            // maxNum
            // 
            maxNum.AutoSize = true;
            maxNum.Location = new Point(74, 353);
            maxNum.Name = "maxNum";
            maxNum.Size = new Size(84, 20);
            maxNum.TabIndex = 9;
            maxNum.Text = "Số lớn nhất";
            // 
            // maxResult
            // 
            maxResult.BorderStyle = BorderStyle.FixedSingle;
            maxResult.Location = new Point(209, 354);
            maxResult.Name = "maxResult";
            maxResult.Size = new Size(169, 26);
            maxResult.TabIndex = 10;
            // 
            // minNum
            // 
            minNum.AutoSize = true;
            minNum.Location = new Point(446, 358);
            minNum.Name = "minNum";
            minNum.Size = new Size(88, 20);
            minNum.TabIndex = 11;
            minNum.Text = "Số nhỏ nhất";
            // 
            // minResult
            // 
            minResult.BorderStyle = BorderStyle.FixedSingle;
            minResult.Location = new Point(590, 353);
            minResult.Name = "minResult";
            minResult.Size = new Size(169, 25);
            minResult.TabIndex = 12;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(minResult);
            Controls.Add(minNum);
            Controls.Add(maxResult);
            Controls.Add(maxNum);
            Controls.Add(btn_exit);
            Controls.Add(btn_delete);
            Controls.Add(btn_find);
            Controls.Add(inputNum3);
            Controls.Add(inputNum2);
            Controls.Add(inputNum1);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1;
        private Label num2;
        private Label num3;
        private TextBox inputNum1;
        private TextBox inputNum2;
        private TextBox inputNum3;
        private Button btn_find;
        private Button btn_delete;
        private Button btn_exit;
        private Label maxNum;
        private Label maxResult;
        private Label minNum;
        private Label minResult;
    }
}