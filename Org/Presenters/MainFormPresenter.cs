using System;
using Org.Common.Views;
using Org.Common.Repositories;
using System.Linq;
using Org.Pes;
using Org.Domain;
using Org.Repositories;
using Org.Common.Services;

namespace Org.Presenters
{
    public class MainFormPresenter
    {
        private readonly IMainView _view;

        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryRepository _categoryRepository;
        private readonly IManufactorRepository _manufactorRepository;
        private readonly IVendorRepository _vendorRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public MainFormPresenter(
            IMainView view,

            IUpdateService updateService,

            IProductRepository productRepository,
            IProductCategoryRepository categoryRepository,
            IManufactorRepository manufactorRepository, 
            IVendorRepository vendorRepository, 
            IClientRepository clientRepository, 
            IEmployeeRepository employeeRepository)
        {
            _view = view;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _manufactorRepository = manufactorRepository;
            _vendorRepository = vendorRepository;
            _clientRepository = clientRepository;
            _employeeRepository = employeeRepository;

            _view.Loaded += ViewLoadedRequested;
            _view.AddRequested += ViewAddRequested;
            _view.UpdateRequested += ViewUpdateRequested;
            _view.EditRequested += ViewEditRequested;
            _view.CancelRequested += ViewCancelRequested;

            updateService.ClientAdded += UpdateService_ClientUpdated;
            updateService.ClientUpdated += UpdateService_ClientUpdated;
            updateService.ClientDeleted += UpdateService_ClientUpdated;
            updateService.VendorAdded += UpdateService_VendorUpdated;
            updateService.VendorUpdated += UpdateService_VendorUpdated;
            updateService.VendorDeleted += UpdateService_VendorUpdated;
            updateService.EmployeeAdded += UpdateService_EmployeeUpdated;
            updateService.EmployeeUpdated += UpdateService_EmployeeUpdated;
            updateService.EmployeeDeleted += UpdateService_EmployeeUpdated;
            updateService.ManufactorAdded += UpdateService_ManufactorUpdated;
            updateService.ManufactorUpdated += UpdateService_ManufactorUpdated;
            updateService.ManufactorDeleted += UpdateService_ManufactorUpdated;
            updateService.ProductCategoryAdded += UpdateService_ProducCategoryUpdated;
            updateService.ProductCategoryUpdated += UpdateService_ProducCategoryUpdated;
            updateService.ProductCategoryDeleted += UpdateService_ProducCategoryUpdated;
        }

