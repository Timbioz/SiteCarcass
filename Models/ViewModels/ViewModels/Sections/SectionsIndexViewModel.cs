using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AutoMapper;

namespace WebSite.Models
{
    public class SectionsIndexViewModel : DashboardViewModel
    {
        public SectionsIndexViewModel(){}

        public SectionsIndexViewModel(IEnumerable<Sections> sections)
        {
            Sections = sections;
        }
        
        public IEnumerable<Sections> Sections { get; set; }

        public IEnumerable<Selected> SelectedItems { get; set; }

    }

    public class Selected
    {
         public bool Select { get; set; }
    }
}
