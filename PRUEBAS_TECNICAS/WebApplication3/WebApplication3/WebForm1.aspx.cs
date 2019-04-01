using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using WebApplication3.ServiceReference1;
using System.Xml.Linq;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string Filename = "C:\\Users\\User\\Source\\Repos\\WebApplication3\\WebApplication3\\Data\\Ejemplo2.xml";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("Data") + "\\" + fn;
                try
                {
                    FileUpload1.PostedFile.SaveAs(SaveLocation);
                    Response.Write("The file has been uploaded.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                    //Note: Exception.Message returns a detailed message that describes the current exception. 
                    //For security reasons, we do not recommend that you return Exception.Message to end users in 
                    //production environments. It would be better to return a generic error message. 
                }
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("C:\\Users\\User\\Source\\Repos\\WebApplication3\\WebApplication3\\Data\\Ejemplo.xml");
                XmlNodeList aDateNodes = xmlDoc.SelectNodes("/dtoFacFacturasInput/lDetalle/DTOFacDetallefacturas/Nvfac_dcop");
                foreach (XmlNode aDateNode in aDateNodes)
                {
                    //XmlAttribute DateAttribute = aDateNode.Attributes["Nvfac_dcop"];
                    aDateNode.InnerText = "4";
                }
                //__________________________________________________________________________________
                // Validacion del XML Schema
                //__________________________________________________________________________________
                //var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
                XmlSchemaSet schema = new XmlSchemaSet();
                schema.Add("", "C:\\Users\\User\\Source\\Repos\\WebApplication3\\WebApplication3\\Data\\EjemploSchema.xsd");
                XmlReader rd = XmlReader.Create("C:\\Users\\User\\Source\\Repos\\WebApplication3\\WebApplication3\\Data\\Ejemplo.xml");
                XDocument doc = XDocument.Load(rd);
                doc.Validate(schema, ValidationEventHandler);
                //__________________________________________________________________________________

                xmlDoc.Save(Filename);
                ServiceReference1.FacFacturas servicio = new ServiceReference1.FacFacturas();
                Documento documento = new Documento();
                documento.Nvemp_nnit = "900154184";
                documento.Nvfac_cont = 121342;
                documento.Nvfac_orig = "E";
                documento.Nvdoc_tipo = "nombre.txt";
                documento.Nvpla_codi = "01";
                documento.Nvdoc_arch = System.Text.Encoding.Default.GetBytes(xmlDoc.OuterXml);
                documento.Nvusu_codi = "PruebaDev";


                TSalida salida = servicio.SetFacDocumentos(documento);
                Label1.Text = salida.Result+" "+salida.Description;


            }
            else
            {
                Response.Write("Please select a file to upload.");
            }
        }
        void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }


    }
}