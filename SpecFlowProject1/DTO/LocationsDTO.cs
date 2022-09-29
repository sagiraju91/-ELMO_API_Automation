using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class LocationsDTO
    {
        public Guid id { get; set; }
        public object parent { get; set; }
        public string title { get; set; }
        public string locationId { get; set; }
        public object description { get; set; }
        public object addressLine1 { get; set; }
        public object addressLine2 { get; set; }
        public object suburb { get; set; }
        public object state { get; set; }
        public object postcode { get; set; }
        public string country { get; set; }
        public string path { get; set; }
        public bool deleted { get; set; }
    }
}
