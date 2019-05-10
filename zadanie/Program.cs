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
            string startupPath = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "\\source\\input.xml");
            XmlReader.Read(startupPath);
            List<@object> newList = ObjectList.FindSerializableObjects();
            JsonSerializer.Serialize(newList);
        }
    }


   


}
