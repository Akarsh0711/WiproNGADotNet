using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayFour.ObjectOriented
{
    interface IServiceAlpha
    {
        void DisplayServiceInfo();
    }

    interface IServiceBeta
    {
        void DisplayServiceInfo();
    }

    interface IServiceGamma
    {
        void DisplayServiceInfo();
    }

    class ServiceProvider : IServiceAlpha, IServiceBeta, IServiceGamma
    {
        void IServiceAlpha.DisplayServiceInfo()
        {
            Console.WriteLine("Service Info from Alpha...");
        }

        void IServiceBeta.DisplayServiceInfo()
        {
            Console.WriteLine("Service Info From Beta...");
        }

        void IServiceGamma.DisplayServiceInfo()
        {
            Console.WriteLine("Service Info From Gamma...");
        }
    }
    internal class ExplicitInterfaceDemo
    {
        static void Main()
        {
            IServiceAlpha service1 = new ServiceProvider();
            IServiceBeta service2 = new ServiceProvider();
            IServiceGamma service3 = new ServiceProvider();

            service1.DisplayServiceInfo();
            service2.DisplayServiceInfo();
            service3.DisplayServiceInfo();
        }
    }
}
