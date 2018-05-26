using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MidasMain
{
    public class IO_XML
    {
        public static IO_XML m_instance;
        public static IO_XML Instance
        {
            get { return m_instance ??(m_instance = new IO_XML()); }
        }
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(Document));
        
        public static void Save(string path)
        {

        }


        public static void Load(string path)
        {

        }
    }
}
