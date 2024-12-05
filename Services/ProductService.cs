using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rabotaipj.Models;

namespace Rabotaipj.Services // Замените YourNamespace на имя вашего пространства имен
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }


    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
