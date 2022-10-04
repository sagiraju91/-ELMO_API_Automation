using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class PositionsDTO
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public object parent { get; set; }
        public bool deleted { get; set; }
        public string positionId { get; set; }
        public object description { get; set; }
        public object qualifications { get; set; }
    }
}
