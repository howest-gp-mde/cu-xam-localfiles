using System;
using System.IO;
using System.Reflection;
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
            var assembly = typeof(EmbeddedFilePage).GetTypeInfo().Assembly;
            Stream stream =
                assembly.GetManifestResourceStream("XrnCourse.LocalFiles.EmbeddedFiles.translations.txt");
            using (var reader = new StreamReader(stream))
            {
                txtFileContents.Text = reader.ReadToEnd();
            }
        }
    }
}
