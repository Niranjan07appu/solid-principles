using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class InvoiceAntiSRP
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }

        public decimal CalculateTotal()
        {
            // Logic to calculate total
            return Amount * 1.18m; // includes tax
        }

        public void SaveToDatabase()
        {
            // Logic to save invoice to DB
        }

        public void SendEmail()
        {
            // Logic to send invoice email
        }
    }

}
