using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Domain.News
{
    public class PageGroup
    {
        public int PageGroupId { get; set; }
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
    }
}
