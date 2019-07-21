using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Recibidor.Models
{
    [XmlRoot(ElementName = "Receivement")]
    public class Receivement
    {
        //public Guid NoOrden { get; set; }
        public string Employee { get; set; }
        public string Status { get; set; }
        public string OrderNumber { get; set; }
        public string Date { get; set; }
        public string Total { get; set; }
        public string CustomerEmailName { get; set; }
        
    }
}