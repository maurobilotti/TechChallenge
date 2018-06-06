using Southworks_TC.Repository;
using System;

namespace Southworks_TC.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Technology { get; set; } //probably a new class must be created.
        public string StartingDate { get; set; }
        public string RegistrationLink { get; set; }

        public EventViewModel(Event e)
        {
            this.Id = e.Id;
            this.Title = e.Title;
            this.StartingDate = e.StartingDate.ToShortDateString();
            this.Technology = e.Technology;
            this.RegistrationLink = e.RegistrationLink;
        }
    }
}