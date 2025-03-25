using System.Xml.Serialization;

namespace Timbrado.CFDIS.CartaPorte._30
{

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	[XmlRoot(Namespace = "http://www.sat.gob.mx/CartaPorte30", IsNullable = false)]
	public partial class CartaPorte
	{

		private CartaPorteUbicacion[] ubicacionesField;

		private CartaPorteMercancias mercanciasField;

		private CartaPorteTiposFigura[] figuraTransporteField;

		private string versionField;

		private string idCCPField;

		private CartaPorteTranspInternac transpInternacField;

		private string regimenAduaneroField;

		private bool regimenAduaneroFieldSpecified;

		private CartaPorteEntradaSalidaMerc entradaSalidaMercField;

		private bool entradaSalidaMercFieldSpecified;

		private string paisOrigenDestinoField;

		private bool paisOrigenDestinoFieldSpecified;

		private string viaEntradaSalidaField;

		private bool viaEntradaSalidaFieldSpecified;

		private decimal totalDistRecField;

		private bool totalDistRecFieldSpecified;

		private CartaPorteRegistroISTMO registroISTMOField;

		private bool registroISTMOFieldSpecified;

		private string ubicacionPoloOrigenField;

		private bool ubicacionPoloOrigenFieldSpecified;

		private string ubicacionPoloDestinoField;

		private bool ubicacionPoloDestinoFieldSpecified;

		public CartaPorte()
		{
			this.versionField = "3.0";
		}

		/// <remarks/>
		[XmlArrayItem("Ubicacion", IsNullable = false)]
		public CartaPorteUbicacion[] Ubicaciones
		{
			get { return this.ubicacionesField; }
			set { this.ubicacionesField = value; }
		}

		/// <remarks/>
		public CartaPorteMercancias Mercancias
		{
			get { return this.mercanciasField; }
			set { this.mercanciasField = value; }
		}

