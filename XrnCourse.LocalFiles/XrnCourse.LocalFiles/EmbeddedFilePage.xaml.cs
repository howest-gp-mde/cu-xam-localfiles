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
    public partial class EmbeddedFilePage : ContentPage
    {
        public EmbeddedFilePage()
        {
            InitializeComponent();
        }

        private void BtnClearContents_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnLoadFile_Clicked(object sender, EventArgs e)
        {

        }
    }
}