using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Application_Green_Quake.Models
{
    class LeaderBoard
    {
        public ImageSource image { get; set; }
        public string username { get; set; }
        public int points { get; set; }
        public string rank { get; set; }
        public string bio { get; set; }
    }
}
