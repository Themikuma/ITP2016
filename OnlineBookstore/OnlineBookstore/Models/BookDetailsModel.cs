using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class BookDetailsModel : BookPreviewModel
    {
        public string Author { get; set; }
        public double ISBN { get; set; } 
    }
}