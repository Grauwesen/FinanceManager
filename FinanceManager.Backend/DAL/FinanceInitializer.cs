using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FinanceManager.Backend.Models;
using FinanceManager.Backend.Enums;

namespace FinanceManager.Backend.DAL
{
    public class FinanceInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FinanceContext>
    {
        protected override void Seed(FinanceContext context)
        {
            var processes = new List<Process>
            {
                new Process { Amount=1000, Currency=Currency.Euro, Sign=1, ProcessDay=1, ProcessStart=DateTime.MinValue, ProcessEnd=DateTime.MaxValue, Description="Salary", CreatedAt= DateTime.Now },
                new Process { Amount=130, Currency=Currency.Euro, Sign=0, ProcessDay=1, ProcessStart=DateTime.MinValue, ProcessEnd=DateTime.MaxValue, Description="Insurance", CreatedAt= DateTime.Now },
                new Process { Amount=200, Currency=Currency.Euro, Sign=0, ProcessDay=1, ProcessStart=DateTime.MinValue, ProcessEnd=DateTime.MaxValue, Description="Shopping", CreatedAt= DateTime.Now },
                new Process { Amount=250, Currency=Currency.Euro, Sign=0, ProcessDay=1, ProcessStart=DateTime.MinValue, ProcessEnd=DateTime.MaxValue, Description="Foods", CreatedAt= DateTime.Now }
            };

            processes.ForEach(p => context.Processes.Add(p));
            context.SaveChanges();

            var processors = new List<Processor>
            {
                new Processor { Name="IT-Solutions", Description="The company I work for", Street="Solution Blvd. 1", PostalCode="12345", Country="DE", Email="info@it-solutions.de", PhoneNumber="01234-56789-0", MobilePhoneNumber="0987-6543210", CreatedAt=DateTime.Now },
                new Processor { Name="Best Insurances", Description="My insurance", Street="Health Rd. 100", PostalCode="54321", Country="DE", Email="contact@bestins.de", PhoneNumber="01234-56789-0", MobilePhoneNumber="0987-6543210", CreatedAt=DateTime.Now },
                new Processor { Name="Grauwesen", Description="Myself", Street="Grey Hwy. 666", PostalCode="01001", Country="DE", Email="grauwesen@helloworld.com", PhoneNumber="01234-56789-0", MobilePhoneNumber="0987-6543210", CreatedAt=DateTime.Now }
            };

            processors.ForEach(p => context.Processors.Add(p));
            context.SaveChanges();

            var months = new List<Month>
            {
                new Month { Name="June" },
                new Month { Name="July" },
                new Month { Name="August" }
            };

            months.ForEach(m => context.Months.Add(m));
            context.SaveChanges();
        }
    }
}
