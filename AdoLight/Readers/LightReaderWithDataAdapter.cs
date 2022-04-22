using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLight.Readers;
public sealed class LightAdapterReader<TConnection, TCommand, TDataAdapter>
    where TConnection : DbConnection
    where TCommand : DbCommand
    where TDataAdapter : DbDataAdapter
{

}
