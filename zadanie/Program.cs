using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string basePath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            string path = basePath+ @"\source\input.xml";
            string localPath = new Uri(path).LocalPath;
            XmlReader.Read(localPath);
            List<@object> newList = ObjectList.FindSerializableObjects();
            JsonSerializer.Serialize(basePath,newList);
        }
    }


   


}
