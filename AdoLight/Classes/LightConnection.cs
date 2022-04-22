using AdoLight.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLight.Classes;
public class LightConnection<T> : ILightConnection<T> where T : DbConnection
{
}
