using AdoLight.Classes;
using AdoLight.Exceptions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;

namespace AdoLight.Core;
public abstract class LightSetInitializer<T> where T : LightEntity
{
    /// <summary>
    /// The table that will hold all of out entities.
    /// </summary>
    protected DataTable? table;

    /// <summary>
    /// The <typeparamref name="T"/>'s table schema holder.
    /// </summary>
    protected Dictionary<string, Type> schema = new Dictionary<string, Type>();

    /// <summary>
    /// The  <typeparamref name="T"/>'s table key's name.
    /// </summary>
    protected string? keyName;


    /// <summary>
    /// Reads the <typeparamref name="T"/> schema and stores it in the <see cref="schema"/> property.
    /// </summary>
    /// <exception cref="NotDefinedColumn"></exception>
    private void GetSchema()
    {
        PropertyInfo[] props = typeof(T).GetProperties();
        foreach (PropertyInfo prop in props)
        {
            // Reading the class' attributes
            foreach (Attribute attr in prop.GetCustomAttributes(true))
            {
                if (attr is ColumnAttribute)
                {
                    ColumnAttribute columnAttribute = (ColumnAttribute)attr;

                    if (columnAttribute.Name is null)
                        throw new NotDefinedColumn($"The property {prop.Name} doesn't have a defined name for its Column attribute");
                    else
                        schema.TryAdd(columnAttribute.Name, prop.PropertyType);
                }
            }
        }
    }
}

public abstract class LightSetInitializer
{
}