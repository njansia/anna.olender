using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace zadanie
{
    class XmlReader
    {

        public static void Read(string path)
        {
            ObjectList.List = new List<@object>();
           
            using (var reader = new StreamReader(path))
            {
                XmlSerializer deser = new XmlSerializer(typeof(List<@object>), new XmlRootAttribute("objects"));
                ObjectList.List = (List<@object>)deser.Deserialize(reader);
            }

            Console.Write(ObjectList.List.Count);
        }

    }
}
