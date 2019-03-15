using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            lCount.Text = "#" + ++count;
            DependencyService.Get<ForeseeSDK>().increamentWithKey("app_test_1");
        }

        private void Button_Reset(object sender, EventArgs e)
        {
            count = 0;
            lCount.Text = "#" + count;
            DependencyService.Get<ForeseeSDK>().reset();
        }

        private void Button_Check(object sender, EventArgs e)
        {
            DependencyService.Get<ForeseeSDK>().checkIfEligible();
        }
    }
}
