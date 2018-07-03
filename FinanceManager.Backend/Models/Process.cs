using System;

namespace FinanceManager.Backend.Models
{
    public class Process
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime CurrentProcessDate { get; set; }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Processor Processor { get; set; }
    }
}
