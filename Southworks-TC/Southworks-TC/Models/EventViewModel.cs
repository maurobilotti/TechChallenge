using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Southworks_TC.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Technology { get; set; } //probably a new class must be created.
        public DateTime StartingDate { get; set; }
        public string RegistrationLink { get; set; }
    }
}