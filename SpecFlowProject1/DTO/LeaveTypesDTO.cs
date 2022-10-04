using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class LeaveTypesDTO
    {
        public Guid id { get; set; }
        public string accrualType { get; set; }
        public string title { get; set; }
        public string displayTitle { get; set; }
        public string description { get; set; }
        public object code { get; set; }
        public string entitlementType { get; set; }
        public bool deleted { get; set; }
    }
}
