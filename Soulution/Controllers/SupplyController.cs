using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Model;
using ProductsApi.Repository;
using ProductsApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class SupplyController : ControllerBase
    {
        private readonly Iseachservice _data;

        public SupplyController(Iseachservice data)
        {
            _data = data;
        }
        [HttpGet("{search}")]

        public ActionResult<List<Supplier>> Seach(string search)
          
        {
            try 
            {

                var results =  _data.Seach(search);
                if (results.Any()) 
                {
                    return Ok(results);
                }
                return NotFound();       
            }
            catch(Exception) 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Name Not found");
            }
        }
    }
}
