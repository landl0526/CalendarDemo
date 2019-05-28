using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;

namespace CalendarDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }       

        private void Button_Clicked(object sender, EventArgs e)
        {
            calendar.SpecialDates = new List<SpecialDate>
            {
                new SpecialDate(DateTime.Now.AddDays(1))
                {
                    Selectable = true,
                    BackgroundPattern = new BackgroundPattern(1)
                    {
                        Pattern = new List<Pattern>
                        {
                            new Pattern { WidthPercent = 1f, HightPercent = 0.6f, Color = Color.Transparent },
                            new Pattern{ WidthPercent = 1f, HightPercent = 0.4f, Color = Color.Transparent, Text = "Mass", TextColor=Color.Black, TextSize=11, TextAlign=TextAlign.Middle},
                        }
                    }
                }
            };
        }

        private void CurrentDate(object sender, XamForms.Controls.DateTimeEventArgs e)
        {

        }
    }
}
