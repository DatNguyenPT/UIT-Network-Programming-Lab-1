using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            string[] separators = { "/", "-" };
            string[] dob = input.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            if (dob.Length == 2)
            {
                int day, month;

                if (int.TryParse(dob[0], out day) && int.TryParse(dob[1], out month))
                {
                    string zodiac = "";
                    if(month >= 1 && month <= 12)
                    {
                        switch (month)
                        {
                            case 1:
                                if (day >= 20) zodiac = "Ma Kết";
                                else zodiac = "Bảo Bình";
                                break;
                            case 2:
                                if (day <= 19) zodiac = "Bảo Bình";
                                else zodiac = "Song Ngư";
                                break;
                            case 3:
                                if (day <= 20) zodiac = "Song Ngư";
                                else zodiac = "Bạch Dương";
                                break;
                            case 4:
                                if (day <= 20) zodiac = "Bạch Dương";
                                else zodiac = "Kim Ngưu";
                                break;
                            case 5:
                                if (day <= 21) zodiac = "Kim Ngưu";
                                else zodiac = "Song Tử";
                                break;
                            case 6:
                                if (day <= 21) zodiac = "Song Tử";
                                else zodiac = "Cự Giải";
                                break;
                            case 7:
                                if (day <= 22) zodiac = "Cự Giải";
                                else zodiac = "Sư Tử";
                                break;
                            case 8:
                                if (day <= 22) zodiac = "Sư Tử";
                                else zodiac = "Xử Nữ";
                                break;
                            case 9:
                                if (day <= 23) zodiac = "Xử Nữ";
                                else zodiac = "Thiên Bình";
                                break;
                            case 10:
                                if (day <= 23) zodiac = "Thiên Bình";
                                else zodiac = "Thần Nông";
                                break;
                            case 11:
                                if (day <= 22) zodiac = "Thần Nông";
                                else zodiac = "Nhân Mã";
                                break;
                            case 12:
                                if (day <= 21) zodiac = "Nhân Mã";
                                else zodiac = "Ma Kết";
                                break;
                        }
                        result.Text = "Kết quả: \nCung hoàng đạo của bạn là " + zodiac;
                    }
                    else
                    {
                        result.Text = "Kết quả: \nĐịnh dạng ngày/tháng không hợp lệ";
                    }

                }
                else
                {
                    result.Text = "Kết quả: \nĐịnh dạng ngày/tháng không hợp lệ";
                }
            }
            else
            {
                result.Text = "Kết quả: \nĐịnh dạng ngày/tháng không hợp lệ";
            }
        }
    }
}
