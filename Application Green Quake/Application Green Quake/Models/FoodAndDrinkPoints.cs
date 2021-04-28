/*! \mainpage The FoodAndDrinkPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the FoodAndDrinkPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class FoodAndDrinkPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int organicCount { get; set; }
        public int eatAllCount { get; set; }
        public int foodDeliverCount { get; set; }
        public int noMeatCount { get; set; }
        public int ownCoffeeCount { get; set; }
        public int reCoffeeMugCount { get; set; }
        public int saveLeftOversCount { get; set; }
        public int steelStrawCount { get; set; }
        public int waterOverFizzyCount { get; set; }
    }
}
