using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XrnCourse.LocalFiles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowBundledPdfPage : ContentPage
    {
        public ShowBundledPdfPage()
        {
            InitializeComponent();
        }

        private void BtnLoadPdf_Clicked(object sender, EventArgs e)
        {
            //todo: open packaged PDF stream using Xamarin.Essentials

            //todo: update filesize

        }
    }
}
