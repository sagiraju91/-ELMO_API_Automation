using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.DTO
{
    public class GetUsersDTO
    {
        public Guid id { get; set; }
        public string identifier { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string employeeNumber { get; set; }
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string expiryDate { get; set; }
        public string timezone { get; set; }
        public bool active { get; set; }
        public UserData customData { get; set; }
        public string position { get; set; }
        public string location { get; set; }
        public string department { get; set; }
        public string legalEntity { get; set; }
        public string manager { get; set; }
        public string mobile { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string role { get; set; }
    }

    public class UserData
    {
        public string preferredname { get; set; }
        public string dynamicsempid { get; set; }
        public string company { get; set; }
        public object upn { get; set; }
    }
}