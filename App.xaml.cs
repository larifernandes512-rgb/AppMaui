using Microsoft.Maui.Controls;

namespace AppMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}