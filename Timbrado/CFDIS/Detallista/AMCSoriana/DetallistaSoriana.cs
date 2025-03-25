using System.Xml.Serialization;

namespace Timbrado.CFDIS.Detallista.AMCSoriana
{
    public class DetallistaSoriana
    {
        // using System.Xml.Serialization;
        // XmlSerializer serializer = new XmlSerializer(typeof(Root));
        // using (StringReader reader = new StringReader(xml))
        // {
        //    var test = (Root)serializer.Deserialize(reader);
        // }

        [XmlRoot(ElementName = "Remision")]
        public class RemisionCls
        {

            [XmlElement(ElementName = "Proveedor")]
            public string Proveedor;

            [XmlElement(ElementName = "Remision")]
            public string Remision;

            [XmlElement(ElementName = "Consecutivo")]
            public string Consecutivo;

            [XmlElement(ElementName = "FechaRemision")]
            public string FechaRemision;

            [XmlElement(ElementName = "Tienda")]
            public string Tienda;

            [XmlElement(ElementName = "TipoMoneda")]
            public string TipoMoneda;

            [XmlElement(ElementName = "TipoBulto")]
            public string TipoBulto;

            [XmlElement(ElementName = "EntregaMercancia")]
            public string EntregaMercancia;

            [XmlElement(ElementName = "CumpleReqFiscales")]
            public string CumpleReqFiscales;

            [XmlElement(ElementName = "CantidadBultos")]
            public string CantidadBultos;

            [XmlElement(ElementName = "Subtotal")]
            public string Subtotal;

            [XmlElement(ElementName = "Descuentos")]
            public string Descuentos;

            [XmlElement(ElementName = "IEPS")]
            public string IEPS;

            [XmlElement(ElementName = "IVA")]
            public string IVA;

            [XmlElement(ElementName = "OtrosImpuestos")]
            public string OtrosImpuestos;

            [XmlElement(ElementName = "Total")]
            public string Total;

            [XmlElement(ElementName = "CantidadPedidos")]
            public string CantidadPedidos;

            [XmlElement(ElementName = "FechaEntregaMercancia")]
            public string FechaEntregaMercancia;

            [XmlElement(ElementName = "Cita")]
            public string Cita;

            [XmlAttribute(AttributeName = "Id")]
            public string Id;

            [XmlAttribute(AttributeName = "RowOrder")]
            public string RowOrder;

            [XmlText]
            public string Text;
        }

        [XmlRoot(ElementName = "Pedidos")]
        public class Pedidos
        {

            [XmlElement(ElementName = "Proveedor")]
            public string Proveedor;

            [XmlElement(ElementName = "Remision")]
            public string Remision;

            [XmlElement(ElementName = "FolioPedido")]
            public string FolioPedido;

            [XmlElement(ElementName = "Tienda")]
            public string Tienda;

            [XmlElement(ElementName = "CantidadArticulos")]
            public string CantidadArticulos;

            [XmlAttribute(AttributeName = "Id")]
            public string Id;

            [XmlAttribute(AttributeName = "RowOrder")]
            public string RowOrder;

            [XmlText]
            public string Text;
        }

        [XmlRoot(ElementName = "Articulos")]
        public class Articulos
        {

            [XmlElement(ElementName = "Proveedor")]
            public string Proveedor;

            [XmlElement(ElementName = "Remision")]
            public string Remision;

            [XmlElement(ElementName = "FolioPedido")]
            public string FolioPedido;

            [XmlElement(ElementName = "Tienda")]
            public string Tienda;

            [XmlElement(ElementName = "Codigo")]
            public string Codigo;

            [XmlElement(ElementName = "CantidadUnidadCompra")]
            public string CantidadUnidadCompra;

            [XmlElement(ElementName = "CostoNetoUnidadCompra")]
            public string CostoNetoUnidadCompra;

            [XmlElement(ElementName = "PorcentajeIEPS")]
            public string PorcentajeIEPS;

            [XmlElement(ElementName = "PorcentajeIVA")]
            public string PorcentajeIVA;

            [XmlAttribute(AttributeName = "Id")]
            public string Id;

            [XmlAttribute(AttributeName = "RowOrder")]
            public string RowOrder;

            [XmlText]
            public string Text;
        }

        [XmlRoot(ElementName = "DSCargaRemisionProv")]
        public class DSCargaRemisionProv
        {

            [XmlElement(ElementName = "Remision")]
            public RemisionCls Remision;

            [XmlElement(ElementName = "Pedidos")]
            public Pedidos Pedidos;

            [XmlElement(ElementName = "Articulos")]
            public Articulos Articulos;
        }

        [XmlRoot(ElementName = "Addenda")]
        public class Addenda
        {

            [XmlElement(ElementName = "DSCargaRemisionProv")]
            public DSCargaRemisionProv DSCargaRemisionProv;
        }

        [XmlRoot(ElementName = "Root")]
        public class Root
        {

            [XmlElement(ElementName = "Addenda")]
            public Addenda Addenda;

            [XmlAttribute(AttributeName = "cfdi")]
            public string Cfdi;

            [XmlText]
            public string Text;
        }


    }
}
