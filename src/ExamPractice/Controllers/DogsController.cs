using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamPractice.Services;
using ExamPractice.Services.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamPractice.Controllers
{   //this will return the route /api/dogs
    [Route("api/[controller]")]
    public class DogsController : Controller
    {
        //dependency injection--you need to grab the DTO you created in the service
        private DogService _dService;

        public DogsController(DogService ds)
        {
            _dService = ds;
        }

        //now we'll create a basic request to get the list of DogDTO
        //we want to return the GetDogs() method we created in the Service
        [HttpGet]
        public IEnumerable<DogDTO> GetDogs()
        {
            return _dService.GetDogs();
        }


    }
}
