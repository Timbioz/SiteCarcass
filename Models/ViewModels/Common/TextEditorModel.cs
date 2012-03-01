using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebSite.Models
{
    public class TextEditorModel
    {
        [AllowHtml]
        public string Content { get; set; }
    }
}
