using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HabitsPage : ContentPage
    {
        public HabitsPage()
        {
            InitializeComponent();
        }

        private async void NavigateToBrushingPage(object sender, EventArgs e)
        {
            Application.Current.MainPage = new BrushingTeeth();
        }
    }
}