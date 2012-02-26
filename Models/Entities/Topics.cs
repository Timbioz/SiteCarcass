using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class Topics
    {

        public Topics()
        {
            IsPublished = false;
            IsCommentsEnabled = true;
            IsRatingEnabled = true;
            IsVisible = true;
        }

        [Key]
        public int TopicId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Display(Name = "Название статьи")]
        [Required(ErrorMessage = "Название статьи обязательно")]
        [StringLength(100, ErrorMessage = "Название должно содержать не более 100 символов")]
        public string Title { get; set; }

        [Display(Name = "Название для URL")]
        public string Slug { get; set; }

        [Display(Name = "Название статьи")]
        [StringLength(500, ErrorMessage = "Название должно содержать не более 500 символов")]
        public string Description { get; set; }

        [Display(Name = "Имя автора")]
        [StringLength(50, ErrorMessage = "...должно содержать не более 50 символов")]
        public string Author { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "...должно содержать не более 50 символов")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Тело статьи должно быть заполнено обязательно!")]
        [Display(Name = "Содержание статьи")]
        [MaxLength]
        public string Content { get; set; }

        [Display(Name = "Ссылка на источник")]
        [StringLength(128, ErrorMessage = "...должно содержать не более 128 символов")]
        public string SourseLink { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public DateTime? PublishedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public DateTime? ArchivedDate { get; set; }

        public bool? IsVisible { get; set; }

        public bool? IsPublic { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        public bool? IsModified { get; set; }

        public bool? IsDeleted { get; set; }

        public bool? IsArchived { get; set; }

        public bool? IsRatingEnabled { get; set; }

        public bool? IsCommentsEnabled { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Ratings> Rating { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
    }
}
