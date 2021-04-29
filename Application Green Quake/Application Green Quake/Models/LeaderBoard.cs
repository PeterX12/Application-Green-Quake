/*! \class The LeaderBoard Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the LeaderBoard Model Class.
 *
 */
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
        public string nation { get; set; }
        public string uid { get; set; }
    }
}
