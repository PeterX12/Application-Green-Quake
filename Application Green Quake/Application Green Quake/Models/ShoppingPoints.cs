/*! \class The ShoppingPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the ShoppingPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class ShoppingPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int clothNapkinCount { get; set; }
        public int clothTowelCount { get; set; }
        public int applianceCount { get; set; }
        public int productCount { get; set; }
        public int toothbrushCount { get; set; }
        public int clothesCount { get; set; }
        public int foodCount { get; set; }
        public int localCount { get; set; }
        public int looseLeafCount { get; set; }
        public int organicFoodCount { get; set; }
        public int reusableCount { get; set; }
        public int reBatCount { get; set; }
        public int reBagCount { get; set; }
    }
}
