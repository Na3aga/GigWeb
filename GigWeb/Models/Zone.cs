using System.Collections.Generic;

namespace GigWeb.Models
{
    public class Zone
    {
        public Zone(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }
        private string name;
        private HashSet<Invitation> seats;
        private int capacity;

        public int FreeSits
        {
            get { return capacity - seats.Count; }
        }
        public void BookSeat()
        {
            // TODO implement here
        }
    }
}