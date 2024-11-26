using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Productosv2
{
    public class GestionProducto
    {
        private const string archivoXml = "productos.xml";

        public void GuardarProductos(List<Producto> productos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
            using (StreamWriter writer = new StreamWriter(archivoXml))
            {
                serializer.Serialize(writer, productos);
            }
        }

        public List<Producto> LeerProductos()
        {
            if (!File.Exists(archivoXml))
                return new List<Producto>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Producto>));
            using (StreamReader reader = new StreamReader(archivoXml))
            {
                return (List<Producto>)serializer.Deserialize(reader);
            }
        }
    }
}
