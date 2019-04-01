using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    [XmlRoot(ElementName = "DTOFacDetallefacturas")]
    public class DTOFacDetallefacturas
    {
        [XmlElement(ElementName = "Nvfac_dcop")]
        public string Nvfac_dcop { get; set; }
        [XmlElement(ElementName = "Nvpro_codi")]
        public string Nvpro_codi { get; set; }
        [XmlElement(ElementName = "Nvpro_nomb")]
        public string Nvpro_nomb { get; set; }
        [XmlElement(ElementName = "Nvuni_desc")]
        public string Nvuni_desc { get; set; }
        [XmlElement(ElementName = "Nvuni_quan")]
        public string Nvuni_quan { get; set; }
        [XmlElement(ElementName = "Nvfac_cant")]
        public string Nvfac_cant { get; set; }
        [XmlElement(ElementName = "Nvfac_valo")]
        public string Nvfac_valo { get; set; }
        [XmlElement(ElementName = "Nvfac_pdes")]
        public string Nvfac_pdes { get; set; }
        [XmlElement(ElementName = "Nvfac_desc")]
        public string Nvfac_desc { get; set; }
        [XmlElement(ElementName = "Nvfac_stot")]
        public string Nvfac_stot { get; set; }
        [XmlElement(ElementName = "Nvdet_piva")]
        public string Nvdet_piva { get; set; }
        [XmlElement(ElementName = "Nvdet_viva")]
        public string Nvdet_viva { get; set; }
        [XmlElement(ElementName = "Nvdet_nota")]
        public string Nvdet_nota { get; set; }
    }

    [XmlRoot(ElementName = "lDetalle")]
    public class LDetalle
    {
        [XmlElement(ElementName = "DTOFacDetallefacturas")]
        public DTOFacDetallefacturas DTOFacDetallefacturas { get; set; }
    }

    [XmlRoot(ElementName = "dtoFacFacturasInput")]
    public class DtoFacFacturasInput
    {
        [XmlElement(ElementName = "lDetalle")]
        public LDetalle LDetalle { get; set; }
        [XmlElement(ElementName = "Nvfac_orig")]
        public string Nvfac_orig { get; set; }
        [XmlElement(ElementName = "Nvemp_nnit")]
        public string Nvemp_nnit { get; set; }
        [XmlElement(ElementName = "Nvfac_tipo")]
        public string Nvfac_tipo { get; set; }
        [XmlElement(ElementName = "Nvfac_fech")]
        public string Nvfac_fech { get; set; }
        [XmlElement(ElementName = "Nvfac_venc")]
        public string Nvfac_venc { get; set; }
        [XmlElement(ElementName = "Nvcli_cper")]
        public string Nvcli_cper { get; set; }
        [XmlElement(ElementName = "Nvcli_cdoc")]
        public string Nvcli_cdoc { get; set; }
        [XmlElement(ElementName = "Nvcli_docu")]
        public string Nvcli_docu { get; set; }
        [XmlElement(ElementName = "Nvcli_mail")]
        public string Nvcli_mail { get; set; }
    }

}
