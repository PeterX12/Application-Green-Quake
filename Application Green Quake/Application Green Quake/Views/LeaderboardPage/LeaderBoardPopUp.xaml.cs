using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Application_Green_Quake.Views.LeaderboardPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderBoardPopUp
    {
        public LeaderBoardPopUp(string username)
        {
            InitializeComponent();
            here.Text = username;
        }
    }
}