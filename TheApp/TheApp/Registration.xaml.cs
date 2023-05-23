using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TheApp.Models;
using TheApp.Logic;

namespace TheApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        TheApp.Logic.Logic logic = new TheApp.Logic.Logic();
        public Registration()
        {
            InitializeComponent();
        }

        private async void Out_Clicked(object sender, EventArgs e)
        {
            User user = new User(name.Text, number.Text, DateTime.Parse(active.Text));

            

        }
    }
}