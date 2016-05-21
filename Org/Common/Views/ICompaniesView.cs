using System;
using System.Collections.Generic;
using Org.Pes;

namespace Org.Common.Views
{
    public interface ICompaniesView
    {
        Action Loaded { get; set; }
        Action AddCompany { get; set; }
        Action<CompanyEditPe> AddRequested { get; set; }
        Action<CompanyEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action<int> DeleteRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitCompanies(IEnumerable<CompanyIndexPe> companies);
        void ShowCompany(CompanyEditPe pe);
        void ShowEmptyCompany();
    }
}