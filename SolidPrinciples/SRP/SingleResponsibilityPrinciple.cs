using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    internal class SingleResponsibilityPrinciple
    {
        /*
          Concept: Invoice Processing System
            Let's say you're building a system to handle invoice processing. The system has to:

            Create invoice details.

            Calculate the total amount.

            Save the invoice to a database.

            Send the invoice via email.
         */

        public void ExecuteSRP()
        {
            var invoice = new Invoice { Id = 1, Customer = "Alice", Amount = 1000 };
            Console.WriteLine($"Total: {invoice.CalculateTotal()}");

            var db = new DatabaseUtility();
            db.OpenConnection();
            db.SaveToDatabase();

            var emailService = new EmailService();
            emailService.ConfigureEmail("alice@example.com");
            emailService.SendEmail();
        }
    }
}
