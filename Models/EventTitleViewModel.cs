using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ToMeet.Models
{
    public class EventTitleViewModel
    {
        public List<Event> events;
        public SelectList titles;
        public string eventTitle {get;set;}
    }
}