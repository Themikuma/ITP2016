using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class BookPreviewViewModel
    {
        public double Price { get; set; }

        public string Picture { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Stars { get; set; }

        public int Quantity { get; set; }
    }
}