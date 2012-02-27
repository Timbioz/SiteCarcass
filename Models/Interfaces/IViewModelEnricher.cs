using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebSite.Models
{
    public interface IViewModelEnricher<TViewModel>
    {
        void Enrich(TViewModel viewModel);
    }
}
