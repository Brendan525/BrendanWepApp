using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrendanWepApp.Models;
using System.Text.RegularExpressions;

namespace BrendanWepApp.Controllers
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

        public void PrepareContactPage() // Method
        {
            ViewBag.Message = "This is the PrepareContactPage() and it works";
        }

        public ActionResult Contact()
        {
            PrepareContactPage();
            return View();
        }

        public ActionResult Registration()
        {     
            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname, string state, string email)
        {

            //if (email.IndexOf('@') == -1)
            //{
            //    PrepareContactPage();
            //    ViewBag.Welcome = "Sorry! Not an email address";
            //    ViewBag.EmailStatusMessage = "Please make sure your email has an @ symbol.";
            //    return Redirect("/Home/Registration");
            //}
            //else
            //{
            //    ViewBag.Welcome = $"Welcome, {firstname} {lastname} from {state}. You registered {email} as your username. Thank you for registering";
            //    return View();
            //}

            ViewBag.Welcome = $"Welcome, {firstname} {lastname} from {state}. You registered {email} as your username. Thank you for registering";
            return View();
        }

        public ActionResult Demo()
        {
            List<string> mylist = new List<string>();
            mylist.Add("Hello");
            mylist.Add("There");
            mylist.Add("World");
            mylist.Add("Have a great day");

            ViewBag.List = mylist;
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {  
            return View();
        }


        [HttpPost]
        public ActionResult Save(string firstname, string lastname, string gender, DateTime birthday, string state, string email, string phone, string password, string starter)
        {
            WebUser user = new WebUser() // Class Object
            {
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                Birthday = birthday,
                State = state,
                Email = email,
                PhoneNumber = phone,
                Password = password,
                Starter = starter
            };
            //ViewBag.password = password; // Will show password that user entered
            ViewBag.ThankYou = "Thank you for registering with us.";
            return View(user);
        }

        public ActionResult Layout1()
        {
            return View();
        }

        public ActionResult Layout2()
        {
            return View();
        }


        public ActionResult Layout3()
        {
            return View();
        }

    }
}