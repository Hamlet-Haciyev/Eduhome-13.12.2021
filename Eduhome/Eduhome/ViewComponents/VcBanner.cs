﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewComponents
{
    public class VcBanner : ViewComponent
    {


        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
