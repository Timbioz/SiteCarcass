﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using AutoMapper;
using WebSite.Core;

namespace WebSite.Models
{
    public class SectionsIndexViewModel : DashboardViewModel
    {
        public SectionsIndexViewModel(){}

        public SectionsIndexViewModel(IEnumerable<Sections> sections)
        {
            Sections = sections;
            Names = new SelectList(sections.Select(s => s.Name), Sections);
        }
        
        public IEnumerable<Sections> Sections { get; set; }

        public SelectList Names { get; set; }

        
    }
}