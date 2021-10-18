using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Model
{
    public class Supplier
    {
     
        public Supplier( int code, string name, string telephone_No)
        {
          
            Code = code;
            Name = name;
            Telephone_No = telephone_No;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Telephone_No { get; set; }
    }
}
