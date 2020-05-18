using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyHR.Models;
using System.Web.Mvc;

namespace MyHR.Library.ActionFilter
{
    public class ActionLogFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {

            using (MyHREntities myDB = new MyHREntities())
            {
                AcionLog log = new AcionLog()
                {
                    Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                    Action = filterContext.ActionDescriptor.ActionName,
                    HttpMethod = filterContext.RequestContext.HttpContext.Request.HttpMethod,
                    ActionDate = DateTime.Now,
                    URL = filterContext.RequestContext.HttpContext.Request.Url.AbsoluteUri
                };

                myDB.AcionLogs.Add(log);
                myDB.SaveChanges();
                OnActionExecuting(filterContext);
            }
        }
    }
}