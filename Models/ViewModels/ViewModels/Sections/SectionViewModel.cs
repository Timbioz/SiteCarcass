using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using AutoMapper;

namespace WebSite.Models
{
    public class SectionViewModel : DashboardViewModel
    {
        public SectionViewModel(){}

        public SectionViewModel(Sections section)
        {
            Mapper.CreateMap<Sections, SectionViewModel>();
            Mapper.Map(section, this);
        }

        public static IEnumerable<SectionViewModel> GetDtoList(IEnumerable<Sections> sections)
        {
            Mapper.CreateMap<Sections, SectionViewModel>();
            var list = Mapper.Map<IEnumerable<Sections>, IEnumerable<SectionViewModel>>(sections);
            return list;
        }

        [Display(Name = "Имя раздела")]
        [Required(ErrorMessage = "Имя раздела обязательно")]
        [StringLength(25, ErrorMessage = "Имя должно содержать менее 25 символов")]
        public string Name { get; set; }

        [Display(Name = "Описание раздела")]
        [StringLength(250, ErrorMessage = "Описание должно содержать не более 250 символов")]
        public string Description { get; set; }
    }
}
