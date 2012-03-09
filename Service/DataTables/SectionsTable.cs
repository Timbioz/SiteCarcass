using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Helpers;
using WebSite.Models;

namespace WebSite.Services
{
    public class SectionsTable
    {
        private IEnumerable<Sections> sections; 
        private JQueryDataTableParametersModel parameters;
        private HttpRequestBase request;
        private IEnumerable<Sections> _filtered;
        private IEnumerable<Sections> _sorted;
        private int totalCount;
        private IEnumerable<object[]> _displayed; 

        public JQueryDataTableResponse RequestTable(
            IEnumerable<Sections> sections,
            HttpRequestBase request, 
            JQueryDataTableParametersModel parameters)
        {
            this.sections = sections;
            this.request = request;
            this.parameters = parameters;

            _filtered = !string.IsNullOrEmpty(parameters.sSearch)
                                                 ? sections.Where(
                                                     c =>
                                                     (c.Name ?? "").ToLower().Contains(parameters.sSearch.ToLower()) ||
                                                     (c.Description ?? "").ToLower().Contains(parameters.sSearch.ToLower()))
                                                 : sections;

            var isNameSortable = Convert.ToBoolean(request["bSortable_1"]);
            var isDescriptionSortable = Convert.ToBoolean(request["bSortable_2"]);
            var sortColumnIndex = Convert.ToInt32(request["iSortCol_0"]);

            Func<Sections, string> ordering = (c => sortColumnIndex == 1 && isNameSortable ? c.Name :
                                                    sortColumnIndex == 2 && isDescriptionSortable ? c.Description : "");

            var sortDirection = request["sSortDir_0"]; // asc or desc
            _sorted = sortDirection == "asc" ? _filtered.OrderBy(ordering) : _filtered.OrderByDescending(ordering);

            var displayed = _sorted
                .Skip(parameters.iDisplayStart)
                .Take(parameters.iDisplayLength);
            totalCount = _filtered.Count();
            _displayed = from c in displayed
                         select new[] { Convert.ToString(c.SectionId), c.Name, c.Description };

            return new JQueryDataTableResponse
                       {
                           sEcho = parameters.sEcho,
                           iTotalRecords = sections.Count(),
                           iTotalDisplayRecords = totalCount,
                           aaData = _displayed
                       };
        }

    }

    
}
