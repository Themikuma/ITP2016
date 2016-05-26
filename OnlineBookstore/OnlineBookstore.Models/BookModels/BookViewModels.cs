using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Models.BookModels
{
    class BookViewModels
    {
        public String BookName { get; set; }
        public String BookAuthor { get; set; }
        public int BookStar { get; set; }
        public String BookSummary {get;set;}
        public List<String> BookReview { get; set; }
        public String BookImageName { get; set; }
        public float BookPrice { get; set; }
    }
}
