﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendV2.Controllers
{
    [Route("api/[controller]")]// El link localhost --> api/Operation
    [ApiController]
    public class OperationController : ControllerBase
    {

        [HttpGet]
        public decimal Get(decimal a, decimal b)
        {

            return a + b;

        }

        [HttpPost]
        public decimal Add( Numbers numbers, [FromHeader] string Host,
            [FromHeader(Name = "Content-Length")] string ContentLength,
            [FromHeader(Name = "X-Some")] string Some)
        {
            Console.WriteLine(Host);
            Console.WriteLine(ContentLength);
            Console.WriteLine(Some);


            return numbers.A - numbers.B;

        }

        [HttpPut]
        public decimal Edit(decimal a, decimal b)
        {

            return a * b;

        }
        [HttpDelete]
        public decimal Delete(decimal a, decimal b)
        {

            return a / b;

        }



    }

    // Solo para uso practico

    public class Numbers
    { 
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}
