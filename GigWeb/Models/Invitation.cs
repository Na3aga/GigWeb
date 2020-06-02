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
        public int InvitationId { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        [ForeignKey("Zone")]
        public int ZoneId { get; set; }
        [ForeignKey("GigUser")]
        public int UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDateTime{ get; set; }
        public string Sha512key{ get; set; }
    }
}