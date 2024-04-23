using System;
using System.Text;
using System.Xml;
using System.Xml.Writer; 
using System.Xml.Schema;

namespace CartaPorteGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			GenerateCartaPorteXml("D:\\ProyectoCC\\ConsoleApp1\\DG\\CartaPorte.xml");
		}

		static void GenerateCartaPorteXml(string filePath)
		{
			XmlWriter cartaPorteXml = XmlWriter.Create("");
			cartaPorteXml.WriteStartDocument();
			// Crear el elemento raíz <xs:schema>

			XmlElement schemaElement = cartaPorteXml.CreateElement("xs", "schema", "http://www.w3.org/2001/XMLSchema");
			schemaElement.SetAttribute("xmlns", "urn:namespace#xml_cartaportemx_v2_transportista.xsd");
			schemaElement.SetAttribute("targetNamespace", "urn:namespace#xml_cartaportemx_v2_transportista.xsd");
			schemaElement.SetAttribute("version", "1.0");
			cartaPorteXml.AppendChild(schemaElement);

			// Agregar la anotación y documentación
			XmlElement annotationElement = cartaPorteXml.CreateElement("xs", "annotation", "http://www.w3.org/2001/XMLSchema");
			schemaElement.AppendChild(annotationElement);

			XmlElement documentationElement = cartaPorteXml.CreateElement("xs", "documentation", "http://www.w3.org/2001/XMLSchema");
			documentationElement.InnerText = "XMLSchema generado usando EBIMAP Editor.\nCopyright (C) 2001-2020 EDICOM CAPITAL.\nTodos los derechos reservados.";
			annotationElement.AppendChild(documentationElement);

			// Agregar el elemento <xs:element name="Addenda"> con su complejidad
			XmlElement addendaElement = cartaPorteXml.CreateElement("xs", "element", "http://www.w3.org/2001/XMLSchema");
			addendaElement.SetAttribute("name", "Addenda");
			schemaElement.AppendChild(addendaElement);

			XmlElement addendaComplexType = cartaPorteXml.CreateElement("xs", "complexType", "http://www.w3.org/2001/XMLSchema");
			addendaElement.AppendChild(addendaComplexType);

			XmlElement addendaSequence = cartaPorteXml.CreateElement("xs", "sequence", "http://www.w3.org/2001/XMLSchema");
			addendaSequence.SetAttribute("maxOccurs", "unbounded");
			addendaSequence.SetAttribute("minOccurs", "0");
			addendaComplexType.AppendChild(addendaSequence);

			// Agregar más elementos según tus necesidades
			// Por ejemplo:
			// XmlElement customizedElement = cartaPorteXml.CreateElement("customized");
			// addendaSequence.AppendChild(customizedElement);

			// Guardar el archivo XML
			cartaPorteXml.Save(filePath);

			Console.WriteLine($"Archivo CartaPorte.xml generado correctamente en {filePath}");
				}
	}
	}


	// Crear el elemento raíz
	//XmlElement addendaElement = cartaPorteXml.CreateElement("Addenda");
	//cartaPorteXml.AppendChild(addendaElement);
	//XmlSchemaElement xmlSchema = cartaPorteXml.CreateElement("xml version=\"1.0\"; encoding=\"UTF-8\"; ");
	//cartaPorteXml.AppendChild(xmlSchema);
	// Agregar elementos dentro de customized (por ejemplo, RFC_Emisor y RFC_Receptor)
	//XmlElement transportistaElement = cartaPorteXml.CreateElement("Transportista");
	//transportistaElement.InnerText = "Datos del transportista";

	//addendaElement.AppendChild(transportistaElement);
	//XmlElement customizedElement = cartaPorteXml.CreateElement("customized");

	//addendaElement.AppendChild(customizedElement);

	//XmlElement rfcEmisorElement = cartaPorteXml.CreateElement("RFC_Emisor");
	//rfcEmisorElement.InnerText = "RIDJ760314";
	//transportistaElement.AppendChild(rfcEmisorElement);

	//Version = "4.0";
	//Serie = "Serie";
	//Folio = "Folio";
	//Fecha = "2024-02-29T00:00:55";
	//TipoDeComprobante = "I";
	//Moneda = "MXN";
	//FormaPago = "01";
	//MetodoPago = "PUE"; 
	//Total = "100.00"; 
	//Agregar más elementos según tus necesidades
	// Por ejemplo:


	// Guardar el archivo XML

