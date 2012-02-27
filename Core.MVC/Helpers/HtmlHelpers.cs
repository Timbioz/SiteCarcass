using System;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;



    public static partial class HtmlHelpers
    {
        /// <summary>
        /// Insert Meta Keywords
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static HtmlString MetaKeywords(this HtmlHelper htmlHelper, string keywords)
        {
            if (string.IsNullOrEmpty(keywords))
                return null;
            return new HtmlString(
                string.Format("<meta name=\"keywords\" content=\"{0}\" />",
                              HttpUtility.HtmlAttributeEncode(keywords)));
        }

        /// <summary>
        /// Insert Meta Description
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public static HtmlString MetaDescription(this HtmlHelper htmlHelper, string description)
        {
            if (string.IsNullOrEmpty(description))
                return null;
            return new HtmlString(
                string.Format("<meta name=\"description\" content=\"{0}\" />",
                              HttpUtility.HtmlAttributeEncode(description)));
        }

        /// <summary>
        /// Insert Meta Accept Language
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public static IHtmlString MetaAcceptLanguage(this HtmlHelper html)
        {
            return new HtmlString(
                string.Format("<meta name=\"accept-language\" content=\"{0}\" />",
                              HttpUtility.HtmlAttributeEncode(Thread.CurrentThread.CurrentUICulture.ToString())));
        }
    }
