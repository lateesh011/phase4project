using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using phase4project.Models;

namespace phase4project.Controllers
{
    public class HomeController : Controller
    {
        UserInfomethods m = null;
        CustInfoLogMethods m1 = null;
        public HomeController()
        {
            m = new UserInfomethods();
            m1 = new CustInfoLogMethods();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection c)
        {
            int i = Convert.ToInt32(c["UserID"]);
            string p = c["Password"].ToString();
            UserInfo t = m.Checklogin(i, p);

            if (t != null)
            {
                TempData["user"] = Convert.ToInt32(t.UserId);
                return RedirectToAction("AddComplaints");

            }
            else
            {
                ViewBag.Message1 = "Invalid Credentials..Try Again";
                return View();
            }
        }
        public ActionResult AddComplaints()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddComplaints(FormCollection c)
        {
            CustLoginfo k = new CustLoginfo();
            Complaint k1 = new Complaint();
            k.Logid = Convert.ToInt32(c["LogId"]);
            k1.LogId = k.Logid;
            k.CustEmail = c["CustomerMail"].ToString();
            k1.CustomerMail = k.CustEmail;
            k.CustName = c["CustomerName"].ToString();
            k1.CustomerName = k.CustName;
            k.LogStatus = c["LogStatus"].ToString();
            k1.LogStatus = k.LogStatus;
            k.Description = c["Description"].ToString();
            k1.Description = k.Description;
            k.UserId = Convert.ToInt32(TempData["user"]);
            TempData["user"] = k.UserId;
            bool k2 = m1.SaveCustLog(k);
            if (k2 == true)
            {
                ViewBag.Message2 = "Saved Successfully";
                return View(k1);
            }
            else
            {
                ViewBag.Message3 = "Not Saved";
                return View();
            }
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
    }
}