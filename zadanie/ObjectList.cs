using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class ObjectList
    {
        static List<@object> list;

        public static List<@object> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        public static void FindSerializableObjects()
        {
            List<@object> serializableList = new List<@object>();

            foreach (@object o in list)
            {
                @object newO = new @object();

                //Console.WriteLine(o.IsObjectCorrect());
                if (o.IsObjectCorrect())
                {
                    newO.obj_name = o.obj_name;
                    List<objectField> fieldList = new List<objectField>();
                    foreach (objectField f in o.field)
                    {
                        Console.WriteLine(f.IsFieldCorrect());
                        if (f.IsFieldCorrect())
                        {
                            
                            fieldList.Add(f);
                        }
                    }
                    o.field = fieldList.ToArray();
                    serializableList.Add(o);
                }
            }
        }
    }
}
