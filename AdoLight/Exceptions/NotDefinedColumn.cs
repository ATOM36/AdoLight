using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLight.Exceptions;
public sealed class NotDefinedColumn : Exception
{
    public NotDefinedColumn(string message) : base(message)
    {
    }
}
