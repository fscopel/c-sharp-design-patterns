using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class RadioStation : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Radio Station Recieved: " + message);
        }

    }
}
