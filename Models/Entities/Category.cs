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
        public int? SectionId { get; set; }

        [Display(Name = "Имя категории")]
        [Required(ErrorMessage = "Имя категории обязательно")]
        [StringLength(25, ErrorMessage = "Имя должно содержать не более 25 символов")]
        public string Name { get; set; }

        [StringLength(500, ErrorMessage = "...должно содержать не более 500 символов")]
        public string Description { get; set; }

        public virtual Sections Section { get; set; }

        public virtual ICollection<Settings> Settings { get; set; }

        public virtual ICollection<Topics> Topics { get; set; }

    }
}
