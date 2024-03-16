namespace WinFormsApp1
{
    partial class Bai9
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
            add = new Button();
            find = new Button();
            delete = new Button();
            exit = new Button();
            result = new Label();
            foodBoard = new Label();
            SuspendLayout();
            // 
            // welcomeWord
            // 
            welcomeWord.Location = new Point(6, 45);
            welcomeWord.Name = "welcomeWord";
            welcomeWord.Size = new Size(148, 40);
            welcomeWord.TabIndex = 0;
            welcomeWord.Text = "Nhập tên món ăn";
            // 
            // input
            // 
            input.Location = new Point(143, 45);
            input.Name = "input";
            input.Size = new Size(334, 27);
            input.TabIndex = 1;
            // 
            // add
            // 
            add.Location = new Point(21, 139);
            add.Name = "add";
            add.Size = new Size(133, 49);
            add.TabIndex = 2;
            add.Text = "Thêm";
            add.UseVisualStyleBackColor = true;
            add.Click += addFood;
            // 
            // find
            // 
            find.Location = new Point(31, 282);
            find.Name = "find";
            find.Size = new Size(133, 44);
            find.TabIndex = 3;
            find.Text = "Tìm món ăn";
            find.UseVisualStyleBackColor = true;
            find.Click += findFood;
            // 
            // delete
            // 
            delete.Location = new Point(313, 279);
            delete.Name = "delete";
            delete.Size = new Size(133, 47);
            delete.TabIndex = 4;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += deleteFoods;
            // 
            // exit
            // 
            exit.Location = new Point(570, 282);
            exit.Name = "exit";
            exit.Size = new Size(148, 47);
            exit.TabIndex = 5;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_form;
            // 
            // result
            // 
            result.BorderStyle = BorderStyle.FixedSingle;
            result.Location = new Point(218, 360);
            result.Name = "result";
            result.Size = new Size(343, 66);
            result.TabIndex = 6;
            result.Text = "Hôm nay ăn: \n";
            result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foodBoard
            // 
            foodBoard.BackColor = Color.White;
            foodBoard.BorderStyle = BorderStyle.FixedSingle;
            foodBoard.Location = new Point(531, 9);
            foodBoard.Name = "foodBoard";
            foodBoard.Size = new Size(257, 258);
            foodBoard.TabIndex = 7;
            // 
            // Bai9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(foodBoard);
            Controls.Add(result);
            Controls.Add(exit);
            Controls.Add(delete);
            Controls.Add(find);
            Controls.Add(add);
            Controls.Add(input);
            Controls.Add(welcomeWord);
            Name = "Bai9";
            Text = "Bai9";
            Load += Bai9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeWord;
        private TextBox input;
        private Button add;
        private Button find;
        private Button delete;
        private Button exit;
        private Label result;
        private Label foodBoard;
    }
}