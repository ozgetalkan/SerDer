using Newtonsoft.Json;
using System.IO;

namespace SerDer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi { Id=1, Ad="Ali"};

            JsonSerializer serializer = new JsonSerializer();
            StringWriter sw = new StringWriter();
            
            serializer.Serialize(sw,k1);
            Console.WriteLine(sw.ToString());
            
        }
    }
    public class Kisi
    {
        [JsonProperty()]
        public int Id { get; set; }
        public string Ad { get; set; }
    }
}