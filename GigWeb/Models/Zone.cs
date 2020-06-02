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
        public int ZoneId { get; set; }
        [ForeignKey("Event")]
        public int ZoneEventId { get; set; }
        public int Color { get; set; }
        public string Name{ get; set; }
        public int Capacity{ get; set; }
        
    }
}