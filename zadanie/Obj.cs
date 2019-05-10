using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class @object
    {

        private string obj_nameField;

        private objectField[] fieldField;

        /// <remarks/>
        public string obj_name
        {
            get
            {
                return this.obj_nameField;
            }
            set
            {
                this.obj_nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("field")]
        public objectField[] field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }

        public bool IsObjectCorrect()
        {
            if (String.IsNullOrEmpty(obj_name)) //nie ma nazwy
            {
                return false;
            }
            else//ma nazwe
            {
                if (field.Count() >= 1)//ma jedno pole lub wiecej
                {
                    return true;
                }
                else//ma mniej niz jedno pole
                    return false;
            }
        }
    }
}
