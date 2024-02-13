using System;
using System.ComponentModel.DataAnnotations;


namespace Domain.News
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }

        public int PageId { get; set; }
        public virtual Page Page { get; set; }
    }
}
