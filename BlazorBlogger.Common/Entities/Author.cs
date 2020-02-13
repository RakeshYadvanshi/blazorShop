using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBlogger.Common.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
    }
}
