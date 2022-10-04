using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    class LegalEntityDTO
    {
        public Guid id { get; set; }
        public string abn { get; set; }
        public string businessName { get; set; }
        public string tradingName { get; set; }
        public object branchNumber { get; set; }
        public string contactName { get; set; }
        public string phone { get; set; }
        public object fax { get; set; }
        public string email { get; set; }
        public bool Default { get; set; }
        public bool active { get; set; }
        public string jurisdiction { get; set; }
        public Address address { get; set; }
    }

    public partial class Address
    {
        public string addressLine1 { get; set; }
        public object addressLine2 { get; set; }
        public string suburb { get; set; }
        public string state { get; set; }
        public long postcode { get; set; }
        public string country { get; set; }
    }
}

