/*! \mainpage The WorkPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the WorkPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class WorkPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int paperCount { get; set; }
        public int offElectronicsCount { get; set; }
        public int remoteWorkCount { get; set; }
    }
}
