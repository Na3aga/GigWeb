using System.Collections.Generic;
using System.Linq;

namespace GigWeb.Models
{
    public class Event
    {
        public Event(string name, string information)
        {
            this.name = name;
        }
        
        private string name;
        private HashSet<Zone> sitZones;
        // List of pathes to images
        private List<string> images;
        private string information;
        
        public int TicketsLeft()
        {
            return sitZones.Sum(zone => zone.FreeSits);
        }
    }
}