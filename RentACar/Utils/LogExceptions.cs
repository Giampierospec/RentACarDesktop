using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Utils
{
    public static class LogExceptions
    {
        /// <summary>
        /// Guarda la excepcion en un JSON
        /// </summary>
        /// <param name="ex"></param>
        public static void LogToJsonFile(Exception ex)
        {
            string path = $@"C:\Users\Public\Logs\{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            var exList = new List<Exception>();
            path += $@"\{DateTime.Now.ToString("dd-MM-yyyy")}.json";
            if (File.Exists(path))
                exList = JsonConvert.DeserializeObject<List<Exception>>(path);
            exList.Add(ex);
            File.WriteAllText(path, JsonConvert.SerializeObject(exList));
        }
    }
}
