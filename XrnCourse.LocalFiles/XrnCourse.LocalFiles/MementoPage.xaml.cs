using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.LocalFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MementoPage : ContentPage
    {
        public MementoPage()
        {
            InitializeComponent();
        }

        private void BtnClearContents_Clicked(object sender, EventArgs e)
        {
            txtContents.Text = "";
        }

        private void BtnLoadMemento_Clicked(object sender, EventArgs e)
        {
            //todo: load contents from text file
        }

        private void BtnSaveMemento_Clicked(object sender, EventArgs e)
        {
            //todo: save contents from text file
        }
    }
}
