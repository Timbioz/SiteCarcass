using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class Ratings
    {
        [Key]
        public int RatingId { get; set; }

        public int TopicId { get; set; }

        public DateTime Date { get; set; }

        public string Rater { get; set; }

        public string RaterIP { get; set; }

        public float Rate { get; set; }

        public virtual Topics Topic { get; set; }
    }
}
