using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SearchBarRTL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainArabic : ContentPage
    {
        public MainArabic()
        {
            InitializeComponent();
        }

        private void GoToEnglish(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
    
}