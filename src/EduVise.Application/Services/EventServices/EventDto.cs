using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduVise.Services.EventServices
{
    public class EventDto
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Type { get; set; }//make reflist (Open Day,Career Fair,Information Session

        public virtual DateTime Date { get; set; }
        public virtual string Venue { get; set; }
        public virtual string Institution { get; set; }//for custumized get of events hosted by specific institutions
    }
}
