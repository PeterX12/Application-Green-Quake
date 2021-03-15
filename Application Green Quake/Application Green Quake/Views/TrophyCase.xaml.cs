using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrophyCase : TabbedPage
    {
        public TrophyCase(int tab)
        {
            InitializeComponent();
            CurrentPage = Children[tab];
        }
    }
}