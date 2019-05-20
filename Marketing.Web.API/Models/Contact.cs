using System;
using System.Collections.Generic;
using System.Text;

namespace Marketing.Web.API.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProjectedMonthlyBudget { get; set; }
        public string Comments { get; set; }
    }
}
