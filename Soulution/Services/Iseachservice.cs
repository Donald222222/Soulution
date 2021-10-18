using ProductsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Services
{
    public interface Iseachservice

    {
       List<Supplier> Seach(string name);
    }
}
