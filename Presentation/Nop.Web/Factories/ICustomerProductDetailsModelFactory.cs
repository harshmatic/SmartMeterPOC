﻿using Nop.Core;
using Nop.Core.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nop.Web.Factories
{
    public partial interface ICustomerProductDetailsModelFactory
    {
        IPagedList<CustomerProductDetails> PrepareCustomerProductDetailsPagingFilteringModel(int customerId);
    }
}