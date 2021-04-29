/*! \class The WaterPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WaterPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class WaterPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int cisternCount { get; set; }
        public int rainBarrelCount { get; set; }
        public int reWaterCount { get; set; }
        public int showerBucketCount { get; set; }
        public int wSShowerHeadCount { get; set; }
    }
}
