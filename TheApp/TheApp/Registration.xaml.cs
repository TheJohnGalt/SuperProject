using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

            Console.WriteLine(entry.Text);
        }
    }
}