using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A17 佐藤　勝貴";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double h = Convert.ToInt32(heighit);
            double w = Convert.ToInt32(weighit);
            if (h <= 3)
            {
                double heighit = h / 100;
            }
            else if(w <=1000)
            {
                double weighit = w / 100;
            }
            //計算
            double bmi = ((h*h)/w);
            //表示
             if (bmi=<18.5);
             {
                result.Text = (bmi"低体重（痩せ）\n");
            }
            else if(18.5=<bmi && bmi=<25.0);
            {
                result.Text =(bmi"普通体重\n");
            }
            else if(25.0=<bmi && bmi=<30.0);
            {
                result.Text =(bmi"肥満（1度）\n");
            }
            else if(30.0=<bmi && bmi=<35.0);
            {
                result.Text =(bmi"肥満（2度）\n");
            }
            else if(35.0=<bmi && bmi=<40.0);
            {
                result.Text =(bmi"肥満（3度）\n");
            }
            else(40.0=<bmi);
            {
                result.Text =(bmi"肥満（4度）\n");
            }
        }
    }
}