        private void ViewLoadedRequested()
        {
            var products = _productRepository.Get()
                .Select(x => new ProductIntexPe {
                    Id = x.Id,
                    Number = x.Number,
                    Price = x.Price,
                    ReceiveDate = x.ReceiveDate,
                    SendDate = x.SendDate,
                    ReceiveCount = x.ReceiveCount,
                    SendCount = x.SendCount,
                    ReserveCount = x.ReserveCount,
                    TotalReceivePrice = x.TotalReceivePrice,
                    TotalSendPrice = x.TotalSendPrice,

                    Category = x.Category.Name,
                    Manufactor = x.Manufactor.Name,
                    Vendor = x.Vendor.Name,
                    Client = x.Client.Name,
                    Employee = string.Format("{0} {1} {2}", x.Employee.LastName, x.Employee.FirstName, x.Employee.MiddleName)
                })
                .ToList();
            var categories = _categoryRepository.Get()
                .Select(x => new DicIndexPe {
                    Id = x.Id,
                    Name = x.Name
                });
            var manufactors = _manufactorRepository.Get()
                .Select(x => new DicIndexPe {
                    Id = x.Id,
                    Name = x.Name
                });
            var vendors = _vendorRepository.Get()
                .Select(x => new VendorIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            var clients = _clientRepository.Get()
                .Select(x => new ClientIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            var employess = _employeeRepository.Get()
                .Select(x => new EmployeeIndexPe
                {
                    Id = x.Id,
                    Name = string.Format("{0} {1} {2}", x.LastName, x.FirstName, x.MiddleName)
                });

            _view.InitProducts(products, categories, manufactors, vendors, clients, employess);
            _view.ShowEmptyProduct();
        }

        private void ViewAddRequested(ProductEditPe pe)
        {
            var category = _categoryRepository.FirstOrDefault(x => x.Id == pe.Category);
            var manufactor = _manufactorRepository.FirstOrDefault(x => x.Id == pe.Manufactor);
            var vendor = _vendorRepository.FirstOrDefault(x => x.Id == pe.Vendor);
            var client = _clientRepository.FirstOrDefault(x => x.Id == pe.Client);
            var employee = _employeeRepository.FirstOrDefault(x => x.Id == pe.Employee);

            var product = new Product
            {
                Number = pe.Number,
                CategoryId = category.Id,
                Category = category,
                ManufactorId = manufactor.Id,
                Manufactor = manufactor,
                Price = pe.Price,
                VendorId = vendor.Id,
                Vendor = vendor,
                ClientId = client.Id,
                Client = client,
                EmployeeId = employee.Id,
                Employee = employee,
                ReceiveDate = pe.ReceiveDate,
                SendDate = pe.SendDate,
                ReceiveCount = pe.ReceiveCount,
                SendCount = pe.SendCount,
                ReserveCount = pe.ReserveCount,
                TotalReceivePrice = pe.TotalReceivePrice,
                TotalSendPrice = pe.TotalSendPrice,
                Description = pe.Description
            };
            _productRepository.Add(product);

            ViewLoadedRequested();
            _view.ShowEmptyProduct();
        }

        private void ViewUpdateRequested(ProductEditPe pe)
        {
            var category = _categoryRepository.FirstOrDefault(x => x.Id == pe.Category);
            var manufactor = _manufactorRepository.FirstOrDefault(x => x.Id == pe.Manufactor);
            var vendor = _vendorRepository.FirstOrDefault(x => x.Id == pe.Vendor);
            var client = _clientRepository.FirstOrDefault(x => x.Id == pe.Client);
            var employee = _employeeRepository.FirstOrDefault(x => x.Id == pe.Employee);

            var product = new Product
            {
                Id = pe.Id,
                Number = pe.Number,
                CategoryId = category.Id,
                Category = category,
                ManufactorId = manufactor.Id,
                Manufactor = manufactor,
                Price = pe.Price,
                VendorId = vendor.Id,
                Vendor = vendor,
                ClientId = client.Id,
                Client = client,
                EmployeeId = employee.Id,
                Employee = employee,
                ReceiveDate = pe.ReceiveDate,
                SendDate = pe.SendDate,
                ReceiveCount = pe.ReceiveCount,
                SendCount = pe.SendCount,
                ReserveCount = pe.ReserveCount,
                TotalReceivePrice = pe.TotalReceivePrice,
                TotalSendPrice = pe.TotalSendPrice,
                Description = pe.Description
            };
            _productRepository.Update(product);

            ViewLoadedRequested();
            _view.ShowEmptyProduct();
        }

        private void ViewEditRequested(int id)
        {
            var product = _productRepository.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _view.ShowProduct(new ProductEditPe
                {
                    Id = product.Id,
                    Number = product.Number,
                    Price = product.Price,
                    ReceiveDate = product.ReceiveDate,
                    SendDate = product.SendDate,
                    ReceiveCount = product.ReceiveCount,
                    SendCount = product.SendCount,
                    ReserveCount = product.ReserveCount,
                    TotalReceivePrice = product.TotalReceivePrice,
                    TotalSendPrice = product.TotalSendPrice,
                    Description = product.Description,

                    Category = product.Category.Id,
                    Manufactor = product.Manufactor.Id,
                    Vendor = product.Vendor.Id,
                    Client = product.Client.Id,
                    Employee = product.Employee.Id
                });
            }
        }

        private void ViewCancelRequested()
        {
            _view.ShowEmptyProduct();
        }

        private void UpdateService_ClientUpdated(Client obj)
        {
            var clients = _clientRepository.Get()
                .Select(x => new ClientIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            _view.InitClients(clients);
        }

        private void UpdateService_VendorUpdated(Vendor obj)
        {
            var vendors = _vendorRepository.Get()
                .Select(x => new VendorIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            _view.InitVendors(vendors);
        }

        private void UpdateService_EmployeeUpdated(Employee obj)
        {
            var employess = _employeeRepository.Get()
                .Select(x => new EmployeeIndexPe
                {
                    Id = x.Id,
                    Name = string.Format("{0} {1} {2}", x.LastName, x.FirstName, x.MiddleName)
                });
            _view.InitEmployees(employess);
        }

        private void UpdateService_ManufactorUpdated(Manufactor obj)
        {
            var employess = _manufactorRepository.Get()
                .Select(x => new DicIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            _view.InitManufactors(employess);
        }

        public void UpdateService_ProducCategoryUpdated(ProductCategory category)
        {
            var employess = _categoryRepository.Get()
                .Select(x => new DicIndexPe
                {
                    Id = x.Id,
                    Name = x.Name
                });
            _view.InitCategories(employess);
        }
    }
}
