using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBookstore.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult GetLocalImage(string imageName)
        {
            var root = @"C:\Users\SunMi\Desktop\ITP\ITPPictures";
            var path = Path.Combine(root, imageName);
            path = Path.GetFullPath(path);
            if (!path.StartsWith(root))
            {
                throw new HttpException(403, "Forbidden");
            }

            return File(path, "image/jpeg");
        }
    }
}