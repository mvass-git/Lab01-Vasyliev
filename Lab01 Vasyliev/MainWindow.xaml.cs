using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab01_Vasyliev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Date_picker.SelectedDate != null)
            {
                DateTime birthday = Date_picker.SelectedDate.Value;
                DateTime today = DateTime.Today;
                int age = today.Year - birthday.Year;

                if (age > 135 || birthday > today)
                {
                    MessageBox.Show("Incorrect birth date.");
                }
                else
                {
                    if(today == birthday)
                    {
                        MessageBox.Show("Happy birthday!");
                    }
                    if (today.Month < birthday.Month || (today.Month == birthday.Month && today.Day < birthday.Day))
                    {
                        age--;
                    }
                    Age.Text = $"You are {age.ToString()} years old.";
                    ZodiacText.Text = $"Your zodiac sign: {GetZodiacSign(birthday.Month, birthday.Day)}";
                    ChineseZodiacText.Text = $"Your zodiac sign: {GetChineseZodiacSign(birthday.Year)}";
                }
                
            }
            else
            {
                MessageBox.Show("Choose a date.");
            }
        }

        static string GetZodiacSign(int month, int day)
        {
            if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
            {
                return "Aquarius";
            }
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
            {
                return "Pisces";
            }
            else if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
            {
                return "Aries";
            }
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
            {
                return "Taurus";
            }
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
            {
                return "Gemini";
            }
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
            {
                return "Cancer";
            }
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
            {
                return "Leo";
            }
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
            {
                return "Virgo";
            }
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
            {
                return "Libra";
            }
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
            {
                return "Scorpio";
            }
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
            {
                return "Sagittarius";
            }
            else
            {
                return "Capricorn";
            }
        }

        static string GetChineseZodiacSign(int year)
        {
            string[] chineseZodiacSigns = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };

            return chineseZodiacSigns[year % 12];
        }
    }
}
