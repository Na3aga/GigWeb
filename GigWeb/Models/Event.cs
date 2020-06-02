using System.Collections.Generic;
using System.Linq;

namespace GigWeb.Models
{
    public class Event
    {
        public Event(string name, string information)
        {
            Name = name;
        }

        public string Name { get;set;}

        public HashSet<Zone> SitZones { get; set; }
        // List of pathes to images
        public List<string> Images { get; set; }
        public string Information { get; set; }

        public int TicketsLeft()
        {
            return SitZones.Sum(zone => zone.FreeSits);
        }
    }
}