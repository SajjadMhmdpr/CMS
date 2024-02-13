using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Models
{
    public class PageViewModel
    {
        public int id { get; set; }
        public string PageTitle { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
