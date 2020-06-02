using System.Collections.Generic;

namespace GigWeb.Models
{
    public class Zone
    {
        public Zone(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public string Name{ get; set; }
        public HashSet<Invitation> Seats{ get; set; }
        public int Capacity{ get; set; }

        public int FreeSits
        {
            get { return Capacity - Seats.Count; }
        }
        public void BookSeat()
        {
            // TODO implement here
        }
    }
}