using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class objectField
    {

        private string nameField;

        private string typeField;

        private string valueField;


        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }


        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }


        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }


        public bool IsFieldCorrect()
        {

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(type) || String.IsNullOrEmpty(value))
            {
                return false;
            }
            else // mają nazwę, typ, wartość
            {
                if (type.ToLower().CompareTo("string") != 0 && type.ToLower().CompareTo("int") != 0) //zly typ
                {
                    return false;
                }
                else
                {
                    if (type.ToLower().CompareTo("string") == 0) //string
                    {
                        return true;
                    }
                    else//int
                    {
                        try
                        {
                            Int32.Parse(value);
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                        
                    }
                }
            }
        }

    }

}
