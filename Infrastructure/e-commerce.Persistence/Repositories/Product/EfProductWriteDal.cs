﻿using e_commerce.Application.Repositories;
using e_commerce.Domain.Entities;
using e_commerce.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Persistence.Repositories
{
    public class EfProductWriteDal : EfEntityWriteRepositoryBase<Product>, IProductWriteDal
    {
        public EfProductWriteDal(dbContext context) : base(context)
        {
        }
    }
}
