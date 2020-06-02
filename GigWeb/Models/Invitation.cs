using System;

namespace GigWeb.Models
{
    public class Invitation
    {
        public Invitation()
        {
        }

        private int userID;
        private DateTime purchaseDateTime;
        private string sha512key;
        private Zone target;
    }
}