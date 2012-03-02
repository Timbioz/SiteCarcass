using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class Pages
    {
        public Pages()
        {
            this.IsIndexVisible = true;
            this.IsVisible = true;
            this.IsPublic = true;
            this.IsDeleted = false;
            this.IsHomePage = false;
            this.CanEdit = false; 
            this.CanDelete = false;
        }

        [Key]
        public int PageId { get; set; }

        public int Views { get; set; }

        public int? ContentId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Keywords { get; set; }

        public string AbsoluteLink { get; set; }

        public string RelativeLink { get; set; }

        public string Slug { get; set; }

        public bool? IsIndexVisible { get; set; }

        public bool? IsVisible { get; set; }

        public bool? IsPublic { get; set; }

        public bool? IsDeleted { get; set; }

        public bool IsPublished { get; set; }

        public bool? IsHomePage { get; set; }

        public bool? CanEdit { get; set; }

        public bool? CanDelete { get; set; }

        public virtual Content Content { get; set; }
    }
}
