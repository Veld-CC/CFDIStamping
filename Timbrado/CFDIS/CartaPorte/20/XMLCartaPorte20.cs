namespace Timbrado.CFDIS.CartaPorte._20
{
	public class XMLCartaPorte20
	{
		public CartaPorte GenComplementoCartaPorte20Ejemplo()
		{
			//Declaracion de objeto
			CartaPorte _cartaPorte = new CartaPorte();


			// Encabezado de CartaPorte
			_cartaPorte.Version = "2.0";
			_cartaPorte.TotalDistRec = (decimal)1.0;
			_cartaPorte.TranspInternac = CartaPorteTranspInternac.No;
			

			#region Ubicaciones

			// Ubicaciones
			List<CartaPorteUbicacion> lstUbicaciones = new List<CartaPorteUbicacion>();


			// Ubicaciones Origen
			CartaPorteUbicacion _origen = new CartaPorteUbicacion();
			_origen.FechaHoraSalidaLlegada = "2023-10-04T08:15:00";
			_origen.IDUbicacion = "OR000001";
			_origen.NombreRemitenteDestinatario = "ESCUELA KEMPER URGATE";
			_origen.RFCRemitenteDestinatario = "EKU9003173C9";
			_origen.TipoUbicacion = CartaPorteUbicacionTipoUbicacion.Origen;


			//Domicilio origen
			CartaPorteUbicacionDomicilio _domicilioOrigen = new CartaPorteUbicacionDomicilio();
			_domicilioOrigen.Calle = "CARRETERA NACIONAL TUXPAN-TAMPICO";
			_domicilioOrigen.CodigoPostal = "92116";
			_domicilioOrigen.Colonia = "7284";
			_domicilioOrigen.Estado = "VER";
			_domicilioOrigen.Municipio = "155";
			_domicilioOrigen.NumeroExterior = "KM 64";
			_domicilioOrigen.Pais = "MEX";

			// asognacion de domicilio a domicilio origen
			_origen.Domicilio = _domicilioOrigen;

			// agrega ubicaciones
			lstUbicaciones.Add(_origen);


			//Ubicaciones destino
			CartaPorteUbicacion _destino = new CartaPorteUbicacion();
			_destino.DistanciaRecorrida = (decimal)1.0;
			_destino.DistanciaRecorridaSpecified = true;
			_destino.FechaHoraSalidaLlegada = "2023-10-04T08:15:00";
			_destino.IDUbicacion = "DE000002";
			_destino.NombreRemitenteDestinatario = "ERIC GARCIA MONTIEL";
			_destino.RFCRemitenteDestinatario = "XAXX010101000";
			_destino.TipoUbicacion = CartaPorteUbicacionTipoUbicacion.Destino;


			//Domicilio destino
			CartaPorteUbicacionDomicilio _domicilioDestino = new CartaPorteUbicacionDomicilio();
			_domicilioDestino.Calle = "AVENIDA HIDALGO";
			_domicilioDestino.CodigoPostal = "74129";
			_domicilioDestino.Colonia = "1482";
			_domicilioDestino.Estado = "PUE";
			_domicilioDestino.Municipio = "132";
			_domicilioDestino.NumeroExterior = "#63";
			_domicilioDestino.Pais = "MEX";

			// asognacion de domicilio a domicilio origen
			_destino.Domicilio = _domicilioDestino;

			// agrega ubicaciones
			lstUbicaciones.Add(_destino);

			// se agrega nodo ubicaciones a carta porte
			_cartaPorte.Ubicaciones = lstUbicaciones.ToArray();

			#endregion


			#region Mercancias

			CartaPorteMercancias _mercancias = new CartaPorteMercancias();

			_mercancias.NumTotalMercancias = 1;
			_mercancias.PesoBrutoTotal = (decimal)0.1500;
			_mercancias.UnidadPeso = "KGM";

			List<CartaPorteMercanciasMercancia> _mercanciaList = new List<CartaPorteMercanciasMercancia>();
			CartaPorteMercanciasMercancia _mercancia = new CartaPorteMercanciasMercancia();

			_mercancia.BienesTransp = "40102100";
			_mercancia.Cantidad = 1;
			_mercancia.ClaveUnidad = "H87";
			_mercancia.Descripcion = "SOMBRERO DE LAMINA GALVANIZADA CAL.30  4";
			_mercancia.MaterialPeligroso = CartaPorteMercanciasMercanciaMaterialPeligroso.No;
			//_mercancia.Embalaje = "nailo";
			//_mercancia.EmbalajeSpecified = true;
			_mercancia.Moneda = "MXN";
			_mercancia.PesoEnKg = (decimal)0.1500;
			_mercancia.Unidad = "PIEZA";
			_mercancia.ValorMercancia = (decimal)150.77;

			_mercanciaList.Add(_mercancia);

			_mercancias.Mercancia = _mercanciaList.ToArray();

			#region AutoTransporte

			CartaPorteMercanciasAutotransporte _autotransporte = new CartaPorteMercanciasAutotransporte();
			_autotransporte.NumPermisoSCT = "10340";
			_autotransporte.PermSCT = "TPAF02";

			// identificacion vehicular
			CartaPorteMercanciasAutotransporteIdentificacionVehicular _identificacion = new CartaPorteMercanciasAutotransporteIdentificacionVehicular();
			_identificacion.AnioModeloVM = 2016;
			_identificacion.ConfigVehicular = "C2";
			_identificacion.PlacaVM = "XY2975A";

			// seguros
			CartaPorteMercanciasAutotransporteSeguros _seguros = new CartaPorteMercanciasAutotransporteSeguros();
			_seguros.AseguraCarga = "HDI SEGUROS, S.A DE C.V.";
			_seguros.AseguraRespCivil = "QUALITAS COMPAÑIA DE SEGUROS, S.A. DE C.V.";
			_seguros.PolizaCarga = "10-00000";
			_seguros.PolizaRespCivil = "0000000000";
			// aseguradora de medio ambiete en caso de transportar material peligroso

			_autotransporte.Seguros = _seguros;
			_autotransporte.IdentificacionVehicular = _identificacion;
			#endregion

			//se agrega nodo autotransporte a mercancias
			_mercancias.Autotransporte = _autotransporte;

			// se agrega nodo mercancias a carta porte
			_cartaPorte.Mercancias = _mercancias;
			#endregion

			#region FiguraTransporte

			List<CartaPorteTiposFigura> _figuraTransporteList = new List<CartaPorteTiposFigura>();

			// figura 01
			CartaPorteTiposFigura _figuraTransporte = new CartaPorteTiposFigura();
			_figuraTransporte.NombreFigura = "RENE PRISCILIANO HERNANDEZ LOZANO";
			_figuraTransporte.NumLicencia = "40C822392";
			_figuraTransporte.RFCFigura = "XAXX010101000";
			_figuraTransporte.TipoFigura = "01";

			CartaPorteTiposFiguraDomicilio _domiciliofigura = new CartaPorteTiposFiguraDomicilio();
			_domiciliofigura.Calle = "PRIV. PASEO GRANADOS";
			_domiciliofigura.CodigoPostal = "74160";
			_domiciliofigura.Colonia = "3697";
			_domiciliofigura.Estado = "PUE";
			_domiciliofigura.Municipio = "074";
			_domiciliofigura.NumeroExterior = "30";
			_domiciliofigura.NumeroInterior = "D";
			_domiciliofigura.Pais = "MEX";
			_figuraTransporte.Domicilio = _domiciliofigura;

			_figuraTransporteList.Add(_figuraTransporte);

			// figura 02
			_figuraTransporte = new CartaPorteTiposFigura();
			_figuraTransporte.NombreFigura = "ESCUELA KEMPER URGATE";
			_figuraTransporte.RFCFigura = "EKU9003173C9";
			_figuraTransporte.TipoFigura = "02";

			List<CartaPorteTiposFiguraPartesTransporte> _partesTransporteList = new List<CartaPorteTiposFiguraPartesTransporte>();

			//partes transporte
			CartaPorteTiposFiguraPartesTransporte _partesTransporte = new CartaPorteTiposFiguraPartesTransporte();

			_partesTransporte.ParteTransporte = "PT06";
			_partesTransporteList.Add(_partesTransporte);

			_domiciliofigura = new CartaPorteTiposFiguraDomicilio();
			_domiciliofigura.Calle = "PRIV. PASEO GRANADOS";
			_domiciliofigura.CodigoPostal = "74129";
			_domiciliofigura.Colonia = "1482";
			_domiciliofigura.Estado = "PUE";
			_domiciliofigura.Municipio = "132";
			_domiciliofigura.NumeroExterior = "30";
			_domiciliofigura.NumeroInterior = "D";
			_domiciliofigura.Pais = "MEX";




			_figuraTransporte.PartesTransporte = _partesTransporteList.ToArray();
			_figuraTransporte.Domicilio = _domiciliofigura;

			_figuraTransporteList.Add(_figuraTransporte);

			_cartaPorte.FiguraTransporte = _figuraTransporteList.ToArray();



			#endregion

			


			return _cartaPorte;
		}
	}
}
