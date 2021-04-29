/*! \class The OutdoorsPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the OutdoorsPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class OutdoorsPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int campingCount { get; set; }
        public int picnicCount { get; set; }
        public int plantBushCount { get; set; }
        public int plantFlowerCount { get; set; }
        public int plantTreeCount { get; set; }
        public int scoopCount { get; set; }
        public int fruitGardenCount { get; set; }
        public int herbGardenCount { get; set; }
        public int vegetableGardenCount { get; set; }
        public int birdFeederCount { get; set; }

    }
}
