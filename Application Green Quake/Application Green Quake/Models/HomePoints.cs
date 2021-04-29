/*! \class The HomePoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the HomePoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class HomePoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int airOutCount { get; set; }
        public int nonHarmCount { get; set; }
        public int outsideCount { get; set; }
        public int plantIntoHomeCount { get; set; }
        public int toiletFlushCount { get; set; }
    }
}
