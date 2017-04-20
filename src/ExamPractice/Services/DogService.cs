using ExamPractice.Infrastructure;
using ExamPractice.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractice.Services
{   //service level contains the bulk of your logic.  This is where you map database info onto view models, for example.  NO DATABASE MODELS ALLOWED at service level--use view models (DTOs)
    public class DogService
    {
        //dependency injection--inject your repository first so you can take advantage of its data

        private DogRepository _dRepo;

        public DogService(DogRepository dr)
        {
            _dRepo = dr;
        }

        //here we're taking the data we got from the repository and mapping it onto a DTO
        //calls the GetDogs() method we created in the repository
        public IList<DogDTO> GetDogs()
        {
            return (from d in _dRepo.GetDogs()
                    select new DogDTO()
                    {
                        Id = d.Id,
                        Age = d.Age,
                        Breed = d.Breed,
                        Name = d.Name
                    }).ToList();
        }
    }
}
