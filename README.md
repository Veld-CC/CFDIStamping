# Librería de Generación de CFDI 4.0 con Timbrado Fiscal (SAT 2025)

## 1. Descripción General

Librería desarrollada en C# (.NET) para la generación, timbrado y manejo de Comprobantes Fiscales Digitales por  
Internet (CFDI) versión 4.0 conforme a los lineamientos del Servicio de Administración Tributaria (SAT) de México para 2025

Proporciona funcionalidades completas para:

- Generación de XML conforme al esquema CFDI 4.0
- Timbrado fiscal digital con proveedores externos
- Generación de Código QR según estándares SAT
- Soporte para complementos (Carta Porte 2.0/3.0/3.1 y Detallista 8.1)
- Generación de documentos PDF mediante RDLC

## 2. 🔧 Stack Tecnológico <a name="-stack-tecnológico"></a>

### 💻 Core

| Componente         | Tecnología/Estándar                   |  
|--------------------|---------------------------------------|  
| Lenguaje Principal | C# (.NET 6+)                          |  
| Esquemas XML       | XSD SAT (CFDI 4.0, Complementos)      |  
| Generación QR      | QRCodeGenerator (estándar SAT)        |  
| Serialización      | XmlSerializer, Newtonsoft.Json        |  
| Criptografía       | OpenSSL (sellado digital)             |  
| Reportes           | RDLC (Report Definition Language)     |  
| Estructura         | Arquitectura modular por complementos |  

## 3. Componentes Principales

### 3.1. Procesamiento CFDI 4.0

`CFDI40Processor`

Clase principal que coordina el flujo completo de generación y timbrado.

```
    public async Task<ResponseTimbrado> TimbrarCFDI40(Comprobante comprobante, object complemento, Parametros parametros)  
    {  
	    // 1. Inicialización de componentes  
	    // 2. Procesamiento de complementos  
	    // 3. Generación de número de certificado  
	    // 4. Sellado digital del CFDI  
	    // 5. Timbrado con proveedor externo  
	    // 6. Generación de respuesta con TFD  
    }
```

### 3.2. Manejo de Complementos

#### Soporte para Carta Porte

- Versiones 2.0, 3.0 y 3.1
- Generación de IDCCP según estándar SAT
- Namespaces dinámicos por versión

```
    private void SetCartaPorteSchemaLocation()
    {
        _comprobante.xsiSchemaLocation = _parametros.SVersion switch
        {
        "20" => "...CartaPorte20.xsd",
        "30" => "...CartaPorte30.xsd",
        "31" => "...CartaPorte31.xsd",
        _ => "...cfdv40.xsd"
        };
    }
```

Soporte para Detallista (Addenda)
Versión 8.1 (AMC81)
Adicionalmente contene las clases de las versiones 7.1 y Soriana (Personalizada)
Compatibilidad con esquemas XSD proporcionados por el SAT

### 3.3. Timbrado Fiscal Digital

Flujo de Timbrado:

1. Generación de cadena original
2. Sellado digital con clave privada
3. Comunicación con proveedor de timbrado
4. Procesamiento de respuesta
5. Generación de TFD (Timbre Fiscal Digital)

```
    sequenceDiagram
    participant Cliente
    participant CFDI40Processor
    participant ProveedorTimbrado
    
        Cliente->>CFDI40Processor: TimbrarCFDI40()
        CFDI40Processor->>CFDI40Processor: Generar XML
        CFDI40Processor->>CFDI40Processor: Sellar Documento
        CFDI40Processor->>ProveedorTimbrado: Solicitar Timbrado
        ProveedorTimbrado->>CFDI40Processor: XML Timbrado
        CFDI40Processor->>CFDI40Processor: Generar QR/JSON
        CFDI40Processor->>Cliente: ResponseTimbrado
```

### 3.4. Generación de Código QR

Implementación conforme al estándar SAT:

```
    public void GenerateCFDIQR(string uuid, string emisorRfc, string receptorRfc,
    string total, string sello, string outputPath)
    {
        var url = $"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?" +
        $"&id={uuid}&re={emisorRfc}&rr={receptorRfc}&tt={total}&fe={sello}";
        // Generación de imagen QR
    }
```

### 3.5. Utilidades Adicionales

`CantidadLetra.cs`
Conversión de cantidades numéricas a su representación en letras (requerido para complementos).

`GUIID.cs`
Generación de identificadores únicos conforme a estándares SAT para complemento carta porte, aplica solo para carta
porte 3.1 y posteriores.

## 4. Estructura de Directorios

```
    CFDI/
    ├── Timbrado/                  # Lógica de timbrado
    ├── CFDIFunctions/             # Funciones auxiliares
    │   ├── CantidadLetra.cs       # Conversión num->letras
    │   └── GUIID.cs               # Generación de UUIDs
    ├── CFDI/                      
    │   └── CartaPorte/            # Complemento Carta Porte
    │       ├── 20/                # Versión 2.0
    │       ├── 30/                # Versión 3.0
    │       └── 31/                # Versión 3.1
    ├── Detallista/                # Complemento Detallista
    │   ├── AMC71/                 # Estándar 7.1
    │   └── AMC81/                 # Estándar 8.1
    ├── TFD/                       # Timbre Fiscal Digital
    │   ├── 11/                    # Versión 1.1
    │   └── xsd11/                 # Esquemas XSD
    ├── Utils/                     # Utilidades
    │   ├── SelloDigital.cs        # Sellado criptográfico
    │   └── StringWriterWithEncoding.cs # Manejo de encoding
    └── Core/
    ├── CanCFDI.cs             # Validaciones
    └── CFDI40Processor.cs     # Procesamiento principal
```

## 5. Flujo de Trabajo

1. Configuración Inicial:

- Establecer parámetros de conexión con proveedor de timbrado
- Cargar certificados (.cer) y clave privada (.key)

2. Construcción CFDI:

- Crear objeto Comprobante con datos fiscales
- Agregar complementos según necesidades (CartaPorte, Detallista)

3. Procesamiento:

```
    var processor = new CFDI40Processor();
    var response = await processor.TimbrarCFDI40(comprobante, complemento, parametros);
```

4. Resultados:

- XML timbrado
- Timbre Fiscal Digital (TFD)
- Código QR en formato imagen
- JSON con datos de timbrado

## 6. Consideraciones Técnicas

- Validación Estricta: Todos los componentes se construyen a partir de los XSD oficiales del SAT
- Modularidad: Los complementos pueden extenderse sin modificar el núcleo

- Seguridad:

    - Sellado digital con algoritmos aprobados por el SAT
    - Manejo seguro de certificados y claves privadas

- Rendimiento:
    - Procesamiento asíncrono
    - Caché de transformaciones XSLT

## 7. Dependencias Externas

| Paquete NuGet       | Uso                              |  
|---------------------|----------------------------------|  
| Newtonsoft.Json     | C# Serialización JSON            |  
| QRCoder             | Generación de códigos QR         |  
| OpenSSL.NET         | Manejo de certificados digitales |  
| Microsoft.Reporting | Generación de reportes RDLC      |  

Esta documentación proporciona una visión técnica completa del sistema para facilitar su implementación, mantenimiento y
extensión conforme a los requisitos del SAT 2025.