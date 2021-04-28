/*! \mainpage The TravelPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the TravelPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class TravelPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int carpoolCount { get; set; }
        public int cycleCount { get; set; }
        public int ecoCarCount { get; set; }
        public int transportCount { get; set; }
        public int walkCount { get; set; }
    }
}
