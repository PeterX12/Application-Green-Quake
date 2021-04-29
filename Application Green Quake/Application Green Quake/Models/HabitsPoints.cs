/*! \class The HabitsPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the HabitsPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class HabitsPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int brushingCount { get; set; }
        public int fullWasherCount { get; set; }
        public int showerCount { get; set; }
        public int timedShowerCount { get; set; }
        public int offLigtsCount { get; set; }
        public int matchesCount { get; set; }
    }
}
