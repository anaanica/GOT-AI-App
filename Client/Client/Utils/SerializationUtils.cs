using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Client.Utils
{
    public class SerializationUtils
    {
        public static byte[] SerializeObjectToBytes<T>(T obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                using (XmlWriter xmlWriter = XmlWriter.Create(stream))
                {
                    serializer.WriteObject(xmlWriter, obj);
                }
                return stream.ToArray();
            }

        }
    }
}
