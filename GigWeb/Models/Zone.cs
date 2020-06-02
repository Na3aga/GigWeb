using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigWeb.Models
{
    public class Zone
    {
        public Zone(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        [Key]
        public int zone_id { get; set; }
        [ForeignKey("Event")]
        public int zone_event_id { get; set; }
        public string Name{ get; set; }
        public int Capacity{ get; set; }
        
    }
}