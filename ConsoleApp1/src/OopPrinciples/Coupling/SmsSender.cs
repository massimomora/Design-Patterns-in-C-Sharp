using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Coupling;

namespace ConsoleApp1.src.OopPrinciples.Coupling
{
    public class SmsSender : INotificationService
    {


        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}