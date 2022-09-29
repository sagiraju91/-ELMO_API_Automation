using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace SpecFlowProject1.DTO
{

    public class ActivateUserDTO
    {
        public long responseCode { get; set; }
        public string summary { get; set; }
        public Logs logs { get; set; }
        public Guid id { get; set; }
    }

    public class Logs
    {
        public successData success { get; set; }
        public failureData failure { get; set; }
        public long successCount { get; set; }
        public long failureCount { get; set; }
    }

    public  class successData
    {
    }

    public class failureData
    {
    }
}