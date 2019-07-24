using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TheProject.Controllers
{
    public class SignUpController : Controller
    {

        public void PostUserData(string firstName, string lastName, string userEmail, string userPassword)
        {



        }

        public class SignUpScreen
        {
            public string UserEmail { get; set; }
            public string UserPassword { get; set; }
            public string ConfirmPassword { get; set; }
        }
    }
}