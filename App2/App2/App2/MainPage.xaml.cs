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
            //Console.WriteLine("WTF" + DependencyService.Get<IT4CService>().getTime() + "\n");
            //Console.WriteLine("==============================");
            //Console.WriteLine(DependencyService.Get<IT4CService>().getString(new Person("joe",count)));

            Console.WriteLine("==============================");
            lCount.Text = "#" + ++count;

            //DependencyService.Get<IT4CService>().showInviteForSurveyId("app_test_1");
            DependencyService.Get<IT4CService>().increamentWithKey("app_test_1");
            DependencyService.Get<IT4CService>().checkIfEligible();
        }

        private void Button_Rest(object sender, EventArgs e)
        {
            count = 0;
            lCount.Text = "#" + count;
            DependencyService.Get<IT4CService>().reset();
        }

        class Person
        {
            String name;
            int age;
            public Person(String name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