		/// <remarks/>
		[XmlArrayItem("TiposFigura", IsNullable = false)]
		public CartaPorteTiposFigura[] FiguraTransporte
		{
			get { return this.figuraTransporteField; }
			set { this.figuraTransporteField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Version
		{
			get { return this.versionField; }
			set { this.versionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IdCCP
		{
			get { return this.idCCPField; }
			set { this.idCCPField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteTranspInternac TranspInternac
		{
			get { return this.transpInternacField; }
			set { this.transpInternacField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RegimenAduanero
		{
			get { return this.regimenAduaneroField; }
			set { this.regimenAduaneroField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool RegimenAduaneroSpecified
		{
			get { return this.regimenAduaneroFieldSpecified; }
			set { this.regimenAduaneroFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteEntradaSalidaMerc EntradaSalidaMerc
		{
			get { return this.entradaSalidaMercField; }
			set { this.entradaSalidaMercField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool EntradaSalidaMercSpecified
		{
			get { return this.entradaSalidaMercFieldSpecified; }
			set { this.entradaSalidaMercFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PaisOrigenDestino
		{
			get { return this.paisOrigenDestinoField; }
			set { this.paisOrigenDestinoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool PaisOrigenDestinoSpecified
		{
			get { return this.paisOrigenDestinoFieldSpecified; }
			set { this.paisOrigenDestinoFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ViaEntradaSalida
		{
			get { return this.viaEntradaSalidaField; }
			set { this.viaEntradaSalidaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool ViaEntradaSalidaSpecified
		{
			get { return this.viaEntradaSalidaFieldSpecified; }
			set { this.viaEntradaSalidaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal TotalDistRec
		{
			get { return this.totalDistRecField; }
			set { this.totalDistRecField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool TotalDistRecSpecified
		{
			get { return this.totalDistRecFieldSpecified; }
			set { this.totalDistRecFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteRegistroISTMO RegistroISTMO
		{
			get { return this.registroISTMOField; }
			set { this.registroISTMOField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool RegistroISTMOSpecified
		{
			get { return this.registroISTMOFieldSpecified; }
			set { this.registroISTMOFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string UbicacionPoloOrigen
		{
			get { return this.ubicacionPoloOrigenField; }
			set { this.ubicacionPoloOrigenField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool UbicacionPoloOrigenSpecified
		{
			get { return this.ubicacionPoloOrigenFieldSpecified; }
			set { this.ubicacionPoloOrigenFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string UbicacionPoloDestino
		{
			get { return this.ubicacionPoloDestinoField; }
			set { this.ubicacionPoloDestinoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool UbicacionPoloDestinoSpecified
		{
			get { return this.ubicacionPoloDestinoFieldSpecified; }
			set { this.ubicacionPoloDestinoFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteUbicacion
	{

		private CartaPorteUbicacionDomicilio domicilioField;

		private CartaPorteUbicacionTipoUbicacion tipoUbicacionField;

		private string iDUbicacionField;

		private string rFCRemitenteDestinatarioField;

		private string nombreRemitenteDestinatarioField;

		private string numRegIdTribField;

		private string residenciaFiscalField;

		private bool residenciaFiscalFieldSpecified;

		private string numEstacionField;

		private bool numEstacionFieldSpecified;

		private string nombreEstacionField;

		private CartaPorteUbicacionNavegacionTrafico navegacionTraficoField;

		private bool navegacionTraficoFieldSpecified;

		private string fechaHoraSalidaLlegadaField;

		private string tipoEstacionField;

		private bool tipoEstacionFieldSpecified;

		private decimal distanciaRecorridaField;

		private bool distanciaRecorridaFieldSpecified;

		/// <remarks/>
		public CartaPorteUbicacionDomicilio Domicilio
		{
			get { return this.domicilioField; }
			set { this.domicilioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteUbicacionTipoUbicacion TipoUbicacion
		{
			get { return this.tipoUbicacionField; }
			set { this.tipoUbicacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IDUbicacion
		{
			get { return this.iDUbicacionField; }
			set { this.iDUbicacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RFCRemitenteDestinatario
		{
			get { return this.rFCRemitenteDestinatarioField; }
			set { this.rFCRemitenteDestinatarioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreRemitenteDestinatario
		{
			get { return this.nombreRemitenteDestinatarioField; }
			set { this.nombreRemitenteDestinatarioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumRegIdTrib
		{
			get { return this.numRegIdTribField; }
			set { this.numRegIdTribField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ResidenciaFiscal
		{
			get { return this.residenciaFiscalField; }
			set { this.residenciaFiscalField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool ResidenciaFiscalSpecified
		{
			get { return this.residenciaFiscalFieldSpecified; }
			set { this.residenciaFiscalFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumEstacion
		{
			get { return this.numEstacionField; }
			set { this.numEstacionField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool NumEstacionSpecified
		{
			get { return this.numEstacionFieldSpecified; }
			set { this.numEstacionFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreEstacion
		{
			get { return this.nombreEstacionField; }
			set { this.nombreEstacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteUbicacionNavegacionTrafico NavegacionTrafico
		{
			get { return this.navegacionTraficoField; }
			set { this.navegacionTraficoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool NavegacionTraficoSpecified
		{
			get { return this.navegacionTraficoFieldSpecified; }
			set { this.navegacionTraficoFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string FechaHoraSalidaLlegada
		{
			get { return this.fechaHoraSalidaLlegadaField; }
			set { this.fechaHoraSalidaLlegadaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoEstacion
		{
			get { return this.tipoEstacionField; }
			set { this.tipoEstacionField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool TipoEstacionSpecified
		{
			get { return this.tipoEstacionFieldSpecified; }
			set { this.tipoEstacionFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal DistanciaRecorrida
		{
			get { return this.distanciaRecorridaField; }
			set { this.distanciaRecorridaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool DistanciaRecorridaSpecified
		{
			get { return this.distanciaRecorridaFieldSpecified; }
			set { this.distanciaRecorridaFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteUbicacionDomicilio
	{

		private string calleField;

		private string numeroExteriorField;

		private string numeroInteriorField;

		private string coloniaField;

		private string localidadField;

		private string referenciaField;

		private string municipioField;

		private string estadoField;

		private string paisField;

		private string codigoPostalField;

		/// <remarks/>
		[XmlAttribute()]
		public string Calle
		{
			get { return this.calleField; }
			set { this.calleField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroExterior
		{
			get { return this.numeroExteriorField; }
			set { this.numeroExteriorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroInterior
		{
			get { return this.numeroInteriorField; }
			set { this.numeroInteriorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Colonia
		{
			get { return this.coloniaField; }
			set { this.coloniaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Localidad
		{
			get { return this.localidadField; }
			set { this.localidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Referencia
		{
			get { return this.referenciaField; }
			set { this.referenciaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Municipio
		{
			get { return this.municipioField; }
			set { this.municipioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Estado
		{
			get { return this.estadoField; }
			set { this.estadoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Pais
		{
			get { return this.paisField; }
			set { this.paisField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CodigoPostal
		{
			get { return this.codigoPostalField; }
			set { this.codigoPostalField = value; }
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteUbicacionTipoUbicacion
	{

		/// <remarks/>
		Origen,

		/// <remarks/>
		Destino,
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteUbicacionNavegacionTrafico
	{

		/// <remarks/>
		Altura,

		/// <remarks/>
		Cabotaje,
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercancias
	{

		private CartaPorteMercanciasMercancia[] mercanciaField;

		private CartaPorteMercanciasAutotransporte autotransporteField;

		private CartaPorteMercanciasTransporteMaritimo transporteMaritimoField;

		private CartaPorteMercanciasTransporteAereo transporteAereoField;

		private CartaPorteMercanciasTransporteFerroviario transporteFerroviarioField;

		private decimal pesoBrutoTotalField;

		private string unidadPesoField;

		private decimal pesoNetoTotalField;

		private bool pesoNetoTotalFieldSpecified;

		private int numTotalMercanciasField;

		private decimal cargoPorTasacionField;

		private bool cargoPorTasacionFieldSpecified;

		private CartaPorteMercanciasLogisticaInversaRecoleccionDevolucion logisticaInversaRecoleccionDevolucionField;

		private bool logisticaInversaRecoleccionDevolucionFieldSpecified;

		/// <remarks/>
		[XmlElement("Mercancia")]
		public CartaPorteMercanciasMercancia[] Mercancia
		{
			get { return this.mercanciaField; }
			set { this.mercanciaField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasAutotransporte Autotransporte
		{
			get { return this.autotransporteField; }
			set { this.autotransporteField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasTransporteMaritimo TransporteMaritimo
		{
			get { return this.transporteMaritimoField; }
			set { this.transporteMaritimoField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasTransporteAereo TransporteAereo
		{
			get { return this.transporteAereoField; }
			set { this.transporteAereoField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasTransporteFerroviario TransporteFerroviario
		{
			get { return this.transporteFerroviarioField; }
			set { this.transporteFerroviarioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoBrutoTotal
		{
			get { return this.pesoBrutoTotalField; }
			set { this.pesoBrutoTotalField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string UnidadPeso
		{
			get { return this.unidadPesoField; }
			set { this.unidadPesoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoNetoTotal
		{
			get { return this.pesoNetoTotalField; }
			set { this.pesoNetoTotalField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool PesoNetoTotalSpecified
		{
			get { return this.pesoNetoTotalFieldSpecified; }
			set { this.pesoNetoTotalFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public int NumTotalMercancias
		{
			get { return this.numTotalMercanciasField; }
			set { this.numTotalMercanciasField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal CargoPorTasacion
		{
			get { return this.cargoPorTasacionField; }
			set { this.cargoPorTasacionField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool CargoPorTasacionSpecified
		{
			get { return this.cargoPorTasacionFieldSpecified; }
			set { this.cargoPorTasacionFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteMercanciasLogisticaInversaRecoleccionDevolucion LogisticaInversaRecoleccionDevolucion
		{
			get { return this.logisticaInversaRecoleccionDevolucionField; }
			set { this.logisticaInversaRecoleccionDevolucionField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool LogisticaInversaRecoleccionDevolucionSpecified
		{
			get { return this.logisticaInversaRecoleccionDevolucionFieldSpecified; }
			set { this.logisticaInversaRecoleccionDevolucionFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasMercancia
	{

		private CartaPorteMercanciasMercanciaDocumentacionAduanera[] documentacionAduaneraField;

		private CartaPorteMercanciasMercanciaGuiasIdentificacion[] guiasIdentificacionField;

		private CartaPorteMercanciasMercanciaCantidadTransporta[] cantidadTransportaField;

		private CartaPorteMercanciasMercanciaDetalleMercancia detalleMercanciaField;

		private string bienesTranspField;

		private string claveSTCCField;

		private string descripcionField;

		private decimal cantidadField;

		private string claveUnidadField;

		private string unidadField;

		private string dimensionesField;

		private CartaPorteMercanciasMercanciaMaterialPeligroso materialPeligrosoField;

		private bool materialPeligrosoFieldSpecified;

		private string cveMaterialPeligrosoField;

		private bool cveMaterialPeligrosoFieldSpecified;

		private string embalajeField;

		private bool embalajeFieldSpecified;

		private string descripEmbalajeField;

		private string sectorCOFEPRISField;

		private bool sectorCOFEPRISFieldSpecified;

		private string nombreIngredienteActivoField;

		private string nomQuimicoField;

		private string denominacionGenericaProdField;

		private string denominacionDistintivaProdField;

		private string fabricanteField;

		private System.DateTime fechaCaducidadField;

		private bool fechaCaducidadFieldSpecified;

		private string loteMedicamentoField;

		private string formaFarmaceuticaField;

		private bool formaFarmaceuticaFieldSpecified;

		private string condicionesEspTranspField;

		private bool condicionesEspTranspFieldSpecified;

		private string registroSanitarioFolioAutorizacionField;

		private string permisoImportacionField;

		private string folioImpoVUCEMField;

		private string numCASField;

		private string razonSocialEmpImpField;

		private string numRegSanPlagCOFEPRISField;

		private string datosFabricanteField;

		private string datosFormuladorField;

		private string datosMaquiladorField;

		private string usoAutorizadoField;

		private decimal pesoEnKgField;

		private decimal valorMercanciaField;

		private bool valorMercanciaFieldSpecified;

		private string monedaField;

		private bool monedaFieldSpecified;

		private string fraccionArancelariaField;

		private bool fraccionArancelariaFieldSpecified;

		private string uUIDComercioExtField;

		private string tipoMateriaField;

		private bool tipoMateriaFieldSpecified;

		private string descripcionMateriaField;

		/// <remarks/>
		[XmlElement("DocumentacionAduanera")]
		public CartaPorteMercanciasMercanciaDocumentacionAduanera[] DocumentacionAduanera
		{
			get { return this.documentacionAduaneraField; }
			set { this.documentacionAduaneraField = value; }
		}

		/// <remarks/>
		[XmlElement("GuiasIdentificacion")]
		public CartaPorteMercanciasMercanciaGuiasIdentificacion[] GuiasIdentificacion
		{
			get { return this.guiasIdentificacionField; }
			set { this.guiasIdentificacionField = value; }
		}

		/// <remarks/>
		[XmlElement("CantidadTransporta")]
		public CartaPorteMercanciasMercanciaCantidadTransporta[] CantidadTransporta
		{
			get { return this.cantidadTransportaField; }
			set { this.cantidadTransportaField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasMercanciaDetalleMercancia DetalleMercancia
		{
			get { return this.detalleMercanciaField; }
			set { this.detalleMercanciaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string BienesTransp
		{
			get { return this.bienesTranspField; }
			set { this.bienesTranspField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ClaveSTCC
		{
			get { return this.claveSTCCField; }
			set { this.claveSTCCField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Descripcion
		{
			get { return this.descripcionField; }
			set { this.descripcionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal Cantidad
		{
			get { return this.cantidadField; }
			set { this.cantidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ClaveUnidad
		{
			get { return this.claveUnidadField; }
			set { this.claveUnidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Unidad
		{
			get { return this.unidadField; }
			set { this.unidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Dimensiones
		{
			get { return this.dimensionesField; }
			set { this.dimensionesField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public CartaPorteMercanciasMercanciaMaterialPeligroso MaterialPeligroso
		{
			get { return this.materialPeligrosoField; }
			set { this.materialPeligrosoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool MaterialPeligrosoSpecified
		{
			get { return this.materialPeligrosoFieldSpecified; }
			set { this.materialPeligrosoFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CveMaterialPeligroso
		{
			get { return this.cveMaterialPeligrosoField; }
			set { this.cveMaterialPeligrosoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool CveMaterialPeligrosoSpecified
		{
			get { return this.cveMaterialPeligrosoFieldSpecified; }
			set { this.cveMaterialPeligrosoFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Embalaje
		{
			get { return this.embalajeField; }
			set { this.embalajeField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool EmbalajeSpecified
		{
			get { return this.embalajeFieldSpecified; }
			set { this.embalajeFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DescripEmbalaje
		{
			get { return this.descripEmbalajeField; }
			set { this.descripEmbalajeField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string SectorCOFEPRIS
		{
			get { return this.sectorCOFEPRISField; }
			set { this.sectorCOFEPRISField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool SectorCOFEPRISSpecified
		{
			get { return this.sectorCOFEPRISFieldSpecified; }
			set { this.sectorCOFEPRISFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreIngredienteActivo
		{
			get { return this.nombreIngredienteActivoField; }
			set { this.nombreIngredienteActivoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NomQuimico
		{
			get { return this.nomQuimicoField; }
			set { this.nomQuimicoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DenominacionGenericaProd
		{
			get { return this.denominacionGenericaProdField; }
			set { this.denominacionGenericaProdField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DenominacionDistintivaProd
		{
			get { return this.denominacionDistintivaProdField; }
			set { this.denominacionDistintivaProdField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Fabricante
		{
			get { return this.fabricanteField; }
			set { this.fabricanteField = value; }
		}

		/// <remarks/>
		[XmlAttribute(DataType = "date")]
		public System.DateTime FechaCaducidad
		{
			get { return this.fechaCaducidadField; }
			set { this.fechaCaducidadField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool FechaCaducidadSpecified
		{
			get { return this.fechaCaducidadFieldSpecified; }
			set { this.fechaCaducidadFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string LoteMedicamento
		{
			get { return this.loteMedicamentoField; }
			set { this.loteMedicamentoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string FormaFarmaceutica
		{
			get { return this.formaFarmaceuticaField; }
			set { this.formaFarmaceuticaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool FormaFarmaceuticaSpecified
		{
			get { return this.formaFarmaceuticaFieldSpecified; }
			set { this.formaFarmaceuticaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CondicionesEspTransp
		{
			get { return this.condicionesEspTranspField; }
			set { this.condicionesEspTranspField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool CondicionesEspTranspSpecified
		{
			get { return this.condicionesEspTranspFieldSpecified; }
			set { this.condicionesEspTranspFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RegistroSanitarioFolioAutorizacion
		{
			get { return this.registroSanitarioFolioAutorizacionField; }
			set { this.registroSanitarioFolioAutorizacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PermisoImportacion
		{
			get { return this.permisoImportacionField; }
			set { this.permisoImportacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string FolioImpoVUCEM
		{
			get { return this.folioImpoVUCEMField; }
			set { this.folioImpoVUCEMField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumCAS
		{
			get { return this.numCASField; }
			set { this.numCASField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RazonSocialEmpImp
		{
			get { return this.razonSocialEmpImpField; }
			set { this.razonSocialEmpImpField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumRegSanPlagCOFEPRIS
		{
			get { return this.numRegSanPlagCOFEPRISField; }
			set { this.numRegSanPlagCOFEPRISField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DatosFabricante
		{
			get { return this.datosFabricanteField; }
			set { this.datosFabricanteField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DatosFormulador
		{
			get { return this.datosFormuladorField; }
			set { this.datosFormuladorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DatosMaquilador
		{
			get { return this.datosMaquiladorField; }
			set { this.datosMaquiladorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string UsoAutorizado
		{
			get { return this.usoAutorizadoField; }
			set { this.usoAutorizadoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoEnKg
		{
			get { return this.pesoEnKgField; }
			set { this.pesoEnKgField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal ValorMercancia
		{
			get { return this.valorMercanciaField; }
			set { this.valorMercanciaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool ValorMercanciaSpecified
		{
			get { return this.valorMercanciaFieldSpecified; }
			set { this.valorMercanciaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Moneda
		{
			get { return this.monedaField; }
			set { this.monedaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool MonedaSpecified
		{
			get { return this.monedaFieldSpecified; }
			set { this.monedaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string FraccionArancelaria
		{
			get { return this.fraccionArancelariaField; }
			set { this.fraccionArancelariaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool FraccionArancelariaSpecified
		{
			get { return this.fraccionArancelariaFieldSpecified; }
			set { this.fraccionArancelariaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string UUIDComercioExt
		{
			get { return this.uUIDComercioExtField; }
			set { this.uUIDComercioExtField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoMateria
		{
			get { return this.tipoMateriaField; }
			set { this.tipoMateriaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool TipoMateriaSpecified
		{
			get { return this.tipoMateriaFieldSpecified; }
			set { this.tipoMateriaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DescripcionMateria
		{
			get { return this.descripcionMateriaField; }
			set { this.descripcionMateriaField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasMercanciaDocumentacionAduanera
	{

		private string tipoDocumentoField;

		private string numPedimentoField;

		private string identDocAduaneroField;

		private string rFCImpoField;

		/// <remarks/>
		[XmlAttribute()]
		public string TipoDocumento
		{
			get { return this.tipoDocumentoField; }
			set { this.tipoDocumentoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPedimento
		{
			get { return this.numPedimentoField; }
			set { this.numPedimentoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IdentDocAduanero
		{
			get { return this.identDocAduaneroField; }
			set { this.identDocAduaneroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RFCImpo
		{
			get { return this.rFCImpoField; }
			set { this.rFCImpoField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasMercanciaGuiasIdentificacion
	{

		private string numeroGuiaIdentificacionField;

		private string descripGuiaIdentificacionField;

		private decimal pesoGuiaIdentificacionField;

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroGuiaIdentificacion
		{
			get { return this.numeroGuiaIdentificacionField; }
			set { this.numeroGuiaIdentificacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string DescripGuiaIdentificacion
		{
			get { return this.descripGuiaIdentificacionField; }
			set { this.descripGuiaIdentificacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoGuiaIdentificacion
		{
			get { return this.pesoGuiaIdentificacionField; }
			set { this.pesoGuiaIdentificacionField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasMercanciaCantidadTransporta
	{

		private decimal cantidadField;

		private string iDOrigenField;

		private string iDDestinoField;

		private string cvesTransporteField;

		private bool cvesTransporteFieldSpecified;

		/// <remarks/>
		[XmlAttribute()]
		public decimal Cantidad
		{
			get { return this.cantidadField; }
			set { this.cantidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IDOrigen
		{
			get { return this.iDOrigenField; }
			set { this.iDOrigenField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IDDestino
		{
			get { return this.iDDestinoField; }
			set { this.iDDestinoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CvesTransporte
		{
			get { return this.cvesTransporteField; }
			set { this.cvesTransporteField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool CvesTransporteSpecified
		{
			get { return this.cvesTransporteFieldSpecified; }
			set { this.cvesTransporteFieldSpecified = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasMercanciaDetalleMercancia
	{

		private string unidadPesoMercField;

		private decimal pesoBrutoField;

		private decimal pesoNetoField;

		private decimal pesoTaraField;

		private int numPiezasField;

		private bool numPiezasFieldSpecified;

		/// <remarks/>
		[XmlAttribute()]
		public string UnidadPesoMerc
		{
			get { return this.unidadPesoMercField; }
			set { this.unidadPesoMercField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoBruto
		{
			get { return this.pesoBrutoField; }
			set { this.pesoBrutoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoNeto
		{
			get { return this.pesoNetoField; }
			set { this.pesoNetoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoTara
		{
			get { return this.pesoTaraField; }
			set { this.pesoTaraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public int NumPiezas
		{
			get { return this.numPiezasField; }
			set { this.numPiezasField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool NumPiezasSpecified
		{
			get { return this.numPiezasFieldSpecified; }
			set { this.numPiezasFieldSpecified = value; }
		}
	}





	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteMercanciasMercanciaMaterialPeligroso
	{

		/// <remarks/>
		Sí,

		/// <remarks/>
		No,
	}







	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasAutotransporte
	{

		private CartaPorteMercanciasAutotransporteIdentificacionVehicular identificacionVehicularField;

		private CartaPorteMercanciasAutotransporteSeguros segurosField;

		private CartaPorteMercanciasAutotransporteRemolque[] remolquesField;

		private string permSCTField;

		private string numPermisoSCTField;

		/// <remarks/>
		public CartaPorteMercanciasAutotransporteIdentificacionVehicular IdentificacionVehicular
		{
			get { return this.identificacionVehicularField; }
			set { this.identificacionVehicularField = value; }
		}

		/// <remarks/>
		public CartaPorteMercanciasAutotransporteSeguros Seguros
		{
			get { return this.segurosField; }
			set { this.segurosField = value; }
		}

		/// <remarks/>
		[XmlArrayItem("Remolque", IsNullable = false)]
		public CartaPorteMercanciasAutotransporteRemolque[] Remolques
		{
			get { return this.remolquesField; }
			set { this.remolquesField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PermSCT
		{
			get { return this.permSCTField; }
			set { this.permSCTField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPermisoSCT
		{
			get { return this.numPermisoSCTField; }
			set { this.numPermisoSCTField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasAutotransporteIdentificacionVehicular
	{

		private string configVehicularField;

		private decimal pesoBrutoVehicularField;

		private string placaVMField;

		private int anioModeloVMField;

		/// <remarks/>
		[XmlAttribute()]
		public string ConfigVehicular
		{
			get { return this.configVehicularField; }
			set { this.configVehicularField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoBrutoVehicular
		{
			get { return this.pesoBrutoVehicularField; }
			set { this.pesoBrutoVehicularField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PlacaVM
		{
			get { return this.placaVMField; }
			set { this.placaVMField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public int AnioModeloVM
		{
			get { return this.anioModeloVMField; }
			set { this.anioModeloVMField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasAutotransporteSeguros
	{

		private string aseguraRespCivilField;

		private string polizaRespCivilField;

		private string aseguraMedAmbienteField;

		private string polizaMedAmbienteField;

		private string aseguraCargaField;

		private string polizaCargaField;

		private decimal primaSeguroField;

		private bool primaSeguroFieldSpecified;

		/// <remarks/>
		[XmlAttribute()]
		public string AseguraRespCivil
		{
			get { return this.aseguraRespCivilField; }
			set { this.aseguraRespCivilField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PolizaRespCivil
		{
			get { return this.polizaRespCivilField; }
			set { this.polizaRespCivilField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string AseguraMedAmbiente
		{
			get { return this.aseguraMedAmbienteField; }
			set { this.aseguraMedAmbienteField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PolizaMedAmbiente
		{
			get { return this.polizaMedAmbienteField; }
			set { this.polizaMedAmbienteField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string AseguraCarga
		{
			get { return this.aseguraCargaField; }
			set { this.aseguraCargaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PolizaCarga
		{
			get { return this.polizaCargaField; }
			set { this.polizaCargaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PrimaSeguro
		{
			get { return this.primaSeguroField; }
			set { this.primaSeguroField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool PrimaSeguroSpecified
		{
			get { return this.primaSeguroFieldSpecified; }
			set { this.primaSeguroFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasAutotransporteRemolque
	{

		private string subTipoRemField;

		private string placaField;

		/// <remarks/>
		[XmlAttribute()]
		public string SubTipoRem
		{
			get { return this.subTipoRemField; }
			set { this.subTipoRemField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Placa
		{
			get { return this.placaField; }
			set { this.placaField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteMaritimo
	{

		private CartaPorteMercanciasTransporteMaritimoContenedor[] contenedorField;

		private CartaPorteMercanciasTransporteMaritimoRemolqueCCP[] remolquesCCPField;

		private string permSCTField;

		private bool permSCTFieldSpecified;

		private string numPermisoSCTField;

		private string nombreAsegField;

		private string numPolizaSeguroField;

		private string tipoEmbarcacionField;

		private string matriculaField;

		private string numeroOMIField;

		private int anioEmbarcacionField;

		private bool anioEmbarcacionFieldSpecified;

		private string nombreEmbarcField;

		private string nacionalidadEmbarcField;

		private decimal unidadesDeArqBrutoField;

		private string tipoCargaField;

		private decimal esloraField;

		private bool esloraFieldSpecified;

		private decimal mangaField;

		private bool mangaFieldSpecified;

		private decimal caladoField;

		private bool caladoFieldSpecified;

		private decimal puntalField;

		private bool puntalFieldSpecified;

		private string lineaNavieraField;

		private string nombreAgenteNavieroField;

		private string numAutorizacionNavieroField;

		private string numViajeField;

		private string numConocEmbarcField;

		private string permisoTempNavegacionField;

		/// <remarks/>
		[XmlElement("Contenedor")]
		public CartaPorteMercanciasTransporteMaritimoContenedor[] Contenedor
		{
			get { return this.contenedorField; }
			set { this.contenedorField = value; }
		}

		/// <remarks/>
		[XmlArrayItem("RemolqueCCP", IsNullable = false)]
		public CartaPorteMercanciasTransporteMaritimoRemolqueCCP[] RemolquesCCP
		{
			get { return this.remolquesCCPField; }
			set { this.remolquesCCPField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PermSCT
		{
			get { return this.permSCTField; }
			set { this.permSCTField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool PermSCTSpecified
		{
			get { return this.permSCTFieldSpecified; }
			set { this.permSCTFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPermisoSCT
		{
			get { return this.numPermisoSCTField; }
			set { this.numPermisoSCTField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreAseg
		{
			get { return this.nombreAsegField; }
			set { this.nombreAsegField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPolizaSeguro
		{
			get { return this.numPolizaSeguroField; }
			set { this.numPolizaSeguroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoEmbarcacion
		{
			get { return this.tipoEmbarcacionField; }
			set { this.tipoEmbarcacionField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Matricula
		{
			get { return this.matriculaField; }
			set { this.matriculaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroOMI
		{
			get { return this.numeroOMIField; }
			set { this.numeroOMIField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public int AnioEmbarcacion
		{
			get { return this.anioEmbarcacionField; }
			set { this.anioEmbarcacionField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool AnioEmbarcacionSpecified
		{
			get { return this.anioEmbarcacionFieldSpecified; }
			set { this.anioEmbarcacionFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreEmbarc
		{
			get { return this.nombreEmbarcField; }
			set { this.nombreEmbarcField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NacionalidadEmbarc
		{
			get { return this.nacionalidadEmbarcField; }
			set { this.nacionalidadEmbarcField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal UnidadesDeArqBruto
		{
			get { return this.unidadesDeArqBrutoField; }
			set { this.unidadesDeArqBrutoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoCarga
		{
			get { return this.tipoCargaField; }
			set { this.tipoCargaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal Eslora
		{
			get { return this.esloraField; }
			set { this.esloraField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool EsloraSpecified
		{
			get { return this.esloraFieldSpecified; }
			set { this.esloraFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal Manga
		{
			get { return this.mangaField; }
			set { this.mangaField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool MangaSpecified
		{
			get { return this.mangaFieldSpecified; }
			set { this.mangaFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal Calado
		{
			get { return this.caladoField; }
			set { this.caladoField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool CaladoSpecified
		{
			get { return this.caladoFieldSpecified; }
			set { this.caladoFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal Puntal
		{
			get { return this.puntalField; }
			set { this.puntalField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool PuntalSpecified
		{
			get { return this.puntalFieldSpecified; }
			set { this.puntalFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string LineaNaviera
		{
			get { return this.lineaNavieraField; }
			set { this.lineaNavieraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreAgenteNaviero
		{
			get { return this.nombreAgenteNavieroField; }
			set { this.nombreAgenteNavieroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumAutorizacionNaviero
		{
			get { return this.numAutorizacionNavieroField; }
			set { this.numAutorizacionNavieroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumViaje
		{
			get { return this.numViajeField; }
			set { this.numViajeField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumConocEmbarc
		{
			get { return this.numConocEmbarcField; }
			set { this.numConocEmbarcField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PermisoTempNavegacion
		{
			get { return this.permisoTempNavegacionField; }
			set { this.permisoTempNavegacionField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteMaritimoContenedor
	{

		private string tipoContenedorField;

		private string matriculaContenedorField;

		private string numPrecintoField;

		private string idCCPRelacionadoField;

		private string placaVMCCPField;

		private System.DateTime fechaCertificacionCCPField;

		private bool fechaCertificacionCCPFieldSpecified;

		/// <remarks/>
		[XmlAttribute()]
		public string TipoContenedor
		{
			get { return this.tipoContenedorField; }
			set { this.tipoContenedorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string MatriculaContenedor
		{
			get { return this.matriculaContenedorField; }
			set { this.matriculaContenedorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPrecinto
		{
			get { return this.numPrecintoField; }
			set { this.numPrecintoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string IdCCPRelacionado
		{
			get { return this.idCCPRelacionadoField; }
			set { this.idCCPRelacionadoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PlacaVMCCP
		{
			get { return this.placaVMCCPField; }
			set { this.placaVMCCPField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public System.DateTime FechaCertificacionCCP
		{
			get { return this.fechaCertificacionCCPField; }
			set { this.fechaCertificacionCCPField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool FechaCertificacionCCPSpecified
		{
			get { return this.fechaCertificacionCCPFieldSpecified; }
			set { this.fechaCertificacionCCPFieldSpecified = value; }
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteMaritimoRemolqueCCP
	{

		private string subTipoRemCCPField;

		private string placaCCPField;

		/// <remarks/>
		[XmlAttribute()]
		public string SubTipoRemCCP
		{
			get { return this.subTipoRemCCPField; }
			set { this.subTipoRemCCPField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string PlacaCCP
		{
			get { return this.placaCCPField; }
			set { this.placaCCPField = value; }
		}
	}





	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteAereo
	{

		private string permSCTField;

		private string numPermisoSCTField;

		private string matriculaAeronaveField;

		private string nombreAsegField;

		private string numPolizaSeguroField;

		private string numeroGuiaField;

		private string lugarContratoField;

		private string codigoTransportistaField;

		private string rFCEmbarcadorField;

		private string numRegIdTribEmbarcField;

		private string residenciaFiscalEmbarcField;

		private bool residenciaFiscalEmbarcFieldSpecified;

		private string nombreEmbarcadorField;

		/// <remarks/>
		[XmlAttribute()]
		public string PermSCT
		{
			get { return this.permSCTField; }
			set { this.permSCTField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPermisoSCT
		{
			get { return this.numPermisoSCTField; }
			set { this.numPermisoSCTField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string MatriculaAeronave
		{
			get { return this.matriculaAeronaveField; }
			set { this.matriculaAeronaveField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreAseg
		{
			get { return this.nombreAsegField; }
			set { this.nombreAsegField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPolizaSeguro
		{
			get { return this.numPolizaSeguroField; }
			set { this.numPolizaSeguroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroGuia
		{
			get { return this.numeroGuiaField; }
			set { this.numeroGuiaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string LugarContrato
		{
			get { return this.lugarContratoField; }
			set { this.lugarContratoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CodigoTransportista
		{
			get { return this.codigoTransportistaField; }
			set { this.codigoTransportistaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RFCEmbarcador
		{
			get { return this.rFCEmbarcadorField; }
			set { this.rFCEmbarcadorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumRegIdTribEmbarc
		{
			get { return this.numRegIdTribEmbarcField; }
			set { this.numRegIdTribEmbarcField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ResidenciaFiscalEmbarc
		{
			get { return this.residenciaFiscalEmbarcField; }
			set { this.residenciaFiscalEmbarcField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool ResidenciaFiscalEmbarcSpecified
		{
			get { return this.residenciaFiscalEmbarcFieldSpecified; }
			set { this.residenciaFiscalEmbarcFieldSpecified = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreEmbarcador
		{
			get { return this.nombreEmbarcadorField; }
			set { this.nombreEmbarcadorField = value; }
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteFerroviario
	{

		private CartaPorteMercanciasTransporteFerroviarioDerechosDePaso[] derechosDePasoField;

		private CartaPorteMercanciasTransporteFerroviarioCarro[] carroField;

		private string tipoDeServicioField;

		private string tipoDeTraficoField;

		private string nombreAsegField;

		private string numPolizaSeguroField;

		/// <remarks/>
		[XmlElement("DerechosDePaso")]
		public CartaPorteMercanciasTransporteFerroviarioDerechosDePaso[] DerechosDePaso
		{
			get { return this.derechosDePasoField; }
			set { this.derechosDePasoField = value; }
		}

		/// <remarks/>
		[XmlElement("Carro")]
		public CartaPorteMercanciasTransporteFerroviarioCarro[] Carro
		{
			get { return this.carroField; }
			set { this.carroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoDeServicio
		{
			get { return this.tipoDeServicioField; }
			set { this.tipoDeServicioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoDeTrafico
		{
			get { return this.tipoDeTraficoField; }
			set { this.tipoDeTraficoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreAseg
		{
			get { return this.nombreAsegField; }
			set { this.nombreAsegField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumPolizaSeguro
		{
			get { return this.numPolizaSeguroField; }
			set { this.numPolizaSeguroField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteFerroviarioDerechosDePaso
	{

		private string tipoDerechoDePasoField;

		private decimal kilometrajePagadoField;

		/// <remarks/>
		[XmlAttribute()]
		public string TipoDerechoDePaso
		{
			get { return this.tipoDerechoDePasoField; }
			set { this.tipoDerechoDePasoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal KilometrajePagado
		{
			get { return this.kilometrajePagadoField; }
			set { this.kilometrajePagadoField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteFerroviarioCarro
	{

		private CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] contenedorField;

		private string tipoCarroField;

		private string matriculaCarroField;

		private string guiaCarroField;

		private decimal toneladasNetasCarroField;

		/// <remarks/>
		[XmlElement("Contenedor")]
		public CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] Contenedor
		{
			get { return this.contenedorField; }
			set { this.contenedorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoCarro
		{
			get { return this.tipoCarroField; }
			set { this.tipoCarroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string MatriculaCarro
		{
			get { return this.matriculaCarroField; }
			set { this.matriculaCarroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string GuiaCarro
		{
			get { return this.guiaCarroField; }
			set { this.guiaCarroField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal ToneladasNetasCarro
		{
			get { return this.toneladasNetasCarroField; }
			set { this.toneladasNetasCarroField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteMercanciasTransporteFerroviarioCarroContenedor
	{

		private string tipoContenedorField;

		private decimal pesoContenedorVacioField;

		private decimal pesoNetoMercanciaField;

		/// <remarks/>
		[XmlAttribute()]
		public string TipoContenedor
		{
			get { return this.tipoContenedorField; }
			set { this.tipoContenedorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoContenedorVacio
		{
			get { return this.pesoContenedorVacioField; }
			set { this.pesoContenedorVacioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public decimal PesoNetoMercancia
		{
			get { return this.pesoNetoMercanciaField; }
			set { this.pesoNetoMercanciaField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteMercanciasLogisticaInversaRecoleccionDevolucion
	{

		/// <remarks/>
		Sí,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteTiposFigura
	{

		private CartaPorteTiposFiguraPartesTransporte[] partesTransporteField;

		private CartaPorteTiposFiguraDomicilio domicilioField;

		private string tipoFiguraField;

		private string rFCFiguraField;

		private string numLicenciaField;

		private string nombreFiguraField;

		private string numRegIdTribFiguraField;

		private string residenciaFiscalFiguraField;

		private bool residenciaFiscalFiguraFieldSpecified;

		/// <remarks/>
		[XmlElement("PartesTransporte")]
		public CartaPorteTiposFiguraPartesTransporte[] PartesTransporte
		{
			get { return this.partesTransporteField; }
			set { this.partesTransporteField = value; }
		}

		/// <remarks/>
		public CartaPorteTiposFiguraDomicilio Domicilio
		{
			get { return this.domicilioField; }
			set { this.domicilioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string TipoFigura
		{
			get { return this.tipoFiguraField; }
			set { this.tipoFiguraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string RFCFigura
		{
			get { return this.rFCFiguraField; }
			set { this.rFCFiguraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumLicencia
		{
			get { return this.numLicenciaField; }
			set { this.numLicenciaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NombreFigura
		{
			get { return this.nombreFiguraField; }
			set { this.nombreFiguraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumRegIdTribFigura
		{
			get { return this.numRegIdTribFiguraField; }
			set { this.numRegIdTribFiguraField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string ResidenciaFiscalFigura
		{
			get { return this.residenciaFiscalFiguraField; }
			set { this.residenciaFiscalFiguraField = value; }
		}

		/// <remarks/>
		[XmlIgnore()]
		public bool ResidenciaFiscalFiguraSpecified
		{
			get { return this.residenciaFiscalFiguraFieldSpecified; }
			set { this.residenciaFiscalFiguraFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteTiposFiguraPartesTransporte
	{

		private string parteTransporteField;

		/// <remarks/>
		[XmlAttribute()]
		public string ParteTransporte
		{
			get { return this.parteTransporteField; }
			set { this.parteTransporteField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public partial class CartaPorteTiposFiguraDomicilio
	{

		private string calleField;

		private string numeroExteriorField;

		private string numeroInteriorField;

		private string coloniaField;

		private string localidadField;

		private string referenciaField;

		private string municipioField;

		private string estadoField;

		private string paisField;

		private string codigoPostalField;

		/// <remarks/>
		[XmlAttribute()]
		public string Calle
		{
			get { return this.calleField; }
			set { this.calleField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroExterior
		{
			get { return this.numeroExteriorField; }
			set { this.numeroExteriorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string NumeroInterior
		{
			get { return this.numeroInteriorField; }
			set { this.numeroInteriorField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Colonia
		{
			get { return this.coloniaField; }
			set { this.coloniaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Localidad
		{
			get { return this.localidadField; }
			set { this.localidadField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Referencia
		{
			get { return this.referenciaField; }
			set { this.referenciaField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Municipio
		{
			get { return this.municipioField; }
			set { this.municipioField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Estado
		{
			get { return this.estadoField; }
			set { this.estadoField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string Pais
		{
			get { return this.paisField; }
			set { this.paisField = value; }
		}

		/// <remarks/>
		[XmlAttribute()]
		public string CodigoPostal
		{
			get { return this.codigoPostalField; }
			set { this.codigoPostalField = value; }
		}
	}



	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteTranspInternac
	{

		/// <remarks/>
		Sí,

		/// <remarks/>
		No,
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteEntradaSalidaMerc
	{

		/// <remarks/>
		Entrada,

		/// <remarks/>
		Salida,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
	[Serializable()]
	[XmlType(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte30")]
	public enum CartaPorteRegistroISTMO
	{

		/// <remarks/>
		Sí,
	}


}