using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
    }
}
