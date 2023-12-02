using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_c_
{
    public struct Event
    {
        private string _eventtype;
        private string _venue;
        private Eventint _eventint;
        public string Eventtype
        {
            get => _eventtype;
            set => _eventtype = value;
        }

        public string Venue
        {
            get => _venue;
            set => _venue = value;
        }
        public Eventint eventint
        {
            get => _eventint;
            set => _eventint = value;
        }
        public Event(string type, string venue, Eventint eventint)
            {
            _eventtype = type;
            _venue = venue;
        }
        public void Printinfo()
        {
            Console.WriteLine("The event is ----{0} and it will take place at {1} which is the best for {2}", _eventtype, _venue, _eventint);
        }

    }
}
