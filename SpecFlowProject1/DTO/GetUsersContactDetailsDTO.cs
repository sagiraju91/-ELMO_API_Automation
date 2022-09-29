using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    public class GetUsersContactDetailsDTO
    {
        public object personalEmail { get; set; }
        public object homePhone { get; set; }
        public object workPhone { get; set; }
        public object personalMobile { get; set; }
        public object addressLine1 { get; set; }
        public object addressLine2 { get; set; }
        public object suburb { get; set; }
        public object state { get; set; }
        public object postCode { get; set; }
        public object country { get; set; }
    }
}