using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Models
{
    public class Content
    {
        public int ContentId { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
