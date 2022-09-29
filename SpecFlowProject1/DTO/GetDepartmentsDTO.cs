using System;

namespace SpecFlowProject1.DTO
{
    public class GetDepartmentsDTO
    { 
        public object parent { get; set; }
        public Guid id { get; set; }
        public object description { get; set; }
        public string departmentId { get; set; }
        public string title { get; set; }
        public string path { get; set; }
        public bool deleted { get; set; }
    }

  
 }
