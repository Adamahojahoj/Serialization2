using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Serialization2.Serializer
{
    public class Serializer<T> where T : class
    {
        private JsonSerializerOptions _options;

        public Serializer()
        {
            _options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(
                    UnicodeRanges.BasicLatin,
                    UnicodeRanges.Latin1Supplement,
                    UnicodeRanges.LatinExtendedA
                ),
                WriteIndented = true
            };
        }

        public bool Serialize(in T inputData, string path = "Data.json")
        {
            try
            {
                string json = JsonSerializer.Serialize(inputData);
                using var stream = new StreamWriter(path);
                stream.Write(json);
                stream.Flush();
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }



        public bool Serialize(IList<T> collection, string path = "Data.json")
        {
            try
            {
                string json = JsonSerializer.Serialize(collection,_options);
                using var stream = new StreamWriter(path);
                stream.Write(json);
                stream.Flush();
                stream.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        
        public T Deserialize(string path="Data.json")
        {
            using var stream = new StreamReader(path);
            string json = stream.ReadToEnd();
            return JsonSerializer.Deserialize<T>(json);
        }
        public IList<T>? DeserializeCollection(string path = "Data.json")
        {
            using var stream = new StreamReader(path);
            string json = stream.ReadToEnd();
            return JsonSerializer.Deserialize<List<T>>(json);
        }
    }
}
