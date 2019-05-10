using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace zadanie
{
    class JsonSerializer
    {

        static public void Serialize(List<@object> list)
        {
            
            File.WriteAllText(@"c:\source\data.json", CreateJsonString(list));
           
        }
        static public string CreateJsonString(List<@object> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("{");
           
            for(int j=0;j<list.Count();j++)
            {
                
                sb.AppendLine("\"" + list.ElementAt(j).obj_name + "\":{");
                
                for(int i=0; i<(list.ElementAt(j).field.Count());i++)
                {
                    sb.AppendLine("\"" + list.ElementAt(j).field.ElementAt(i).name + "\":");
                    if (list.ElementAt(j).field.ElementAt(i).type.ToLower().CompareTo("int") == 0)
                    {
                        sb.Append(list.ElementAt(j).field.ElementAt(i).value);
                    }
                    else
                    {
                        sb.Append("\"" + list.ElementAt(j).field.ElementAt(i).value + "\"");
                    }


                    if (i != list.ElementAt(j).field.Count() - 1)
                    {
                        sb.Append(",");
                    }
                    else
                        sb.AppendLine("}");

                   
                }
                if (j != list.Count - 1)
                {
                    sb.Append(",");
                }

            }
            sb.AppendLine("}");

            return sb.ToString();
        }

    }
}
