using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XrnCourse.LocalFiles.Domain;

namespace XrnCourse.LocalFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeSettingsPage : ContentPage
    {
        public CoffeeSettingsPage()
        {
            InitializeComponent();
        }

        private void BtnResetToDefaults_Clicked(object sender, EventArgs e)
        {
            txtCoffeeName.Text = "";
            swHasSugar.On = false;
            sldMilkAmount.Value = 0;  // also triggers SldMilkAmount_ValueChanged
            tpBrewTime.Time = TimeSpan.Zero;
        }

        private void BtnSaveSettings_Clicked(object sender, EventArgs e)
        {
            var settings = new CoffeeSettings
            {
                CoffeeName = txtCoffeeName.Text,
                HasSugar = swHasSugar.On,
                MilkAmount = (int) sldMilkAmount.Value,
                BrewTime = tpBrewTime.Time
            };

            //todo: save settings object to JSON file!

        }

        private void SldMilkAmount_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblMilkAmount.Text = GetMilkAmountText((int)sldMilkAmount.Value);
        }

        private string GetMilkAmountText(int milkAmount)
        {
            switch (milkAmount)
            {
                case 0:
                    return "Black";
                case 1:
                    return "Macchiato";
                case 2:
                    return "Café au lait";
                case 3:
                    return "Latté";
                case 4:
                    return "Flat white";
            }
            return $"{milkAmount}";
        }
    }
}
