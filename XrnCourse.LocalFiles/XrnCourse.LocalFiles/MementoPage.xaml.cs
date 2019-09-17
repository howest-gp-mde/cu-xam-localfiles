using System;
using System.IO;
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
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(folder, Constants.MementoFileName);
            if (File.Exists(fullPath))
                txtContents.Text = File.ReadAllText(fullPath);
        }

        private void BtnSaveMemento_Clicked(object sender, EventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string fullPath = Path.Combine(folder, Constants.MementoFileName);
            File.WriteAllText(fullPath, txtContents.Text);
        }
    }
}
