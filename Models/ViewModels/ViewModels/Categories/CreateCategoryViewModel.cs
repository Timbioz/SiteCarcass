using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AutoMapper;

namespace WebSite.Models
{
    public class CreateCategoryViewModel : DashboardViewModel
    {
        public CreateCategoryViewModel(){}

        public CreateCategoryViewModel(IEnumerable<Sections> sections, int? id)
        {
            Sections = new SelectList(sections, "SectionId", "Name", id = 3);
        }


        [Display(Name = "Имя категории")]
        [Required(ErrorMessage = "Имя категории обязательно")]
        [StringLength(25, ErrorMessage = "Имя должно содержать не более 25 символов")]
        public string Name { get; set; }

        [Display(Name = "Описание категории")]
        [StringLength(250, ErrorMessage = "...не более 250 символов")]
        public string Description { get; set; }

        [Display(Name = "Раздел")]
        [Required(ErrorMessage = "Выбор раздела обязателен")]
        public SelectList Sections { get; set; }


        [Required]
        public int SectionId { get; set; }

    }
}
