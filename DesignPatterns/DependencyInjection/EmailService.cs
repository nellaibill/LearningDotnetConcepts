using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DependencyInjection
{
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            // Logic to send an email
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
