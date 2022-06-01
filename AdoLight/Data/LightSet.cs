using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdoLight.Exceptions;
using AdoLight.Core;

namespace AdoLight.Data;
public sealed class LightSet<T> : LightSetInitializer<T> where T : LightEntity 
{
}
