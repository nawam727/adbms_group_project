using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace adbms_group_project.Models
{
    public class Camp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date { get; set; }
        public string Organiser { get; set; }
        public string Venue { get; set; }
    }
}