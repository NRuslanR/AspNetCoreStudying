using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AspNetCoreFromScratch.State_Mng
{
    public static class SessionExtensions
    {
        public static ISession SetUserVisitedLinksProfile(
            this ISession session, UserVisitedLinksProfile userVisitedLinksProfile
            )
        {
            session.SetString("UserProfile", JsonConvert.SerializeObject(userVisitedLinksProfile));
            
            return session;
        }

        public static UserVisitedLinksProfile GetUserVisitedLinksProfile(
            this ISession session
        )
        {
            string userProfileStr = session.GetString("UserProfile");

            if (string.IsNullOrWhiteSpace(userProfileStr))
                return null;
            
            return JsonConvert.DeserializeObject<UserVisitedLinksProfile>(userProfileStr);
        }
    }
}