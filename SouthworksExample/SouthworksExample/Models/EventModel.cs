using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SouthworksExample.Models
{
    public class EventModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Technology { get; set; }
        public DateTime StartDate { get; set; }
        public string RegistrationLink { get; set; }
    }
}