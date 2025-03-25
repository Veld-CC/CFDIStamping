using System.Text;

namespace Timbrado.CFDIS.Utils
{
    public class StringWriterWithEncoding : StringWriter
    {
        private readonly Encoding m_Enconding;

        public StringWriterWithEncoding(Encoding encoding)
            : base()
        {
            m_Enconding = encoding;
        }

        public override Encoding Encoding
        {
            get
            {
                return m_Enconding;
            }
        }
    }
}
