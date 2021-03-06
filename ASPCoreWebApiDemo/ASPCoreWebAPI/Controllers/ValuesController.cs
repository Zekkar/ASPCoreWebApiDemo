﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreWebAPI.DTO;
using Newtonsoft.Json;
using ASPCoreWebAPI.Model;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            List<DemoDTO> reList = new List<DemoDTO>()
            {
                new DemoDTO {number = "1" },
                new DemoDTO {number = "121" }
            };

            string jsondata = JsonConvert.SerializeObject(reList);


            return jsondata;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string re = "";

            if (id <= 0 && id > 2)
                re = "Fail 1 + 2 + 3 + 4";
            switch(id)
            {
                case 1:
                    re = "2"; 
                    break;
                case 2:
                    re = "3";
                    break;
                default:
                    re = "1 + 2 + 3 + 4";
                    break;
            }

            return JsonConvert.SerializeObject(re);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
