using System.Collections.Generic;

namespace AccountingSystem.Models
{
    public class Customer
    {
        public int CutomerId { get; set; }
        public string CustomerName { get; set; }

        public List<Project> Projects { get; set; }
    }
}
