using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AutoMapper;
using PagedList;


namespace WebSite.Models
{
    public class SectionsIndexViewModel : DashboardViewModel
    {
        public SectionsIndexViewModel(){}

        public SectionsIndexViewModel(IEnumerable<Sections> sections, int page = 1, int pages = 10)
        {
            Sections = sections.ToPagedList(page, pages);
        }
        
        public IPagedList<Sections> Sections { get; set; }

    }

    
}
