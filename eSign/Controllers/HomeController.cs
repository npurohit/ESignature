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

        public ViewResult GetSigningSession(string sessionId)
        {
            return View("_signingSession");
        }

        private SessionGroup CreateModelForTesting()
        {
            return new SessionGroup
            {
                test = "greg",
                Sessions = new List<SigningSession>
                {
                    new SigningSession
                    {
                        Documents = new List<Document>
                        {
                            new Document
                            {
                                Signers =new List<Signer>
                                {
                                    new Signer{
                                        Name = "Greg Dzezinski"
                                    }
                                },
                                //SignableImage = new System.Drawing.Bitmap("~/")
                            }
                        }
                    }
                }
            };
        }

    }
}
