using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace interfaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdministerProducts());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Create());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {

        }
    }
}