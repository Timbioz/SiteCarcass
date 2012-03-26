using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using AutoMapper;

namespace WebSite.Models
{
    public class SectionCreateViewModel : DashboardViewModel
    {
        [Display(Name = "Имя раздела")]
        [Required(ErrorMessage = "Имя раздела обязательно")]
        [StringLength(25, ErrorMessage = "Имя должно содержать менее 25 символов")]
        public string Name { get; set; }

        [Display(Name = "Описание раздела")]
        [StringLength(250, ErrorMessage = "Описание должно содержать не более 250 символов")]
        public string Description { get; set; }
    }
}
