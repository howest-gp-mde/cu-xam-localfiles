using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XrnCourse.LocalFiles
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

        private async void BtnOpenEmbeddedFilePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmbeddedFilePage(), true);
        }

        private async void BtnOpenBundledPdfPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowBundledPdfPage(), true);
        }

        private async void BtnOpenMementoPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MementoPage(), true);
        }

        private async void BtnOpenCoffeePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoffeeSettingsPage(), true);
        }
    }
}
