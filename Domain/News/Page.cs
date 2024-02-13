using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.News
{
    public class Page
    {
        public int PageId { get; set; }
        [MaxLength(150)]
        public string PageTitle { get; set; }
        [MaxLength(500)]
        public string ShortDescription { get; set; }
        public string Text { get; set; }
        public int Visit { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image { get; set; }
        public string Tags { get; set; }

        public int PageGroupId { get; set; }
        public virtual PageGroup PageGroup { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
