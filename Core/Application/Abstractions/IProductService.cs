using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IProductService
    {
        string GetProductName(string productName);
        List<Product> GetProducts();

    }
}
