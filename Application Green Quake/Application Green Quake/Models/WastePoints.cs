/*! \class The WastePoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WastePoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class WastePoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int billsCount { get; set; }
        public int compostCount { get; set; }
        public int setUpRecyclingBinCount { get; set; }
        public int bioBinBagsCount { get; set; }
        public int recyclingBinCount { get; set; }
    }
}
