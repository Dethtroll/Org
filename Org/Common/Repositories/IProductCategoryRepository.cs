using Org.Domain;

namespace Org.Common.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        void Update(ProductCategory product);
    }
}