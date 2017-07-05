﻿using OrderProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts.Services
{
    public interface IBookService
    {
        List<BookModel> GetAll(string orderOptions);
    }
}