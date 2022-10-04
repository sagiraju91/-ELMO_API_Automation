using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class PayrollCyclesDTO
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public DateTimeOffset startDate { get; set; }
        public string type { get; set; }
        public bool Default { get; set; }
        public long weeksPerAnnum { get; set; }
        public string jurisdiction { get; set; }
    }
}
