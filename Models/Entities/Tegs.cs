using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebSite.Models
{
    public class Tags
    {
        [Key]
        public int TagId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }
    }
}
