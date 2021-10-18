using ProductsApi.Model;
using ProductsApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Services
{
    public class SerchSevice : Iseachservice
    {
        private readonly ISuppyRepository _data;

        public SerchSevice(ISuppyRepository data)
        {
            _data = data;
        }

     

        public List<Supplier> Seach(string name)
        {
            List<Supplier> Query = _data.GGtData();
            List<Supplier> temp = new();
            if (!string.IsNullOrEmpty(name))
            {
                for (int y=0;y<Query.Count;y++)
                {
                    if (Query[y].Name.Contains(name))
                    { 
                        temp.Add(Query[y]);
                    }
                }
              //Linq solution : Query = (List<Supplier>)Query.Where(n => n.Name.Contains(name));
            }
            return temp;

        }
    }
}
