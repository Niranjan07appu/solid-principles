using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal Amount { get; set; }

        public decimal CalculateTotal()
        {
            // Logic to calculate total
            return Amount * 1.18m; // includes tax
        }
    }

    public class DatabaseUtility
    {
        public void OpenConnection()
        {
            Console.WriteLine("Connection is open");
        }

        public void SaveToDatabase()
        {
            Console.WriteLine("Invoice saved into database");
        }

    }

    public class EmailService
    {
        public string Email { get; set; } = string.Empty;
        public void ConfigureEmail(string email)
        {
            Console.WriteLine($"Email configured for this email: {email}");
        }
        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }
    }
}
