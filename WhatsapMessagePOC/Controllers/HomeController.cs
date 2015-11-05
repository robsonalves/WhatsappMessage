using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhatsAppApi;

namespace WhatsapMessagePOC.Controllers
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

        public ActionResult WhatsAppMessage()
        {
            return View("WhatsApp");
        }

        public void SendMessage(string to, string msg)
        {
            string from = "5511950405840";

            WhatsApp wa = new WhatsApp(from, "ljeQt1NKyfGP8XB+B10rtddN8xI=", "Pr0view", false, false);

            wa.OnConnectSuccess += () =>
            {

                wa.OnLoginSuccess += (phonenumber, data) =>
                {
                    wa.SendMessage(to, msg);
                };

                wa.OnLoginFailed += (data) =>
                {
                    string dataex = data;
                };

                wa.Login();
            };

            wa.OnConnectFailed += (ex) =>
            {
                string s = ex.Message;
            };

            wa.Connect();

        }
    }
}