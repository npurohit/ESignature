using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ESign.Model;

namespace eSign.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = CreateModelForTesting();

            return View(model);
        }


        private SessionGroup CreateModelForTesting()
        {
            return new SessionGroup
            {
                Sessions = new List<SigningSession>
                {
                    new SigningSession
                    {
                        LineOfBusiness = "Auto",
                        Documents = new List<Document>
                        {
                            new Document
                            {
                                Name = "Application",
                                Signers =new List<Signer>
                                {
                                    new Signer{
                                        Name = "Greg Dzezinski"
                                    }
                                },
                                PdfName = "AutoApplication"
                            }
                        }
                    },
                    new SigningSession
                    {
                        LineOfBusiness = "Home",
                        Documents = new List<Document>
                        {
                            new Document
                            {
                                Name = "d Application",
                                Signers =new List<Signer>
                                {
                                    new Signer{
                                        Name = "Greg Dzezinski"
                                    }
                                },
                                PdfName = "HomeApplication"
                            }
                        }
                    }
                }
            };
        }

    }
}
