using Org.Common.Repositories;
using Org.Common.Views;
using Org.Domain;
using Org.Pes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Presenters
{
    public class ManufactorPresenter
    {
        private readonly IDictionayView _view;

        private readonly IManufactorRepository _dictRepository;

        public ManufactorPresenter(
            IDictionayView view,

            IManufactorRepository dictRepository)
        {
            _view = view;

            _dictRepository = dictRepository;

            _view.Loaded += ViewLoadedRequested;
            _view.AddRequested += ViewAddRequested;
            _view.UpdateRequested += ViewUpdateRequested;
            _view.EditRequested += ViewEditRequested;
            _view.DeleteRequested += ViewDeleteRequested;
            _view.CancelRequested += ViewCancelRequested;
        }

        private void ViewLoadedRequested()
        {
            var companies = _dictRepository.Get()
                .Select(x => new DicIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();
            _view.InitDic(companies);
            _view.ShowEmptyItem();
        }

        private void ViewAddRequested(DicEditPe pe)
        {
            var employee = new Manufactor
            {
                Name = pe.Name
            };
            _dictRepository.Add(employee);

            ViewLoadedRequested();
            _view.ShowEmptyItem();
        }

        private void ViewUpdateRequested(DicEditPe pe)
        {
            var company = new Manufactor
            {
                Id = pe.Id,
                Name = pe.Name
            };
            _dictRepository.Update(company);

            ViewLoadedRequested();
            _view.ShowEmptyItem();
        }

        public void ViewEditRequested(int id)
        {
            var company = _dictRepository.FirstOrDefault(p => p.Id == id);
            if (company != null)
            {
                _view.ShowItem(new DicEditPe
                {
                    Id = company.Id,
                    Name = company.Name
                });
            }
        }

        public void ViewDeleteRequested(int id)
        {
            var employee = _dictRepository.FirstOrDefault(p => p.Id == id);
            if (employee != null)
            {
                _dictRepository.Delete(employee);
            }
            ViewLoadedRequested();
        }

        public void ViewCancelRequested()
        {
            _view.ShowEmptyItem();
        }
    }
}
