using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Models
{
    public class CommentViewModel
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        public int PageId { get; set; }
    }
}
