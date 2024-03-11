using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            Load += new EventHandler(Bai4_Load);
        }

        private void Bai4_Load(object sender, EventArgs e) { }

        private string numRead(char number)
        {
            string result = "";
            switch (number)
            {
                case '0':
                    result = "Không";
                    break;
                case '1':
                    result = "Một";
                    break;
                case '2':
                    result = "Hai";
                    break;
                case '3':
                    result = "Ba";
                    break;
                case '4':
                    result = "Bốn";
                    break;
                case '5':
                    result = "Năm";
                    break;
                case '6':
                    result = "Sáu";
                    break;
                case '7':
                    result = "Bảy";
                    break;
                case '8':
                    result = "Tám";
                    break;
                case '9':
                    result = "Chín";
                    break;
            }
            return result;
        }

        private void read_click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> hundred = new Stack<char>();
            Stack<char> thousand = new Stack<char>();
            Stack<char> million = new Stack<char>();
            Stack<char> billion = new Stack<char>();
            List<Stack<char>> listOfStacks = new List<Stack<char>>();
            listOfStacks.Add(hundred);
            listOfStacks.Add(thousand);
            listOfStacks.Add(million);
            listOfStacks.Add(billion);
            int currentPointer = input.Text.Length - 1;
            int index = 0;
            while (currentPointer >= 0)
            {
                listOfStacks[index].Push(input.Text[currentPointer]);
                if (listOfStacks[index].Count == 3 || currentPointer == 0)
                {
                    index++;
                }
                currentPointer--;
            }

            for (int i = listOfStacks.Count - 1; i >= 0; i--)
            {
                if (listOfStacks[i].Count > 0)
                {
                    sb.Append(stackRead(listOfStacks[i]));
                    if (i > 0 && listOfStacks[i - 1].Count > 0) // Kiểm tra nếu cần thêm "nghìn", "triệu", "tỷ"
                    {
                        switch (i)
                        {
                            case 1:
                                sb.Append(" nghìn");
                                break;
                            case 2:
                                sb.Append(" triệu");
                                break;
                            case 3:
                                sb.Append(" tỷ");
                                break;
                        }
                    }
                }
            }

            resultbox.Text = sb.ToString().Trim(); // Xóa khoảng trắng ở cuối kết quả
        }


        private string stackRead(Stack<char> stack)
        {
            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
            {
                if (stack.Count == 1)
                {
                    sb.Insert(0, numRead(stack.Pop())); // Chèn vào đầu chuỗi để đảo ngược
                }
                else if (stack.Count == 2)
                {
                    char digit = stack.Pop();
                    if (digit == '1')
                    {
                        if (stack.Count > 0 && stack.Peek() != '0')
                        {
                            sb.Insert(0, "mười ");
                        }
                        else
                        {
                            sb.Insert(0, "mười");
                        }
                    }
                    else
                    {
                        sb.Insert(0, " ");
                        sb.Insert(0, numRead(digit));
                        sb.Insert(0, "mươi");
                    }
                }
                else if (stack.Count == 3)
                {
                    sb.Insert(0, " ");
                    sb.Insert(0, numRead(stack.Pop()));
                    sb.Insert(0, "trăm");
                }
            }
            return sb.ToString();
        }
    }
}
