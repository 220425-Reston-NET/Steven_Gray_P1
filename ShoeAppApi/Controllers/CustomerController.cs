using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ShoeAppBL;
using ShoeAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //==============Dependency Injection==============
        private ICustomerBL _custBL;
        private ICustInvoJoinBL _custJoin;
        public CustomerController(ICustomerBL c_custBL, ICustInvoJoinBL custJoin)
        {
            _custBL = c_custBL;
            _custJoin = custJoin;
        }

        //================================================

        //Data annotation to indicate what type of HTTP verb it is
        //this is an action of a controller
        //It needs what HTTP verb it is associated with
        [HttpGet("GetAllCustomer")]
        public IActionResult GetAllMethod()
        {
            try
            {
                List<Customer> listOfCurrentCustomer = _custBL.GetAllCustomer();
                //Followed by "OK()"
                return Ok(listOfCurrentCustomer);
            }
            catch (SqlException)
            {
                return NotFound("No Customer Exist");
            }

        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customer c_cust)
        {
            try
            {
                _custBL.AddCustomer(c_cust);

                return Created("Customer was created!", c_cust);
            }
            catch (SqlException)
            {
                return Conflict();
            }
        }
    


    [HttpGet("SearchCustomerByName")]
    public IActionResult SearchCustomerByName ([FromQuery] string custName)
    {
        try
        {
            return Ok(_custBL.SearchCustomerByName(custName));
        }
        catch (SqlException)
        {
             return Conflict();
        }
    }

    
        [HttpPut("ReplenishInventory")]
        public IActionResult ReplenishInventory([FromQuery] int c_PP, [FromQuery] int c_abId, [FromQuery] int c_custId)
        {
            // Customer found = _custBL.SearchCustomerBy(c);

            // if (found == null)
            // {
            //     return NotFound("Customer was not found!");
            // }
            
            // else
            // {
        
                try
                {
                    _custJoin.ReplenishInventory(c_PP, c_abId, c_custId);

                    return Ok();
                }
                catch (SqlException)
                {
                    return Conflict();
                }

            
        }    
    }
}
