﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace HackITAll.Controllers
{
    public class AppController : Controller
    {
        public UserApp CurrentUser
        {
            get
            {
                return new UserApp(this.User as ClaimsPrincipal);
            }
        }
    }
}