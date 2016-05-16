using Org.Common.Repositories;
using Org.Common.Views;
using Org.Domain;
using Org.Pes;
using System.Linq;

namespace Org.Presenters
{
    public class VendorFormPresenter
    {
        private readonly ICompaniesView _view;

        private readonly IVendorRepository _vendorRepository;

        public VendorFormPresenter(
            ICompaniesView view,

            IVendorRepository vendorRepository)
        {
            _view = view;

            _vendorRepository = vendorRepository;

            _view.Loaded += ViewLoadedRequested;
            _view.AddRequested += ViewAddRequested;
            _view.UpdateRequested += ViewUpdateRequested;
            _view.EditRequested += ViewEditRequested;
            _view.DeleteRequested += ViewDeleteRequested;
            _view.CancelRequested += ViewCancelRequested;
        }

        private void ViewLoadedRequested()
        {
            var companies = _vendorRepository.Get()
                .Select(x => new CompanyIndexPe
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = x.Address,
                    Phone = x.Phone
                })
                .ToList();
            _view.InitCompanies(companies);
            _view.ShowEmptyCompany();
        }

        private void ViewAddRequested(CompanyEditPe pe)
        {
            var employee = new Vendor
            {
                Name = pe.Name,
                Address = pe.Address,
                Phone = pe.Phone,
            };
            _vendorRepository.Add(employee);

            ViewLoadedRequested();
            _view.ShowEmptyCompany();
        }

        private void ViewUpdateRequested(CompanyEditPe pe)
        {
            var company = new Vendor
            {
                Id = pe.Id,
                Name = pe.Name,
                Address = pe.Address,
                Phone = pe.Phone,
            };
            _vendorRepository.Update(company);

            ViewLoadedRequested();
            _view.ShowEmptyCompany();
        }

        public void ViewEditRequested(int id)
        {
            var company = _vendorRepository.FirstOrDefault(p => p.Id == id);
            if (company != null)
            {
                _view.ShowCompany(new CompanyEditPe
                {
                    Id = company.Id,
                    Name = company.Name,
                    Address = company.Address,
                    Phone = company.Phone,
                });
            }
        }

        public void ViewDeleteRequested(int id)
        {
            var employee = _vendorRepository.FirstOrDefault(p => p.Id == id);
            if (employee != null)
            {
                _vendorRepository.Delete(employee);
            }
        }

        public void ViewCancelRequested()
        {
            _view.ShowEmptyCompany();
        }
    }
}
