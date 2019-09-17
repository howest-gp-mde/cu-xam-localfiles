using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        }

        private void BtnSaveSettings_Clicked(object sender, EventArgs e)
        {

        }

        private void SldMilkAmount_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}