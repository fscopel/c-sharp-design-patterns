using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CBSNews : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("CBS News Received: " + message);
        }

    }

}