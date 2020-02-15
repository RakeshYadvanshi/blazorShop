using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorShop.Common.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public int AutherId { get; set; }
        public int LastModifedAuthorId { get; set; }
    }
}
