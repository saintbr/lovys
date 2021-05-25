using Lovys.Domain.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lovys.Infrastructure.Common.IO
{
    public static class JsonFileHelper
    {
        public static List<T> GetFile<T>() where T : IBaseModel
        {
            try
            {
                var file = File.ReadAllText($"{typeof(T).Name}.json");
                return JsonConvert.DeserializeObject<List<T>>(file);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public static void SaveJsonFile<T>(string json)
        {
            try
            {
                File.WriteAllText($"{typeof(T).Name}.json", json);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}