using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigWeb.Models
{
    public class Invitation
    {
        public Invitation()
        {
        }
        [Key]
        public int invitation_id { get; set; }
        [ForeignKey("Event")]
        public int event_id { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDateTime{ get; set; }
        public string Sha512key{ get; set; }
        public Zone target{ get; set; }
    }
}