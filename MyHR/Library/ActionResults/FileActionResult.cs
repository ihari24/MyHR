using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHR.Library.ActionResults
{
    public class FileActionResult : ActionResult
    {
        public string _contentType { get; private set; }
        public string _filename { get; private set; }
        public string _path { get; private set; }

        public FileActionResult (string filename, string path, string contentType)
        {
            _filename = filename;
            _path = path;
            _contentType = contentType;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var bytes = System.IO.File.ReadAllBytes(context.HttpContext.Server.MapPath( _path + _filename ));
            context.HttpContext.Response.ContentType = _contentType;
            context.HttpContext.Response.BinaryWrite(bytes);
        }
    }
}