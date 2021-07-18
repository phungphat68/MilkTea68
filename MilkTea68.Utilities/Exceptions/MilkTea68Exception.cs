using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.Utilities.Exceptions
{
    public class MilkTea68Exception : Exception
    {
        public MilkTea68Exception()
        {

        }

        public MilkTea68Exception(string message)
            :base(message)
        {

        }
        public MilkTea68Exception(string message, Exception inner)
            :base (message, inner)
        {

        }
    }
}
