using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal sealed class ThereCanBeOnlyOne
    {
        private static volatile ThereCanBeOnlyOne? _instance;
        private static readonly object _lock = new object();

        private ThereCanBeOnlyOne() { }

        public static ThereCanBeOnlyOne Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new ThereCanBeOnlyOne();
                }

                return _instance;

            }
        }

        public int Value { get; set; }


    }
}
