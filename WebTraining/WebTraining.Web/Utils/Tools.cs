using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTraining.Web.Utils
{
    public static class Tools
    {
        public static SelectList ToSelectList(this IEnumerable<SelectListItem> items)
        {
            return new SelectList(items, "Value", "Text");
        }
    }
}