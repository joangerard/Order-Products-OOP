﻿using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll(string orderOptions);
        int Create(ProductModel product);
        ProductModel GetByCode(string code);
    }
}
