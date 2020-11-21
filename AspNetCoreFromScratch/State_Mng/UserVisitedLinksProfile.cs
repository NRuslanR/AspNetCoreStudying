using System;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreFromScratch.State_Mng
{
    public class VisitedLinkInfo
    {
        public DateTime LastVisitDateTime { get; set; }
        public string Url { get; set; }

        public bool Equals(VisitedLinkInfo other)
        {
            return (!(other is null)) && Url == other.Url;
        }
        
        public override bool Equals(object? obj)
        {
            return Equals(obj as VisitedLinkInfo);
        }
    }
    
    public class UserVisitedLinksProfile
    {
        public string User { get; set; }
        public ICollection<VisitedLinkInfo> VisitedLinkInfos { get; private set; }

        public UserVisitedLinksProfile(string user)
        {
            User = user;
            
            VisitedLinkInfos = new List<VisitedLinkInfo>();
        }

        public void AddOrUpdateVisitedLinkInfo(VisitedLinkInfo visitedLinkInfo)
        {
            if (!VisitedLinkInfos.Contains(visitedLinkInfo))
                VisitedLinkInfos.Add(visitedLinkInfo);

            else
            {
                VisitedLinkInfos.First(
                        vl => vl.Url == visitedLinkInfo.Url
                        ).LastVisitDateTime = visitedLinkInfo.LastVisitDateTime;
            }
        }

        public void Clear()
        {
            VisitedLinkInfos.Clear();
        }

        public void RemoveVisitedLinkInfo(VisitedLinkInfo visitedLinkInfo)
        {
            VisitedLinkInfos.Remove(visitedLinkInfo);
        }

        public void RemoveVisitedLinkInfo(string url)
        {
            RemoveVisitedLinkInfo(new VisitedLinkInfo() {Url = url});
        }
    }
}