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
    public partial class ShowBundledPdfPage : ContentPage
    {
        public ShowBundledPdfPage()
        {
            InitializeComponent();
        }

        private void BtnLoadPdf_Clicked(object sender, EventArgs e)
        {

        }
    }
}