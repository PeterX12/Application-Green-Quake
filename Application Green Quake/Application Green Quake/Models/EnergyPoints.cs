/*! \mainpage The EnergyPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the EnergyPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class EnergyPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int hangDryCount { get; set; }
        public int fullDryerCount { get; set; }
        public int insulateWaterCount { get; set; }
        public int efficientThermostatCount { get; set; }
        public int isolateHomeCount { get; set; }
        public int ledLightBulbCount { get; set; }
        public int fullMachineCount { get; set; }
        public int microwaveCount { get; set; }
        public int offSocketCount { get; set; }
        public int reBatteriesCount { get; set; }
        public int fridgeCount { get; set; }
        public int draftSealCount { get; set; }
        public int ductSealCount { get; set; }
        public int solarPanelCount { get; set; }
    }
}
