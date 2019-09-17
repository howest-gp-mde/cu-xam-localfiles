using System;
using System.IO;
using Xamarin.Essentials;
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

        private async void BtnLoadPdf_Clicked(object sender, EventArgs e)
        {
            using (var fileStream = await FileSystem
                .OpenAppPackageFileAsync("MyPdfs\\CSharpCheatSheet.pdf"))
            {
                MemoryStream memoryStream = new MemoryStream();
                await fileStream.CopyToAsync(memoryStream);
                pdfViewer.InputFileStream = memoryStream;
                lblPdfSize.Text = $"{(memoryStream.Length / 1024.0):N2} kB";
            }
        }
    }
}
