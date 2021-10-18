using ProductsApi.Data;
using ProductsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Repository
{
    public class SupplyRepository : ISuppyRepository
    {
        private readonly SupplierDataContext repo;

        public SupplyRepository(SupplierDataContext _repo)
        {
            repo = _repo;
        }

        public List<Supplier> GGtData()
        {
            return repo.Supliers.ToList();
        }

      
        public Supplier Update(Supplier name)
        {
            throw new NotImplementedException();
        }
    }
}
