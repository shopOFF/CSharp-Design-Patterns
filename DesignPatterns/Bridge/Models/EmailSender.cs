using Bridge.Contracts;
using System;

namespace Bridge.Models
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
        }
    }
}
