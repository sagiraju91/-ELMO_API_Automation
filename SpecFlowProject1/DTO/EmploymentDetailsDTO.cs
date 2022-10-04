using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class EmploymentDetailsDTO
    {
        
            public Guid id { get; set; }
            public object employmentType { get; set; }
            public object unitsPerWeek { get; set; }
            public object rate { get; set; }
            public object rateType { get; set; }
            public object terminationDate { get; set; }
            public object payCycle { get; set; }
            public object taxDetails { get; set; }
            public object bankAccountDetails { get; set; }
            public object superannuationDetails { get; set; }
    }
}


