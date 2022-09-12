
using ECommerce.Api.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Api.Products.Interfaces
{
  public interface IProductsProvider
  {
    //returning the named TUPLE
    //Return all the Products
    Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();


    Task<(bool IsSuccess, Product Product, string ErrorMessage)> GetProductAsync(int id);
  }
}