using Microsoft.AspNetCore.Mvc;
using ShoppingApp.WebUI.Infrastructure;
using ShoppingApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Components
{
    public class CardSummaryViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return HttpContext.Session.GetJson<Card>("Card")?.Products.Count().ToString() ?? "0";
        }
    }
}
