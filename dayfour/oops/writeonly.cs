using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    class Client
    {
        private int _clientId;
        private string _clientName;
        private double _amountDue;

        public int ClientId { set { _clientId = value; } }
        public string ClientName { set { _clientName = value; } }
        public double AmountDue { set { _amountDue = value; } }

        public override string ToString()
        {
            return $"Client ID: {_clientId}, Name: {_clientName}, Amount Due: {_amountDue}";
        }
    }

    internal class WriteOnlyPropertyDemo
    {
        static void Main()
        {
            Client client = new Client();
            client.ClientId = 1;
            client.ClientName = "Client A";
            client.AmountDue = 87773.23;

            Console.WriteLine(client);
        }
    }
}