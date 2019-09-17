using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.LocalFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmbeddedFilePage : ContentPage
    {
        public EmbeddedFilePage()
        {
            InitializeComponent();
        }

        private void BtnClearContents_Clicked(object sender, EventArgs e)
        {
            txtFileContents.Text = "";
        }

        private void BtnLoadFile_Clicked(object sender, EventArgs e)
        {
            //todo: load contents from embedded text file
        }
    }
}
