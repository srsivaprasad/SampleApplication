using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRISTest
{
    public class Task3
    {
        #region SerializeContactsToJson 
        /// <summary>
        /// Methode to Serialize Contact object
        /// </summary>
        /// <param name="contacts"></param>
        /// <param name="filePath"></param>
        public static void SerializeContactsToJson(List<Contact> contacts, string filePath)
        {
            string contactStr = JsonConvert.SerializeObject(contacts);
            var result = SaveFile(contactStr, filePath);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Methode to save the data to specified path
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string SaveFile(string data, string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    StreamWriter file = new StreamWriter(filePath);
                    file.WriteLine(data);
                    file.Close();
                    return "File saved";
                }
                else
                {
                    File.Create(filePath);
                    TextWriter tw = new StreamWriter(filePath);
                    tw.WriteLine(data);
                    tw.Close();
                    return "File created and saved";
                }
            }
            catch (Exception)
            {
                {
                    return "File Not Created due to error";
                }
            }
        }
        #endregion

    }
    public class Contact
    {
        public int id { get; set; }
        public string Data { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
