using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace GigWeb.Models
{
    public class Event
    {
        public Event(string name, string information = "None")
        {
            Name = name;
            Information = information;
        }

        public string Name { get;set;}
        public HashSet<Zone> SitZones { get; set; }
        // List of pathes to images
        public List<string> Images { get; set; }
        public string Information { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        public int TicketsLeft()
        {
            return SitZones.Sum(zone => zone.FreeSits);
        }
    }
}