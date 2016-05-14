﻿using Org.Common.Repositories;
using Org.Common.Views;
using Org.Domain;
using Org.Pes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Org.Presenters
{
    public class EmployeesFormPresenter
    {
        private readonly IEmployeesView _view;

        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesFormPresenter(
            IEmployeesView view,

            IEmployeeRepository employeeRepository)
        {
            _view = view;

            _employeeRepository = employeeRepository;

            _view.Loaded += ViewLoadedRequested;
            _view.AddRequested += ViewAddRequested;
            _view.UpdateRequested += ViewUpdateRequested;
            _view.EditRequested += ViewEditRequested;
            _view.CancelRequested += ViewCancelRequested;
        }

        private void ViewLoadedRequested()
        {
            var employees = _employeeRepository.Get()
                .Select(x => new EmployeeIndexPe
                {
                    Id = x.Id,
                    Name = string.Format("{0} {1} {2}", x.LastName, x.FirstName, x.MiddleName),
                    Address = x.Address,
                    Phone = x.Phone,
                    BirthDay = x.BirthDay,
                    FirstWorkDay = x.FirstWorkDay,
                    Position = x.Position,
                    Degree = x.Degree
                })
                .ToList();
            _view.InitEmployees(employees);
            _view.ShowEmptyEmployee();
        }

        private void ViewAddRequested(EmployeeEditPe pe)
        {
            var employee = new Employee
            {
                LastName = pe.LastName,
                FirstName = pe.FirstName,
                MiddleName = pe.MiddleName,
                Address = pe.Address,
                Phone = pe.Phone,
                BirthDay = pe.BirthDay,
                FirstWorkDay = pe.FirstWorkDay,
                Degree = pe.Degree,
                Position = pe.Position
            };
            _employeeRepository.Add(employee);

            ViewLoadedRequested();
            _view.ShowEmptyEmployee();
        }

        private void ViewUpdateRequested(EmployeeEditPe pe)
        {
            var employee = new Employee
            {
                Id = pe.Id,
                LastName = pe.LastName,
                FirstName = pe.FirstName,
                MiddleName = pe.MiddleName,
                Address = pe.Address,
                Phone = pe.Phone,
                BirthDay = pe.BirthDay,
                FirstWorkDay = pe.FirstWorkDay,
                Degree = pe.Degree,
                Position = pe.Position
            };
            _employeeRepository.Update(employee);

            ViewLoadedRequested();
            _view.ShowEmptyEmployee();
        }

        public void ViewEditRequested(int id)
        {
            var employee = _employeeRepository.FirstOrDefault(p => p.Id == id);
            if (employee != null)
            {
                _view.ShowEmployee(new EmployeeEditPe
                {
                    Id = employee.Id,
                    LastName = employee.LastName,
                    FirstName = employee.FirstName,
                    MiddleName = employee.MiddleName,
                    Address = employee.Address,
                    Phone = employee.Phone,
                    BirthDay = employee.BirthDay,
                    FirstWorkDay = employee.FirstWorkDay,
                    Position = employee.Position,
                    Degree = employee.Degree
                });
            }
        }

        public void ViewCancelRequested()
        {
            _view.ShowEmptyEmployee();
        }
    }
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

        public void ViewCancelRequested()
        {
            _view.ShowEmptyCompany();
        }
    }
}