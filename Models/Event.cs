using System;
using System.ComponentModel.DataAnnotations;

namespace ToMeet.Models{
    public class Event{
        public int ID {get; set;}
        public string Publisher {get; set;}
        public string Title{get; set;}
        [Display(Name="Start Time")]
        [DataType(DataType.Date)]
        public DateTime StartTime {get; set;}
        public int Number{get; set;}
        public string Location {get; set;}
        public string Description {get; set;}        
    }
}
