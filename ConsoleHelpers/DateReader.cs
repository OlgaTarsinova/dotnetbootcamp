using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelpers
{
    class DateReader : BaseConsoleReader<DateTime>
    {
        protected override bool CheckValue(string input, out DateTime value)
        {
            return DateTime.TryParse(input, out value);
        }
    }
}
