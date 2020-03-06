using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Contracts;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IRepositoryWrapper _repo;
        public SchoolController(IRepositoryWrapper repo)
        {
            _repo = repo;
        }
        // GET: api/School
        [HttpGet]
        public string Get()
        {
            return _repo.ToString();
        }
    }
}
