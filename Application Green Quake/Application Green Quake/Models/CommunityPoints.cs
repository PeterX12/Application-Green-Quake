/*! \mainpage The CommunityPoints Model Class
 * \author Peter Lucan, 4th Year Software Development student at IT Carlow, C00228946, c00228956@itcarlow.ie
 * \date 28/04/2021
 * \section desc_sec Description
 *
 * Description: This is the CommunityPoints Model Class.
 *
 */
namespace Application_Green_Quake.Models
{
    class CommunityPoints
    {
        public string username { get; set; }
        public int points { get; set; }
        public int numberOfLogs { get; set; }
        public int createGroupCount { get; set; }
        public int communityCount { get; set; }
        public int donateCount { get; set; }
        public int groupCount { get; set; }
        public int shareCount{ get; set; }
        public int awarenessCount { get; set; }

    }
}
