using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using Xamarin.Essentials;
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

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, Constants.CoffeeSettingsFileName);
            if (File.Exists(fullPath))
            {
                string jsonText = File.ReadAllText(fullPath);
                try
                {
                    var savedSettings = JsonConvert.DeserializeObject<CoffeeSettings>(jsonText);
                    txtCoffeeName.Text = savedSettings.CoffeeName;
                    swHasSugar.On = savedSettings.HasSugar;
                    sldMilkAmount.Value = savedSettings.MilkAmount;
                    tpBrewTime.Time = savedSettings.BrewTime;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error reading settings: {ex.Message}");
                    //todo: log error!
                }
            }
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

            //object to json string
            string jsonText = JsonConvert.SerializeObject(settings);

            //get appdata dir using Xamaring Essentials
            string folder = FileSystem.AppDataDirectory;

            //standard,simple save operation
            string fullPath = Path.Combine(folder, Constants.CoffeeSettingsFileName);
            File.WriteAllText(fullPath, jsonText);
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
