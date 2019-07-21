using Recibidor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace Recibidor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetOrdenes()
        {
            var receivementList = new List<Receivement>();

            foreach (string file in Directory.EnumerateFiles(@"C:\Temp\XMLS", "*.xml"))
            {
                string contents = System.IO.File.ReadAllText(file);

                var stringReader = new StringReader(contents);

                XmlRootAttribute xRoot = new XmlRootAttribute
                {
                    ElementName = "Receivement",
                    IsNullable = true
                };

                var serializer = new XmlSerializer(typeof(Receivement), xRoot);

                var receivement = serializer.Deserialize(stringReader) as Receivement;

                receivementList.Add(receivement);
            }

            return Json(receivementList, JsonRequestBehavior.AllowGet);
        }

    }
}