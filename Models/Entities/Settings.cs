using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebSite.Models
{
    public class Settings
    {
        [Key]
        public int SettingId { get; set; }

        public int? CategoryId { get; set; }

        [Display(Name = "Имя настройки")]
        [Required(ErrorMessage = "Имя настройки обязательно")]
        [StringLength(25, ErrorMessage = "Имя должно содержать менее 25 символов")]
        public string Name { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public bool? Enabled { get; set; }

        public virtual Category Categories { get; set; }
    }
}
