using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Backend.Models
{
    public class Month
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Process> Processes { get; set; }
    }
}
