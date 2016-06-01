using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class MarketPageViewModel
    {
        public BookPreviewViewModel BestSellerOne { get; set; }

        public BookPreviewViewModel BestSellerTwo { get; set; }

        public BookPreviewViewModel BestSellerThree { get; set; }

        public Dictionary<string, List<BookPreviewViewModel>> BooksByGenres;
    }
}