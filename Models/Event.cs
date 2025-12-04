namespace FCIT_Event_Finder.Models
{
    public class Event
    {
        public int id { get; set; }

        public string organizer { get; set; }

        public string  name { get; set; }

        
        public string date { get; set; }

        public string time { get; set; }

        public string location { get; set; }

        public string description { get; set; }

        public string url { get; set; }


        public Event()
        {
            
        }
    }

     
}
