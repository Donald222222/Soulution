using ProductsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Repository
{
   public  interface ISuppyRepository
    {

        List<Supplier> GGtData();
        Supplier Update( Supplier  name);
    }
}
