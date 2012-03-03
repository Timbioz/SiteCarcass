using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace WebSite.Models
{
    public class BaseViewModel
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public string CurrentPage { get; set; }
        public IDictionary<string, string> Settings { get; set; }

        public BaseViewModel WithErrorMessage(string errorMessage)
        {
            this.Error = errorMessage;
            return this;
        }

        public BaseViewModel WithMessage(string message)
        {
            this.Message = message;
            return this;
        }

        public BaseViewModel WithCurrentPage(string page)
        {
            this.CurrentPage = page;
            return this;
        }

        public BaseViewModel WithSettings(IDictionary<string, string> settings)
        {
            this.Settings = settings;
            return this;
        }

    }
}
