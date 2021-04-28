/*! \mainpage The Station Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the Station Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class Station
    {
        public string description { get; set; }

        public string label { get; set; }

        public double latitude { get; set; }

        public double longitude { get; set; }
    }
}
