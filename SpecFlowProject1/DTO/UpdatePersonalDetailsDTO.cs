using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    public class UpdatePersonalDetailsDTO
    {
        public long responseCode { get; set; }
        public string summary { get; set; }
        public Log logs { get; set; }
        public string personalEmail { get; set; }
        public long homePhone { get; set; }
        public long workPhone { get; set; }
        public long personalMobile { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string suburb { get; set; }
        public long state { get; set; }
        public long postCode { get; set; }
        public string country { get; set; }
    }

    public class Log
    {
        public Success success { get; set; }
        public Failure failure { get; set; }
        public long SuccessCount { get; set; }
        public long FailureCount { get; set; }
    }

    public class Success
    {
    }
    public class Failure
    {
    }

}
