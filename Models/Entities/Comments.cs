using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int PostId { get; set; }

        public string Commenter { get; set; }

        public string CommenterIP { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool? IsSpam { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsEditable { get; set; }

        public virtual Posts Post { get; set; }
    }
}
