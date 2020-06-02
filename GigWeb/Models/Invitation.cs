using System;

namespace GigWeb.Models
{
    public class Invitation
    {
        public Invitation()
        {
        }

        public int UserID { get; set; }
        public DateTime PurchaseDateTime{ get; set; }
        public string Sha512key{ get; set; }
        public Zone target{ get; set; }
    }
}