using FinanceManager.Backend.Enums;
using System;

namespace FinanceManager.Backend.Models
{
    public class Process
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public int Sign { get; set; }
        public int ProcessDay { get; set; }
        public DateTime ProcessStart { get; set; }
        public DateTime ProcessEnd { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Processor Processor { get; set; }
    }
}
