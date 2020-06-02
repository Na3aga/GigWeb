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
        // List of pathes to images
        public string Image { get; set; }
        public string Information { get; set; }
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

    }
}