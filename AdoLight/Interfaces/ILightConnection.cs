﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLight.Interfaces;
internal interface ILightConnection<T> where T : DbConnection
{
}
