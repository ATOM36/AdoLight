using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoLight.Interfaces;
internal interface ILightReader
{

    //******************** BASIC  READ FUNCTIONS **********************


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    T ReadFirst<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    Task<T> ReadFirstAsync<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    T ReadLast<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    Task<T> ReadLastAsync<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <param name="offset"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    IEnumerable<T> ReadRange<T>(string table, int offset, int size);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <param name="offset"></param>
    /// <param name="size"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> ReadRangeAsync<T>(string table, int offset, int size);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    IEnumerable<T> Read<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    IEnumerable<T> Read<T>(string table, params string[] columns);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> ReadAllAsync<T>(string table);


    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="table"></param>
    /// <param name="columns"></param>
    /// <returns></returns>
    Task<IEnumerable<T>> ReadAllAsync<T>(string table, params string[] columns);

}
