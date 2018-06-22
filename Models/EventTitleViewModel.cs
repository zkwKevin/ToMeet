using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ToMeet.Models
{
    public class EventTitleViewModel
    {
        public List<Event> events;
        public SelectList titles;
        // selected title
        public string eventTitle {get;set;}
    }
}