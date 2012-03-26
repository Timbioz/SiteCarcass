using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebSite.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public int SectionId { get; set; }

        
        [Required]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "...не более 500 символов")]
        public string Description { get; set; }

        public virtual Sections Section { get; set; }

        public virtual ICollection<Settings> Settings { get; set; }

        public virtual ICollection<Posts> Posts { get; set; }

    }
}
